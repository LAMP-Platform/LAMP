using System.Windows.Forms;
using System.Drawing;
using LAMP.Classes;

namespace LAMP.Controls;

public class TileViewer : Control
{
    //TODO: why override?
    public override Image BackgroundImage
    {
        get => base.BackgroundImage;
        set
        {
            base.BackgroundImage = value;
            Size = base.BackgroundImage.Size * zoom;
        }
    }

    #region Fields
    /// <summary>
    /// The mutliplier by which everything gets zoomed
    /// </summary>
    public int Zoom { 
        get
        {
            return zoom;
        }
        set
        {
            zoom = value;
            Size = BackgroundImage.Size * zoom;
        }
    }
    private int zoom = 1;

    /// <summary>
    /// The rectangle that shows under the currently selected tile
    /// </summary>
    public Rectangle RedRect {
        get => redRect;
        set
        {
            if (redRect == value) return;

            Rectangle old = redRect;
            redRect = value;

            Invalidate(Editor.UniteRect(redRect, old));
        }
    }
    private Rectangle redRect = new Rectangle(-1, -1, 0, 0);

    /// <summary>
    /// The rectangle that shows the selected area
    /// </summary>
    public Rectangle SelRect
    {
        get => selRect;
        set
        {
            if (selRect == value) return;

            Rectangle old = selRect;
            selRect = value;

            Invalidate(Editor.UniteRect(selRect, old));
        }
    }
    private Rectangle selRect = new Rectangle(-1, -1, 0, 0);
    #endregion

    //Pens
    private Pen SelectionPen { get; set; } = new Pen(Globals.SelectionColor, 1);
    private Pen TilePen { get; set; } = new Pen(Globals.SelectedColor, 1);
    private Pen BlackPen { get; set; } = new Pen(Color.Black, 1);

    public void ResetSelection()
    {
        redRect = new Rectangle(-1, -1, 0, 0);
        SelRect = new Rectangle(-1, -1, 0, 0);
    }

    public TileViewer()
    {
        SuspendLayout();
        ResumeLayout(false);
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        BackColor = Color.FromArgb(40, 50, 50);

        BackgroundImageLayout = ImageLayout.Stretch;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (redRect.X != -1) e.Graphics.DrawRectangle(TilePen, redRect);
        if (selRect.X == -1 || !selRect.IntersectsWith(e.ClipRectangle)) return;

        //Dash pattern
        SelectionPen.DashPattern = BlackPen.DashPattern = new float[] { 2, 3 };
        BlackPen.DashOffset = 2;
        e.Graphics.DrawRectangle(BlackPen, selRect);
        e.Graphics.DrawRectangle(SelectionPen, selRect);
        base.OnPaint(e);
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        pevent.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
        pevent.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
        base.OnPaintBackground(pevent);
    }
}