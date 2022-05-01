using System.Windows.Forms;
using System.Drawing;

namespace YAM2E.Classes;

public class TileViewer : Control
{
    //TODO: why override?
    public override Image BackgroundImage
    {
        get => base.BackgroundImage;
        set
        {
            base.BackgroundImage = value;
            Size = base.BackgroundImage.Size;
        }
    }

    //TODO:unused?
    public bool HasSelection => SelRect.X != -1; //Selection rectangle doesn't have a negative x value

    public Rectangle RedRect { get; set; }
    private Pen TilePen { get; set; } = new Pen(Globals.SelectedColor, 1);

    public Rectangle SelRect { get; set; }
    private Pen SelectionPen { get; set; } = new Pen(Globals.SelectionColor, 1);

    //TODO:unused?
    private Pen BlackPen { get; set; } = new Pen(Color.Black, 1);

    public void ResetSelection()
    {
        RedRect = new Rectangle(-1, -1, 0, 0);
        SelRect = new Rectangle(-1, -1, 0, 0);
    }

    public TileViewer()
    {
        SuspendLayout();
        ResumeLayout(false);
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        BackColor = Color.FromArgb(40, 50, 50);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (RedRect.X != -1)
            e.Graphics.DrawRectangle(TilePen, RedRect);
        if (SelRect.X == -1 || !SelRect.IntersectsWith(e.ClipRectangle))
            return;

        SelectionPen.DashPattern = BlackPen.DashPattern = new float[] { 2, 3 };
        BlackPen.DashOffset = 2;
        e.Graphics.DrawRectangle(BlackPen, SelRect);
        e.Graphics.DrawRectangle(SelectionPen, SelRect);
        base.OnPaint(e);
    }
}