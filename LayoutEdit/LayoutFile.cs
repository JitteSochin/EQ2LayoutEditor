using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace LayoutEdit
{
    class LayoutFile
    {
        private string _filename;       // Name of the file
        private int _fileversion;       // Version of the file
        private Int64 _houseid;         // Unique House ID
        private Int64 _houseversion;    // Internal Identifier for House
        private string _housetype;      // House Type
        private bool _fileloaded;       // Do we have a file loaded?
        public DataTable HouseItems = new DataTable("HouseItems");
        public DataView CrateItems = new DataView();
        private DateTime _lastModified;
        public List<Group> Groups = new List<Group>();

        public string FileName
        {
            get { return _filename; }
            set
            {
                Groups.Clear();
                _filename = value;
                _fileloaded = LoadFile(_filename);
                if (!_fileloaded)
                {
                    _filename = string.Empty;
                    throw new FileNotFoundException("The file '" + value + "' either does not exist or is not a valid (Version 6) layout file");
                }
            }
        }
        public bool FileLoaded { get { return _fileloaded; } }
        public int FileVersion { get { return (_fileloaded) ? _fileversion : 0; } }
        public Int64 HouseID { get { return (_fileloaded) ? _houseid : 0; } }
        public string HouseType { get { return _housetype; } }
        public DateTime LastModified { get { return _lastModified; } set { _lastModified = value; } }
        public LayoutFile()
        {
            HouseItems.Columns.Add(new DataColumn("ItemName", typeof(string)));
            HouseItems.Columns.Add(new DataColumn("x", typeof(decimal)));
            HouseItems.Columns.Add(new DataColumn("z", typeof(decimal)));
            HouseItems.Columns.Add(new DataColumn("y", typeof(decimal)));
            HouseItems.Columns.Add(new DataColumn("Rotation", typeof(decimal)));
            HouseItems.Columns.Add(new DataColumn("Pitch", typeof(decimal)));
            HouseItems.Columns.Add(new DataColumn("Roll", typeof(decimal)));
            HouseItems.Columns.Add(new DataColumn("Scale", typeof(decimal)));
            HouseItems.Columns.Add(new DataColumn("InCrate", typeof(bool)));
            HouseItems.Columns.Add(new DataColumn("ItemID", typeof(Int64)));
            HouseItems.Columns.Add(new DataColumn("DatabaseID", typeof(Int32)));
            HouseItems.Columns.Add(new DataColumn("Memo", typeof(string)));
            CrateItems.Table = HouseItems;
            CrateItems.RowFilter = "InCrate = 'TRUE'";
            DataColumn[] PK = new DataColumn[1];
            PK[0] = HouseItems.Columns["DatabaseID"];
            HouseItems.PrimaryKey = PK;

        }
        internal bool ImportGroups(string FileName, bool ClearCurrentGroups)
        { return LoadFile(FileName, true, ClearCurrentGroups, false); }
        internal bool ImportNotes(string FileName)
        { return LoadFile(FileName, false, false, false, true); }
        internal bool MergeFile(string FileName)
        { return LoadFile(FileName, false, false, false, false); }
        private bool LoadFile(string FileName, bool GroupOnly = false, bool ClearCurrentGroups = true, bool ClearCurrentItems = true, bool NotesImport = false)
        {
            if (!File.Exists(FileName)) return false;
            if (ClearCurrentGroups) Groups.Clear();
            StreamReader sr = new StreamReader(FileName);
            string _input;
            if (!GroupOnly && ClearCurrentItems)
            {
                _input = sr.ReadLine();
                if (_input.Split(',').Count() != 2) return false;
                _fileversion = int.Parse(_input.Split(',')[0]);
                if (_fileversion != 6) return false;

                _input = sr.ReadLine();
                _housetype = _input.Split(',')[1];
                _houseversion = Int64.Parse(_input.Split(',')[0]);

                _input = sr.ReadLine();
                try
                {
                    _houseid = Int64.Parse(_input.Split(',')[0]);
                } catch (System.FormatException fe) {
                    _houseid = Int64.Parse(_input.Split(',')[0], System.Globalization.NumberStyles.HexNumber);
                }
            }
            else
            {
                _input = sr.ReadLine();
                _input = sr.ReadLine();
                _input = sr.ReadLine();
            }
            string[] _inpItem = new string[11];
            if (ClearCurrentItems) HouseItems.Clear();
            bool layout_tag_found = false;
            while (!sr.EndOfStream)
            {
                _input = sr.ReadLine();
                if (_input == "//EQ2LayoutEditor") 
                {
                    layout_tag_found = true;
                    continue;
                }
                if (_input.Substring(0, 7) == "//GROUP")
                {
                    Group grpAdd = new Group();
                    grpAdd.Name = _input.Split(':')[1];
                    foreach (string item in _input.Split(':')[2].Split(','))
                    {
                        grpAdd.AddItem(Int32.Parse(item));
                    }
                    Groups.Add(grpAdd);
                    continue;
                }
                _inpItem = _input.Split(',');
                Int32 dbid = Int32.Parse(_inpItem[1]);
                DataRow dr = HouseItems.NewRow();
                dr["ItemID"] = Int64.Parse(_inpItem[0]);
                dr["DatabaseID"] = dbid;
                dr["x"] = decimal.Parse(_inpItem[2]);
                dr["z"] = decimal.Parse(_inpItem[3]);
                dr["y"] = decimal.Parse(_inpItem[4]);
                dr["Rotation"] = decimal.Parse(_inpItem[5]);
                dr["Pitch"] = decimal.Parse(_inpItem[6]);
                dr["Roll"] = decimal.Parse(_inpItem[7]);
                dr["Scale"] = decimal.Parse(_inpItem[8]);
                dr["InCrate"] = bool.Parse(_inpItem[9]);
                //string ItemName = _input.Split(",\"")[10];
                DataRow drUpd = HouseItems.Rows.Find(dbid);
                string ItemName = string.Empty;
                if (layout_tag_found)
                {
                    ItemName = _input.Substring(_input.IndexOf(",\"") + 2, _input.IndexOf("\",", _input.IndexOf("\",")) - _input.IndexOf(",\"") - 2);
                }
                else
                {
                    ItemName = _input.Substring(_input.IndexOf(",\"") + 2, _input.LastIndexOf("\"") - _input.IndexOf(",\"") - 2);
                }
                dr["ItemName"] = ItemName;
                string Memo = string.Empty;
                if (layout_tag_found)
                {
                    ItemName = ",\"" + ItemName + "\",";
                    int FindPos = _input.IndexOf(ItemName);
                    if (!(_input.Length == FindPos + ItemName.Length))
                    {
                        Memo = _input.Substring(FindPos + ItemName.Length);
                        if (NotesImport)
                        {
                            // Notes Process
                            if (drUpd != null)
                            {
                                drUpd.BeginEdit();
                                drUpd["Memo"] = Memo;
                                drUpd.EndEdit();
                            }
                        }
                    }
                }
                dr["Memo"] = Memo;
                if (!GroupOnly && !NotesImport && drUpd == null) HouseItems.Rows.Add(dr);
            }
            sr.Close();
            _lastModified = File.GetLastWriteTime(_filename);
            return true;
        }

        public bool SaveFile()
        {
            if (!_fileloaded) return false;
            return SaveFile(_filename);
        }
        public bool SaveFile(string FileName)
        {
            File.WriteAllText(FileName, "");
            StreamWriter sw = new StreamWriter(FileName);
            sw.WriteLine(_fileversion.ToString() + ",Version Number");
            sw.WriteLine(_houseversion.ToString() + "," + _housetype);
            sw.WriteLine(_houseid.ToString() + ", Unique House ID. ");
            sw.WriteLine("//EQ2LayoutEditor"); 
            string line;
            foreach (DataRow dr in HouseItems.Rows)
            {
                line = dr["ItemID"].ToString();
                line += ",";
                line += dr["DatabaseID"].ToString();
                line += ",";
                line += String.Format("{0:0.00000000}", dr["x"]);
                line += ",";
                line += String.Format("{0:0.00000000}", dr["z"]);
                line += ",";
                line += String.Format("{0:0.00000000}", dr["y"]);
                line += ",";
                line += String.Format("{0:0.00000000}", dr["Rotation"]);
                line += ",";
                line += String.Format("{0:0.00000000}", dr["Pitch"]);
                line += ",";
                line += String.Format("{0:0.00000000}", dr["Roll"]);
                line += ",";
                line += String.Format("{0:0.00000000}", dr["Scale"]);
                line += ", ";
                line += dr["InCrate"].ToString().ToLower();
                line += ",";
                line += "\"" + dr["ItemName"] + "\"";
                line += "," + dr["Memo"].ToString();
                sw.WriteLine(line);
            }
            line = "//GROUP:";
            foreach (Group grp in Groups)
            {
                List<Int32> Items = new List<Int32>();
                line += grp.Name + ":";
                line += String.Join(",", grp.GetItems().ToArray());
                line += ":";
                sw.WriteLine(line);
            }
            sw.Close();
            if (FileName != _filename) { _filename = FileName; }
            System.Threading.Thread.Sleep(250);
            _lastModified = File.GetLastWriteTime(_filename);
            return true;

        }
        public void Refresh()
        {
            LoadFile(_filename);
            _lastModified = File.GetLastWriteTime(_filename);
        }
        internal void ItemstoDB(Placement.HouseItem[] Items)
        {
            foreach (Placement.HouseItem Item in Items)
            {
                bool ItemFound = false;
                foreach (DataRow dr in HouseItems.Rows)
                {
                    if ((int)dr["DatabaseID"] == Item.DatabaseID)
                    {
                        dr["ItemID"] = Item.ItemID;
                        dr["DatabaseID"] = Item.DatabaseID;
                        dr["x"] = Item.x;
                        dr["z"] = Item.z;
                        dr["y"] = Item.y;
                        dr["Rotation"] = Item.Rotation;
                        dr["Pitch"] = Item.Pitch;
                        dr["Roll"] = Item.Roll;
                        dr["Scale"] = Item.Scale;
                        dr["InCrate"] = Item.InCrate;
                        dr["ItemName"] = Item.ItemName;
                        dr["Memo"] = Item.Memo;
                        ItemFound = true;
                        break;
                    }
                }
                if (!ItemFound)
                {
                    DataRow dr_add = HouseItems.NewRow();
                    dr_add["ItemID"] = Item.ItemID;
                    dr_add["DatabaseID"] = Item.DatabaseID;
                    dr_add["x"] = Item.x;
                    dr_add["z"] = Item.z;
                    dr_add["y"] = Item.y;
                    dr_add["Rotation"] = Item.Rotation;
                    dr_add["Pitch"] = Item.Pitch;
                    dr_add["Roll"] = Item.Roll;
                    dr_add["Scale"] = Item.Scale;
                    dr_add["InCrate"] = Item.InCrate;
                    dr_add["ItemName"] = Item.ItemName;
                    dr_add["Memo"] = Item.Memo;
                    HouseItems.Rows.Add(dr_add);
                }
            }
        }
        internal void ManifestGenerate(bool CSV, bool HTML)
        {
            string OutPath = FileName + "_manifest.csv";
            string OutFile = "\"Item Name\",\"Item Count\"";

            var ItemsQuery = from row in HouseItems.AsEnumerable()
                             group row by new { ItemName = row.Field<string>("ItemName"), ItemID = row.Field<Int64>("ItemID") } into items
                             orderby items.Key.ItemName
                             select new { ItemName = items.Key.ItemName, ItemID = items.Key.ItemID, ItemCount = items.Count() };
            if (CSV)
            {
                foreach (var Item in ItemsQuery)
                {
                    OutFile += string.Format(Environment.NewLine + "\"{0}\",\"{1}\"", Item.ItemName.ToString(), Item.ItemCount.ToString());
                }

                File.WriteAllText(OutPath, OutFile);
            }
            if (HTML)
            {
                OutFile = String.Format("<html><title>{0}</title>", FileName);
                OutFile += @"<style>
	a 
	{
		color: #00a;
		text-decoration: none;
		display: inline-block;
		margin: 1px 2px;
		padding: 1px;
	}
    a:visited
	{
		color: #606;
		text-decoration: none;
	}
	a:hover
	{
		color: #FFF;
		text-decoration: none;
		background-color: #252;
	}
</style>";
                OutFile += "<body><table cellpadding=0 cellspacing=0><tr style=\"background-color:#333;color:#FFF;\"><td>EQ2i</td><td>LootDB</td><td>EQ2U</td><td>Item Name</td><td>Item Quantity</td></tr>";
                int rownum = 0;
                foreach (var item in ItemsQuery)
                {
                    string RowColor = (rownum == 0) ? "#FFF" : "#DDD";
                    OutFile += String.Format("\r\n<tr style=\"background-color:{0};\"><td><a href=\"http://eq2.wikia.com/wiki/{1}\" target=\"_blank\">EQ2i</a></td><td><a href=\"http://lootdb.com/?t=item&q={2}\" target=\"_blank\">LootDB</a></td><td><a href=\"http://u.eq2wire.com/item/index/{3}\"target=\"_blank\">EQ2U</a></td><td>{4}</td><td>{5}</td></tr>", RowColor, item.ItemName.Replace(" ", "_"), item.ItemName.Replace(" ", "+"), item.ItemID, item.ItemName, item.ItemCount.ToString());
                    rownum = Math.Abs(rownum - 1);
                }
                OutFile += "</table></body></html>";
                OutPath = FileName + ".html";
                File.WriteAllText(OutPath, OutFile);
            }
        }
        internal void AddGroupItem(string GroupName, Int32 DatabaseID)
        {
            GroupName = GroupName.Replace(":", "|");
            foreach (Group grp in Groups)
            {
                if (grp.Name == GroupName)
                {
                    grp.AddItem(DatabaseID);
                    return;
                }
            }
            Group grpAdd = new Group();
            grpAdd.Name = GroupName;
            grpAdd.AddItem(DatabaseID);
            Groups.Add(grpAdd);
        }
        internal void RemoveGroupItem(string GroupName, Int32 DatabaseID)
        {
            foreach (Group grp in Groups)
            {
                if (grp.Name == GroupName)
                {
                    grp.RemoveItem(DatabaseID);
                    break;
                }
            }
        }
        internal void RemoveGroup(string GroupName)
        {
            int grpCt = Groups.Count;
            for (int grp = 0; grp <= grpCt; grp++)
            {
                if (Groups[grp].Name == GroupName)
                {
                    Groups.RemoveAt(grp);
                    break;
                }
            }
        }
        internal DataRow FindCrateItem(Int64 ItemID)
        {
            foreach (DataRow dr in HouseItems.Rows)
            {
                if (Int64.Parse(dr["ItemId"].ToString()) == ItemID && bool.Parse(dr["InCrate"].ToString()) == true)
                {
                    return dr;
                }
            }
            return null;
        }
    }
}
