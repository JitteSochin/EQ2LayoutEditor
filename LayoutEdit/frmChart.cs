using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LayoutEdit
{
    public partial class frmChart : Form
    {
        internal bool SettingUp = true;
        internal DataTable HouseItems = new DataTable();
        string Caption = string.Empty;
        public frmChart()
        {
            InitializeComponent();
        }
        internal void FirstBuild(DataTable Items){
            SettingUp = true;
            Caption = this.Text;
            HouseItems = Items;

            double MinX = 0, MaxX = 0, MinY = 0, MaxY = 0, MinZ = 0, MaxZ = 0;
            bool firstitem = true;
            chart.Series["xy"].Points.Clear();
            int pointindex = 0;
            foreach (DataRow Item in HouseItems.Rows)
            {
                if (bool.Parse(Item["InCrate"].ToString())) continue;
                Double Itemz = Double.Parse(Item["z"].ToString());
                if (Itemz < MinZ) MinZ = Itemz;
                if (Itemz > MaxZ) MaxZ = Itemz;

                Double Itemx = Double.Parse(Item["x"].ToString()) * -1;
                if (Itemx < MinX) MinX = Itemx;
                if (Itemx > MaxX) MaxX = Itemx;

                Double Itemy = Double.Parse(Item["y"].ToString()) * -1;
                if (Itemy < MinY) MinY = Itemy;
                if (Itemy > MaxY) MaxY = Itemy;

                if (firstitem)
                {
                    MinZ = Itemz;
                    MaxZ = Itemz;
                    MinX = Itemx;
                    MaxX = Itemx;
                    MinY = Itemy;
                    MaxY = Itemy;
                    firstitem = false;
                }
            }
            pb_x_range.Value = 100;
            scr_Z_Axis.Minimum = (int)MinZ;
            scr_Z_Axis.Maximum = (int)MaxZ;
            foreach (DataRow Item in HouseItems.Rows)
            {
                if (bool.Parse(Item["InCrate"].ToString())) continue;
                Double Itemx = Double.Parse(Item["x"].ToString()) * -1 - MinX;
                Double Itemy = Double.Parse(Item["y"].ToString()) * -1 - MinY;
                Double Itemz = Double.Parse(Item["z"].ToString());
                double spread = MaxZ - MinZ;
                double halfspread = spread * 0.5d;
                int gInt = (int)(255d * (MaxZ - Itemz) / halfspread);
                if (gInt > 255) gInt = 255;
                int rInt = (int)(255d * (Itemz - MinZ) / halfspread);
                if (rInt > 255) rInt = 255;
                if (MinZ == MaxZ)
                {
                    rInt = 0;
                    gInt = 255;
                }
                chart.Series["xy"].Points.AddXY(Itemx, Itemy);
                chart.Series["xy"].Points[pointindex].Color = Color.FromArgb(rInt, gInt, 0);
                chart.Series["xy"].Points[pointindex].ToolTip = String.Format("{0} [{1}]", Item["ItemName"].ToString(), Item["DatabaseID"].ToString());
                pointindex++;
            }
            chart.ChartAreas["ChartArea"].AxisX.Minimum = -(int)(((double)MaxX - (double)MinX) * 0.1d);
            chart.ChartAreas["ChartArea"].AxisX.Maximum = MaxX - MinX + (int)(((double)MaxX - (double)MinX) * 0.1d);

            chart.ChartAreas["ChartArea"].AxisY.Minimum = -(int)(((double)MaxY - (double)MinY) * 0.1d);
            chart.ChartAreas["ChartArea"].AxisY.Maximum = MaxY - MinY + (int)(((double)MaxY - (double)MinY) * 0.1d);
            SettingUp = false;
        }

        private void pb_x_range_MouseClick(object sender, MouseEventArgs e)
        {
            int newval = 100 - (int)((double)e.Y / (double)pb_x_range.Height * 100d);
            if (newval < 3) newval = 3;
            pb_x_range.Value = newval;
            if (!SettingUp) Redraw();
        }
        internal void Redraw()
        {
            double MinX = 0, MaxX = 0, MinY = 0, MaxY = 0, MinZ = 0, MaxZ = 0;
            bool firstitem = true;
            chart.Series["xy"].Points.Clear();
            int pointindex = 0;
            foreach (DataRow Item in HouseItems.Rows)
            {
                if (bool.Parse(Item["InCrate"].ToString())) continue;
                Double Itemz = Double.Parse(Item["z"].ToString());
                if (Itemz < MinZ) MinZ = Itemz;
                if (Itemz > MaxZ) MaxZ = Itemz;

                Double Itemx = Double.Parse(Item["x"].ToString()) * -1;
                if (Itemx < MinX) MinX = Itemx;
                if (Itemx > MaxX) MaxX = Itemx;

                Double Itemy = Double.Parse(Item["y"].ToString()) * -1;
                if (Itemy < MinY) MinY = Itemy;
                if (Itemy > MaxY) MaxY = Itemy;

                if (firstitem)
                {
                    MinZ = Itemz;
                    MaxZ = Itemz;
                    MinX = Itemx;
                    MaxX = Itemx;
                    MinY = Itemy;
                    MaxY = Itemy;
                    firstitem = false;
                }
            }
            double zRangeMin = MinZ, zRangeMax = MaxZ;
            double zRangeScope = MaxZ - (((double)scr_Z_Axis.Value - MinZ) / (MaxZ - MinZ)) * (MaxZ - MinZ);
            double zRangeBreadth = pb_x_range.Value;
            zRangeMin = zRangeScope - ((zRangeBreadth / 100d) * (zRangeMax - zRangeMin));
            zRangeMax = zRangeScope + ((zRangeBreadth / 100d) * (zRangeMax - zRangeMin));
            this.Text = Caption + String.Format(" -- Z Values between {0} and {1}", zRangeMin.ToString("0.00"), zRangeMax.ToString("0.00"));
            foreach (DataRow Item in HouseItems.Rows)
            {
                if (bool.Parse(Item["InCrate"].ToString())) continue;
                Double Itemx = Double.Parse(Item["x"].ToString()) * -1 - MinX;
                Double Itemy = Double.Parse(Item["y"].ToString()) * -1 - MinY;
                Double Itemz = Double.Parse(Item["z"].ToString());
                double spread = MaxZ - MinZ;
                double halfspread = spread * 0.5d;
                int gInt = (int)(255d * (MaxZ - Itemz) / halfspread);
                if (gInt > 255) gInt = 255;
                int rInt = (int)(255d * (Itemz - MinZ) / halfspread);
                if (rInt > 255) rInt = 255;
                if (MinZ == MaxZ)
                {
                    rInt = 0;
                    gInt = 255;
                }
                if (Itemz > zRangeMin && Itemz < zRangeMax)
                {
                    chart.Series["xy"].Points.AddXY(Itemx, Itemy);
                    chart.Series["xy"].Points[pointindex].Color = Color.FromArgb(rInt, gInt, 0);
                    chart.Series["xy"].Points[pointindex].ToolTip = String.Format("{0} [{1}]", Item["ItemName"].ToString(), Item["DatabaseID"].ToString());
                    pointindex++;
                }
            }
        }
        private void scr_Z_Axis_ValueChanged(object sender, EventArgs e)
        {
            if (!SettingUp) Redraw();
        }
    }
}
