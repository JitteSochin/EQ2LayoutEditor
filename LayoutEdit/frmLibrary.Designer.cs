namespace LayoutEdit
{
    partial class frmLibrary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpLibrary = new System.Windows.Forms.TabPage();
            this.splt_library = new System.Windows.Forms.SplitContainer();
            this.lvLayouts = new System.Windows.Forms.ListView();
            this.hdrFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrZone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lvItems = new System.Windows.Forms.ListView();
            this.hdrItmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrItmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrItemCt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrCrateCt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpFinder = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFindItem = new System.Windows.Forms.TextBox();
            this.dgFinder = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatabaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waypoint = new System.Windows.Forms.DataGridViewLinkColumn();
            this.InCrate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HouseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpOptions = new System.Windows.Forms.TabPage();
            this.btnRemoveDir = new System.Windows.Forms.Button();
            this.btnAddDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDirectories = new System.Windows.Forms.ListBox();
            this.FolderFinder = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tbpLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_library)).BeginInit();
            this.splt_library.Panel1.SuspendLayout();
            this.splt_library.Panel2.SuspendLayout();
            this.splt_library.SuspendLayout();
            this.tbpFinder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFinder)).BeginInit();
            this.tbpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbpLibrary);
            this.tabControl1.Controls.Add(this.tbpFinder);
            this.tabControl1.Controls.Add(this.tbpOptions);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(889, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpLibrary
            // 
            this.tbpLibrary.BackColor = System.Drawing.SystemColors.Control;
            this.tbpLibrary.Controls.Add(this.splt_library);
            this.tbpLibrary.Location = new System.Drawing.Point(4, 22);
            this.tbpLibrary.Name = "tbpLibrary";
            this.tbpLibrary.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLibrary.Size = new System.Drawing.Size(881, 381);
            this.tbpLibrary.TabIndex = 0;
            this.tbpLibrary.Text = "Library Viewer";
            // 
            // splt_library
            // 
            this.splt_library.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splt_library.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splt_library.Location = new System.Drawing.Point(6, 6);
            this.splt_library.Name = "splt_library";
            // 
            // splt_library.Panel1
            // 
            this.splt_library.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splt_library.Panel1.Controls.Add(this.lvLayouts);
            // 
            // splt_library.Panel2
            // 
            this.splt_library.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splt_library.Panel2.Controls.Add(this.label2);
            this.splt_library.Panel2.Controls.Add(this.txtFind);
            this.splt_library.Panel2.Controls.Add(this.lvItems);
            this.splt_library.Size = new System.Drawing.Size(869, 369);
            this.splt_library.SplitterDistance = 424;
            this.splt_library.TabIndex = 0;
            // 
            // lvLayouts
            // 
            this.lvLayouts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLayouts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrFile,
            this.hdrItems,
            this.hdrID,
            this.hdrZone});
            this.lvLayouts.FullRowSelect = true;
            this.lvLayouts.HideSelection = false;
            this.lvLayouts.Location = new System.Drawing.Point(3, 3);
            this.lvLayouts.Name = "lvLayouts";
            this.lvLayouts.Size = new System.Drawing.Size(418, 363);
            this.lvLayouts.TabIndex = 0;
            this.lvLayouts.UseCompatibleStateImageBehavior = false;
            this.lvLayouts.View = System.Windows.Forms.View.Details;
            this.lvLayouts.SelectedIndexChanged += new System.EventHandler(this.lvLayouts_SelectedIndexChanged);
            // 
            // hdrFile
            // 
            this.hdrFile.Text = "Filename";
            this.hdrFile.Width = 131;
            // 
            // hdrItems
            // 
            this.hdrItems.Text = "Item Count";
            this.hdrItems.Width = 69;
            // 
            // hdrID
            // 
            this.hdrID.Text = "House ID";
            this.hdrID.Width = 95;
            // 
            // hdrZone
            // 
            this.hdrZone.Text = "Zone Name";
            this.hdrZone.Width = 104;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Find Item";
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.Location = new System.Drawing.Point(235, 7);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(202, 20);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // lvItems
            // 
            this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrItmID,
            this.hdrItmName,
            this.hdrItemCt,
            this.hdrCrateCt});
            this.lvItems.FullRowSelect = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(3, 33);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(435, 333);
            this.lvItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvItems.TabIndex = 0;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            this.lvItems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvItems_ColumnClick);
            // 
            // hdrItmID
            // 
            this.hdrItmID.Text = "Item ID";
            this.hdrItmID.Width = 72;
            // 
            // hdrItmName
            // 
            this.hdrItmName.Text = "Item Name";
            this.hdrItmName.Width = 174;
            // 
            // hdrItemCt
            // 
            this.hdrItemCt.Text = "Item Count";
            this.hdrItemCt.Width = 75;
            // 
            // hdrCrateCt
            // 
            this.hdrCrateCt.Text = "Crated Ct";
            this.hdrCrateCt.Width = 69;
            // 
            // tbpFinder
            // 
            this.tbpFinder.Controls.Add(this.btnClear);
            this.tbpFinder.Controls.Add(this.btnFind);
            this.tbpFinder.Controls.Add(this.label3);
            this.tbpFinder.Controls.Add(this.txtFindItem);
            this.tbpFinder.Controls.Add(this.dgFinder);
            this.tbpFinder.Location = new System.Drawing.Point(4, 22);
            this.tbpFinder.Name = "tbpFinder";
            this.tbpFinder.Size = new System.Drawing.Size(881, 381);
            this.tbpFinder.TabIndex = 2;
            this.tbpFinder.Text = "Item Finder";
            this.tbpFinder.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(299, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 20);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(228, 20);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(65, 20);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Partial Name";
            // 
            // txtFindItem
            // 
            this.txtFindItem.Location = new System.Drawing.Point(4, 20);
            this.txtFindItem.Name = "txtFindItem";
            this.txtFindItem.Size = new System.Drawing.Size(217, 20);
            this.txtFindItem.TabIndex = 1;
            this.txtFindItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindItem_KeyPress);
            // 
            // dgFinder
            // 
            this.dgFinder.AllowUserToAddRows = false;
            this.dgFinder.AllowUserToDeleteRows = false;
            this.dgFinder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFinder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFinder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.DatabaseID,
            this.ItemName,
            this.Waypoint,
            this.InCrate,
            this.HouseID,
            this.HouseType,
            this.FileName});
            this.dgFinder.Location = new System.Drawing.Point(4, 46);
            this.dgFinder.Name = "dgFinder";
            this.dgFinder.ReadOnly = true;
            this.dgFinder.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dgFinder.Size = new System.Drawing.Size(874, 332);
            this.dgFinder.TabIndex = 0;
            this.dgFinder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFinder_CellContentClick);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // DatabaseID
            // 
            this.DatabaseID.HeaderText = "Database ID";
            this.DatabaseID.Name = "DatabaseID";
            this.DatabaseID.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Waypoint
            // 
            this.Waypoint.HeaderText = "Waypoint";
            this.Waypoint.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Waypoint.LinkColor = System.Drawing.Color.Blue;
            this.Waypoint.Name = "Waypoint";
            this.Waypoint.ReadOnly = true;
            this.Waypoint.TrackVisitedState = false;
            this.Waypoint.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // InCrate
            // 
            this.InCrate.HeaderText = "In Crate";
            this.InCrate.Name = "InCrate";
            this.InCrate.ReadOnly = true;
            this.InCrate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HouseID
            // 
            this.HouseID.HeaderText = "House ID";
            this.HouseID.Name = "HouseID";
            this.HouseID.ReadOnly = true;
            this.HouseID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HouseType
            // 
            this.HouseType.HeaderText = "House Type";
            this.HouseType.Name = "HouseType";
            this.HouseType.ReadOnly = true;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tbpOptions
            // 
            this.tbpOptions.Controls.Add(this.btnRemoveDir);
            this.tbpOptions.Controls.Add(this.btnAddDir);
            this.tbpOptions.Controls.Add(this.label1);
            this.tbpOptions.Controls.Add(this.lstDirectories);
            this.tbpOptions.Location = new System.Drawing.Point(4, 22);
            this.tbpOptions.Name = "tbpOptions";
            this.tbpOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOptions.Size = new System.Drawing.Size(881, 381);
            this.tbpOptions.TabIndex = 1;
            this.tbpOptions.Text = "Options";
            this.tbpOptions.UseVisualStyleBackColor = true;
            // 
            // btnRemoveDir
            // 
            this.btnRemoveDir.Location = new System.Drawing.Point(204, 120);
            this.btnRemoveDir.Name = "btnRemoveDir";
            this.btnRemoveDir.Size = new System.Drawing.Size(58, 23);
            this.btnRemoveDir.TabIndex = 3;
            this.btnRemoveDir.Text = "Remove";
            this.btnRemoveDir.UseVisualStyleBackColor = true;
            this.btnRemoveDir.Click += new System.EventHandler(this.btnRemoveDir_Click);
            // 
            // btnAddDir
            // 
            this.btnAddDir.Location = new System.Drawing.Point(268, 120);
            this.btnAddDir.Name = "btnAddDir";
            this.btnAddDir.Size = new System.Drawing.Size(58, 23);
            this.btnAddDir.TabIndex = 2;
            this.btnAddDir.Text = "Add";
            this.btnAddDir.UseVisualStyleBackColor = true;
            this.btnAddDir.Click += new System.EventHandler(this.btnAddDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EQ2 Layout Directories";
            // 
            // lstDirectories
            // 
            this.lstDirectories.FormattingEnabled = true;
            this.lstDirectories.Location = new System.Drawing.Point(6, 19);
            this.lstDirectories.Name = "lstDirectories";
            this.lstDirectories.Size = new System.Drawing.Size(320, 95);
            this.lstDirectories.Sorted = true;
            this.lstDirectories.TabIndex = 0;
            // 
            // frmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 431);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmLibrary";
            this.Text = "Layout Library";
            this.Load += new System.EventHandler(this.frmLibrary_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpLibrary.ResumeLayout(false);
            this.splt_library.Panel1.ResumeLayout(false);
            this.splt_library.Panel2.ResumeLayout(false);
            this.splt_library.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_library)).EndInit();
            this.splt_library.ResumeLayout(false);
            this.tbpFinder.ResumeLayout(false);
            this.tbpFinder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFinder)).EndInit();
            this.tbpOptions.ResumeLayout(false);
            this.tbpOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpLibrary;
        private System.Windows.Forms.TabPage tbpOptions;
        private System.Windows.Forms.Button btnRemoveDir;
        private System.Windows.Forms.Button btnAddDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDirectories;
        private System.Windows.Forms.FolderBrowserDialog FolderFinder;
        private System.Windows.Forms.SplitContainer splt_library;
        private System.Windows.Forms.ListView lvLayouts;
        private System.Windows.Forms.ColumnHeader hdrFile;
        private System.Windows.Forms.ColumnHeader hdrItems;
        private System.Windows.Forms.ColumnHeader hdrID;
        private System.Windows.Forms.ColumnHeader hdrZone;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader hdrItmID;
        private System.Windows.Forms.ColumnHeader hdrItmName;
        private System.Windows.Forms.ColumnHeader hdrItemCt;
        private System.Windows.Forms.ColumnHeader hdrCrateCt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TabPage tbpFinder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFindItem;
        private System.Windows.Forms.DataGridView dgFinder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatabaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewLinkColumn Waypoint;
        private System.Windows.Forms.DataGridViewCheckBoxColumn InCrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
    }
}