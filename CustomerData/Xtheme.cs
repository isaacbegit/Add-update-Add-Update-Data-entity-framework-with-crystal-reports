using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace CustomerData
{
    public class xVisualTheme : ContainerControl
    {
        private static List<WeakReference> __ENCList;

        private TextureBrush TopTexture;

        private TextureBrush InnerTexture;

        private Font drawFont;

        private Point MouseP;

        private bool Cap;

        private int MoveHeight;

        private int pos;

        private MouseState State;

        private bool AreCreated;

        [DebuggerNonUserCode]
        static xVisualTheme()
        {
            xVisualTheme.__ENCList = new List<WeakReference>();
        }

        public xVisualTheme()
        {
            List<WeakReference> _ENCList = xVisualTheme.__ENCList;
            Monitor.Enter(_ENCList);
            try
            {
                xVisualTheme.__ENCList.Add(new WeakReference(this));
            }
            finally
            {
                Monitor.Exit(_ENCList);
            }
            Color[] colorArray = new Color[] { Color.FromArgb(66, 64, 62), Color.FromArgb(63, 61, 59), Color.FromArgb(69, 67, 65) };
            this.TopTexture = Draw.NoiseBrush(colorArray);
            colorArray = new Color[] { Color.FromArgb(57, 53, 50), Color.FromArgb(56, 52, 49), Color.FromArgb(58, 55, 51) };
            this.InnerTexture = Draw.NoiseBrush(colorArray);
            this.drawFont = new Font("Arial", 11f, FontStyle.Bold);
            this.MouseP = new Point(0, 0);
            this.Cap = false;
            this.MoveHeight = 53;
            this.pos = 0;
            this.State = MouseState.None;
            this.AreCreated = false;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(46, 43, 40);
            this.DoubleBuffered = true;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.ParentForm.FormBorderStyle = FormBorderStyle.None;
            this.ParentForm.TransparencyKey = Color.Fuchsia;
            this.Dock = DockStyle.Fill;
            this.AreCreated = true;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Rectangle rectangle = new Rectangle(0, 0, this.Width, this.MoveHeight);
            if (e.Button == MouseButtons.Left & rectangle.Contains(e.Location))
            {
                this.Cap = true;
                this.MouseP = e.Location;
            }
            this.State = MouseState.Down;
            this.Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.State = MouseState.Over;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.State = MouseState.None;
            this.Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (this.Cap)
            {
                this.Parent.Location = Control.MousePosition - (Size)this.MouseP;
            }
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.Cap = false;
            this.State = MouseState.Over;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            base.OnPaint(e);
            graphics.Clear(Color.Fuchsia);
            Rectangle rectangle = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle rectangle1 = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle1, Color.FromArgb(66, 64, 63), Color.FromArgb(56, 54, 53), 90f);
            rectangle1 = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush(rectangle1, Color.FromArgb(80, 78, 77), Color.FromArgb(70, 68, 67), 90f);
            rectangle1 = new Rectangle(0, 0, checked(this.Width - 1), 53);
            LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(rectangle1, Color.FromArgb(15, Color.White), Color.FromArgb(100, Color.FromArgb(43, 40, 38)), 90f);
            LinearGradientBrush linearGradientBrush3 = new LinearGradientBrush(rectangle, Color.FromArgb(73, 71, 69), Color.FromArgb(69, 67, 64), 90f);
            graphics.FillRectangle(linearGradientBrush3, rectangle);
            Pen black = Pens.Black;
            rectangle1 = new Rectangle(0, 0, checked(this.Width - 1), checked(this.Height - 1));
            graphics.DrawRectangle(black, rectangle1);
            TextureBrush innerTexture = this.InnerTexture;
            rectangle1 = new Rectangle(10, 53, checked(this.Width - 21), checked(this.Height - 84));
            graphics.FillRectangle(innerTexture, rectangle1);
            Pen pen = Pens.Black;
            rectangle1 = new Rectangle(10, 53, checked(this.Width - 21), checked(this.Height - 84));
            graphics.DrawRectangle(pen, rectangle1);
            TextureBrush topTexture = this.TopTexture;
            rectangle1 = new Rectangle(0, 0, checked(this.Width - 1), 53);
            graphics.FillRectangle(topTexture, rectangle1);
            rectangle1 = new Rectangle(0, 0, checked(this.Width - 1), 53);
            graphics.FillRectangle(linearGradientBrush2, rectangle1);
            Pen black1 = Pens.Black;
            rectangle1 = new Rectangle(0, 0, checked(this.Width - 1), 53);
            graphics.DrawRectangle(black1, rectangle1);
            ColorBlend colorBlend = new ColorBlend();
            Color[] colorArray = new Color[] { Color.FromArgb(10, Color.White), Color.FromArgb(10, Color.Black), Color.FromArgb(10, Color.White) };
            colorBlend.Colors = colorArray;
            colorBlend.Positions = new float[] { 0f, 0.7f, 1f };
            Rectangle rectangle2 = new Rectangle(0, 0, checked(this.Width - 1), 53);
            using (LinearGradientBrush linearGradientBrush4 = new LinearGradientBrush(rectangle2, Color.White, Color.Black, LinearGradientMode.Vertical))
            {
                linearGradientBrush4.InterpolationColors = colorBlend;
                graphics.FillRectangle(linearGradientBrush4, rectangle2);
            }
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(173, 172, 172)), 4, 1, checked(this.Width - 5), 1);
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(110, 109, 107)), 11, checked(this.Height - 30), checked(this.Width - 12), checked(this.Height - 30));
            graphics.FillRectangle(Draw.GetBrush(Color.FromArgb(173, 172, 172)), 3, 2, 1, 1);
            graphics.FillRectangle(Draw.GetBrush(Color.FromArgb(133, 132, 132)), 2, 2, 1, 1);
            graphics.FillRectangle(Draw.GetBrush(Color.FromArgb(113, 112, 112)), 2, 3, 1, 1);
            graphics.FillRectangle(Draw.GetBrush(Color.FromArgb(83, 82, 82)), 1, 4, 1, 1);
            graphics.FillRectangle(Draw.GetBrush(Color.FromArgb(173, 172, 172)), checked(this.Width - 4), 2, 1, 1);
            graphics.FillRectangle(Draw.GetBrush(Color.FromArgb(133, 132, 132)), checked(this.Width - 3), 2, 1, 1);
            graphics.FillRectangle(Draw.GetBrush(Color.FromArgb(113, 112, 112)), checked(this.Width - 3), 3, 1, 1);
            graphics.FillRectangle(Draw.GetBrush(Color.FromArgb(83, 82, 82)), checked(this.Width - 2), 4, 1, 1);
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(91, 90, 89)), 1, 52, checked(this.Width - 2), 52);
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(40, 37, 34)), 11, 54, checked(this.Width - 12), 54);
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(45, 42, 39)), 11, 55, checked(this.Width - 12), 55);
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(50, 47, 44)), 11, 56, checked(this.Width - 12), 56);
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(50, 47, 44)), 11, checked(this.Height - 32), checked(this.Width - 12), checked(this.Height - 32));
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(52, 49, 46)), 11, checked(this.Height - 33), checked(this.Width - 12), checked(this.Height - 33));
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(54, 51, 48)), 11, checked(this.Height - 34), checked(this.Width - 12), checked(this.Height - 34));
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(59, 57, 55)), 1, 54, 9, 54);
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(64, 62, 60)), 1, 55, 9, 55);
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(73, 71, 69)), 1, 56, 9, 56);
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(59, 57, 55)), checked(this.Width - 10), 54, checked(this.Width - 2), 54);
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(64, 62, 60)), checked(this.Width - 10), 55, checked(this.Width - 2), 55);
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(73, 71, 69)), checked(this.Width - 10), 56, checked(this.Width - 2), 56);
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(59, 57, 55)), 1, 54, 1, checked(this.Height - 5));
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(64, 62, 60)), 2, 55, 2, checked(this.Height - 4));
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(73, 71, 69)), 3, 56, 3, checked(this.Height - 3));
            graphics.DrawLine(new Pen(linearGradientBrush), 1, 5, 1, 51);
            graphics.DrawLine(new Pen(linearGradientBrush1), 2, 5, 2, 51);
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(69, 67, 65)), 9, 56, 9, checked(this.Height - 31));
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(59, 57, 55)), checked(this.Width - 2), 54, checked(this.Width - 2), checked(this.Height - 5));
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(64, 62, 60)), checked(this.Width - 3), 55, checked(this.Width - 3), checked(this.Height - 4));
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(73, 71, 69)), checked(this.Width - 4), 56, checked(this.Width - 4), checked(this.Height - 3));
            graphics.DrawLine(new Pen(linearGradientBrush), checked(this.Width - 2), 5, checked(this.Width - 2), 51);
            graphics.DrawLine(new Pen(linearGradientBrush1), checked(this.Width - 3), 5, checked(this.Width - 3), 51);
            graphics.DrawLine(Draw.GetPen(Color.FromArgb(69, 67, 65)), checked(this.Width - 10), 56, checked(this.Width - 10), checked(this.Height - 31));
            string text = this.Text;
            Font font = this.drawFont;
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 255, 255));
            rectangle1 = new Rectangle(0, 0, this.Width, 37);
            RectangleF rectangleF = rectangle1;
            StringFormat stringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            graphics.DrawString(text, font, solidBrush, rectangleF, stringFormat);
            graphics.FillRectangle(Brushes.Fuchsia, 0, 0, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 1, 0, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 2, 0, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 3, 0, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 0, 1, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 0, 2, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 0, 3, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 1, 1, 1, 1);
            graphics.FillRectangle(Brushes.Black, 1, 3, 1, 1);
            graphics.FillRectangle(Brushes.Black, 1, 2, 1, 1);
            graphics.FillRectangle(Brushes.Black, 2, 1, 1, 1);
            graphics.FillRectangle(Brushes.Black, 3, 1, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 1), 0, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 2), 0, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 3), 0, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 4), 0, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 1), 1, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 1), 2, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 1), 3, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 2), 1, 1, 1);
            graphics.FillRectangle(Brushes.Black, checked(this.Width - 2), 3, 1, 1);
            graphics.FillRectangle(Brushes.Black, checked(this.Width - 2), 2, 1, 1);
            graphics.FillRectangle(Brushes.Black, checked(this.Width - 3), 1, 1, 1);
            graphics.FillRectangle(Brushes.Black, checked(this.Width - 4), 1, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 0, checked(this.Height - 1), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 0, checked(this.Height - 2), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 0, checked(this.Height - 3), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 0, checked(this.Height - 4), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 1, checked(this.Height - 1), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 2, checked(this.Height - 1), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 3, checked(this.Height - 1), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 1, checked(this.Height - 1), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, 1, checked(this.Height - 2), 1, 1);
            graphics.FillRectangle(Brushes.Black, 1, checked(this.Height - 3), 1, 1);
            graphics.FillRectangle(Brushes.Black, 1, checked(this.Height - 4), 1, 1);
            graphics.FillRectangle(Brushes.Black, 3, checked(this.Height - 2), 1, 1);
            graphics.FillRectangle(Brushes.Black, 2, checked(this.Height - 2), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 1), this.Height, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 2), this.Height, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 3), this.Height, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 4), this.Height, 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 1), checked(this.Height - 1), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 1), checked(this.Height - 2), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 1), checked(this.Height - 3), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 2), checked(this.Height - 1), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 3), checked(this.Height - 1), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 4), checked(this.Height - 1), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 1), checked(this.Height - 4), 1, 1);
            graphics.FillRectangle(Brushes.Fuchsia, checked(this.Width - 2), checked(this.Height - 2), 1, 1);
            graphics.FillRectangle(Brushes.Black, checked(this.Width - 2), checked(this.Height - 3), 1, 1);
            graphics.FillRectangle(Brushes.Black, checked(this.Width - 2), checked(this.Height - 4), 1, 1);
            graphics.FillRectangle(Brushes.Black, checked(this.Width - 4), checked(this.Height - 2), 1, 1);
            graphics.FillRectangle(Brushes.Black, checked(this.Width - 3), checked(this.Height - 2), 1, 1);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (this.AreCreated)
            {
                Graphics graphic = this.CreateGraphics();
                Rectangle rectangle = new Rectangle(0, 0, this.Width, this.Height);
                this.OnPaint(new PaintEventArgs(graphic, rectangle));
                base.OnTextChanged(e);
            }
        }
    }
}