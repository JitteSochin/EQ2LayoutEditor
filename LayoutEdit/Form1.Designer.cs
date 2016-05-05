namespace LayoutEdit
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.od = new System.Windows.Forms.OpenFileDialog();
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChangesOnlyAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.importGroupFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importNotesFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeAnotherLayoutIntoCurrentFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crateItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearSortingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dg = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClearSearch = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCircleSpiral = new System.Windows.Forms.TabPage();
            this.cboCirclePlane = new System.Windows.Forms.ComboBox();
            this.chkPointTops = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRevolutions = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndZ = new System.Windows.Forms.TextBox();
            this.rdo_From_Ground = new System.Windows.Forms.RadioButton();
            this.rdo_From_Center = new System.Windows.Forms.RadioButton();
            this.chkSpiral = new System.Windows.Forms.CheckBox();
            this.chk90Offset = new System.Windows.Forms.CheckBox();
            this.chkRotate = new System.Windows.Forms.CheckBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkReverse = new System.Windows.Forms.CheckBox();
            this.lbl_Fill = new System.Windows.Forms.Label();
            this.lbl_off = new System.Windows.Forms.Label();
            this.txtCirCentZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCirCentY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCirCentX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTile = new System.Windows.Forms.TabPage();
            this.chkSpaceLink = new System.Windows.Forms.CheckBox();
            this.txtUnitsZ = new System.Windows.Forms.TextBox();
            this.txtSpaceZ = new System.Windows.Forms.TextBox();
            this.txtSpaceY = new System.Windows.Forms.TextBox();
            this.txtSpaceX = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.chkZeroRotation = new System.Windows.Forms.CheckBox();
            this.chkIgnoreScaling = new System.Windows.Forms.CheckBox();
            this.btnTile = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtScaling = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUnitsX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUnitsY = new System.Windows.Forms.TextBox();
            this.txtStartZ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStartY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStartX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabMove = new System.Windows.Forms.TabPage();
            this.chkMassCrate = new System.Windows.Forms.CheckBox();
            this.txtMassScaling = new System.Windows.Forms.TextBox();
            this.btnScaling = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMoveAmount = new System.Windows.Forms.TextBox();
            this.btnInCrate = new System.Windows.Forms.Button();
            this.btnRotateReset = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnPitch = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnManifest = new System.Windows.Forms.Button();
            this.btnDeleteCrate = new System.Windows.Forms.Button();
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.btnRenameGroup = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilterOutGrp = new System.Windows.Forms.Button();
            this.btnFilterToGroup = new System.Windows.Forms.Button();
            this.btnGroupRemove = new System.Windows.Forms.Button();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.btnGroupItemRemove = new System.Windows.Forms.Button();
            this.btnGroupItemAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cboGroups = new System.Windows.Forms.ComboBox();
            this.tabRotate = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_rg_Z = new System.Windows.Forms.TextBox();
            this.txt_rg_Y = new System.Windows.Forms.TextBox();
            this.txt_rg_X = new System.Windows.Forms.TextBox();
            this.rdoPoint = new System.Windows.Forms.RadioButton();
            this.rdoCenter = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_Rotate = new System.Windows.Forms.RadioButton();
            this.rdo_Pitch = new System.Windows.Forms.RadioButton();
            this.rdo_Roll = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGroupRotate = new System.Windows.Forms.Button();
            this.txtRotation = new System.Windows.Forms.TextBox();
            this.mnuShopping = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShopCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShopHTML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShopBoth = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMirror = new System.Windows.Forms.TabPage();
            this.cboMirrorPlane = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnMirror = new System.Windows.Forms.Button();
            this.chkMirrorRotate = new System.Windows.Forms.CheckBox();
            this.mnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCircleSpiral.SuspendLayout();
            this.tabTile.SuspendLayout();
            this.tabMove.SuspendLayout();
            this.tabOther.SuspendLayout();
            this.tabGroups.SuspendLayout();
            this.tabRotate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mnuShopping.SuspendLayout();
            this.tabMirror.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.viewToolStripMenuItem});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(841, 24);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAs,
            this.saveChangesOnlyAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.importGroupFromFileToolStripMenuItem,
            this.importNotesFromFileToolStripMenuItem,
            this.mergeAnotherLayoutIntoCurrentFileToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(272, 22);
            this.mnuOpen.Text = "&Open Layout File";
            this.mnuOpen.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(272, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(272, 22);
            this.mnuSaveAs.Text = "Save &As";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // saveChangesOnlyAsToolStripMenuItem
            // 
            this.saveChangesOnlyAsToolStripMenuItem.Name = "saveChangesOnlyAsToolStripMenuItem";
            this.saveChangesOnlyAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveChangesOnlyAsToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.saveChangesOnlyAsToolStripMenuItem.Text = "Save &Changes Only As";
            this.saveChangesOnlyAsToolStripMenuItem.Click += new System.EventHandler(this.saveChangesOnlyAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(269, 6);
            // 
            // importGroupFromFileToolStripMenuItem
            // 
            this.importGroupFromFileToolStripMenuItem.Name = "importGroupFromFileToolStripMenuItem";
            this.importGroupFromFileToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.importGroupFromFileToolStripMenuItem.Text = "Import &Group From File";
            this.importGroupFromFileToolStripMenuItem.Click += new System.EventHandler(this.btnGrpImport_Click);
            // 
            // importNotesFromFileToolStripMenuItem
            // 
            this.importNotesFromFileToolStripMenuItem.Name = "importNotesFromFileToolStripMenuItem";
            this.importNotesFromFileToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.importNotesFromFileToolStripMenuItem.Text = "Import &Notes from File";
            this.importNotesFromFileToolStripMenuItem.Click += new System.EventHandler(this.importNotesFromFileToolStripMenuItem_Click);
            // 
            // mergeAnotherLayoutIntoCurrentFileToolStripMenuItem
            // 
            this.mergeAnotherLayoutIntoCurrentFileToolStripMenuItem.Name = "mergeAnotherLayoutIntoCurrentFileToolStripMenuItem";
            this.mergeAnotherLayoutIntoCurrentFileToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.mergeAnotherLayoutIntoCurrentFileToolStripMenuItem.Text = "&Merge another layout into current file";
            this.mergeAnotherLayoutIntoCurrentFileToolStripMenuItem.Click += new System.EventHandler(this.mergeAnotherLayoutIntoCurrentFileToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allItemsToolStripMenuItem,
            this.crateItemsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.clearSortingToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // allItemsToolStripMenuItem
            // 
            this.allItemsToolStripMenuItem.Checked = true;
            this.allItemsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allItemsToolStripMenuItem.Name = "allItemsToolStripMenuItem";
            this.allItemsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.allItemsToolStripMenuItem.Text = "&All Items";
            this.allItemsToolStripMenuItem.Click += new System.EventHandler(this.allItemsToolStripMenuItem_Click);
            // 
            // crateItemsToolStripMenuItem
            // 
            this.crateItemsToolStripMenuItem.Name = "crateItemsToolStripMenuItem";
            this.crateItemsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.crateItemsToolStripMenuItem.Text = "&Crate Items";
            this.crateItemsToolStripMenuItem.Click += new System.EventHandler(this.crateItemsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 6);
            // 
            // clearSortingToolStripMenuItem
            // 
            this.clearSortingToolStripMenuItem.Name = "clearSortingToolStripMenuItem";
            this.clearSortingToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.clearSortingToolStripMenuItem.Text = "Clear Sorting";
            this.clearSortingToolStripMenuItem.Click += new System.EventHandler(this.clearSortingToolStripMenuItem_Click);
            // 
            // dg
            // 
            this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(13, 28);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(557, 450);
            this.dg.TabIndex = 1;
            this.dg.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellValueChanged);
            this.dg.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dg_RowsAdded);
            this.dg.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dg_RowsRemoved);
            this.dg.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dg_UserAddedRow);
            this.dg.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dg_UserAddedRow);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(597, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // lblClearSearch
            // 
            this.lblClearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClearSearch.AutoSize = true;
            this.lblClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearSearch.Location = new System.Drawing.Point(813, 28);
            this.lblClearSearch.Name = "lblClearSearch";
            this.lblClearSearch.Size = new System.Drawing.Size(15, 13);
            this.lblClearSearch.TabIndex = 4;
            this.lblClearSearch.Text = "X";
            this.lblClearSearch.Click += new System.EventHandler(this.lblClearSearch_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabCircleSpiral);
            this.tabControl1.Controls.Add(this.tabTile);
            this.tabControl1.Controls.Add(this.tabMove);
            this.tabControl1.Controls.Add(this.tabGroups);
            this.tabControl1.Controls.Add(this.tabRotate);
            this.tabControl1.Controls.Add(this.tabMirror);
            this.tabControl1.Controls.Add(this.tabOther);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(597, 70);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(231, 389);
            this.tabControl1.TabIndex = 5;
            // 
            // tabCircleSpiral
            // 
            this.tabCircleSpiral.Controls.Add(this.cboCirclePlane);
            this.tabCircleSpiral.Controls.Add(this.chkPointTops);
            this.tabCircleSpiral.Controls.Add(this.label7);
            this.tabCircleSpiral.Controls.Add(this.txtRevolutions);
            this.tabCircleSpiral.Controls.Add(this.label6);
            this.tabCircleSpiral.Controls.Add(this.txtEndZ);
            this.tabCircleSpiral.Controls.Add(this.rdo_From_Ground);
            this.tabCircleSpiral.Controls.Add(this.rdo_From_Center);
            this.tabCircleSpiral.Controls.Add(this.chkSpiral);
            this.tabCircleSpiral.Controls.Add(this.chk90Offset);
            this.tabCircleSpiral.Controls.Add(this.chkRotate);
            this.tabCircleSpiral.Controls.Add(this.btnCircle);
            this.tabCircleSpiral.Controls.Add(this.txtRadius);
            this.tabCircleSpiral.Controls.Add(this.label5);
            this.tabCircleSpiral.Controls.Add(this.chkReverse);
            this.tabCircleSpiral.Controls.Add(this.lbl_Fill);
            this.tabCircleSpiral.Controls.Add(this.lbl_off);
            this.tabCircleSpiral.Controls.Add(this.txtCirCentZ);
            this.tabCircleSpiral.Controls.Add(this.label4);
            this.tabCircleSpiral.Controls.Add(this.txtCirCentY);
            this.tabCircleSpiral.Controls.Add(this.label3);
            this.tabCircleSpiral.Controls.Add(this.txtCirCentX);
            this.tabCircleSpiral.Controls.Add(this.label2);
            this.tabCircleSpiral.Location = new System.Drawing.Point(4, 40);
            this.tabCircleSpiral.Name = "tabCircleSpiral";
            this.tabCircleSpiral.Padding = new System.Windows.Forms.Padding(3);
            this.tabCircleSpiral.Size = new System.Drawing.Size(223, 343);
            this.tabCircleSpiral.TabIndex = 0;
            this.tabCircleSpiral.Text = "Circle / Spiral";
            this.tabCircleSpiral.UseVisualStyleBackColor = true;
            // 
            // cboCirclePlane
            // 
            this.cboCirclePlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCirclePlane.FormattingEnabled = true;
            this.cboCirclePlane.Items.AddRange(new object[] {
            "Z (Draw on Ground)",
            "X (Draw on E/W Wall)",
            "Y (Draw on N/S Wall)"});
            this.cboCirclePlane.Location = new System.Drawing.Point(6, 156);
            this.cboCirclePlane.Name = "cboCirclePlane";
            this.cboCirclePlane.Size = new System.Drawing.Size(204, 21);
            this.cboCirclePlane.TabIndex = 26;
            // 
            // chkPointTops
            // 
            this.chkPointTops.AutoSize = true;
            this.chkPointTops.Location = new System.Drawing.Point(87, 179);
            this.chkPointTops.Name = "chkPointTops";
            this.chkPointTops.Size = new System.Drawing.Size(123, 17);
            this.chkPointTops.TabIndex = 25;
            this.chkPointTops.Text = "Point Tops to Center";
            this.chkPointTops.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Revolutions";
            // 
            // txtRevolutions
            // 
            this.txtRevolutions.Location = new System.Drawing.Point(132, 238);
            this.txtRevolutions.Name = "txtRevolutions";
            this.txtRevolutions.Size = new System.Drawing.Size(55, 20);
            this.txtRevolutions.TabIndex = 23;
            this.txtRevolutions.Text = "0";
            this.txtRevolutions.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ending Z (Sprial)";
            // 
            // txtEndZ
            // 
            this.txtEndZ.Location = new System.Drawing.Point(132, 51);
            this.txtEndZ.Name = "txtEndZ";
            this.txtEndZ.Size = new System.Drawing.Size(55, 20);
            this.txtEndZ.TabIndex = 21;
            this.txtEndZ.Text = "0";
            this.txtEndZ.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // rdo_From_Ground
            // 
            this.rdo_From_Ground.AutoSize = true;
            this.rdo_From_Ground.Location = new System.Drawing.Point(69, 220);
            this.rdo_From_Ground.Name = "rdo_From_Ground";
            this.rdo_From_Ground.Size = new System.Drawing.Size(104, 17);
            this.rdo_From_Ground.TabIndex = 19;
            this.rdo_From_Ground.Text = "From the Ground";
            this.rdo_From_Ground.UseVisualStyleBackColor = true;
            // 
            // rdo_From_Center
            // 
            this.rdo_From_Center.AutoSize = true;
            this.rdo_From_Center.Checked = true;
            this.rdo_From_Center.Location = new System.Drawing.Point(69, 205);
            this.rdo_From_Center.Name = "rdo_From_Center";
            this.rdo_From_Center.Size = new System.Drawing.Size(82, 17);
            this.rdo_From_Center.TabIndex = 18;
            this.rdo_From_Center.TabStop = true;
            this.rdo_From_Center.Text = "From Center";
            this.rdo_From_Center.UseVisualStyleBackColor = true;
            // 
            // chkSpiral
            // 
            this.chkSpiral.AutoSize = true;
            this.chkSpiral.Location = new System.Drawing.Point(10, 205);
            this.chkSpiral.Name = "chkSpiral";
            this.chkSpiral.Size = new System.Drawing.Size(52, 17);
            this.chkSpiral.TabIndex = 17;
            this.chkSpiral.Text = "Spiral";
            this.chkSpiral.UseVisualStyleBackColor = true;
            // 
            // chk90Offset
            // 
            this.chk90Offset.AutoSize = true;
            this.chk90Offset.Location = new System.Drawing.Point(31, 116);
            this.chk90Offset.Name = "chk90Offset";
            this.chk90Offset.Size = new System.Drawing.Size(112, 17);
            this.chk90Offset.TabIndex = 15;
            this.chk90Offset.Text = "Offset 90 Degrees";
            this.chk90Offset.UseVisualStyleBackColor = true;
            // 
            // chkRotate
            // 
            this.chkRotate.AutoSize = true;
            this.chkRotate.Checked = true;
            this.chkRotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRotate.Location = new System.Drawing.Point(9, 102);
            this.chkRotate.Name = "chkRotate";
            this.chkRotate.Size = new System.Drawing.Size(124, 17);
            this.chkRotate.TabIndex = 14;
            this.chkRotate.Text = "Point Items to Center";
            this.chkRotate.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(139, 313);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(75, 23);
            this.btnCircle.TabIndex = 13;
            this.btnCircle.Text = "Draw Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.mnuEffectCircle_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(71, 77);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(55, 20);
            this.txtRadius.TabIndex = 12;
            this.txtRadius.Text = "5";
            this.txtRadius.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Radius";
            // 
            // chkReverse
            // 
            this.chkReverse.AutoSize = true;
            this.chkReverse.Checked = true;
            this.chkReverse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReverse.Location = new System.Drawing.Point(9, 135);
            this.chkReverse.Name = "chkReverse";
            this.chkReverse.Size = new System.Drawing.Size(114, 17);
            this.chkReverse.TabIndex = 8;
            this.chkReverse.Text = "Counter Clockwise";
            this.chkReverse.UseVisualStyleBackColor = true;
            // 
            // lbl_Fill
            // 
            this.lbl_Fill.AutoSize = true;
            this.lbl_Fill.Location = new System.Drawing.Point(73, 263);
            this.lbl_Fill.Name = "lbl_Fill";
            this.lbl_Fill.Size = new System.Drawing.Size(60, 13);
            this.lbl_Fill.TabIndex = 7;
            this.lbl_Fill.Text = "Fill: 100.0%";
            // 
            // lbl_off
            // 
            this.lbl_off.AutoSize = true;
            this.lbl_off.Location = new System.Drawing.Point(7, 250);
            this.lbl_off.Name = "lbl_off";
            this.lbl_off.Size = new System.Drawing.Size(66, 26);
            this.lbl_off.TabIndex = 6;
            this.lbl_off.Text = "Start Offset: \r\n0";
            // 
            // txtCirCentZ
            // 
            this.txtCirCentZ.Location = new System.Drawing.Point(132, 24);
            this.txtCirCentZ.Name = "txtCirCentZ";
            this.txtCirCentZ.Size = new System.Drawing.Size(55, 20);
            this.txtCirCentZ.TabIndex = 5;
            this.txtCirCentZ.Text = "0";
            this.txtCirCentZ.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Center Z";
            // 
            // txtCirCentY
            // 
            this.txtCirCentY.Location = new System.Drawing.Point(71, 24);
            this.txtCirCentY.Name = "txtCirCentY";
            this.txtCirCentY.Size = new System.Drawing.Size(55, 20);
            this.txtCirCentY.TabIndex = 3;
            this.txtCirCentY.Text = "0";
            this.txtCirCentY.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Center Y";
            // 
            // txtCirCentX
            // 
            this.txtCirCentX.Location = new System.Drawing.Point(10, 24);
            this.txtCirCentX.Name = "txtCirCentX";
            this.txtCirCentX.Size = new System.Drawing.Size(55, 20);
            this.txtCirCentX.TabIndex = 1;
            this.txtCirCentX.Text = "0";
            this.txtCirCentX.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Center X";
            // 
            // tabTile
            // 
            this.tabTile.Controls.Add(this.chkSpaceLink);
            this.tabTile.Controls.Add(this.txtUnitsZ);
            this.tabTile.Controls.Add(this.txtSpaceZ);
            this.tabTile.Controls.Add(this.txtSpaceY);
            this.tabTile.Controls.Add(this.txtSpaceX);
            this.tabTile.Controls.Add(this.label18);
            this.tabTile.Controls.Add(this.label17);
            this.tabTile.Controls.Add(this.chkZeroRotation);
            this.tabTile.Controls.Add(this.chkIgnoreScaling);
            this.tabTile.Controls.Add(this.btnTile);
            this.tabTile.Controls.Add(this.label15);
            this.tabTile.Controls.Add(this.txtScaling);
            this.tabTile.Controls.Add(this.label14);
            this.tabTile.Controls.Add(this.txtUnitsX);
            this.tabTile.Controls.Add(this.label12);
            this.tabTile.Controls.Add(this.txtUnitsY);
            this.tabTile.Controls.Add(this.txtStartZ);
            this.tabTile.Controls.Add(this.label8);
            this.tabTile.Controls.Add(this.txtStartY);
            this.tabTile.Controls.Add(this.label9);
            this.tabTile.Controls.Add(this.txtStartX);
            this.tabTile.Controls.Add(this.label10);
            this.tabTile.Location = new System.Drawing.Point(4, 40);
            this.tabTile.Name = "tabTile";
            this.tabTile.Padding = new System.Windows.Forms.Padding(3);
            this.tabTile.Size = new System.Drawing.Size(223, 343);
            this.tabTile.TabIndex = 1;
            this.tabTile.Text = "Tile";
            this.tabTile.UseVisualStyleBackColor = true;
            // 
            // chkSpaceLink
            // 
            this.chkSpaceLink.AutoSize = true;
            this.chkSpaceLink.Location = new System.Drawing.Point(87, 110);
            this.chkSpaceLink.Name = "chkSpaceLink";
            this.chkSpaceLink.Size = new System.Drawing.Size(88, 17);
            this.chkSpaceLink.TabIndex = 30;
            this.chkSpaceLink.Text = "Link Spacing";
            this.chkSpaceLink.UseVisualStyleBackColor = true;
            this.chkSpaceLink.CheckedChanged += new System.EventHandler(this.chkSpaceLink_CheckedChanged);
            // 
            // txtUnitsZ
            // 
            this.txtUnitsZ.Location = new System.Drawing.Point(148, 71);
            this.txtUnitsZ.Name = "txtUnitsZ";
            this.txtUnitsZ.Size = new System.Drawing.Size(55, 20);
            this.txtUnitsZ.TabIndex = 29;
            this.txtUnitsZ.Text = "1";
            // 
            // txtSpaceZ
            // 
            this.txtSpaceZ.Location = new System.Drawing.Point(87, 71);
            this.txtSpaceZ.Name = "txtSpaceZ";
            this.txtSpaceZ.Size = new System.Drawing.Size(55, 20);
            this.txtSpaceZ.TabIndex = 28;
            this.txtSpaceZ.Text = "1";
            this.txtSpaceZ.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // txtSpaceY
            // 
            this.txtSpaceY.Location = new System.Drawing.Point(87, 45);
            this.txtSpaceY.Name = "txtSpaceY";
            this.txtSpaceY.Size = new System.Drawing.Size(55, 20);
            this.txtSpaceY.TabIndex = 27;
            this.txtSpaceY.Text = "1";
            this.txtSpaceY.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // txtSpaceX
            // 
            this.txtSpaceX.Location = new System.Drawing.Point(87, 19);
            this.txtSpaceX.Name = "txtSpaceX";
            this.txtSpaceX.Size = new System.Drawing.Size(55, 20);
            this.txtSpaceX.TabIndex = 26;
            this.txtSpaceX.Text = "1";
            this.txtSpaceX.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(92, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "Spacing";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Start";
            // 
            // chkZeroRotation
            // 
            this.chkZeroRotation.AutoSize = true;
            this.chkZeroRotation.Checked = true;
            this.chkZeroRotation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkZeroRotation.Location = new System.Drawing.Point(54, 210);
            this.chkZeroRotation.Name = "chkZeroRotation";
            this.chkZeroRotation.Size = new System.Drawing.Size(97, 17);
            this.chkZeroRotation.TabIndex = 23;
            this.chkZeroRotation.Text = "Reset Rotation";
            this.chkZeroRotation.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreScaling
            // 
            this.chkIgnoreScaling.AutoSize = true;
            this.chkIgnoreScaling.Location = new System.Drawing.Point(54, 187);
            this.chkIgnoreScaling.Name = "chkIgnoreScaling";
            this.chkIgnoreScaling.Size = new System.Drawing.Size(94, 17);
            this.chkIgnoreScaling.TabIndex = 22;
            this.chkIgnoreScaling.Text = "Ignore Scaling";
            this.chkIgnoreScaling.UseVisualStyleBackColor = true;
            // 
            // btnTile
            // 
            this.btnTile.Location = new System.Drawing.Point(139, 313);
            this.btnTile.Name = "btnTile";
            this.btnTile.Size = new System.Drawing.Size(75, 23);
            this.btnTile.TabIndex = 21;
            this.btnTile.Text = "Tile";
            this.btnTile.UseVisualStyleBackColor = true;
            this.btnTile.Click += new System.EventHandler(this.btnTile_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Start with the Southwesternmost tile";
            // 
            // txtScaling
            // 
            this.txtScaling.Location = new System.Drawing.Point(54, 161);
            this.txtScaling.Name = "txtScaling";
            this.txtScaling.Size = new System.Drawing.Size(55, 20);
            this.txtScaling.TabIndex = 19;
            this.txtScaling.Text = "1";
            this.txtScaling.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Scaling";
            // 
            // txtUnitsX
            // 
            this.txtUnitsX.Location = new System.Drawing.Point(148, 19);
            this.txtUnitsX.Name = "txtUnitsX";
            this.txtUnitsX.Size = new System.Drawing.Size(55, 20);
            this.txtUnitsX.TabIndex = 15;
            this.txtUnitsX.Text = "1";
            this.txtUnitsX.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(159, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Units";
            // 
            // txtUnitsY
            // 
            this.txtUnitsY.Location = new System.Drawing.Point(148, 45);
            this.txtUnitsY.Name = "txtUnitsY";
            this.txtUnitsY.Size = new System.Drawing.Size(55, 20);
            this.txtUnitsY.TabIndex = 13;
            this.txtUnitsY.Text = "1";
            this.txtUnitsY.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // txtStartZ
            // 
            this.txtStartZ.Location = new System.Drawing.Point(26, 71);
            this.txtStartZ.Name = "txtStartZ";
            this.txtStartZ.Size = new System.Drawing.Size(55, 20);
            this.txtStartZ.TabIndex = 11;
            this.txtStartZ.Text = "0";
            this.txtStartZ.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Z";
            // 
            // txtStartY
            // 
            this.txtStartY.Location = new System.Drawing.Point(26, 45);
            this.txtStartY.Name = "txtStartY";
            this.txtStartY.Size = new System.Drawing.Size(55, 20);
            this.txtStartY.TabIndex = 9;
            this.txtStartY.Text = "0";
            this.txtStartY.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Y";
            // 
            // txtStartX
            // 
            this.txtStartX.Location = new System.Drawing.Point(26, 19);
            this.txtStartX.Name = "txtStartX";
            this.txtStartX.Size = new System.Drawing.Size(55, 20);
            this.txtStartX.TabIndex = 7;
            this.txtStartX.Text = "0";
            this.txtStartX.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "X";
            // 
            // tabMove
            // 
            this.tabMove.Controls.Add(this.chkMassCrate);
            this.tabMove.Controls.Add(this.txtMassScaling);
            this.tabMove.Controls.Add(this.btnScaling);
            this.tabMove.Controls.Add(this.label16);
            this.tabMove.Controls.Add(this.txtMoveAmount);
            this.tabMove.Controls.Add(this.btnInCrate);
            this.tabMove.Controls.Add(this.btnRotateReset);
            this.tabMove.Controls.Add(this.btnUp);
            this.tabMove.Controls.Add(this.btnDown);
            this.tabMove.Controls.Add(this.btnRotate);
            this.tabMove.Controls.Add(this.btnRoll);
            this.tabMove.Controls.Add(this.btnPitch);
            this.tabMove.Controls.Add(this.btnWest);
            this.tabMove.Controls.Add(this.btnEast);
            this.tabMove.Controls.Add(this.btnSouth);
            this.tabMove.Controls.Add(this.btnNorth);
            this.tabMove.Location = new System.Drawing.Point(4, 40);
            this.tabMove.Name = "tabMove";
            this.tabMove.Padding = new System.Windows.Forms.Padding(3);
            this.tabMove.Size = new System.Drawing.Size(223, 345);
            this.tabMove.TabIndex = 3;
            this.tabMove.Text = "Mass Move";
            this.tabMove.UseVisualStyleBackColor = true;
            // 
            // chkMassCrate
            // 
            this.chkMassCrate.AutoSize = true;
            this.chkMassCrate.Location = new System.Drawing.Point(120, 312);
            this.chkMassCrate.Name = "chkMassCrate";
            this.chkMassCrate.Size = new System.Drawing.Size(15, 14);
            this.chkMassCrate.TabIndex = 16;
            this.chkMassCrate.UseVisualStyleBackColor = true;
            // 
            // txtMassScaling
            // 
            this.txtMassScaling.Location = new System.Drawing.Point(120, 277);
            this.txtMassScaling.Name = "txtMassScaling";
            this.txtMassScaling.Size = new System.Drawing.Size(60, 20);
            this.txtMassScaling.TabIndex = 15;
            this.txtMassScaling.Text = "1";
            this.txtMassScaling.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // btnScaling
            // 
            this.btnScaling.Location = new System.Drawing.Point(6, 273);
            this.btnScaling.Name = "btnScaling";
            this.btnScaling.Size = new System.Drawing.Size(94, 27);
            this.btnScaling.TabIndex = 14;
            this.btnScaling.Text = "Set Scaling To:";
            this.btnScaling.UseVisualStyleBackColor = true;
            this.btnScaling.Click += new System.EventHandler(this.MassMove_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(75, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Move Amount";
            // 
            // txtMoveAmount
            // 
            this.txtMoveAmount.Location = new System.Drawing.Point(154, 6);
            this.txtMoveAmount.Name = "txtMoveAmount";
            this.txtMoveAmount.Size = new System.Drawing.Size(60, 20);
            this.txtMoveAmount.TabIndex = 12;
            this.txtMoveAmount.Text = "0";
            this.txtMoveAmount.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // btnInCrate
            // 
            this.btnInCrate.Location = new System.Drawing.Point(6, 306);
            this.btnInCrate.Name = "btnInCrate";
            this.btnInCrate.Size = new System.Drawing.Size(94, 27);
            this.btnInCrate.TabIndex = 10;
            this.btnInCrate.Text = "Set Crate To:";
            this.btnInCrate.UseVisualStyleBackColor = true;
            this.btnInCrate.Click += new System.EventHandler(this.MassMove_Click);
            // 
            // btnRotateReset
            // 
            this.btnRotateReset.Location = new System.Drawing.Point(82, 236);
            this.btnRotateReset.Name = "btnRotateReset";
            this.btnRotateReset.Size = new System.Drawing.Size(94, 27);
            this.btnRotateReset.TabIndex = 9;
            this.btnRotateReset.Text = "Reset Rotations";
            this.btnRotateReset.UseVisualStyleBackColor = true;
            this.btnRotateReset.Click += new System.EventHandler(this.MassMove_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(32, 137);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(44, 27);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.MassMove_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(32, 170);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(44, 27);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.MassMove_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(82, 137);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(94, 27);
            this.btnRotate.TabIndex = 6;
            this.btnRotate.Text = "Rotate (Z)";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.MassMove_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(82, 170);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(94, 27);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "Roll (Y)";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.MassMove_Click);
            // 
            // btnPitch
            // 
            this.btnPitch.Location = new System.Drawing.Point(82, 203);
            this.btnPitch.Name = "btnPitch";
            this.btnPitch.Size = new System.Drawing.Size(94, 27);
            this.btnPitch.TabIndex = 4;
            this.btnPitch.Text = "Pitch (X)";
            this.btnPitch.UseVisualStyleBackColor = true;
            this.btnPitch.Click += new System.EventHandler(this.MassMove_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(32, 58);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(44, 27);
            this.btnWest.TabIndex = 3;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.MassMove_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(132, 58);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(44, 27);
            this.btnEast.TabIndex = 2;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.MassMove_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(82, 91);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(44, 27);
            this.btnSouth.TabIndex = 1;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.MassMove_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(82, 25);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(44, 27);
            this.btnNorth.TabIndex = 0;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.MassMove_Click);
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add(this.btnClone);
            this.tabOther.Controls.Add(this.btnManifest);
            this.tabOther.Controls.Add(this.btnDeleteCrate);
            this.tabOther.Location = new System.Drawing.Point(4, 40);
            this.tabOther.Name = "tabOther";
            this.tabOther.Size = new System.Drawing.Size(223, 345);
            this.tabOther.TabIndex = 2;
            this.tabOther.Text = "Other";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(47, 72);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(126, 23);
            this.btnClone.TabIndex = 2;
            this.btnClone.Text = "Clone Item(s)";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnManifest
            // 
            this.btnManifest.Location = new System.Drawing.Point(47, 42);
            this.btnManifest.Name = "btnManifest";
            this.btnManifest.Size = new System.Drawing.Size(126, 23);
            this.btnManifest.TabIndex = 1;
            this.btnManifest.Text = "Make Shopping List";
            this.btnManifest.UseVisualStyleBackColor = true;
            this.btnManifest.Click += new System.EventHandler(this.btnManifest_Click);
            // 
            // btnDeleteCrate
            // 
            this.btnDeleteCrate.Location = new System.Drawing.Point(47, 12);
            this.btnDeleteCrate.Name = "btnDeleteCrate";
            this.btnDeleteCrate.Size = new System.Drawing.Size(126, 23);
            this.btnDeleteCrate.TabIndex = 0;
            this.btnDeleteCrate.Text = "Delete items in crate";
            this.btnDeleteCrate.UseVisualStyleBackColor = true;
            this.btnDeleteCrate.Click += new System.EventHandler(this.btnDeleteCrate_Click);
            // 
            // tabGroups
            // 
            this.tabGroups.Controls.Add(this.btnRenameGroup);
            this.tabGroups.Controls.Add(this.btnClearFilter);
            this.tabGroups.Controls.Add(this.btnFilterOutGrp);
            this.tabGroups.Controls.Add(this.btnFilterToGroup);
            this.tabGroups.Controls.Add(this.btnGroupRemove);
            this.tabGroups.Controls.Add(this.txtGroupName);
            this.tabGroups.Controls.Add(this.btnGroupItemRemove);
            this.tabGroups.Controls.Add(this.btnGroupItemAdd);
            this.tabGroups.Controls.Add(this.label11);
            this.tabGroups.Controls.Add(this.cboGroups);
            this.tabGroups.Location = new System.Drawing.Point(4, 40);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Size = new System.Drawing.Size(223, 345);
            this.tabGroups.TabIndex = 4;
            this.tabGroups.Text = "Groups";
            this.tabGroups.UseVisualStyleBackColor = true;
            // 
            // btnRenameGroup
            // 
            this.btnRenameGroup.Location = new System.Drawing.Point(7, 173);
            this.btnRenameGroup.Name = "btnRenameGroup";
            this.btnRenameGroup.Size = new System.Drawing.Size(196, 23);
            this.btnRenameGroup.TabIndex = 9;
            this.btnRenameGroup.Text = "Rename Group";
            this.btnRenameGroup.UseVisualStyleBackColor = true;
            this.btnRenameGroup.Click += new System.EventHandler(this.btnRenameGroup_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(72, 255);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(131, 23);
            this.btnClearFilter.TabIndex = 8;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFilterOutGrp
            // 
            this.btnFilterOutGrp.Location = new System.Drawing.Point(72, 284);
            this.btnFilterOutGrp.Name = "btnFilterOutGrp";
            this.btnFilterOutGrp.Size = new System.Drawing.Size(131, 23);
            this.btnFilterOutGrp.TabIndex = 7;
            this.btnFilterOutGrp.Text = "Filter out Group";
            this.btnFilterOutGrp.UseVisualStyleBackColor = true;
            this.btnFilterOutGrp.Click += new System.EventHandler(this.btnFilterOutGroup_Click);
            // 
            // btnFilterToGroup
            // 
            this.btnFilterToGroup.Location = new System.Drawing.Point(72, 313);
            this.btnFilterToGroup.Name = "btnFilterToGroup";
            this.btnFilterToGroup.Size = new System.Drawing.Size(132, 23);
            this.btnFilterToGroup.TabIndex = 6;
            this.btnFilterToGroup.Text = "Filter to Group";
            this.btnFilterToGroup.UseVisualStyleBackColor = true;
            this.btnFilterToGroup.Click += new System.EventHandler(this.btnFilterGroup_Click);
            // 
            // btnGroupRemove
            // 
            this.btnGroupRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGroupRemove.Location = new System.Drawing.Point(7, 143);
            this.btnGroupRemove.Name = "btnGroupRemove";
            this.btnGroupRemove.Size = new System.Drawing.Size(197, 23);
            this.btnGroupRemove.TabIndex = 5;
            this.btnGroupRemove.Text = "Remove Group";
            this.btnGroupRemove.UseVisualStyleBackColor = false;
            this.btnGroupRemove.Click += new System.EventHandler(this.btnGroupRemove_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(7, 48);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(197, 20);
            this.txtGroupName.TabIndex = 4;
            this.txtGroupName.Text = "New Group Name...";
            // 
            // btnGroupItemRemove
            // 
            this.btnGroupItemRemove.Location = new System.Drawing.Point(7, 113);
            this.btnGroupItemRemove.Name = "btnGroupItemRemove";
            this.btnGroupItemRemove.Size = new System.Drawing.Size(197, 23);
            this.btnGroupItemRemove.TabIndex = 3;
            this.btnGroupItemRemove.Text = "Remove Selected From Group";
            this.btnGroupItemRemove.UseVisualStyleBackColor = true;
            this.btnGroupItemRemove.Click += new System.EventHandler(this.btnGroupItemRemove_Click);
            // 
            // btnGroupItemAdd
            // 
            this.btnGroupItemAdd.Location = new System.Drawing.Point(7, 83);
            this.btnGroupItemAdd.Name = "btnGroupItemAdd";
            this.btnGroupItemAdd.Size = new System.Drawing.Size(197, 23);
            this.btnGroupItemAdd.TabIndex = 2;
            this.btnGroupItemAdd.Text = "Add Selected to Group";
            this.btnGroupItemAdd.UseVisualStyleBackColor = true;
            this.btnGroupItemAdd.Click += new System.EventHandler(this.btnGroupItemAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Group Name";
            // 
            // cboGroups
            // 
            this.cboGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroups.FormattingEnabled = true;
            this.cboGroups.Items.AddRange(new object[] {
            "... New"});
            this.cboGroups.Location = new System.Drawing.Point(7, 20);
            this.cboGroups.Name = "cboGroups";
            this.cboGroups.Size = new System.Drawing.Size(197, 21);
            this.cboGroups.TabIndex = 0;
            this.cboGroups.SelectedIndexChanged += new System.EventHandler(this.cboGroups_SelectedIndexChanged);
            // 
            // tabRotate
            // 
            this.tabRotate.Controls.Add(this.groupBox2);
            this.tabRotate.Controls.Add(this.groupBox1);
            this.tabRotate.Controls.Add(this.label13);
            this.tabRotate.Controls.Add(this.btnGroupRotate);
            this.tabRotate.Controls.Add(this.txtRotation);
            this.tabRotate.Location = new System.Drawing.Point(4, 40);
            this.tabRotate.Name = "tabRotate";
            this.tabRotate.Padding = new System.Windows.Forms.Padding(3);
            this.tabRotate.Size = new System.Drawing.Size(223, 345);
            this.tabRotate.TabIndex = 5;
            this.tabRotate.Text = "Rotate Items";
            this.tabRotate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txt_rg_Z);
            this.groupBox2.Controls.Add(this.txt_rg_Y);
            this.groupBox2.Controls.Add(this.txt_rg_X);
            this.groupBox2.Controls.Add(this.rdoPoint);
            this.groupBox2.Controls.Add(this.rdoCenter);
            this.groupBox2.Location = new System.Drawing.Point(10, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rotate Around...";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(121, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Z";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(73, 58);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "Y";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(22, 58);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 11;
            this.label22.Text = "X";
            // 
            // txt_rg_Z
            // 
            this.txt_rg_Z.Location = new System.Drawing.Point(106, 74);
            this.txt_rg_Z.Name = "txt_rg_Z";
            this.txt_rg_Z.Size = new System.Drawing.Size(44, 20);
            this.txt_rg_Z.TabIndex = 4;
            this.txt_rg_Z.Text = "0";
            this.txt_rg_Z.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // txt_rg_Y
            // 
            this.txt_rg_Y.Location = new System.Drawing.Point(56, 74);
            this.txt_rg_Y.Name = "txt_rg_Y";
            this.txt_rg_Y.Size = new System.Drawing.Size(44, 20);
            this.txt_rg_Y.TabIndex = 3;
            this.txt_rg_Y.Text = "0";
            this.txt_rg_Y.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // txt_rg_X
            // 
            this.txt_rg_X.Location = new System.Drawing.Point(6, 74);
            this.txt_rg_X.Name = "txt_rg_X";
            this.txt_rg_X.Size = new System.Drawing.Size(44, 20);
            this.txt_rg_X.TabIndex = 2;
            this.txt_rg_X.Text = "0";
            this.txt_rg_X.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // rdoPoint
            // 
            this.rdoPoint.AutoSize = true;
            this.rdoPoint.Location = new System.Drawing.Point(6, 35);
            this.rdoPoint.Name = "rdoPoint";
            this.rdoPoint.Size = new System.Drawing.Size(66, 17);
            this.rdoPoint.TabIndex = 1;
            this.rdoPoint.Text = "Location";
            this.rdoPoint.UseVisualStyleBackColor = true;
            // 
            // rdoCenter
            // 
            this.rdoCenter.AutoSize = true;
            this.rdoCenter.Checked = true;
            this.rdoCenter.Location = new System.Drawing.Point(6, 19);
            this.rdoCenter.Name = "rdoCenter";
            this.rdoCenter.Size = new System.Drawing.Size(140, 17);
            this.rdoCenter.TabIndex = 0;
            this.rdoCenter.TabStop = true;
            this.rdoCenter.Text = "Determined Center Point";
            this.rdoCenter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_Rotate);
            this.groupBox1.Controls.Add(this.rdo_Pitch);
            this.groupBox1.Controls.Add(this.rdo_Roll);
            this.groupBox1.Location = new System.Drawing.Point(10, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 78);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotate On...";
            // 
            // rdo_Rotate
            // 
            this.rdo_Rotate.AutoSize = true;
            this.rdo_Rotate.Checked = true;
            this.rdo_Rotate.Location = new System.Drawing.Point(6, 19);
            this.rdo_Rotate.Name = "rdo_Rotate";
            this.rdo_Rotate.Size = new System.Drawing.Size(95, 17);
            this.rdo_Rotate.TabIndex = 3;
            this.rdo_Rotate.TabStop = true;
            this.rdo_Rotate.Text = "Z Axis (Rotate)";
            this.rdo_Rotate.UseVisualStyleBackColor = true;
            // 
            // rdo_Pitch
            // 
            this.rdo_Pitch.AutoSize = true;
            this.rdo_Pitch.Location = new System.Drawing.Point(6, 35);
            this.rdo_Pitch.Name = "rdo_Pitch";
            this.rdo_Pitch.Size = new System.Drawing.Size(87, 17);
            this.rdo_Pitch.TabIndex = 4;
            this.rdo_Pitch.Text = "X Axis (Pitch)";
            this.rdo_Pitch.UseVisualStyleBackColor = true;
            // 
            // rdo_Roll
            // 
            this.rdo_Roll.AutoSize = true;
            this.rdo_Roll.Location = new System.Drawing.Point(6, 51);
            this.rdo_Roll.Name = "rdo_Roll";
            this.rdo_Roll.Size = new System.Drawing.Size(81, 17);
            this.rdo_Roll.TabIndex = 5;
            this.rdo_Roll.Text = "Y Axis (Roll)";
            this.rdo_Roll.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(56, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Degrees";
            // 
            // btnGroupRotate
            // 
            this.btnGroupRotate.Location = new System.Drawing.Point(6, 32);
            this.btnGroupRotate.Name = "btnGroupRotate";
            this.btnGroupRotate.Size = new System.Drawing.Size(97, 23);
            this.btnGroupRotate.TabIndex = 1;
            this.btnGroupRotate.Text = "Rotate Group";
            this.btnGroupRotate.UseVisualStyleBackColor = true;
            this.btnGroupRotate.Click += new System.EventHandler(this.btnGroupRotate_Click);
            // 
            // txtRotation
            // 
            this.txtRotation.Location = new System.Drawing.Point(6, 6);
            this.txtRotation.Name = "txtRotation";
            this.txtRotation.Size = new System.Drawing.Size(43, 20);
            this.txtRotation.TabIndex = 0;
            this.txtRotation.Text = "0";
            this.txtRotation.Leave += new System.EventHandler(this.NumberText_Leave);
            // 
            // mnuShopping
            // 
            this.mnuShopping.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShopCSV,
            this.mnuShopHTML,
            this.mnuShopBoth});
            this.mnuShopping.Name = "mnuShopping";
            this.mnuShopping.Size = new System.Drawing.Size(205, 70);
            // 
            // mnuShopCSV
            // 
            this.mnuShopCSV.Name = "mnuShopCSV";
            this.mnuShopCSV.Size = new System.Drawing.Size(204, 22);
            this.mnuShopCSV.Text = "Generate CSV List";
            this.mnuShopCSV.Click += new System.EventHandler(this.mnuShopping_ItemClick);
            // 
            // mnuShopHTML
            // 
            this.mnuShopHTML.Name = "mnuShopHTML";
            this.mnuShopHTML.Size = new System.Drawing.Size(204, 22);
            this.mnuShopHTML.Text = "Generate HTML List";
            this.mnuShopHTML.Click += new System.EventHandler(this.mnuShopping_ItemClick);
            // 
            // mnuShopBoth
            // 
            this.mnuShopBoth.Name = "mnuShopBoth";
            this.mnuShopBoth.Size = new System.Drawing.Size(204, 22);
            this.mnuShopBoth.Text = "Generate CSV and HTML";
            this.mnuShopBoth.Click += new System.EventHandler(this.mnuShopping_ItemClick);
            // 
            // tabMirror
            // 
            this.tabMirror.Controls.Add(this.chkMirrorRotate);
            this.tabMirror.Controls.Add(this.btnMirror);
            this.tabMirror.Controls.Add(this.label19);
            this.tabMirror.Controls.Add(this.cboMirrorPlane);
            this.tabMirror.Location = new System.Drawing.Point(4, 40);
            this.tabMirror.Name = "tabMirror";
            this.tabMirror.Padding = new System.Windows.Forms.Padding(3);
            this.tabMirror.Size = new System.Drawing.Size(223, 345);
            this.tabMirror.TabIndex = 6;
            this.tabMirror.Text = "Mirror";
            this.tabMirror.UseVisualStyleBackColor = true;
            // 
            // cboMirrorPlane
            // 
            this.cboMirrorPlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMirrorPlane.FormattingEnabled = true;
            this.cboMirrorPlane.Items.AddRange(new object[] {
            "Z Plane (Ground)",
            "- Mirror Items Upwards",
            "- Mirror Items Downwards",
            "X Plane (East/West)",
            "- Mirror Items to East",
            "- Mirror Items to West",
            "Y Plane (North/South)",
            "- Mirror Items North",
            "- Mirror Items South"});
            this.cboMirrorPlane.Location = new System.Drawing.Point(7, 22);
            this.cboMirrorPlane.Name = "cboMirrorPlane";
            this.cboMirrorPlane.Size = new System.Drawing.Size(210, 21);
            this.cboMirrorPlane.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Rotation Plane";
            // 
            // btnMirror
            // 
            this.btnMirror.Location = new System.Drawing.Point(142, 72);
            this.btnMirror.Name = "btnMirror";
            this.btnMirror.Size = new System.Drawing.Size(75, 23);
            this.btnMirror.TabIndex = 2;
            this.btnMirror.Text = "Mirror!";
            this.btnMirror.UseVisualStyleBackColor = true;
            this.btnMirror.Click += new System.EventHandler(this.btnMirror_Click);
            // 
            // chkMirrorRotate
            // 
            this.chkMirrorRotate.AutoSize = true;
            this.chkMirrorRotate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMirrorRotate.Checked = true;
            this.chkMirrorRotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMirrorRotate.Location = new System.Drawing.Point(86, 49);
            this.chkMirrorRotate.Name = "chkMirrorRotate";
            this.chkMirrorRotate.Size = new System.Drawing.Size(131, 17);
            this.chkMirrorRotate.TabIndex = 3;
            this.chkMirrorRotate.Text = "Rotate Items on Plane";
            this.chkMirrorRotate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 490);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblClearSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.mnu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabCircleSpiral.ResumeLayout(false);
            this.tabCircleSpiral.PerformLayout();
            this.tabTile.ResumeLayout(false);
            this.tabTile.PerformLayout();
            this.tabMove.ResumeLayout(false);
            this.tabMove.PerformLayout();
            this.tabOther.ResumeLayout(false);
            this.tabGroups.ResumeLayout(false);
            this.tabGroups.PerformLayout();
            this.tabRotate.ResumeLayout(false);
            this.tabRotate.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mnuShopping.ResumeLayout(false);
            this.tabMirror.ResumeLayout(false);
            this.tabMirror.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog od;
        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClearSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.SaveFileDialog sd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCircleSpiral;
        private System.Windows.Forms.TextBox txtCirCentZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCirCentY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCirCentX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabTile;
        private System.Windows.Forms.Label lbl_off;
        private System.Windows.Forms.Label lbl_Fill;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkReverse;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.CheckBox chkRotate;
        private System.Windows.Forms.CheckBox chk90Offset;
        private System.Windows.Forms.RadioButton rdo_From_Ground;
        private System.Windows.Forms.RadioButton rdo_From_Center;
        private System.Windows.Forms.CheckBox chkSpiral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEndZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRevolutions;
        private System.Windows.Forms.TextBox txtScaling;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUnitsX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUnitsY;
        private System.Windows.Forms.TextBox txtStartZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStartY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStartX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkIgnoreScaling;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.Button btnDeleteCrate;
        private System.Windows.Forms.Button btnManifest;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.CheckBox chkZeroRotation;
        private System.Windows.Forms.TabPage tabMove;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnPitch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMoveAmount;
        private System.Windows.Forms.Button btnInCrate;
        private System.Windows.Forms.Button btnRotateReset;
        private System.Windows.Forms.CheckBox chkPointTops;
        private System.Windows.Forms.TextBox txtMassScaling;
        private System.Windows.Forms.Button btnScaling;
        private System.Windows.Forms.CheckBox chkMassCrate;
        private System.Windows.Forms.ContextMenuStrip mnuShopping;
        private System.Windows.Forms.ToolStripMenuItem mnuShopCSV;
        private System.Windows.Forms.ToolStripMenuItem mnuShopHTML;
        private System.Windows.Forms.ToolStripMenuItem mnuShopBoth;
        private System.Windows.Forms.ToolStripMenuItem saveChangesOnlyAsToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSpaceZ;
        private System.Windows.Forms.TextBox txtSpaceY;
        private System.Windows.Forms.TextBox txtSpaceX;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUnitsZ;
        private System.Windows.Forms.CheckBox chkSpaceLink;
        private System.Windows.Forms.TabPage tabGroups;
        private System.Windows.Forms.Button btnFilterOutGrp;
        private System.Windows.Forms.Button btnFilterToGroup;
        private System.Windows.Forms.Button btnGroupRemove;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Button btnGroupItemRemove;
        private System.Windows.Forms.Button btnGroupItemAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboGroups;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnRenameGroup;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crateItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearSortingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem importGroupFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importNotesFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeAnotherLayoutIntoCurrentFileToolStripMenuItem;
        private System.Windows.Forms.TabPage tabRotate;
        private System.Windows.Forms.Button btnGroupRotate;
        private System.Windows.Forms.TextBox txtRotation;
        private System.Windows.Forms.RadioButton rdo_Roll;
        private System.Windows.Forms.RadioButton rdo_Pitch;
        private System.Windows.Forms.RadioButton rdo_Rotate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboCirclePlane;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_rg_Z;
        private System.Windows.Forms.TextBox txt_rg_Y;
        private System.Windows.Forms.TextBox txt_rg_X;
        private System.Windows.Forms.RadioButton rdoPoint;
        private System.Windows.Forms.RadioButton rdoCenter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabMirror;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboMirrorPlane;
        private System.Windows.Forms.Button btnMirror;
        private System.Windows.Forms.CheckBox chkMirrorRotate;
    }
}

