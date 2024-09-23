using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airlane
{
    public class RoundBTN : Button
    {
        public int Radius { get; set; } = 30;
        StringFormat SF = new StringFormat();

        private bool MouseEntered = false;
        private bool MousePressed = false;

        public delegate void roundBTNClickHandler(object sender, EventArgs e);

        public event roundBTNClickHandler roundBTNClick;
        public RoundBTN()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserPaint,
                true
            );

            DoubleBuffered = true;
            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;

            this.Click += roundBTN_Click;
        }

        private void roundBTN_Click(object sender, EventArgs e)
        {
            // Вызываем пользовательское событие CustomClick
            roundBTNClick?.Invoke(sender, e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;

            Invalidate();
        }

        

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = false;

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.Clear(Parent.BackColor);
            g.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            GraphicsPath rectGp = RoundedRectangle(rect);

            g.FillPath(new SolidBrush(BackColor), rectGp);
            g.DrawPath(new Pen(ForeColor, 1), rectGp);
            g.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);

            if (MouseEntered)
            {
                g.FillPath(new SolidBrush(Color.FromArgb(50, Color.Blue)), rectGp);
            }
        }

        GraphicsPath RoundedRectangle(Rectangle rect)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, Radius, Radius, 180, 90);
            gp.AddArc(rect.X + rect.Width - Radius, rect.Y, Radius, Radius, 270, 90);
            gp.AddArc(rect.X + rect.Width - Radius, rect.Y + rect.Height - Radius, Radius, Radius, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - Radius, Radius, Radius, 90, 90);

            gp.CloseFigure();

            return gp;
        }
    }
}
