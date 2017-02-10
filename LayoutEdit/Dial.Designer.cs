namespace LayoutEdit
{
    partial class Dial
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Dial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Dial";
            this.Size = new System.Drawing.Size(72, 82);
            this.Load += new System.EventHandler(this.Dial_Load);
            this.SizeChanged += new System.EventHandler(this.Dial_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Dial_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dial_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dial_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Dial_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
