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

namespace LAMP.FORMS
{
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

            GraphicsSet.Zoom = toolbar_graphics.ZoomLevel = 2;

            //Adding the TileViewer for Metatiles
            flw_metatile_view.Controls.Add(MetatileSet);

            MetatileSet.Zoom = toolbar_metatiles.ZoomLevel = 1;
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
            if (MetatilePointer == null)
            {
                if (GraphicsSet.BackgroundImage != null) GraphicsSet.BackgroundImage.Dispose();
                if (MetatileSet.BackgroundImage != null) MetatileSet.BackgroundImage.Dispose();
                return;
            }

            //Graphics View
            if (GraphicsSet.BackgroundImage != null)
            {
                GraphicsSet.BackgroundImage.Dispose();
            }
            Bitmap GFXBitmap = new Bitmap(GfxWidth * 8, GfxHeight * 8);
            Editor.DrawTile8Set(graphicsPointer.Offset, GFXBitmap, new Point(0, 0), GfxWidth, GfxHeight);
            GraphicsSet.BackgroundImage = GFXBitmap;

            //Metatile View
            if (MetatileSet.BackgroundImage != null)
            {
                MetatileSet.BackgroundImage.Dispose();
            }
            Bitmap MetaBitmap = new Bitmap(256, 128);
            if (MetatilePointer != null)
            {
                MetaBitmap.Dispose();
                MetaBitmap = Editor.DrawTileSet(GraphicsPointer, MetatilePointer, 16, 8, false);
            }
            MetatileSet.BackgroundImage = MetaBitmap;
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
            GraphicsPointer = Format.StringToPointer(txb_offset.Text);
            MetatilePointer = Format.StringToPointer(txb_meta_offset.Text);
            if (txb_offset.Text.Length == 0)
            {
                GraphicsPointer = null;
                metatilePointer = null;
            }

            SetTilesets();
        }

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
}
