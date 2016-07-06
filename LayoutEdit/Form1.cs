using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace LayoutEdit
{
    public partial class Form1 : Form
    {
        LayoutFile layout = new LayoutFile();
        Dial Percentage = new Dial();
        Dial Fill = new Dial();
        frmChart Chart = new frmChart();
        private Int64 ClonedHouseItemDBId = 99999999;
        public Form1()
        {
            InitializeComponent();
            /* JesDer 2016-04-15 */
            // Fix decimal separator issues by setting culture to en-US 
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            ttThickness.SetToolTip(txtPlaneThick, "This sets the \"Thickness\" of the mirror. Creating a gap between the items at the plane");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (od.ShowDialog(this) == DialogResult.Cancel) return;
            ClonedHouseItemDBId = 99999999;
            layout.FileName = od.FileName;
            dg.Columns["ItemName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns["ItemName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Text = "Layout Editor: " + layout.FileName + " - " + layout.HouseType + ": " + layout.HouseID;
            cboGroups.Items.Clear();
            cboGroups.Items.Add("New...");
            foreach (Group grp in layout.Groups)
            {
                cboGroups.Items.Add(grp.Name);
            }
            if (Chart.Visible) Chart.FirstBuild(layout.HouseItems);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboGroups.Items.Clear();
            cboGroups.Items.Add("New...");
            cboCirclePlane.SelectedIndex = 0;
            dg.DataSource = layout.HouseItems;                      
            dg.Columns["x"].HeaderText = "+ West / - East (X)";
            dg.Columns["y"].HeaderText = "+ South / - North (Y)";
            dg.Columns["z"].HeaderText = "+ Up / - Down (Z)";
            dg.Columns["Rotation"].HeaderText = "Z Rotation";
            dg.Columns["Pitch"].HeaderText = "X Rotation";
            dg.Columns["Roll"].HeaderText = "Y Rotation";

            dg.Columns["x"].DefaultCellStyle.Format = "0.00000000";
            dg.Columns["y"].DefaultCellStyle.Format = "0.00000000";
            dg.Columns["z"].DefaultCellStyle.Format = "0.00000000";
            dg.Columns["Rotation"].DefaultCellStyle.Format = "0.00000000";
            dg.Columns["Pitch"].DefaultCellStyle.Format = "0.00000000";
            dg.Columns["Roll"].DefaultCellStyle.Format = "0.00000000";
            dg.Columns["Scale"].DefaultCellStyle.Format = "0.00000000";

            this.Text = "Layout Editor: No File Loaded";

            Percentage.Top = lbl_off.Bottom; ;
            Percentage.Left = lbl_off.Left; ;
            Percentage.Width = 50;
            Percentage.Height = 50;
            Percentage.BackColor = tabCircleSpiral.BackColor;
            Percentage.Wrap = true;
            Percentage.ValueChanged += new EventHandler(Percentage_ValueChanged);
            tabCircleSpiral.Controls.Add(Percentage);

            Fill.Top = lbl_Fill.Bottom;
            Fill.Left = lbl_Fill.Left;
            Fill.Width = 50;
            Fill.Height = 50;
            Fill.BackColor = tabCircleSpiral.BackColor;
            Fill.Wrap = false;
            Fill.StartingOffset = 270;
            Fill.FillMode = Dial.FillType.Pie;
            Fill.ValueChanged += new EventHandler(Fill_ValueChanged);
            Fill.Value = 359;
            tabCircleSpiral.Controls.Add(Fill);
        }

        void Fill_ValueChanged(object sender, EventArgs e)
        {
            double FillValue = (Fill.Value == 0) ? 0 : (((double)Fill.Value + 1) / (double)360);
            lbl_Fill.Text = "Fill: " + String.Format("{0:0.0%}", FillValue);
        }

        void Percentage_ValueChanged(object sender, EventArgs e)
        {
            lbl_off.Text = "Start Offset:" + Environment.NewLine + Percentage.Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Length != 0)
            {
                string[] Search = txtSearch.Text.Trim().Split(' ');
                string Filter = string.Empty;
                int tick = 0;
                foreach (string Param in Search)
                {
                    if (tick > 0) Filter += "AND ";
                    Filter += string.Format("ItemName Like '%{0}%' ", Param.Replace("'","''"));
                    tick++;
                }
                layout.HouseItems.DefaultView.RowFilter = Filter;
            }
            else
            {
                layout.HouseItems.DefaultView.RowFilter = "";
            }
        }

        private void lblClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            sd.FileName = layout.FileName;
            if (sd.ShowDialog(this) != DialogResult.Cancel)
            {
                layout.SaveFile(sd.FileName);
                this.Text = "Layout Editor: " + layout.FileName + " - " + layout.HouseType + ": " + layout.HouseID;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            layout.SaveFile();
        }

        private void mnuEffectCircle_Click(object sender, EventArgs e)
        {
            Placement.HouseItem[] Items = SelectedGridToItems();
            Placement.Vector3D CenterPoint = new Placement.Vector3D(
                double.Parse(txtCirCentX.Text)
                , double.Parse(txtCirCentY.Text)
                , double.Parse(txtCirCentZ.Text));
            int StartingPoint = Percentage.Value;
            double FillPerc = (double)Fill.Value / 359d;
            double RadiusX = double.Parse(txtRadiusLeft.Text);
            double RadiusY = double.Parse(txtRadiusRight.Text);
            Placement.DirectionType Reverse = (chkReverse.Checked) ? Placement.DirectionType.Reverse : Placement.DirectionType.Forward;
            int Orientation = (cboCirclePlane.SelectedIndex != 0) ? 1 : 0;
            int Facing = (cboCirclePlane.SelectedIndex == 1) ? 1 : 0;
            bool sVertical = rdo_From_Ground.Checked ;
            bool Spiral = chkSpiral.Checked;
            Items = Placement.CirclePlane(Items, CenterPoint, Orientation, RadiusX, RadiusY, Facing, double.Parse(txtEndZ.Text),
                Reverse, FillPerc, chkRotate.Checked, StartingPoint, chk90Offset.Checked, Spiral, sVertical, double.Parse(txtRevolutions.Text), chkPointTops.Checked);
            layout.ItemstoDB(Items);
            if (Chart.Visible) Chart.Redraw();
        }
       
        private Placement.HouseItem[] SelectedGridToItems()
        {
            Placement.HouseItem[] Items = new Placement.HouseItem[dg.SelectedRows.Count];
            int i = 0;
            foreach (DataGridViewRow row in dg.SelectedRows)
            {
                //Items[i].ID = int.Parse(row.Cells["ID"].Value.ToString());
                Items[i].DatabaseID = int.Parse(row.Cells["DatabaseID"].Value.ToString());
                Items[i].InCrate = bool.Parse(row.Cells["InCrate"].Value.ToString());
                Items[i].ItemID = Int64.Parse(row.Cells["ItemID"].Value.ToString());
                Items[i].ItemName = row.Cells["ItemName"].Value.ToString();
                Items[i].Pitch = decimal.Parse(row.Cells["Pitch"].Value.ToString());
                Items[i].Roll = decimal.Parse(row.Cells["Roll"].Value.ToString());
                Items[i].Rotation = decimal.Parse(row.Cells["Rotation"].Value.ToString());
                Items[i].Scale = decimal.Parse(row.Cells["Scale"].Value.ToString());
                Items[i].x = decimal.Parse(row.Cells["x"].Value.ToString());
                Items[i].y = decimal.Parse(row.Cells["y"].Value.ToString());
                Items[i].z = decimal.Parse(row.Cells["z"].Value.ToString());
                Items[i].Memo = row.Cells["Memo"].Value.ToString();
                i++;
            }
            return Items;
        }
       
        private void btnTile_Click(object sender, EventArgs e)
        {
            int ItemsCount = dg.SelectedRows.Count;
            if (ItemsCount == 0) { MessageBox.Show("No rows selected. Aborting."); return; }
            Placement.Vector3D v3 = new Placement.Vector3D(double.Parse(txtStartX.Text), double.Parse(txtStartY.Text), double.Parse(txtStartZ.Text));
            int xUnits = int.Parse(txtUnitsX.Text);
            int yUnits = int.Parse(txtUnitsY.Text);
            int zUnits = int.Parse(txtUnitsZ.Text);
            decimal xSpacing = decimal.Parse(txtSpaceX.Text);
            decimal ySpacing = decimal.Parse(txtSpaceY.Text);
            decimal zSpacing = decimal.Parse(txtSpaceZ.Text);
            decimal Scaling = decimal.Parse(txtScaling.Text);
            int RC = xUnits * yUnits * zUnits;
            if (RC == 0)
            {
                MessageBox.Show("You need to have at least 1 column and 1 row. Aborting.");
                return;
            }
            if (RC == 1)
            {
                MessageBox.Show("Your current settings will put everything in one place. Aborting.");
                return;
            }
            if (RC != ItemsCount)
            {
                string Effect = (RC < ItemsCount) ? (ItemsCount - RC).ToString() + " items left in place" : (RC - ItemsCount).ToString() + " missing tiles";
                DialogResult dr = MessageBox.Show(string.Format("The input you have placed for Rows and Columns requires {0} items. Currently you have {1}. Using this will have {2}.{3}Continue?",
                    RC.ToString(), ItemsCount.ToString(), Effect, Environment.NewLine), "Item count mismatch", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No) return;
            }

            Placement.HouseItem[] Items = SelectedGridToItems();
            Items = Placement.Tile(Items, v3, xSpacing, ySpacing, zSpacing, xUnits, yUnits, zUnits, Scaling, chkIgnoreScaling.Checked, chkZeroRotation.Checked);
            layout.ItemstoDB(Items);
            if (Chart.Visible) Chart.Redraw();
        }

        private void NumberText_Leave(object sender, EventArgs e)
        {
            TextBox Sender = (TextBox)sender;
            decimal throwaway;
            if (!decimal.TryParse(Sender.Text, out throwaway)){
                MessageBox.Show("This field needs to be numerical. Please enter a valid value");
                Sender.Focus();
                return;
            }
            if (Sender.Name == "txtSpaceX" && chkSpaceLink.Checked)
            {
                txtSpaceY.Text = txtSpaceX.Text;
                txtSpaceZ.Text = txtSpaceX.Text;
            }
            if (Sender.Name == "txtRadiusX" && chkRadiusSync.Checked) 
            {
                txtRadiusRight.Text = txtRadiusLeft.Text;
            }
        }

        private void btnDeleteCrate_Click(object sender, EventArgs e)
        {
            DataRow[] rows = layout.HouseItems.Select("InCrate = TRUE");
            foreach (DataRow row in rows)
            {
                row.Delete();
            }
        }

        private void btnManifest_Click(object sender, EventArgs e)
        {
            mnuShopping.Show(MousePosition);
        }
        private void mnuShopping_ItemClick(object sender, EventArgs e)
        {
            ToolStripMenuItem Clicked = (ToolStripMenuItem)sender;
            string CSVOutPath = layout.FileName + "_manifest.csv";
            string HTMLOutPath = layout.FileName + ".html";
            switch (Clicked.Name)
            {
                case "mnuShopCSV":
                    layout.ManifestGenerate(true, false);
                    if (MessageBox.Show("CSV file created as" + Environment.NewLine + CSVOutPath + Environment.NewLine + Environment.NewLine + "Open Now?", "File Created", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(CSVOutPath);
                    }
                    break;
                case "mnuShopHTML":
                    layout.ManifestGenerate(false, true);
                    if (MessageBox.Show("HTML file created as" + Environment.NewLine + HTMLOutPath + Environment.NewLine + Environment.NewLine + "Open Now?", "File Created", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(HTMLOutPath);
                    }
                    break;
                case "mnuShopBoth":
                    layout.ManifestGenerate(true, true);
                    if (MessageBox.Show("CSV file created as" + Environment.NewLine + CSVOutPath + Environment.NewLine + Environment.NewLine + "Open Now?", "File Created", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(CSVOutPath);
                    }
                    if (MessageBox.Show("HTML file created as" + Environment.NewLine + HTMLOutPath + Environment.NewLine + Environment.NewLine + "Open Now?", "File Created", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(HTMLOutPath);
                    }
                    break;
                default:
                    break;
            }
        }
        private void btnClone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg.SelectedRows)
            {
                DataRow DR = layout.HouseItems.NewRow();
                
                DR["InCrate"] = bool.Parse(row.Cells["InCrate"].Value.ToString());
                DR["ItemID"] = Int64.Parse(row.Cells["ItemID"].Value.ToString());
                DR["ItemName"] = row.Cells["ItemName"].Value.ToString();
                DR["Pitch"] = decimal.Parse(row.Cells["Pitch"].Value.ToString());
                DR["Roll"] = decimal.Parse(row.Cells["Roll"].Value.ToString());
                DR["Rotation"] = decimal.Parse(row.Cells["Rotation"].Value.ToString());
                DR["Scale"] = decimal.Parse(row.Cells["Scale"].Value.ToString());
                DR["x"] = decimal.Parse(row.Cells["x"].Value.ToString());
                DR["y"] = decimal.Parse(row.Cells["y"].Value.ToString());
                DR["z"] = decimal.Parse(row.Cells["z"].Value.ToString());
            clonePreAdd:
                DR["DatabaseID"] = ClonedHouseItemDBId;
                ClonedHouseItemDBId--;
                try
                {
                    layout.HouseItems.Rows.Add(DR);
                }
                catch
                {
                    goto clonePreAdd;
                }
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (!layout.FileLoaded) return;
            if (File.GetLastWriteTime(layout.FileName) != layout.LastModified)
            {
                layout.LastModified = File.GetLastWriteTime(layout.FileName);
                if (MessageBox.Show("The layout file has been changed since last load. Reload?", "File Changed", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    layout.Refresh();
                    ClonedHouseItemDBId = 99999999;
                }
            }
        }
        
        private void MassMove_Click(object sender, EventArgs e)
        {
            decimal modifier = 1;
            Button Clicked = (Button)sender;
            decimal MoveAmount = decimal.Parse(txtMoveAmount.Text);
            if (Clicked.Name == "btnDown" || Clicked.Name == "btnEast" || Clicked.Name == "btnNorth") modifier = -1;
            foreach (DataGridViewRow row in dg.SelectedRows)
            {
                switch (Clicked.Name)
                {
                    case "btnUp":
                    case "btnDown":
                        row.Cells["z"].Value = decimal.Parse(row.Cells["z"].Value.ToString()) + modifier * MoveAmount;
                        break;
                    case "btnEast":
                    case "btnWest":
                        row.Cells["x"].Value = decimal.Parse(row.Cells["x"].Value.ToString()) + modifier * MoveAmount;
                        break;
                    case "btnNorth":
                    case "btnSouth":
                        row.Cells["y"].Value = decimal.Parse(row.Cells["y"].Value.ToString()) + modifier * MoveAmount;
                        break;
                    case "btnRotate":
                        row.Cells["Rotation"].Value = decimal.Parse(row.Cells["Rotation"].Value.ToString()) + modifier * MoveAmount;
                        break;
                    case "btnPitch":
                        row.Cells["Pitch"].Value = decimal.Parse(row.Cells["Pitch"].Value.ToString()) + modifier * MoveAmount;
                        break;
                    case "btnRoll":
                        row.Cells["Roll"].Value = decimal.Parse(row.Cells["Roll"].Value.ToString()) + modifier * MoveAmount;
                        break;
                    case "btnRotateReset":
                        row.Cells["Rotation"].Value = 0;
                        row.Cells["Pitch"].Value = 0;
                        row.Cells["Roll"].Value = 0;
                        break;
                    case "btnInCrate":
                        row.Cells["InCrate"].Value = chkMassCrate.Checked;
                        break;
                    case "btnScaling":
                        row.Cells["Scale"].Value = decimal.Parse(txtMassScaling.Text);
                        break;
                    default:
                        // Do nothing or show a message box.
                        MessageBox.Show(Clicked.Name);
                        break;
                }
            }
            if (Chart.Visible) Chart.Redraw();
        }

        private void saveChangesOnlyAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!layout.FileLoaded) return;
            LayoutFile original = new LayoutFile();
            LayoutFile changes = new LayoutFile();
            changes.FileName = layout.FileName; // Load File Properties
            changes.HouseItems.Clear();

            original.FileName = layout.FileName;
            var Compare =
                from nrow in layout.HouseItems.AsEnumerable()
                join orow in original.HouseItems.AsEnumerable()
                on nrow.Field<Int32>("DatabaseID") equals orow.Field<Int32>("DatabaseID")
                where !(nrow.Field<decimal>("x") == orow.Field<decimal>("x")
                        && nrow.Field<decimal>("y") == orow.Field<decimal>("y")
                        && nrow.Field<decimal>("z") == orow.Field<decimal>("z")
                        && nrow.Field<decimal>("Rotation") == orow.Field<decimal>("Rotation")
                        && nrow.Field<decimal>("Pitch") == orow.Field<decimal>("Pitch")
                        && nrow.Field<decimal>("Roll") == orow.Field<decimal>("Roll")
                        && nrow.Field<decimal>("Scale") == orow.Field<decimal>("Scale")
                        && nrow.Field<bool>("InCrate") == orow.Field<bool>("InCrate"))
                select nrow;
            
            Compare.CopyToDataTable(changes.HouseItems, LoadOption.PreserveChanges);
            if (changes.HouseItems.Rows.Count == 0)
            {
                MessageBox.Show("No Changes Detected");
                return;
            }
            if (sd.ShowDialog(this) == DialogResult.Cancel) return;
            
            changes.SaveFile(sd.FileName);
        }

        private void chkSpaceLink_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpaceLink.Checked)
            {
                txtSpaceY.Enabled = false;
                txtSpaceZ.Enabled = false;
                txtSpaceY.Text = txtSpaceX.Text;
                txtSpaceZ.Text = txtSpaceX.Text;
            }
            else
            {
                txtSpaceY.Enabled = true;
                txtSpaceZ.Enabled = true;
            }
        }

        private void btnGroupItemAdd_Click(object sender, EventArgs e)
        {
            if (cboGroups.SelectedIndex == -1)
            {
                MessageBox.Show("Select a group to add the item(s) to");
                return;
            }
            if (cboGroups.SelectedItem.ToString() == "New..." && txtGroupName.Text == "New Group Name...")
            {
                MessageBox.Show("You must name the group...");
                return;
            }
            string grpName = (cboGroups.SelectedItem.ToString() == "New...") ? txtGroupName.Text : cboGroups.SelectedItem.ToString();
            foreach (DataGridViewRow dgr in dg.SelectedRows)
            {
                layout.AddGroupItem(grpName, Int32.Parse(dgr.Cells["DatabaseId"].Value.ToString()));
            }
            cboGroups.Items.Clear();
            cboGroups.Items.Add("New...");
            foreach (Group grp in layout.Groups)
            {
                cboGroups.Items.Add(grp.Name);
            }
            cboGroups.SelectedItem = grpName.Replace(":","|");
            txtGroupName.Text = "New Group Name...";
        }

        private void btnGroupItemRemove_Click(object sender, EventArgs e)
        {
            if (cboGroups.SelectedIndex == -1 || cboGroups.SelectedItem.ToString() == "New...")
            {
                MessageBox.Show("Select a group to add the item(s) from");
                return;
            }
            string grpName = (cboGroups.SelectedItem.ToString() == "New...") ? txtGroupName.Text : cboGroups.SelectedItem.ToString();
            foreach (DataGridViewRow dgr in dg.SelectedRows)
            {
                layout.RemoveGroupItem(grpName, Int32.Parse(dgr.Cells["DatabaseId"].Value.ToString()));
            }
            HighlightGroupItems(false);
        }

        private void btnGroupRemove_Click(object sender, EventArgs e)
        {
            if (cboGroups.SelectedIndex == -1 || cboGroups.SelectedItem.ToString() == "New...")
            {
                MessageBox.Show("Select a group to remove");
                return;
            }
            string grpName = (cboGroups.SelectedItem.ToString() == "New...") ? txtGroupName.Text : cboGroups.SelectedItem.ToString();
            layout.RemoveGroup(grpName);
            cboGroups.Items.Clear();
            cboGroups.Items.Add("New...");
            foreach (Group grp in layout.Groups)
            {
                cboGroups.Items.Add(grp.Name);
            }
            layout.HouseItems.DefaultView.RowFilter = "";
        }

        private void btnFilterGroup_Click(object sender, EventArgs e)
        {
            if (cboGroups.SelectedIndex == -1 || cboGroups.SelectedItem.ToString() == "New...")
            {
                MessageBox.Show("Select a group to filter");
                return;
            } 
            string Filter = "DATABASEID IN (";
            string grpName = (cboGroups.SelectedItem.ToString() == "New...") ? txtGroupName.Text : cboGroups.SelectedItem.ToString();
            Group CurrGrp = new Group();
            foreach (Group grp in layout.Groups)
            {
                if (grp.Name == grpName)
                {
                    CurrGrp = grp;
                }
            }
            Filter += String.Join(",", CurrGrp.GetItems());
            Filter += ")";
            layout.HouseItems.DefaultView.RowFilter = Filter;
        }

        private void btnFilterOutGroup_Click(object sender, EventArgs e)
        {
            if (cboGroups.SelectedIndex == -1 || cboGroups.SelectedItem.ToString() == "New...")
            {
                MessageBox.Show("Select a group to filter");
                return;
            }
            string Filter = "DATABASEID NOT IN (";
            string grpName = (cboGroups.SelectedItem.ToString() == "New...") ? txtGroupName.Text : cboGroups.SelectedItem.ToString();
            Group CurrGrp = new Group();
            foreach (Group grp in layout.Groups)
            {
                if (grp.Name == grpName)
                {
                    CurrGrp = grp;
                }
            }
            Filter += String.Join(",", CurrGrp.GetItems());
            Filter += ")";
            layout.HouseItems.DefaultView.RowFilter = Filter;
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            layout.HouseItems.DefaultView.RowFilter = "";
        }

        private void cboGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            HighlightGroupItems();
        }
        private void HighlightGroupItems(bool FromCombo = true)
        {
            if (FromCombo)
            {
                if (cboGroups.SelectedIndex == -1)
                {
                    MessageBox.Show("Select a group to filter");
                    return;
                }
            }
            string grpName = (cboGroups.SelectedItem.ToString() == "New...") ? txtGroupName.Text : cboGroups.SelectedItem.ToString();
            if (grpName == "New...")
            {
                foreach (DataGridViewRow dgr in dg.Rows)
                {
                    dgr.DefaultCellStyle.BackColor = Color.White;
                }
            }
            else
            {
                Group CurrGrp = new Group();
                foreach (Group grp in layout.Groups)
                {
                    if (grp.Name == grpName)
                    {
                        CurrGrp = grp;
                    }
                }
                foreach (DataGridViewRow dgr in dg.Rows)
                {
                    if (dgr.IsNewRow) break;
                    if (CurrGrp.GetItems().Contains((Int32.Parse(dgr.Cells["DatabaseID"].Value.ToString()))))
                    {
                        dgr.DefaultCellStyle.BackColor = Color.Gold;
                    }
                    else
                    {
                        dgr.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        private void btnRenameGroup_Click(object sender, EventArgs e)
        {
            if (cboGroups.SelectedIndex == -1 || cboGroups.SelectedItem.ToString() == "New...")
            {
                MessageBox.Show("Select a group to rename");
                return;
            }
            if (cboGroups.SelectedItem.ToString() == "New..." && txtGroupName.Text == "New Group Name...")
            {
                MessageBox.Show("You must name the group...");
                return;
            }
            string grpName = (cboGroups.SelectedItem.ToString() == "New...") ? txtGroupName.Text : cboGroups.SelectedItem.ToString();
            foreach (Group grp in layout.Groups)
            {
                if (grp.Name == grpName)
                {
                    grp.Name = txtGroupName.Text.Replace(":", "|");   
                }
            }
            cboGroups.Items.Clear();
            cboGroups.Items.Add("New...");
            foreach (Group grp in layout.Groups)
            {
                cboGroups.Items.Add(grp.Name);
            }
            cboGroups.SelectedItem = txtGroupName.Text.Replace(":", "|");
            txtGroupName.Text = "New Group Name...";
        }

        private void allItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allItemsToolStripMenuItem.Checked = true;
            crateItemsToolStripMenuItem.Checked = false;
            dg.DataSource = layout.HouseItems;
        }

        private void crateItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allItemsToolStripMenuItem.Checked = false;
            crateItemsToolStripMenuItem.Checked = true;
            dg.DataSource = layout.CrateItems;
        }

        private void dg_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            allItemsToolStripMenuItem.Text = "&All Items - " + layout.HouseItems.Rows.Count.ToString("#,###");
            crateItemsToolStripMenuItem.Text = "&Crate Items - " + layout.CrateItems.Count.ToString("#,###");
        }

        private void dg_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            allItemsToolStripMenuItem.Text = "&All Items - " + layout.HouseItems.Rows.Count.ToString("#,###");
            crateItemsToolStripMenuItem.Text = "&Crate Items - " + layout.CrateItems.Count.ToString("#,###");
        }

        private void dg_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            allItemsToolStripMenuItem.Text = "&All Items - " + layout.HouseItems.Rows.Count.ToString("#,###");
            crateItemsToolStripMenuItem.Text = "&Crate Items - " + layout.CrateItems.Count.ToString("#,###");
        }

        private void dg_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            crateItemsToolStripMenuItem.Text = "&Crate Items - " + layout.CrateItems.Count.ToString("#,###");
        }

        private void btnGrpImport_Click(object sender, EventArgs e)
        {
            if (od.ShowDialog(this) == DialogResult.Cancel) return;
            bool ClearGroups = false;
            if (MessageBox.Show("Clear Current Groups", "Clear Current Groups?", MessageBoxButtons.YesNo) == DialogResult.Yes) ClearGroups = true;
            layout.ImportGroups(od.FileName, ClearGroups);
            cboGroups.Items.Clear();
            cboGroups.Items.Add("New...");
            foreach (Group grp in layout.Groups)
            {
                cboGroups.Items.Add(grp.Name);
            }
        }

        private void clearSortingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            layout.HouseItems.DefaultView.Sort = String.Empty;
            layout.CrateItems.Sort = String.Empty;
        }

        private void importNotesFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (od.ShowDialog(this) == DialogResult.Cancel) return;
            layout.ImportNotes(od.FileName);
        }

        private void mergeAnotherLayoutIntoCurrentFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (od.ShowDialog(this) == DialogResult.Cancel) return;
            layout.MergeFile(od.FileName);
        }

        private void btnGroupRotate_Click(object sender, EventArgs e)
        {
            Placement.RotateAxis ra = Placement.RotateAxis.z;
            if (rdo_Pitch.Checked) ra = Placement.RotateAxis.x;
            if (rdo_Roll.Checked) ra = Placement.RotateAxis.y;
            Placement.HouseItem[] Items = SelectedGridToItems();
            Placement.Vector3D CtrPt = new Placement.Vector3D(double.Parse(txt_rg_X.Text), double.Parse(txt_rg_Y.Text), double.Parse(txt_rg_Z.Text));
            double rotation = double.Parse(txtRotation.Text);
            bool RotateAroundPoint = (rdoCenter.Checked) ? false : true;
            Items = Placement.RotateGroup(Items, rotation, ra, CtrPt, RotateAroundPoint);
            layout.ItemstoDB(Items);
            if (Chart.Visible) Chart.Redraw();
        }

        private void btnMirror_Click(object sender, EventArgs e)
        {
            if (cboMirrorPlane.SelectedIndex == 0 || cboMirrorPlane.SelectedIndex == 3 || cboMirrorPlane.SelectedIndex == 6)
            {
                MessageBox.Show("Please select a mirror direction");
                return;
            }
            decimal PlaneThickness = Decimal.Parse(txtPlaneThick.Text);
            Placement.HouseItem[] Items = SelectedGridToItems();
            List<Placement.HouseItem> MissingCrate = new List<Placement.HouseItem>();
            decimal anchorpoint = 0;
            bool anchorset = false, rotate = chkMirrorRotate.Checked;
            decimal modifier = 1;
            // Find the anchor point that will be the "Mirror" plane.
            foreach (Placement.HouseItem Item in Items)
            {
                switch (cboMirrorPlane.SelectedIndex)
                {
                    case 1: //- Mirror Items Upwards
                        if (anchorset && anchorpoint < Item.z) anchorpoint = Item.z;
                        if (!anchorset) { anchorpoint = Item.z; anchorset = true; }
                        break;
                    case 2: //- Mirror Items Downwards
                        if (anchorset && anchorpoint > Item.z) anchorpoint = Item.z;
                        if (!anchorset) { anchorpoint = Item.z; anchorset = true; }
                        modifier = -1;
                        break;
                    case 4: //- Mirror Items to East
                        if (anchorset && anchorpoint > Item.x) anchorpoint = Item.x;
                        if (!anchorset) { anchorpoint = Item.x; anchorset = true; }
                        modifier = -1;
                        break;
                    case 5: //- Mirror Items to West
                        if (anchorset && anchorpoint < Item.x) anchorpoint = Item.x;
                        if (!anchorset) { anchorpoint = Item.x; anchorset = true; }
                        break;
                    case 7: //- Mirror Items North
                        if (anchorset && anchorpoint > Item.y) anchorpoint = Item.y;
                        if (!anchorset) { anchorpoint = Item.y; anchorset = true; }
                        modifier = -1;
                        break;
                    case 8: //- Mirror Items South
                        if (anchorset && anchorpoint < Item.y) anchorpoint = Item.y;
                        if (!anchorset) { anchorpoint = Item.y; anchorset = true; }
                        break;
                }
            }
            // Mirror the items on the anchor
            for (int ItemNbr = 0; ItemNbr < Items.Length; ItemNbr++)
            {
                // Kick the item out of the crate if it's in crate.
                if (Items[ItemNbr].InCrate) Items[ItemNbr].InCrate = false;
                bool UseExistingRow = false;
                DataRow DR = null;
                if (chkMirrorCrate.Checked && layout.FindCrateItem(Items[ItemNbr].ItemID) != null)
                { // Use Existing Item
                    DR = layout.FindCrateItem(Items[ItemNbr].ItemID);
                    UseExistingRow = true;
                }
                else 
                { // Clone the item
                    MissingCrate.Add(Items[ItemNbr]);
                    DR = layout.HouseItems.NewRow(); 
                }
                
                DR["InCrate"] = Items[ItemNbr].InCrate;
                DR["ItemID"] = Items[ItemNbr].ItemID;
                DR["ItemName"] = Items[ItemNbr].ItemName;
                DR["Pitch"] = Items[ItemNbr].Pitch;
                DR["Roll"] = Items[ItemNbr].Roll;
                DR["Rotation"] = Items[ItemNbr].Rotation;
                DR["Scale"] = Items[ItemNbr].Scale;
                DR["x"] = Items[ItemNbr].x;
                DR["y"] = Items[ItemNbr].y;
                DR["z"] = Items[ItemNbr].z;
                
                switch (cboMirrorPlane.SelectedIndex)
                {
                    case 1: //- Mirror Items Upwards // X/Y remains
                    case 2: //- Mirror Items Downwards // X/Y remains
                        DR["z"] = Items[ItemNbr].z + 2 * (Math.Abs(Items[ItemNbr].z - anchorpoint) + PlaneThickness) * modifier;
                        if (rotate) DR["Rotation"] = Items[ItemNbr].Rotation - 180;
                        if (rotate) DR["Pitch"] = Items[ItemNbr].Pitch - 180;
                        if (rotate && Items[ItemNbr].Rotation == 0) DR["Rotation"] = 180;
                        break;
                    case 4: //- Mirror Items to East // Z/Y remains
                    case 5: //- Mirror Items to West // Z/Y remains
                        DR["x"] = Items[ItemNbr].x + 2 * (Math.Abs(Items[ItemNbr].x - anchorpoint) + PlaneThickness) * modifier;
                        if (rotate) DR["Rotation"] = 360 - Items[ItemNbr].Rotation;
                        if (rotate && Items[ItemNbr].Rotation == 0) DR["Rotation"] = 180;
                        break;
                    case 7: //- Mirror Items North // X/Z remains
                    case 8: //- Mirror Items South // X/Z remains
                        DR["y"] = Items[ItemNbr].y + 2 * (Math.Abs(Items[ItemNbr].y - anchorpoint) + PlaneThickness) * modifier;
                        if (rotate) DR["Rotation"] = 180 - Items[ItemNbr].Rotation;
                        if (rotate && Items[ItemNbr].Rotation == 0) DR["Rotation"] = 180;
                        break;
                }
                
            mirrorPreAdd:
                if (!UseExistingRow)
                {
                    DR["DatabaseID"] = ClonedHouseItemDBId;
                    ClonedHouseItemDBId--;
                    try
                    {
                        layout.HouseItems.Rows.Add(DR);
                    }
                    catch
                    {
                        goto mirrorPreAdd;
                    }
                }
                else { DR["InCrate"] = false; }
            }
            if (chkMirrorCrate.Checked && MissingCrate.Count > 0)
            {
                DialogResult pr_missing = MessageBox.Show(this, "You had checked that you wanted to use items from the crate vs cloning. " + MissingCrate.Count.ToString() + " item(s) were not found in the crate.\r\n\r\nWould you like to see these items?", "Missing Items", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == pr_missing)
                {
                    LayoutFile LayoutMissing = new LayoutFile();
                    LayoutMissing.FileName = layout.FileName;
                    LayoutMissing.HouseItems.Clear();
                    LayoutMissing.ItemstoDB(MissingCrate.ToArray());
                    LayoutMissing.SaveFile(layout.FileName +
                        "_mirrored_items_missing_" +
                        DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") +
                        DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00") + DateTime.Now.Second.ToString("00"));
                    LayoutMissing.ManifestGenerate(false, true);
                    string HTMLOutPath = LayoutMissing.FileName + ".html";
                    pr_missing = MessageBox.Show(this, "An HTML manifest generated of the missing items. This will be opened after this dialog.\r\n\r\nLayout editor has also created a layout file of just what couldn't be replicated. Do you want to keep this new layout file for reference?", "Missing Items", MessageBoxButtons.YesNo);
                    if (pr_missing == DialogResult.No) File.Delete(LayoutMissing.FileName);
                    System.Diagnostics.Process.Start(HTMLOutPath);
                }
            }
            if (Chart.Visible) Chart.Redraw();
        }

        private void visualizeLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Chart.IsDisposed) Chart = new frmChart();
            Chart.Text = "Viewing " + layout.FileName;
            Chart.FirstBuild(layout.HouseItems);
            Chart.Show();
        }

        private void dg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(Chart.Visible) Chart.Redraw();
        }

        private void chkRadiusSync_CheckedChanged(object sender, EventArgs e)
        {
            txtRadiusRight.Enabled = !chkRadiusSync.Checked;
        }

        private void cboCirclePlane_SelectedIndexChanged(object sender, EventArgs e)
        {
            string xRad = "X Radius"
                    , yRad = "Y Radius"
                    , zRad = "Z Radius";
            switch (cboCirclePlane.SelectedIndex){
                case 0: // Z Plane
                    lblRadLeft.Text = xRad;
                    lblRadRight.Text = yRad;
                    break;
                case 1: // X Plane
                    lblRadLeft.Text = zRad;
                    lblRadRight.Text = yRad;
                    break;
                case 2: // Y Plane
                    lblRadLeft.Text = zRad;
                    lblRadRight.Text = xRad;
                    break;
            }
        }
    }
}
