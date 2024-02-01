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
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP.FORMS;

public partial class GraphicsEditor : Form
{
    #region Constructor
    public GraphicsEditor(Tileset t)
    {
        InitializeComponent();
        construct();
        GraphicsPointer = t.GfxOffset;
        MetatilePointer = Editor.GetMetaPointerFromTable(t.MetatileTable);
        SetTilesets();
        HideDataControl();
    }

    public GraphicsEditor(Pointer Graphics, Pointer Metatiles = null)
    {
        InitializeComponent();
        construct();
        GraphicsPointer = Graphics;
        MetatilePointer = Metatiles;
        SetTilesets();
        HideDataControl();
    }

    public GraphicsEditor()
    {
        InitializeComponent();
        construct();
    }

    private void construct()
    {
        //Adding the TileViewer for Graphics
        pnl_graphics_view.Controls.Add(GraphicsSet);
        GraphicsSet.Location = new Point(3, 3);
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

    private void HideDataControl()
    {
        pnl_main.Panel1Collapsed = true;
        pnl_main.Panel1.Hide();
        pnl_main.IsSplitterFixed = true;
    }
    #endregion

    #region Fields
    //Data display fields
    private TileViewer GraphicsSet = new TileViewer() { PixelTileSize = 8 };
    private TileViewer MetatileSet = new TileViewer() { PixelTileSize = 8 };
    private GFX LoadedGFX;
    private Metatiles LoadedMeta;
    private bool changedMetaValue = false;
    public int GfxWidth { get; set; } = 16;
    public int GfxHeight { get; set; } = 8;

    //Pointers
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

    //Graphics Editor
    private int selectedColor = 3;

    //Metatile Editor
    private int? SelectedTileID
    {
        get => selectedTileID;
        set
        {
            if (value == selectedTileID) return;
            selectedTileID = value;
            if (value == null || changedMetaValue) return;
            txb_hex_input.Text = Format.IntToString((int)value);
        }
    }
    private int? selectedTileID = null;
    #endregion

    #region Methods

    #region Actions
    /// <summary>
    /// Fills all neighbouring pixels with the same color to a new color
    /// </summary>
    /// <param name="p">The pixel to start the FloodFill</param>
    /// <param name="oldColor">The color that should be replaced</param>
    /// <param name="newColor">The new color</param>
    private void FloodFillPixel(Point p, int oldColor, int newColor)
    {
        //check if pixel in bounds
        if (p.X < 0 || p.Y < 0 || p.X >= LoadedGFX.Width * GraphicsSet.PixelTileSize ||p.Y >= LoadedGFX.Height * GraphicsSet.PixelTileSize) return;

        //check if pixel is supposed to be edited
        if (LoadedGFX.GetPixel(p) != oldColor) return;
        if (LoadedGFX.GetPixel(p) == newColor) return;

        //replace pixel
        LoadedGFX.SetPixel(p, newColor, true);

        //FloodFill in other directions
        FloodFillPixel(new Point(p.X + 1, p.Y), oldColor, newColor);
        FloodFillPixel(new Point(p.X - 1, p.Y), oldColor, newColor);
        FloodFillPixel(new Point(p.X, p.Y + 1), oldColor, newColor);
        FloodFillPixel(new Point(p.X, p.Y - 1), oldColor, newColor);
    }
    #endregion

    #region Graphics View
    private void GraphicsSetMouseDown(object sender, MouseEventArgs e)
    {
        //NOTE to self: if I ever remake LAMP this should probably be moved in the tile display controls and passed as EventArgs.
        //The currently selected pixel
        Point pixel = new Point(Math.Max(Math.Min(e.X, GraphicsSet.BackgroundImage.Width * GraphicsSet.Zoom - 1), 0) / GraphicsSet.Zoom, Math.Max(Math.Min(e.Y, GraphicsSet.BackgroundImage.Height * GraphicsSet.Zoom - 1), 0) / GraphicsSet.Zoom);
        Point tileNum = new Point(pixel.X / GraphicsSet.PixelTileSize, pixel.Y / GraphicsSet.PixelTileSize); //The number of the tile selected
        Point tile = new Point(tileNum.X * GraphicsSet.PixelTileSize, tileNum.Y * GraphicsSet.PixelTileSize); //The room coordinates of the selected tile

        if (LoadedGFX == null) return;

        switch (toolbar_graphics.SelectedTool)
        {
            case LampTool.Pen:

                if (e.Button == MouseButtons.Right)
                {
                    //Select color of current pixel
                    selectedColor = (int)LoadedGFX?.GetPixel(pixel);

                    //Change the current color display (THIS IS VERY DUMB CODE, SORRY)
                    foreach (Control c in pnl_colors.Controls)
                    {
                        if (c is not Panel) continue;
                        Panel p = c as Panel;
                        string panelColor = p.Tag as string;
                        if (selectedColor == Convert.ToInt32(panelColor)) pnl_current_color.BackColor = p.BackColor;
                    }
                    return;
                }
                if (e.Button != MouseButtons.Left) return;

                //place down pixel
                LoadedGFX?.SetPixel(pixel, selectedColor);
                int changedTile = LoadedGFX.GetTileID(pixel.X, pixel.Y);

                //invalidate the the drawn pixel
                GraphicsSet.Invalidate(RecOp.Multiply(new Rectangle(pixel.X, pixel.Y, 1, 1), GraphicsSet.Zoom));

                //update metatiles
                if (LoadedMeta == null) return;
                List<Rectangle> MetaInvalid = LoadedMeta.RedrawTile(changedTile);
                foreach (Rectangle r in MetaInvalid) MetatileSet.Invalidate(RecOp.Multiply(r, MetatileSet.Zoom));

                break;

            case LampTool.Select:

                //selecting pressed tile
                SelectedTileID = tileNum.Y * GfxWidth + tileNum.X;
                GraphicsSet.SelRect = new Rectangle(tileNum.X * GraphicsSet.TileSize, tileNum.Y * GraphicsSet.TileSize, GraphicsSet.TileSize - 1, GraphicsSet.TileSize - 1);

                break;

            case LampTool.Fill:

                //FloodFilling from current Pixel
                FloodFillPixel(pixel, LoadedGFX.GetPixel(pixel), selectedColor);

                //update visuals
                LoadedGFX.Draw();
                GraphicsSet.BackgroundImage = LoadedGFX.Image;
                GraphicsSet.Invalidate();

                //update metatiles
                if (LoadedMeta == null) return;
                LoadedMeta.Draw();
                MetatileSet.BackgroundImage = LoadedMeta.Image;
                MetatileSet.Invalidate();

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


        switch (toolbar_graphics.SelectedTool)
        {
            case LampTool.Pen:

                if (e.Button != MouseButtons.Left) return;

                GraphicsSet.RedRect = new Rectangle(-1, -1, 1, 1);

                //Continue only if clicking
                if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right) return;

                //Place down pixel
                LoadedGFX?.SetPixel(pixel, selectedColor);
                int changedTile = LoadedGFX.GetTileID(pixel.X, pixel.Y);

                //invalidate the drawn pixel
                GraphicsSet.Invalidate(RecOp.Multiply(new Rectangle(pixel.X, pixel.Y, 1, 1), GraphicsSet.Zoom));

                //update metatiles
                if (LoadedMeta == null) return;
                List<Rectangle> MetaInvalid = LoadedMeta.RedrawTile(changedTile);
                foreach (Rectangle r in MetaInvalid) MetatileSet.Invalidate(RecOp.Multiply(r, MetatileSet.Zoom));

                break;

            case LampTool.Select:

                GraphicsSet.RedRect = new Rectangle(tileNum.X * GraphicsSet.TileSize, tileNum.Y * GraphicsSet.TileSize, GraphicsSet.TileSize - 1, GraphicsSet.TileSize - 1);

                break;
        }
    }
    private void GraphicsSetMouseUp(object sender, MouseEventArgs e)
    {

    }
    #endregion

    #region Metatile View
    private void MetatileSetMouseDown(object sender, MouseEventArgs e)
    {
        //The currently selected pixel
        Point pixel = new Point(Math.Max(Math.Min(e.X, MetatileSet.BackgroundImage.Width * MetatileSet.Zoom - 1), 0) / MetatileSet.Zoom, Math.Max(Math.Min(e.Y, MetatileSet.BackgroundImage.Height * MetatileSet.Zoom - 1), 0) / MetatileSet.Zoom);
        Point tileNum = new Point(pixel.X / MetatileSet.PixelTileSize, pixel.Y / MetatileSet.PixelTileSize); //The number of the tile selected
        Point tile = new Point(tileNum.X * MetatileSet.PixelTileSize, tileNum.Y * MetatileSet.PixelTileSize); //The room coordinates of the selected tile

        if (LoadedMeta == null) return;

        switch (toolbar_metatiles.SelectedTool)
        {
            case LampTool.Pen:

                if (selectedTileID == null) return;

                //place down tile
                if (e.Button == MouseButtons.Left) LoadedMeta.ChangeMetaTile(tileNum.X, tileNum.Y, (byte)SelectedTileID);
                else if (e.Button == MouseButtons.Right) LoadedMeta.ChangeMetaTile(tileNum.X, tileNum.Y, 0xFF);
                else if (e.Button == MouseButtons.Middle) SelectedTileID = LoadedMeta.GetMetaTile(tileNum.X, tileNum.Y);

                //invalidate
                MetatileSet.Invalidate();

                break;
        }
    }
    private void MetatileSetMouseMove(object sender, MouseEventArgs e)
    {
        //The currently selected pixel
        Point pixel = new Point(Math.Max(Math.Min(e.X, MetatileSet.BackgroundImage.Width * MetatileSet.Zoom - 1), 0) / MetatileSet.Zoom, Math.Max(Math.Min(e.Y, MetatileSet.BackgroundImage.Height * MetatileSet.Zoom - 1), 0) / MetatileSet.Zoom);
        Point tileNum = new Point(pixel.X / MetatileSet.PixelTileSize, pixel.Y / MetatileSet.PixelTileSize); //The number of the tile selected
        Point tile = new Point(tileNum.X * MetatileSet.PixelTileSize, tileNum.Y * MetatileSet.PixelTileSize); //The room coordinates of the selected tile

        if (LoadedMeta == null) return;

        switch (toolbar_metatiles.SelectedTool)
        {
            case LampTool.Pen:

                if (selectedTileID == null) return;
                else MetatileSet.RedRect = new Rectangle(tileNum.X * MetatileSet.TileSize, tileNum.Y * MetatileSet.TileSize, MetatileSet.TileSize - 1, MetatileSet.TileSize - 1);

                break;
        }
    }
    private void MetatileSetMouseUp(object sender, MouseEventArgs e) { }
    #endregion

    #region Events
    private void pnl_color_Click(object sender, EventArgs e)
    {
        Panel p = sender as Panel;
        string number = p.Tag as string;
        selectedColor = Convert.ToInt32(number);
        pnl_current_color.BackColor = p.BackColor;
    }

    private void btn_accept_Click(object sender, EventArgs e)
    {
        //Checking if width * height will be out of bounds in ROM
        int width = (int)num_width.Value;
        int height = (int)num_height.Value;

        GraphicsPointer = txb_offset.Text == "" ? null : Format.StringToPointer(txb_offset.Text);
        MetatilePointer = txb_meta_offset.Text == "" ? null : Format.StringToPointer(txb_meta_offset.Text);

        GfxWidth = width;
        GfxHeight = height;

        SetTilesets();
    }

    private void btn_apply_Click(object sender, EventArgs e)
    {
        if (LoadedGFX != null) Editor.AddDataChunk((DataChunk)LoadedGFX);
        if (LoadedMeta != null) Editor.AddDataChunk((DataChunk)LoadedMeta);
    }

    private void txb_hex_input_TextChanged(object sender, EventArgs e)
    {
        changedMetaValue = true;
        SelectedTileID = Format.StringToInt(txb_hex_input.Text, 0xFF);
        changedMetaValue = false;
    }
    #endregion

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

    private void toolbar_graphics_ToolSwitched(object sender, EventArgs e)
    {
        //Hide additional bars
        pnl_colors.Visible = toolbar_graphics.SelectedTool == LampTool.Pen || toolbar_graphics.SelectedTool == LampTool.Fill;

        //Remove red rect
        GraphicsSet.RedRect = new Rectangle(0, 0, 0, 0);
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

    #region IMPORT / EXPORT
    private void btn_import_gfx_Click(object sender, EventArgs e)
    {
        string path = Editor.ShowOpenDialog("Character Graphics (*.chr)|*.chr|Binary File (*.*)|*.*");
        if (!File.Exists(path) || path == string.Empty) return;

        //Reading data from file
        byte[] data = File.ReadAllBytes(path);

        //Checking if file is valid
        //Size
        if (data.Length > 2048)
        {
            MessageBox.Show("Graphics data is too long", "Error", MessageBoxButtons.OK);
            return;
        }


        Editor.AddDataChunk(new DataChunk(GraphicsPointer, data, "Graphics"));
        SetTilesets();
    }

    private void btn_import_meta_Click(object sender, EventArgs e)
    {
        string path = Editor.ShowOpenDialog("Binary File (*.*)|*.*");
        if (!File.Exists(path) || path == string.Empty) return;

        //Reading data from file
        byte[] data = File.ReadAllBytes(path);

        //Checking if file is valid
        //Size
        if (data.Length > 512)
        {
            MessageBox.Show("Metatile data is too long", "Error", MessageBoxButtons.OK);
            return;
        }
        if (data.Length < 512)
        {
            MessageBox.Show("Metatile data is too short", "Error", MessageBoxButtons.OK);
            return;
        }

        Editor.AddDataChunk(new DataChunk(MetatilePointer, data, "MetatileTable"));
        SetTilesets();
    }

    private void btn_export_gfx_Click(object sender, EventArgs e)
    {
        string path = Editor.ShowSaveDialog("Character Graphics (*.chr)|*.chr");
        if (path == string.Empty) return;

        File.WriteAllBytes(path, (byte[])(DataChunk)LoadedGFX);
    }

    private void btn_export_meta_Click(object sender, EventArgs e)
    {
        string path = Editor.ShowSaveDialog("Binary File (*.*)|*.*");
        if (path == string.Empty) return;

        File.WriteAllBytes(path, (byte[])(DataChunk)LoadedMeta);
    }

    #endregion
    #endregion
}
