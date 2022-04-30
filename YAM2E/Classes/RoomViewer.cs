using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace YAM2E.Classes;

public class RoomViewer : Control
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

    //TODO:unused?
    public bool HasSelection => SelRect.X != -1; //Selection rectangle doesn't have a negative x value

    public bool ShowScreenOutlines { get; set; } = false;

    public int SelectedScreen { get; set; } = 0;
    private int SelectedScreenOld = 0;
    private List<Rectangle> UniqueScreen { get; } = new List<Rectangle>();

    //Rectangles
    //Red selection rectangle
    public Rectangle RedRect { get; set; }
    private Pen TilePen { get; set; } = new Pen(Globals.CTileSelector, 1);

    //selection rectangle
    public Rectangle SelRect { get; set; }
    private Pen SelectionPen { get; set; } = new Pen(Globals.CTileSelection, 1);

    //screen outline rectangle
    //TODO:unused?
    private Rectangle ScreenRect { get; set; } = new Rectangle();
    private Pen ScreenPen { get; set; } = new Pen(Color.White, 2);
    private Pen UniqueScreenPen { get; set; } = new Pen(Globals.CTileSelector, 2);

    //TODO:unused?
    private Pen BlackPen { get; set; } = new Pen(Color.Black, 1);

    public void ResetSelection()
    {
        RedRect = new Rectangle(-1, -1, 0, 0);
        SelRect = new Rectangle(-1, -1, 0, 0);
    }

    public RoomViewer()
    {
        //SetStyle(ControlStyles.Opaque, true);
        SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        SuspendLayout();
        ResumeLayout(false);
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        BackColor = Color.FromArgb(40, 50, 50);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        //change render settings
        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
        e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

        if (RedRect.X != -1)
            e.Graphics.DrawRectangle(TilePen, RedRect);

        //Screen Outlines
        if (SelectedScreen != SelectedScreenOld)
        {
            //invalidating old outlines
            if (UniqueScreen.Count != 0)
            {
                Rectangle rect = UniqueScreen[0];
                foreach (Rectangle r in UniqueScreen)
                    rect = Editor.UniteRect(rect, r);

                this.Invalidate(Editor.SetValSize(rect));
            }

            UniqueScreen.Clear();
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Rectangle rect = new Rectangle(256 * i, 256 * j, 255, 255);
                    if (Globals.AreaScreens[i, j] != SelectedScreen)
                        continue;
                    UniqueScreen.Add(rect);
                    this.Invalidate(Editor.SetValSize(rect));
                }
            }

            SelectedScreenOld = SelectedScreen;
        }

        //screen outlines
        if (ShowScreenOutlines)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Rectangle rect = new Rectangle(256 * i, 256 * j, 255, 255);
                    e.Graphics.DrawRectangle(ScreenPen, rect);
                }
            }
        }

        //Draw Unique Screen outlines
        if (UniqueScreen.Count != 0)
        {
            foreach (Rectangle r in UniqueScreen)
                e.Graphics.DrawRectangle(UniqueScreenPen, r);
        }

        if (SelRect.X == -1 || !SelRect.IntersectsWith(e.ClipRectangle))
            return;
        e.Graphics.DrawRectangle(SelectionPen, SelRect);
        base.OnPaint(e);
    }
}