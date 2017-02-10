namespace LayoutEdit
{
    partial class frmChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.scr_Z_Axis = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_x_range = new LayoutEdit.VerticalProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.BorderColor = System.Drawing.Color.LightGray;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorX.LineColor = System.Drawing.Color.PeachPuff;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.CursorY.LineColor = System.Drawing.Color.PeachPuff;
            chartArea2.Name = "ChartArea";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Location = new System.Drawing.Point(13, 13);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.LabelForeColor = System.Drawing.Color.Silver;
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "xy";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(706, 493);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // scr_Z_Axis
            // 
            this.scr_Z_Axis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scr_Z_Axis.Location = new System.Drawing.Point(742, 13);
            this.scr_Z_Axis.Name = "scr_Z_Axis";
            this.scr_Z_Axis.Size = new System.Drawing.Size(17, 493);
            this.scr_Z_Axis.TabIndex = 1;
            this.scr_Z_Axis.ValueChanged += new System.EventHandler(this.scr_Z_Axis_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(725, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 169);
            this.label1.TabIndex = 2;
            this.label1.Text = "Z\r\n \r\nA\r\nx\r\ni\r\ns\r\n \r\nF\r\ni\r\nl\r\nt\r\ne\r\nr";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(762, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 156);
            this.label2.TabIndex = 4;
            this.label2.Text = "Z\r\n \r\nA\r\nx\r\ni\r\ns\r\n \r\nR\r\na\r\nn\r\ng\r\ne";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pb_x_range
            // 
            this.pb_x_range.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_x_range.Location = new System.Drawing.Point(785, 13);
            this.pb_x_range.Name = "pb_x_range";
            this.pb_x_range.Size = new System.Drawing.Size(18, 493);
            this.pb_x_range.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_x_range.TabIndex = 5;
            this.pb_x_range.Value = 100;
            this.pb_x_range.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_x_range_MouseClick);
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 518);
            this.Controls.Add(this.pb_x_range);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scr_Z_Axis);
            this.Controls.Add(this.chart);
            this.Name = "frmChart";
            this.Text = "frmChart";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataVisualization.Charting.Chart chart;
        internal System.Windows.Forms.VScrollBar scr_Z_Axis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private VerticalProgressBar pb_x_range;

    }
}