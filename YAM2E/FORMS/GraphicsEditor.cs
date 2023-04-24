using LAMP.Classes;
using LAMP.Controls;
using LAMP.Controls.Room;
using LAMP.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP.FORMS;

public partial class GraphicsEditor : Form
{
    private TileViewer GraphicsSet = new TileViewer();
    private TileViewer MetatileSet = new TileViewer();

    public GraphicsEditor(Tileset t)
    {
        InitializeComponent();
        construct();
    }

    public GraphicsEditor(Pointer Graphics, Pointer Metatiles = null)
    {
        InitializeComponent();
        construct();
        GraphicsPointer = Graphics;
        MetatilePointer = Metatiles;
        SetTilesets();
    }

    public GraphicsEditor()
    {
        InitializeComponent();
        construct();
    }

    private void construct()
    {
        //Adding the TileViewer for Graphics
        flw_graphics_view.Controls.Add(GraphicsSet);
        GraphicsSet.MouseDown += new MouseEventHandler(GraphicsSetMouseDown);
        GraphicsSet.MouseMove += new MouseEventHandler(GraphicsSetMouseMove);
        GraphicsSet.MouseUp += new MouseEventHandler(GraphicsSetMouseUp);

        //Adding the TileViewer for Metatiles
        flw_metatile_view.Controls.Add(MetatileSet);
    }

    #region Fields

    public Pointer GraphicsPointer
    {
        get => graphicsPointer;
        set
        {
            graphicsPointer = value;
        }
    }
    private Pointer graphicsPointer;

    public Pointer MetatilePointer
    {
        get => metatilePointer;
        set
        {
            metatilePointer = value;
        }
    }
    private Pointer metatilePointer;

    public int GfxWidth { get; set; } = 16;
    public int GfxHeight { get; set; } = 8;

    #endregion

    #region Methods

    private void SetTilesets()
    {
        if (GraphicsPointer == null)
        {
            Bitmap b = new(1, 1); //This clears the images
            if (GraphicsSet.BackgroundImage != null) GraphicsSet.BackgroundImage.Dispose();
            GraphicsSet.BackgroundImage = b;
            if (MetatileSet.BackgroundImage != null) MetatileSet.BackgroundImage.Dispose();
            MetatileSet.BackgroundImage = b;
            return;
        }

        //Graphics View
        if (GraphicsSet.BackgroundImage != null) GraphicsSet.BackgroundImage.Dispose();
        Bitmap GFXBitmap = new Bitmap(GfxWidth * 8, GfxHeight * 8);
        Editor.DrawTile8Set(graphicsPointer.Offset, GFXBitmap, new Point(0, 0), GfxWidth, GfxHeight);
        GraphicsSet.BackgroundImage = GFXBitmap;

        //Metatile View
        if (MetatileSet.BackgroundImage != null) MetatileSet.BackgroundImage.Dispose();
        if (MetatilePointer != null) MetatileSet.BackgroundImage = Editor.DrawTileSet(GraphicsPointer, MetatilePointer, 16, 8, false);
        else MetatileSet.BackgroundImage = new Bitmap(1, 1);
    }

    #region Graphics View
    private void GraphicsSetMouseDown(object sender, MouseEventArgs e)
    {

    }
    private void GraphicsSetMouseMove(object sender, MouseEventArgs e)
    {

    }
    private void GraphicsSetMouseUp(object sender, MouseEventArgs e)
    {

    }
    #endregion

    #endregion

    private void btn_accept_Click(object sender, EventArgs e)
    {
        GraphicsPointer = txb_offset.Text == "" ? null : Format.StringToPointer(txb_offset.Text);
        MetatilePointer = txb_meta_offset.Text == "" ? null : Format.StringToPointer(txb_meta_offset.Text);

        SetTilesets();
    }

    /// <summary>
    /// Toolbar for the GFX Editor
    /// </summary>
    private void toolbar_graphics_ToolCommandTriggered(object sender, EventArgs e)
    {
        switch (toolbar_graphics.TriggeredCommand)
        {
            case (LampToolCommand.ZoomIn):
            case (LampToolCommand.ZoomOut):
                GraphicsSet.Zoom = toolbar_graphics.ZoomLevel;
                break;
        }
    }

    /// <summary>
    /// Toolbar for the Metatile Editor
    /// </summary>
    private void toolbar_metatiles_ToolCommandTriggered(object sender, EventArgs e)
    {
        switch (toolbar_metatiles.TriggeredCommand)
        {
            case (LampToolCommand.ZoomIn):
            case (LampToolCommand.ZoomOut):
                MetatileSet.Zoom = toolbar_metatiles.ZoomLevel;
                break;
        }
    }
}
