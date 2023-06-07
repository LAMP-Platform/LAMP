using System.Windows.Forms;
using System.Drawing;
using LAMP.Classes;
using LAMP.Controls.Room;
using System;

namespace LAMP.Controls;

public class TileViewer : Control
{
    public override Image BackgroundImage
    {
        get => base.BackgroundImage;
        set
        {
            if (base.BackgroundImage != null) base.BackgroundImage.Dispose();
            base.BackgroundImage = value;
            if (BackgroundImage != null) Size = base.BackgroundImage.Size * zoom;
        }
    }

    #region Fields
    /// <summary>
    /// The tool that is selected from the Toolbar
    /// </summary>
    public LampTool SelectedTool
    {
        get => selectedTool;
        set
        {
            selectedTool = value;
        }
    }
    private LampTool selectedTool = LampTool.Select;

    /// <summary>
    /// The mutliplier by which everything gets zoomed
    /// </summary>
    public int Zoom { 
        get => zoom;
        set
        {
            //setting rectangles
            ResetSelection();

            zoom = Math.Max(value, 1);
            if (BackgroundImage != null) Size = BackgroundImage.Size * zoom;
        }
    }
    private int zoom = 1;

    /// <summary>
    /// The amount of pixels that represent one in-game <see cref="PixelTileSize"/>.
    /// </summary>
    public int TileSize => PixelTileSize * zoom;

    /// <summary>
    /// The amount of pixels that a tile is made of.
    /// </summary>
    public int PixelTileSize { get; set; } = 16;

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
        RedRect = new Rectangle(-1, -1, 0, 0);
        SelRect = new Rectangle(-1, -1, 0, 0);
    }

    public TileViewer()
    {
        SuspendLayout();
        ResumeLayout(false);
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        BackColor = Color.FromArgb(0xF0, 0xF0, 0xF0);

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