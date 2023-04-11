using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using LAMP.Classes;
using System.Security.Cryptography;

namespace LAMP.Controls;

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

    public RoomViewer()
    {
        DoubleBuffered = true;
        SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        SuspendLayout();
        ResumeLayout(false);
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        BackColor = Color.FromArgb(40, 50, 50);
        BackgroundImageLayout = ImageLayout.Stretch;
    }

    public bool ShowScreenOutlines { get; set; } = false;
    public bool ShowDuplicateOutlines { get; set; } = true;
    public bool ShowScrollBorders { get; set; } = false;
    public bool ShowObjects { get; set; } = true;

    public int SelectedScreen { get; set; } = 0;
    private int SelectedScreenOld = 0;
    private List<Rectangle> UniqueScreen { get; } = new List<Rectangle>();

    #region Rectangles
    /// <summary>
    /// The rectangle showing the area which is going to be replaced if tiles are placed down
    /// </summary>
    public Rectangle RedRect
    {
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
    /// The rectangle that shows the selected tile
    /// </summary>
    public Rectangle CursorRect
    {
        get => cursorRect;
        set
        {
            if (cursorRect == value) return;

            Rectangle old = cursorRect;
            cursorRect = value;

            Invalidate(Editor.UniteRect(cursorRect, old));
        }
    }
    private Rectangle cursorRect = new Rectangle(-1, -1, 0, 0);

    /// <summary>
    /// The rectangle showing the selected tiles in the room
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

    /// <summary>
    /// Rectangle for the current held object
    /// </summary>
    public Rectangle HeldObject
    {
        get => heldObject;
        set
        {
            if (heldObject == value) return;

            Rectangle old = heldObject;
            heldObject = value;

            Invalidate(Editor.UniteRect(heldObject, old));
}
    }
    private Rectangle heldObject = new Rectangle(-1, -1, -1, -1);
    #endregion

    #region Pens
    /// <summary>
/// Pen for the selection rectangle
/// </summary>
    private Pen SelectionPen { get; set; } = new Pen(Globals.SelectionColor, 1);

    /// <summary>
    /// Pen for screen outlines
    /// </summary>
    private Pen ScreenPen { get; set; } = new Pen(Color.White, 1)
    {
        Alignment = PenAlignment.Inset
    };

    /// <summary>
    /// Pen for the unique screen outlines
    /// </summary>
    private Pen UniqueScreenPen { get; set; } = new Pen(Globals.UniqueScreenColor, 2)
    { 
        Alignment = PenAlignment.Inset
    };

    /// <summary>
    /// Pen for the scroll outlines
    /// </summary>
    private Pen BorderOutlinePen { get; set; } = new Pen(Globals.BorderColor, 2)
    {
        Alignment = PenAlignment.Inset
    };

    /// <summary>
    /// Just a black Pen
    /// </summary>
    private Pen BlackPen { get; set; } = new Pen(Color.Black, 1);

    /// <summary>
    /// Pen for the tile placement outlines
    /// </summary>
    private Pen TilePen { get; set; } = new Pen(Globals.SelectedColor, 1);

    //Objects
    /// <summary>
    /// Pen for Objects
    /// </summary>
    private Pen ObjectPen { get; set; } = new Pen(Globals.ObjectColor, 2)
    {
        Alignment = PenAlignment.Inset
    };
    #endregion

    public void ResetSelection()
    {
        RedRect = new Rectangle(-1, -1, 0, 0);
        SelRect = new Rectangle(-1, -1, 0, 0);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        //change render settings
        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

        if (redRect.X != -1 && MainWindow.EditingTiles) e.Graphics.DrawRectangle(TilePen, redRect);
        if (!MainWindow.EditingTiles) e.Graphics.DrawRectangle(TilePen, cursorRect);

        //duplicate Screen Outlines
        if (SelectedScreen != SelectedScreenOld && ShowDuplicateOutlines)
        {
            //invalidating old outlines
            if (UniqueScreen.Count != 0)
            {
                Rectangle rect = UniqueScreen[0];
                foreach (Rectangle r in UniqueScreen)
                    rect = Editor.UniteRect(rect, r);

                Invalidate(Editor.SetValSize(rect));
            }

            UniqueScreen.Clear();
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Rectangle rect = new Rectangle(256 * i + 2, 256 * j + 2, 252, 252);
                    int nr = j * 16 + i;
                    if (Globals.Areas[Globals.SelectedArea].Screens[nr] != SelectedScreen)
                        continue;
                    UniqueScreen.Add(rect);
                    Invalidate(Editor.SetValSize(rect));
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
                    Rectangle rect = new Rectangle(256 * i, 256 * j, 256, 256);
                    e.Graphics.DrawRectangle(ScreenPen, rect);
                }
            }
        }

        //screen borders
        if (ShowScrollBorders)
        {
            foreach (Rectangle r in Globals.ScrollBorders)
                e.Graphics.DrawRectangle(BorderOutlinePen, r);
        }

        //Draw Unique Screen outlines
        if (UniqueScreen.Count != 0 && ShowDuplicateOutlines)
        {
            foreach (Rectangle r in UniqueScreen)
                e.Graphics.DrawRectangle(UniqueScreenPen, r);
        }

        //Draw held object
        if (MainWindow.heldObject != null)
        {
            e.Graphics.DrawEllipse(ObjectPen, heldObject);
        }

        //Draw objects
        if (ShowObjects)
        {
            for(int i = 0; i < 256; i++)
            {
                int screen = i + 256 * Globals.SelectedArea;
                if (Globals.Objects[screen].Count == 0) continue;

                foreach (Enemy o in Globals.Objects[screen]) 
                {
                    Point p = o.GetPosition(i);
                    Rectangle rec = new Rectangle(p.X, p.Y, 15, 15);
                    e.Graphics.DrawEllipse(ObjectPen, rec);
                    //e.Graphics.DrawRectangle(ObjectPen, rec);
                    //TODO: Add option to switch been circle and rect
                }
            }
        }

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