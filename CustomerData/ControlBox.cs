using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;

namespace CustomerData
{
    public class RedemptionControlBox : Control
    {
        private static List<WeakReference> __ENCList;

        private RedemptionControlBox.ButtonHover ButtonState;

        [DebuggerNonUserCode]
        static RedemptionControlBox()
        {
            RedemptionControlBox.__ENCList = new List<WeakReference>();
        }

        public RedemptionControlBox()
        {
            List<WeakReference> _ENCList = RedemptionControlBox.__ENCList;
            Monitor.Enter(_ENCList);
            try
            {
                RedemptionControlBox.__ENCList.Add(new WeakReference(this));
            }
            finally
            {
                Monitor.Exit(_ENCList);
            }
            this.ButtonState = RedemptionControlBox.ButtonHover.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.ForeColor = Color.White;
            this.BackColor = Color.Transparent;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.ButtonState = RedemptionControlBox.ButtonHover.None;
            this.Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int x = e.Location.X;
            int y = e.Location.Y;
            if ((y <= 0 || y >= checked(this.Height - 2) ? true : false))
            {
                this.ButtonState = RedemptionControlBox.ButtonHover.None;
            }
            else if ((x <= 0 || x >= 30 ? false : true))
            {
                this.ButtonState = RedemptionControlBox.ButtonHover.Minimize;
            }
            else if ((x <= 31 || x >= this.Width ? true : false))
            {
                this.ButtonState = RedemptionControlBox.ButtonHover.None;
            }
            else
            {
                this.ButtonState = RedemptionControlBox.ButtonHover.Close;
            }
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            switch (this.ButtonState)
            {
                case RedemptionControlBox.ButtonHover.Minimize:
                    {
                        this.Parent.FindForm().WindowState = FormWindowState.Minimized;
                        break;
                    }
                case RedemptionControlBox.ButtonHover.Maximize:
                    {
                        this.Parent.FindForm().WindowState = FormWindowState.Maximized;
                        break;
                    }
                case RedemptionControlBox.ButtonHover.Close:
                    {
                        this.Parent.FindForm().Close();
                        ProjectData.EndApp();
                        break;
                    }
            }
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics;
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            Graphics graphic = Graphics.FromImage(bitmap);
            graphic.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            base.OnPaint(e);
            graphic.Clear(this.BackColor);
            Font font = new Font("Marlett", 10f);
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(200, 200, 200));
            Point point = new Point(checked(this.Width - 16), 7);
            PointF pointF = point;
            StringFormat stringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center
            };
            graphic.DrawString("r", font, solidBrush, pointF, stringFormat);
            SolidBrush solidBrush1 = new SolidBrush(Color.FromArgb(200, 200, 200));
            point = new Point(20, 7);
            PointF pointF1 = point;
            stringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center
            };
            graphic.DrawString("0", font, solidBrush1, pointF1, stringFormat);
            switch (this.ButtonState)
            {
                case RedemptionControlBox.ButtonHover.Minimize:
                    {
                        SolidBrush solidBrush2 = new SolidBrush(Color.White);
                        point = new Point(20, 7);
                        PointF pointF2 = point;
                        stringFormat = new StringFormat()
                        {
                            Alignment = StringAlignment.Center
                        };
                        graphic.DrawString("0", font, solidBrush2, pointF2, stringFormat);
                        graphics = e.Graphics;
                        point = new Point(0, 0);
                        graphics.DrawImage(bitmap, point);
                        graphic.Dispose();
                        bitmap.Dispose();
                        return;
                    }
                case RedemptionControlBox.ButtonHover.Maximize:
                    {
                        graphics = e.Graphics;
                        point = new Point(0, 0);
                        graphics.DrawImage(bitmap, point);
                        graphic.Dispose();
                        bitmap.Dispose();
                        return;
                    }
                case RedemptionControlBox.ButtonHover.Close:
                    {
                        SolidBrush solidBrush3 = new SolidBrush(Color.White);
                        point = new Point(checked(this.Width - 16), 7);
                        PointF pointF3 = point;
                        stringFormat = new StringFormat()
                        {
                            Alignment = StringAlignment.Center
                        };
                        graphic.DrawString("r", font, solidBrush3, pointF3, stringFormat);
                        graphics = e.Graphics;
                        point = new Point(0, 0);
                        graphics.DrawImage(bitmap, point);
                        graphic.Dispose();
                        bitmap.Dispose();
                        return;
                    }
                default:
                    {
                        graphics = e.Graphics;
                        point = new Point(0, 0);
                        graphics.DrawImage(bitmap, point);
                        graphic.Dispose();
                        bitmap.Dispose();
                        return;
                    }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(60, 25);
        }

        public enum ButtonHover
        {
            Minimize,
            Maximize,
            Close,
            None
        }
    }
}