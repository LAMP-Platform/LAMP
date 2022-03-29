using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YAM2E.Classes;
using YAM2E.FORMS;

namespace YAM2E
{
    public partial class main_window : Form
    {
        public static main_window Current;
        public static TileViewer Tileset = new TileViewer();

        //COPY PASTE SHIT I WILL PROBABLY DELETE LATER
        private Point Pivot = new Point(-1, -1);
        private Point TileCursor = new Point(-1, -1);
        private Rectangle Selection = new Rectangle(-1, -1, 1, 1);
        private Bitmap SelectionImage;

        public Rectangle Union(Rectangle rect1, Rectangle rect2)
        {
            int x = Math.Min(rect1.X, rect2.X);
            int y = Math.Min(rect1.Y, rect2.Y);
            int width = Math.Max(rect1.X + rect1.Width, rect2.X + rect2.Width) - x + 1;
            int height = Math.Max(rect1.Y + rect1.Height, rect2.Y + rect2.Height) - y + 1;
            return new Rectangle(x, y, width, height);
        }
        private void ResizeSelection(Point pos)
        {
            int width = Math.Abs(pos.X - Pivot.X) + 1;
            int height = Math.Abs(pos.Y - Pivot.Y) + 1;
            Selection = new Rectangle(pos.X >= Pivot.X ? Pivot.X : pos.X, pos.Y >= Pivot.Y ? Pivot.Y : pos.Y, width, height);
        }

        public main_window()
        {
            Current = this;
            InitializeComponent();
        }

        public void ROMLoaded() //greys out buttons or enables them if ROM is loaded
        {
            //Enabling UI
            bool value = true;
            btn_save_rom.Enabled = value;
            btn_save_rom_as.Enabled = value;
            btn_create_backup.Enabled = value;
            tool_strip_editors.Enabled = value;
            grp_data_selector.Visible = value;
            btn_open_tweaks_editor_image.Enabled = value;
            btn_save_rom_image.Enabled = value;
            grp_main_tileset_viewer.Visible = value;

            //Tile Viewer 
            Controls.Add(Tileset);
            Tileset.BringToFront();
            grp_main_tileset_viewer.Controls.Add(Tileset);
            Tileset.Location = new Point(15, 20);
            Tileset.BackgroundImage = new Bitmap(256, 128);
            Tileset.MouseDown += new MouseEventHandler(Tileset_MouseDown);
            Tileset.MouseMove += new MouseEventHandler(Tileset_MouseMove);
            Tileset.MouseUp += new MouseEventHandler(Tileset_MouseUp);
            grp_main_tileset_viewer.Size = new Size(Tileset.BackgroundImage.Width + 30, Tileset.BackgroundImage.Height + 35);

        }

        public void UpdateTileset()
        {
            Point p = new Point(0, 0);
            Bitmap bmp = new Bitmap(256, 128);
            Editor.DrawTileSet((int)num_main_graphics_offset.Value, (int)num_main_metatile.Value, bmp, p, 16, 8);
            Tileset.BackgroundImage = bmp;
        }

        #region Main Window Events

        #region Tileset Events
        //ALSO BUNCH OF COPY AND PASTE
        private void Tileset_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle SelRect = Tileset.SelRect;
            Tileset.ResizeSelection(new Rectangle(1, 1, 1, 1));
            Tileset.Invalidate(Union(SelRect, Tileset.SelRect));
            Tileset.Invalidate(Tileset.SelRect);
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
                return;
            Pivot = TileCursor;
            Selection = new Rectangle(Pivot.X, Pivot.Y, 1, 1);
            Rectangle rectangle = new Rectangle(Pivot.X * 16, Pivot.Y * 16, 16, 16);
            Tileset.ResizeSelection(Selection);
            Tileset.Invalidate(rectangle);
            //TSSize.Text = $"1 x 1";
        }

        private void Tileset_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X >> 5;
            int y = e.Y >> 5;
            if (x == TileCursor.X && y == TileCursor.Y || (x < 0 || x >= 8) || (y < 0 || y >= Tileset.Height / 16))
                return;
            TileCursor.X = x;
            TileCursor.Y = y;
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                if (!Tileset.HasSelection) return;
                Rectangle selRect = Tileset.SelRect;
                ResizeSelection(TileCursor);
                Tileset.ResizeSelection(Selection);
                Tileset.MoveRed(x, y);
                Tileset.Invalidate(Union(selRect, Tileset.SelRect));
                //TSSize.Text = $"{Tileset.SelRect.Width / 32 + 1} x {Tileset.SelRect.Height / 32 + 1}";
            }
            else
            {
                Rectangle RedRect = Tileset.RedRect;
                Tileset.MoveRed(x, y);
                Tileset.Invalidate(Union(RedRect, Tileset.RedRect));
            }
        }

        private void Tileset_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right || !Tileset.HasSelection)
                return;
            Pivot = new Point(-1, -1);
            SelectionImage = new Bitmap(Tileset.SelRect.Width, Tileset.SelRect.Height);
            //CopyBlocks();
        }
        #endregion

        private void btn_open_rom_Click(object sender, EventArgs e)
        {
            Editor.open_rom();
        }

        private void btn_tweaks_editor_Click(object sender, EventArgs e)
            => new tweaks_editor().Show();

        private void btn_open_rom_image_Click(object sender, EventArgs e)
            => Editor.open_rom();

        private void btn_open_tweaks_editor_image_Click(object sender, EventArgs e)
            => new tweaks_editor().Show();

        private void btn_save_rom_image_Click(object sender, EventArgs e)
            => Editor.SaveROM();

        private void btn_save_rom_as_Click(object sender, EventArgs e)
            => Editor.SaveROMAs();

        private void window_drag_over(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void window_file_drop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            Editor.open_path(s[0]);
        }

        private void cbb_area_bank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void main_window_Load(object sender, EventArgs e)
        {

        }

        private void num_main_graphics_offset_ValueChanged(object sender, EventArgs e)
        {
            UpdateTileset();
        }

        private void num_main_metatile_ValueChanged(object sender, EventArgs e)
        {
            UpdateTileset();
        }
        #endregion
    }
}