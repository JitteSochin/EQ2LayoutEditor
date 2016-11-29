using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace LayoutEdit
{
    public partial class frmLibrary : Form
    {
        private struct LayoutSummary
        {
            internal Int64 ItemID { get; set; }
            internal string ItemName { get; set; }
            internal Int32 ItemCount { get; set; }
            internal Int32 CratedCount { get; set; }
            internal LayoutSummary(Int64 itemid, string itemname, Int32 itemct, Int32 cratedct)
            {
                ItemID = itemid;
                ItemName = itemname;
                ItemCount = itemct;
                CratedCount = cratedct;
            }
        }
        List<LayoutSummary> Summary = new List<LayoutSummary>();
        List<LayoutFile> layoutfiles = new List<LayoutFile>();
        LayoutFile masterlayout = new LayoutFile();
        
        public frmLibrary()
        {
            InitializeComponent();
        }
        private void btnRemoveDir_Click(object sender, EventArgs e)
        {
            if (lstDirectories.SelectedIndex == -1) return;
            lstDirectories.Items.RemoveAt(lstDirectories.SelectedIndex);
            SaveSettings();
        }
        private void SaveSettings()
        {
            string DirList = string.Empty;
            string AppFolder = Application.StartupPath;
            AppFolder += (AppFolder.Substring(AppFolder.Length - 1, 1) == "\\") ? string.Empty : "\\";
            string DirectoryFile = AppFolder + "layoutdirs";
            for (int itm = 0; itm < lstDirectories.Items.Count; itm ++)
            {
                DirList += lstDirectories.Items[itm].ToString();
                if (itm < lstDirectories.Items.Count - 1) DirList += Environment.NewLine;
            }
            File.WriteAllText(DirectoryFile, DirList);
        }
        private void LoadSettings()
        {
            string DirList = string.Empty;
            string AppFolder = Application.StartupPath;
            AppFolder += (AppFolder.Substring(AppFolder.Length - 1, 1) == "\\") ? string.Empty : "\\";
            string DirectoryFile = AppFolder + "layoutdirs";
            if (!File.Exists(DirectoryFile)) return;
            using (StreamReader sr = new StreamReader(DirectoryFile))
            {
                while (!sr.EndOfStream)
                {
                    string dir = sr.ReadLine();
                    if (!Directory.Exists(dir))
                    {
                        MessageBox.Show(string.Format("Folder \"{0}\" doesn't exist. Skipping.", dir));
                        continue;
                    }
                    int li = lstDirectories.Items.Add(dir);
                }
                sr.Close();
            }
            ScanFolders();
        }
        private void btnAddDir_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = FolderFinder.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            string FolderSel = FolderFinder.SelectedPath.ToLower();
            if (lstDirectories.Items.Contains(FolderSel))
            {
                MessageBox.Show("Selected folder already in list");
                return;
            }
            lstDirectories.Items.Add(FolderSel);
            SaveSettings();
            ScanFolders();
        }
        private void frmLibrary_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }
        private void ScanFolders()
        {
            layoutfiles.Clear();
            foreach (string folder in lstDirectories.Items)
            {
                foreach (string file in Directory.GetFiles(folder, "*."))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        string firstline = sr.ReadLine();
                        sr.Close();
                        if (firstline == "6,Version Number")
                        {
                            LayoutFile LF = new LayoutFile();
                            LF.FileName = file;
                            layoutfiles.Add(LF);
                        }
                    }
                }
            }
            FillList();
        }
        private void FillList()
        {
            lvLayouts.Items.Clear();
            foreach (LayoutFile lf in layoutfiles)
            {
                ListViewItem lvi = lvLayouts.Items.Add(lf.FileName);
                lvi.SubItems.Add(lf.HouseItems.Rows.Count.ToString("#,###"));
                lvi.SubItems.Add(lf.HouseID);
                lvi.SubItems.Add(lf.HouseType);
            }
        }

        private void lvLayouts_SelectedIndexChanged(object sender, EventArgs e)
        {
            masterlayout = new LayoutFile();
            foreach (int item in lvLayouts.SelectedIndices)
            {
                string FileName = lvLayouts.Items[item].Text;
                if (!masterlayout.FileLoaded)
                {
                    masterlayout.FileName = FileName;
                } else
                {
                    masterlayout.MergeFile(FileName);
                }
            }
            Summary.Clear();
            foreach (DataRow dtarw in masterlayout.HouseItems.Rows)
            {
                Int64 itmid = (Int64)dtarw["ItemID"];
                string itmnm = dtarw["ItemName"].ToString();
                bool crated = (bool)dtarw["InCrate"];
                AddSummaryItem(itmnm, itmid, crated);
            }
            lvItems.Items.Clear();
            foreach (LayoutSummary item in Summary)
            {
                ListViewItem itm = new ListViewItem(item.ItemID.ToString());
                itm.SubItems.Add(item.ItemName);
                itm.SubItems.Add(item.ItemCount.ToString("#,###"));
                itm.SubItems.Add(item.CratedCount.ToString("#,###"));
                lvItems.Items.Add(itm);
            }
        }
        private void AddSummaryItem (string ItemName, Int64 ItemID, bool InCrate)
        {
            LayoutSummary Itm = new LayoutSummary();
            Itm.ItemID = ItemID;
            Itm.ItemName = ItemName;
            Itm.ItemCount = 1;
            Itm.CratedCount = (InCrate) ? 1 : 0;
            if (Summary.Count == 0)
            {
                Summary.Add(Itm);
                return;
            } else
            {
                int itmct = Summary.Count;
                for (int ci = 0; ci<itmct; ci++)
                {
                    if (Summary[ci].ItemID == ItemID)
                    {
                        Itm = Summary[ci];
                        Itm.ItemCount++;
                        Itm.CratedCount += (InCrate) ? 1 : 0;
                        Summary[ci] = Itm;
                        return;
                    }
                }
            }
            Summary.Add(Itm);
        }

        private void lvItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lvItems.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            int itmct = lvItems.Items.Count;
            for (int i = 0; i < itmct; i++)
            {
                if (txtFind.Text.Trim() == string.Empty)
                {
                    lvItems.Items[i].BackColor = System.Drawing.SystemColors.Window;
                }else if (lvItems.Items[i].SubItems[1].Text.ToLower().Contains(txtFind.Text.ToLower()))
                {
                    lvItems.Items[i].BackColor = System.Drawing.Color.Yellow;
                } else
                {
                    lvItems.Items[i].BackColor = System.Drawing.SystemColors.Window;
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            doSearch();
        }
        private void doSearch()
        {
            dgFinder.Rows.Clear();
            Int64 ItemID = 0;
            bool IsInt64 = Int64.TryParse(txtFind.Text, out ItemID);
            foreach (LayoutFile lf in layoutfiles)
            {
                var ItemsQuery = from row in lf.HouseItems.AsEnumerable()
                                 where row.Field<string>("ItemName").ToLower().Contains(txtFindItem.Text.Trim().ToLower())
                                 select new
                                 {
                                     ItemID = row.Field<long>("ItemID"),
                                     DatabaseID = row.Field<int>("DatabaseID"),
                                     ItemName = row.Field<string>("ItemName"),
                                     ItemX = row.Field<decimal>("X"),
                                     ItemY = row.Field<decimal>("Y"),
                                     ItemZ = row.Field<decimal>("Z"),
                                     ItemCrate = row.Field<bool>("inCrate")
                                 };
                foreach (var item in ItemsQuery)
                {
                    dgFinder.Rows.Add(item.ItemID, item.DatabaseID, item.ItemName, string.Format("/way {0},{1},{2}", item.ItemX, item.ItemZ, item.ItemY), item.ItemCrate, lf.HouseID, lf.HouseType, lf.FileName);
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgFinder.Rows.Clear();
        }

        private void dgFinder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3 || e.RowIndex == -1) return;
            DataGridViewLinkCell cell = (DataGridViewLinkCell)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex];
            string waypoint = cell.Value.ToString();
            Clipboard.Clear();
            Clipboard.SetText(waypoint);
            cell.Value = " - Copied - ";
            Application.DoEvents();
            System.Threading.Thread.Sleep(250);
            cell.Value = waypoint;
        }

        private void txtFindItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') doSearch();
        }

        private void btnFindDirs_Click(object sender, EventArgs e)
        {

        }
    }
}
