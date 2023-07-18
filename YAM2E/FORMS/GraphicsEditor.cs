using LAMP.Classes;
using LAMP.Classes.M2_Data;
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
    public GraphicsEditor(Tileset t)
    {
        InitializeComponent();
        construct();
        GraphicsPointer = t.GfxOffset;
        MetatilePointer = Editor.GetMetaPointerFromTable(t.MetatileTable);
        SetTilesets();
        grp_data_selector.Enabled = false;
    }

    public GraphicsEditor(Pointer Graphics, Pointer Metatiles = null)
    {
        InitializeComponent();
        construct();
        GraphicsPointer = Graphics;
        MetatilePointer = Metatiles;
        SetTilesets();
        grp_data_selector.Enabled = false;
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
        MetatileSet.MouseDown += new MouseEventHandler(MetatileSetMouseDown);
        MetatileSet.MouseMove += new MouseEventHandler(MetatileSetMouseMove);
        MetatileSet.MouseUp += new MouseEventHandler(MetatileSetMouseUp);

        //Setting zoom
        GraphicsSet.Zoom = toolbar_graphics.ZoomLevel;
    }

    #region Fields
    private TileViewer GraphicsSet = new TileViewer() { PixelTileSize = 8 };
    private TileViewer MetatileSet = new TileViewer();
    private GFX LoadedGFX;
    private Metatiles LoadedMeta;

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
            LoadedGFX = null;
            GraphicsSet.BackgroundImage = b;
            MetatileSet.BackgroundImage = b;
            return;
        }

        LoadedGFX = new GFX(GraphicsPointer, GfxWidth, GfxHeight);
        txb_offset.Text = Format.PointerToString(GraphicsPointer);

        //Graphics View
        LoadedGFX.Draw();
        GraphicsSet.BackgroundImage = LoadedGFX.Image;

        //Metatile View
        if (MetatilePointer != null)
        {
            LoadedMeta = new Metatiles(LoadedGFX, MetatilePointer);
            LoadedMeta.Draw();
            MetatileSet.BackgroundImage = LoadedMeta.Image;
            txb_meta_offset.Text = Format.PointerToString(metatilePointer);
        }
        else
        {
            LoadedMeta = null;
            MetatileSet.BackgroundImage = new Bitmap(1, 1);
        }
    }

    #region Graphics View
    private void GraphicsSetMouseDown(object sender, MouseEventArgs e)
    {
        //The currently selected pixel
        Point pixel = new Point(Math.Max(Math.Min(e.X, GraphicsSet.BackgroundImage.Width * GraphicsSet.Zoom - 1), 0) / GraphicsSet.Zoom, Math.Max(Math.Min(e.Y, GraphicsSet.BackgroundImage.Height * GraphicsSet.Zoom - 1), 0) / GraphicsSet.Zoom);
        Point tileNum = new Point(pixel.X / GraphicsSet.PixelTileSize, pixel.Y / GraphicsSet.PixelTileSize); //The number of the tile selected
        Point tile = new Point(tileNum.X * GraphicsSet.PixelTileSize, tileNum.Y * GraphicsSet.PixelTileSize); //The room coordinates of the selected tile

        if (LoadedGFX == null) return;

        switch (toolbar_graphics.SelectedTool)
        {
            case LampTool.Pen:

                //place down pixel
                LoadedGFX.SetPixel(pixel, 3);
                int changedTile = LoadedGFX.GetTileID(pixel.X, pixel.Y);

                //update metatiles
                List<Rectangle> MetaInvalid = LoadedMeta.RedrawTile(changedTile);

                //invalidate the the drawn pixel
                GraphicsSet.Invalidate(RecOp.Multiply(new Rectangle(pixel.X, pixel.Y, 1, 1), GraphicsSet.Zoom));
                foreach (Rectangle r in MetaInvalid) MetatileSet.Invalidate(RecOp.Multiply(r, MetatileSet.Zoom));

                break;

            case LampTool.Move:
                break;
        }
    }
    private void GraphicsSetMouseMove(object sender, MouseEventArgs e)
    {
        //The currently selected pixel
        Point pixel = new Point(Math.Max(Math.Min(e.X, GraphicsSet.BackgroundImage.Width * GraphicsSet.Zoom - 1), 0) / GraphicsSet.Zoom, Math.Max(Math.Min(e.Y, GraphicsSet.BackgroundImage.Height * GraphicsSet.Zoom - 1), 0) / GraphicsSet.Zoom);
        Point tileNum = new Point(pixel.X / GraphicsSet.PixelTileSize, pixel.Y / GraphicsSet.PixelTileSize); //The number of the tile selected
        Point tile = new Point(tileNum.X * GraphicsSet.PixelTileSize, tileNum.Y * GraphicsSet.PixelTileSize); //The room coordinates of the selected tile

        //General Mouse moving Code here:

        //Click moving code here:
        if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right) return;
        LoadedGFX?.SetPixel(pixel, 3);
        GraphicsSet.Invalidate(RecOp.Multiply(new Rectangle(pixel.X, pixel.Y, 1, 1), GraphicsSet.Zoom));
    }
    private void GraphicsSetMouseUp(object sender, MouseEventArgs e)
    {

    }
    #endregion

    #region Metatile View
    private void MetatileSetMouseDown(object sender, MouseEventArgs e) { }
    private void MetatileSetMouseMove(object sender, MouseEventArgs e) { }
    private void MetatileSetMouseUp(object sender, MouseEventArgs e) { }

    #endregion

    #endregion

    private void btn_accept_Click(object sender, EventArgs e)
    {
        //Checking if width * height will be out of bounds in ROM
        int width = (int)num_width.Value;
        int height = (int)num_height.Value;

        if (width * height * 16 + Format.StringToPointer(txb_offset.Text).Offset >= Editor.ROM.Size) //16 because one tile is 16 bytes
        {
            MessageBox.Show("End of ROM reached!\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        GraphicsPointer = txb_offset.Text == "" ? null : Format.StringToPointer(txb_offset.Text);
        MetatilePointer = txb_meta_offset.Text == "" ? null : Format.StringToPointer(txb_meta_offset.Text);

        GfxWidth = width;
        GfxHeight = height;

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

    private void btn_apply_Click(object sender, EventArgs e)
    {
        if (LoadedGFX != null) Editor.AddDataChunk((DataChunk)LoadedGFX);
        if (LoadedMeta != null) Editor.AddDataChunk((DataChunk)LoadedMeta);
    }
}
