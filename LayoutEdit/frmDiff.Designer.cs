namespace LayoutEdit
{
    partial class frmDiff
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnLoadSource = new System.Windows.Forms.Button();
            this.btnLoadCompare = new System.Windows.Forms.Button();
            this.txtCompare = new System.Windows.Forms.TextBox();
            this.chkDiff = new System.Windows.Forms.CheckBox();
            this.chkKeepSrcNew = new System.Windows.Forms.CheckBox();
            this.chkKeepCompareNew = new System.Windows.Forms.CheckBox();
            this.lblSourceInfo = new System.Windows.Forms.Label();
            this.lblCompareInfo = new System.Windows.Forms.Label();
            this.OD = new System.Windows.Forms.OpenFileDialog();
            this.SD = new System.Windows.Forms.SaveFileDialog();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkKeepSrc = new System.Windows.Forms.CheckBox();
            this.chkKeepCompare = new System.Windows.Forms.CheckBox();
            this.lblFinalCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comparison File";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(16, 29);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(417, 20);
            this.txtSource.TabIndex = 2;
            // 
            // btnLoadSource
            // 
            this.btnLoadSource.Location = new System.Drawing.Point(439, 28);
            this.btnLoadSource.Name = "btnLoadSource";
            this.btnLoadSource.Size = new System.Drawing.Size(28, 20);
            this.btnLoadSource.TabIndex = 3;
            this.btnLoadSource.Text = "...";
            this.btnLoadSource.UseVisualStyleBackColor = true;
            this.btnLoadSource.Click += new System.EventHandler(this.btnLoadSource_Click);
            // 
            // btnLoadCompare
            // 
            this.btnLoadCompare.Location = new System.Drawing.Point(439, 90);
            this.btnLoadCompare.Name = "btnLoadCompare";
            this.btnLoadCompare.Size = new System.Drawing.Size(28, 20);
            this.btnLoadCompare.TabIndex = 5;
            this.btnLoadCompare.Text = "...";
            this.btnLoadCompare.UseVisualStyleBackColor = true;
            this.btnLoadCompare.Click += new System.EventHandler(this.btnLoadCompare_Click);
            // 
            // txtCompare
            // 
            this.txtCompare.Location = new System.Drawing.Point(16, 91);
            this.txtCompare.Name = "txtCompare";
            this.txtCompare.Size = new System.Drawing.Size(417, 20);
            this.txtCompare.TabIndex = 4;
            // 
            // chkDiff
            // 
            this.chkDiff.AutoSize = true;
            this.chkDiff.Checked = true;
            this.chkDiff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDiff.Location = new System.Drawing.Point(16, 140);
            this.chkDiff.Name = "chkDiff";
            this.chkDiff.Size = new System.Drawing.Size(144, 17);
            this.chkDiff.TabIndex = 7;
            this.chkDiff.Text = "Keep items that changed";
            this.chkDiff.UseVisualStyleBackColor = true;
            // 
            // chkKeepSrcNew
            // 
            this.chkKeepSrcNew.AutoSize = true;
            this.chkKeepSrcNew.Location = new System.Drawing.Point(16, 164);
            this.chkKeepSrcNew.Name = "chkKeepSrcNew";
            this.chkKeepSrcNew.Size = new System.Drawing.Size(256, 17);
            this.chkKeepSrcNew.TabIndex = 8;
            this.chkKeepSrcNew.Text = "Keep items that are in source but not comparison";
            this.chkKeepSrcNew.UseVisualStyleBackColor = true;
            // 
            // chkKeepCompareNew
            // 
            this.chkKeepCompareNew.AutoSize = true;
            this.chkKeepCompareNew.Checked = true;
            this.chkKeepCompareNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepCompareNew.Location = new System.Drawing.Point(16, 188);
            this.chkKeepCompareNew.Name = "chkKeepCompareNew";
            this.chkKeepCompareNew.Size = new System.Drawing.Size(267, 17);
            this.chkKeepCompareNew.TabIndex = 9;
            this.chkKeepCompareNew.Text = "Keep items that are in comparison but not in source";
            this.chkKeepCompareNew.UseVisualStyleBackColor = true;
            // 
            // lblSourceInfo
            // 
            this.lblSourceInfo.AutoSize = true;
            this.lblSourceInfo.Location = new System.Drawing.Point(16, 54);
            this.lblSourceInfo.Name = "lblSourceInfo";
            this.lblSourceInfo.Size = new System.Drawing.Size(122, 13);
            this.lblSourceInfo.TabIndex = 10;
            this.lblSourceInfo.Text = "Source File: Not Loaded";
            // 
            // lblCompareInfo
            // 
            this.lblCompareInfo.AutoSize = true;
            this.lblCompareInfo.Location = new System.Drawing.Point(8, 114);
            this.lblCompareInfo.Name = "lblCompareInfo";
            this.lblCompareInfo.Size = new System.Drawing.Size(130, 13);
            this.lblCompareInfo.TabIndex = 11;
            this.lblCompareInfo.Text = "Compare File: Not Loaded";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(280, 283);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 12;
            this.btnCompare.Text = "Recompare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(361, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save and Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkKeepSrc
            // 
            this.chkKeepSrc.AutoSize = true;
            this.chkKeepSrc.Location = new System.Drawing.Point(16, 223);
            this.chkKeepSrc.Name = "chkKeepSrc";
            this.chkKeepSrc.Size = new System.Drawing.Size(416, 43);
            this.chkKeepSrc.TabIndex = 14;
            this.chkKeepSrc.Text = "Keep all items from source\r\n    - If the item is in both files, values from \"comp" +
    "are\" file are used unless any of the \r\n       keep compare values are unchecked";
            this.chkKeepSrc.UseVisualStyleBackColor = true;
            // 
            // chkKeepCompare
            // 
            this.chkKeepCompare.AutoSize = true;
            this.chkKeepCompare.Checked = true;
            this.chkKeepCompare.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepCompare.Location = new System.Drawing.Point(16, 272);
            this.chkKeepCompare.Name = "chkKeepCompare";
            this.chkKeepCompare.Size = new System.Drawing.Size(158, 17);
            this.chkKeepCompare.TabIndex = 15;
            this.chkKeepCompare.Text = "Keep all items from compare";
            this.chkKeepCompare.UseVisualStyleBackColor = true;
            // 
            // lblFinalCount
            // 
            this.lblFinalCount.AutoSize = true;
            this.lblFinalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFinalCount.Location = new System.Drawing.Point(11, 296);
            this.lblFinalCount.Name = "lblFinalCount";
            this.lblFinalCount.Size = new System.Drawing.Size(0, 13);
            this.lblFinalCount.TabIndex = 16;
            // 
            // frmDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 318);
            this.Controls.Add(this.lblFinalCount);
            this.Controls.Add(this.chkKeepCompare);
            this.Controls.Add(this.chkKeepSrc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.lblCompareInfo);
            this.Controls.Add(this.lblSourceInfo);
            this.Controls.Add(this.chkKeepCompareNew);
            this.Controls.Add(this.chkKeepSrcNew);
            this.Controls.Add(this.chkDiff);
            this.Controls.Add(this.btnLoadCompare);
            this.Controls.Add(this.txtCompare);
            this.Controls.Add(this.btnLoadSource);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDiff";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Differential Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDiff_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnLoadSource;
        private System.Windows.Forms.Button btnLoadCompare;
        private System.Windows.Forms.TextBox txtCompare;
        private System.Windows.Forms.CheckBox chkDiff;
        private System.Windows.Forms.CheckBox chkKeepSrcNew;
        private System.Windows.Forms.CheckBox chkKeepCompareNew;
        private System.Windows.Forms.Label lblSourceInfo;
        private System.Windows.Forms.Label lblCompareInfo;
        private System.Windows.Forms.OpenFileDialog OD;
        private System.Windows.Forms.SaveFileDialog SD;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkKeepSrc;
        private System.Windows.Forms.CheckBox chkKeepCompare;
        private System.Windows.Forms.Label lblFinalCount;
    }
}