using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LayoutEdit
{
    public partial class frmDiff : Form
    {
        // Return File
        public string CurrentFile = string.Empty;
        // Entry point to preload currently loaded file
        public string SourceFile
        {
            set
            {
                txtSource.Text = value;
                source.FileName = value;
                lblSourceInfo.Text = String.Format("Source File: House Type: {0}, House ID {1}, Items: {2}", source.HouseType, source.HouseID, source.HouseItems.Rows.Count.ToString("#,###"));
            }
        }
        // Source File Wrapper
        private LayoutFile source = new LayoutFile();
        // Compare File Wrapper
        private LayoutFile compare = new LayoutFile();
        // Destination file wrapper
        private LayoutFile destination = new LayoutFile();
        public frmDiff()
        {
            InitializeComponent();
        }

        private void btnLoadSource_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtSource.Text)) OD.FileName = txtSource.Text;
            DialogResult dr = OD.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            source.FileName = OD.FileName;
            txtSource.Text = OD.FileName;
            lblSourceInfo.Text = String.Format("Original File: House Type: {0}, House ID {1}, Items: {2}", source.HouseType, source.HouseID, source.HouseItems.Rows.Count.ToString("#,###"));
            if (compare.FileLoaded) Compare();
        }

        private void btnLoadCompare_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtCompare.Text)) OD.FileName = txtCompare.Text;
            DialogResult dr = OD.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            compare.FileName = OD.FileName;
            txtCompare.Text = OD.FileName;
            lblCompareInfo.Text = String.Format("New File: House Type: {0}, House ID {1}, Items: {2}", compare.HouseType, compare.HouseID, compare.HouseItems.Rows.Count.ToString("#,###"));
            if (source.FileLoaded) Compare();
        }
        private bool Compare()
        {
            DialogResult dr;
            string CompareStamp = DateTime.Now.ToString("dd.MM.yy HHmm");
            if (source.HouseType != compare.HouseType)
            {
                dr = MessageBox.Show("House types do not match. Continue with compare?", "House Mismatch", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No) return false;
            }
            if (source.FileName == compare.FileName)
            {
                MessageBox.Show("Original and New files are the same file");
                return false;
            }
            Group NotInSource = new Group();
            NotInSource.Name = "Not In Original (" + CompareStamp + ")";
            Group NotInCompare = new Group();
            NotInCompare.Name = "Not In New (" + CompareStamp + ")";
            Group Changed = new Group();
            Changed.Name = "Changed (" + CompareStamp + ")";

            // Find Differences
            var cmpLinq =
                from nrow in source.HouseItems.AsEnumerable()
                join orow in compare.HouseItems.AsEnumerable()
                on nrow.Field<Int32>("DatabaseID") equals orow.Field<Int32>("DatabaseID")
                where !(nrow.Field<decimal>("x") == orow.Field<decimal>("x")
                    && nrow.Field<decimal>("y") == orow.Field<decimal>("y")
                    && nrow.Field<decimal>("z") == orow.Field<decimal>("z")
                    && nrow.Field<decimal>("Rotation") == orow.Field<decimal>("Rotation")
                    && nrow.Field<decimal>("Pitch") == orow.Field<decimal>("Pitch")
                    && nrow.Field<decimal>("Roll") == orow.Field<decimal>("Roll")
                    && nrow.Field<decimal>("Scale") == orow.Field<decimal>("Scale")
                    && nrow.Field<bool>("InCrate") == orow.Field<bool>("InCrate"))
                select nrow.Field<Int32>("DatabaseId");
            foreach (Int32 id in cmpLinq.ToArray())
            {
                Changed.AddItem(id);
            }
            var srcItems = from row in source.HouseItems.AsEnumerable()
                           select row.Field<Int32>("DatabaseId");
            var cmpItems = from row in compare.HouseItems.AsEnumerable()
                           select row.Field<Int32>("DatabaseId");
            // Find missing from source
            foreach (Int32 item in cmpItems)
            {
                if (!srcItems.Contains(item)) NotInSource.AddItem(item); 
            }
            // Find missing from destination
            foreach (Int32 item in srcItems)
            {
                if (!cmpItems.Contains(item)) NotInCompare.AddItem(item);
            }
            // Initiate the file with the properties of the compare file
            destination.FileName = compare.FileName;
            destination.HouseItems.Clear();
            List<Int32> addedItems = new List<Int32>();
            foreach (DataRow row in compare.HouseItems.Rows)
            {
                bool rowadded = false;
                Int32 DBID = Int32.Parse(row["DatabaseId"].ToString());
                if (chkKeepCompare.Checked)
                {
                    destination.HouseItems.Rows.Add(row.ItemArray);
                    rowadded = true;
                }
                if (chkDiff.Checked && Changed.GetItems().Contains(DBID) && !rowadded)
                {
                    destination.HouseItems.Rows.Add(row.ItemArray);
                    rowadded = true;
                }
                if (chkKeepCompareNew.Checked && NotInSource.GetItems().Contains(DBID) && !rowadded)
                {
                    destination.HouseItems.Rows.Add(row.ItemArray);
                    rowadded = true;
                }
                if (rowadded) addedItems.Add(DBID);
            }
            foreach (DataRow row in source.HouseItems.Rows)
            {
                Int32 DBID = Int32.Parse(row["DatabaseId"].ToString());
                if (addedItems.Contains(DBID)) continue;
                bool rowadded = false;
                if (chkKeepSrc.Checked)
                {
                    destination.HouseItems.Rows.Add(row.ItemArray);
                    rowadded = true;
                }
                if (chkKeepSrcNew.Checked && NotInCompare.GetItems().Contains(DBID) && !rowadded)
                {
                    destination.HouseItems.Rows.Add(row.ItemArray);
                }
                if (rowadded) addedItems.Add(DBID);
            }
            if (chkDiff.Checked && Changed.GetItems().Count > 0) destination.Groups.Add(Changed);
            if ((chkKeepCompareNew.Checked || chkKeepCompare.Checked) && NotInSource.GetItems().Count > 0) destination.Groups.Add(NotInSource);
            if ((chkKeepSrcNew.Checked || chkKeepSrc.Checked) && Changed.GetItems().Count > 0) destination.Groups.Add(NotInCompare);
            chkDiff.Text = String.Format("Keep items that changed [{0}]", Changed.GetItems().Count.ToString("#,##0"));
            chkKeepCompareNew.Text = String.Format("Keep items that are in the new file but not in the original [{0}]", NotInSource.GetItems().Count.ToString("#,##0"));
            chkKeepSrcNew.Text = String.Format("Keep items that are in the original but not the new file [{0}]", NotInCompare.GetItems().Count.ToString("#,##0"));
            lblFinalCount.Text = String.Format("Final item count: {0}", destination.HouseItems.Rows.Count.ToString("#,##0"));
            return true;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            Compare();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = SD.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            if (!Compare()) return;
            destination.SaveFile(SD.FileName);
            CurrentFile = SD.FileName;
            this.DialogResult = DialogResult.OK;
        }

        private void frmDiff_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
