using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace YAM2E.Classes
{
    public class TileViewer : Control
    {
        public override Image BackgroundImage
        {
            get => base.BackgroundImage;
            set
            {
                base.BackgroundImage = value;
                Size = base.BackgroundImage.Size;
            }
        }
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        public bool HasSelection => SelRect.X != -1;

        public Rectangle RedRect { get; set; }
        private Pen RedPen { get; set; } = new Pen(Color.Red, 1);

        public Rectangle SelRect { get; set; }
        private Pen WhitePen { get; set; } = new Pen(Color.White, 1);

        private Pen BlackPen { get; set; } = new Pen(Color.Black, 1);

        public TileViewer()
        {
            SuspendLayout();
            ResumeLayout(false);
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            BackColor = Color.FromArgb(40, 50, 50);
        }

        public void Reset()
        {
            RedRect = new Rectangle(-1, -1, 31, 31);
            SelRect = new Rectangle(-1, -1, 31, 31);
        }
        public void MoveRed(int x, int y) => RedRect = new Rectangle(x << 5, y << 5, 31, 31);

        public void ResizeSelection(Rectangle rect) => SelRect = new Rectangle(rect.X << 5, rect.Y << 5, (rect.Width << 5) - 1, (rect.Height << 5) - 1);

        protected override void OnPaint(PaintEventArgs e)
        {
            if (RedRect.X != -1)
                e.Graphics.DrawRectangle(RedPen, RedRect);
            if (SelRect.X == -1 || !SelRect.IntersectsWith(e.ClipRectangle))
                return;
            e.Graphics.DrawRectangle(BlackPen, SelRect);
            e.Graphics.DrawRectangle(WhitePen, SelRect);
            base.OnPaint(e);
        }
    }
}
