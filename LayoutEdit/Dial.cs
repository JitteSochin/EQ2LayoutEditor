using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LayoutEdit
{
    public partial class Dial : UserControl
    {
        public enum FillType{
            Line = 1, Pie = 2
        }
        private int _value, _min, _max;
        private bool ValueChanging;
        private Point MousePos;
        private int _startingoffset;
        private double _fill;
        private FillType _fillmode;
        private Graphics g ;
        private bool _wrap;
        public Dial()
        {
            InitializeComponent();
            _value=0;
            _max = 359;
            _min = 0;
            _startingoffset = 0;
            _fillmode = FillType.Line;
            _fill = 1;
            _wrap = false;
            g = this.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            // g.TranslateTransform(100.0F, 0.0F);
            //g.RotateTransform(-90f);
            DrawControl();
        }
        public FillType FillMode { get { return _fillmode; } set { _fillmode = value; DrawControl(); } }
        public int Value
        {
            get { return _value; }
            set
            {
                int newvalue = value;
                if (value < _min) newvalue = _min;
                if (value > _max) newvalue = _max;
                _value = newvalue; 
                DrawControl();
                ValueChanged(this, new EventArgs());
            }
        }
        public int Max { get { return _max; } set { _max = value; DrawControl(); } }
        public int Min { get { return _min; } set { _min = value; DrawControl(); } }
        public bool Wrap { get { return _wrap; } set { _wrap = value; } }
        public int StartingOffset
        {
            get { return _startingoffset; }
            set
            {
                _startingoffset = value;
                if (_startingoffset < 0) _startingoffset = 0;
                if (_startingoffset > 359) _startingoffset = 359;
                DrawControl();
            }
        }
        public double Fill_Percentage
        {
            get { return _fill; }
            set
            {
                _fill = value;
                if (_fill > 1) _fill = 1;
                if (_fill < 0) _fill = 0;
                DrawControl();
            }
        }
        private void DrawControl()
        {
            if (g == null) g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen Outline = new Pen(Brushes.Black);

            Outline.Width = 1;

            Rectangle OuterRect = new Rectangle(1, 1, this.Width - 2, this.Height - 2);
            g.FillEllipse(SystemBrushes.Control, OuterRect);

            g.DrawEllipse(Outline, OuterRect);

            Point CenterPoint = new Point(this.Width / 2, this.Height / 2);
            Double Radius = this.Width / 2 - 2;

            double Arc = 2 * Math.PI / ((double)_max-_min);
            double X = CenterPoint.X + Radius * Math.Cos(Arc * (_fill * ((double)_value + (double)_startingoffset / 360d * (double)(_max - _min))));
            double Y = CenterPoint.Y + Radius * Math.Sin(Arc * (_fill * ((double)_value + (double)_startingoffset / 360d * (double)(_max - _min))));
            // Math.Sin(Arc * (Percentage * (i + StartDegree / 360 * Items.Count())));

            Point IndicatorPoint = new Point((int)X, (int)Y);
            if (_fillmode == FillType.Line)
            {
                g.DrawLine(Pens.DodgerBlue, CenterPoint, IndicatorPoint);
            }
            else
            {
                g.FillPie(Brushes.DodgerBlue, OuterRect, _startingoffset, (360f * (float)_value / (float)(_max - _min)));
            }
        }

        private void Dial_SizeChanged(object sender, EventArgs e)
        {
            DrawControl();
        }

        private void Dial_Load(object sender, EventArgs e)
        {
            DrawControl();
        }

        private void Dial_Paint(object sender, PaintEventArgs e)
        {
            DrawControl();
        }

        private void Dial_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left) ValueChanging = true;
            MousePos = Cursor.Position;
        }

        private void Dial_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left) ValueChanging = false;
        }

        private void Dial_MouseMove(object sender, MouseEventArgs e)
        {
            if (ValueChanging)
            {
                Point NewPoint = Cursor.Position;
                Cursor.Position = MousePos;
                int NewValue = this.Value;
                if (NewPoint.Y == MousePos.Y) return;
                NewValue -= (NewPoint.Y - MousePos.Y);
                int diff = (NewPoint.Y - MousePos.Y);
                if (NewValue > _max && !_wrap) NewValue = _max;
                if (NewValue > _max && _wrap) NewValue = _min;
                if (NewValue < _min && _wrap) NewValue = _max;
                if (NewValue < _min && !_wrap) NewValue = _min;
                this.Value = NewValue;
            }
        }
        public event EventHandler ValueChanged;
    }
}
