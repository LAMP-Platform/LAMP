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

        //Tile Viewer vars
        public static TileViewer Tileset = new TileViewer();
        public static RoomViewer Room = new RoomViewer();
        private Point StartSelection = new Point(-1, -1);
        private Point SelectedTile = new Point(-1, -1);

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
            grp_main_room_viewer.Visible = value;

            if (value != true) return;

            //Tile Viewer 
            Controls.Add(Tileset);
            Tileset.BringToFront();
            grp_main_tileset_viewer.Controls.Add(Tileset);
            Tileset.Location = new Point(15, 20);
            Tileset.BackColor = Globals.cBlack;
            Tileset.MouseDown += new MouseEventHandler(Tileset_MouseDown);
            Tileset.MouseMove += new MouseEventHandler(Tileset_MouseMove);
            Tileset.MouseUp += new MouseEventHandler(Tileset_MouseUp);
            Tileset.ResetSelection();
            UpdateTileset();

            //Room Viewer
            cbb_area_bank.SelectedIndex = 0;
            Controls.Add(Room);
            Room.BringToFront();
            flw_main_room_view.Controls.Add(Room);
            Room.Location = new Point(15, 20);
            Room.BackColor = Globals.cBlack;
            //Room.MouseDown += new MouseEventHandler(Tileset_MouseDown);
            //Room.MouseMove += new MouseEventHandler(Tileset_MouseMove);
            //Room.MouseUp += new MouseEventHandler(Tileset_MouseUp);
            Room.ResetSelection();
        }

        public void UpdateTileset()
        {
            Globals.Tileset.Dispose();
            Globals.Tileset = Editor.DrawTileSet((int)num_main_graphics_offset.Value, (int)num_main_metatile.Value, 16, 8);
            Tileset.BackgroundImage = Globals.Tileset;
            grp_main_tileset_viewer.Size = new Size(Tileset.BackgroundImage.Width + 30, Tileset.BackgroundImage.Height + 35);
        }

        public void UpdateRoom()
        {
            Point p = new Point(0, 0);
            Globals.AreaBank.Dispose();
            Globals.AreaBank = new Bitmap(4096, 4096);
            Editor.DrawAreaBank(Editor.A_BANKS[cbb_area_bank.SelectedIndex], Globals.AreaBank, p);
            Room.BackgroundImage = Globals.AreaBank;
            //pnl_main_room_view.Size = new Size(Room.BackgroundImage.Width + 30, Room.BackgroundImage.Height + 35);
        }

        public void UpdateSelectedTiles()
        {
            int x = Tileset.SelRect.X / 16;
            int y = Tileset.SelRect.Y / 16;
            int width = (Tileset.SelRect.Width + 1) / 16;
            int height = (Tileset.SelRect.Height + 1) / 16;
            Editor.SelectionWidth = width;
            Editor.SelectionHeight = height;
            lbl_main_selection_size.Text = $"Selected Area: {width} x {height}";

            //returns the selected Metatile offsets
            int tile_width = Tileset.BackgroundImage.Width / 16;
            Editor.SelectedTiles = new int[width * height];
            int count = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int val = (y + i) * tile_width + j;
                    Editor.SelectedTiles[count] = val;
                    count++;
                }
            }
        }

        #region Main Window Events

        #region Tileset Events
        private void Tileset_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X >> 4) * 16; //tile position at moment of click
            int y = (e.Y >> 4) * 16; //
            //setting start position for selection
            StartSelection.X = x;
            StartSelection.Y = y;
            Rectangle rect = Tileset.SelRect; //old selection rectangle
            Tileset.SelRect = new Rectangle(StartSelection.X, StartSelection.Y, 16 - 1, 16 - 1);
            Tileset.Invalidate(Editor.UniteRect(Tileset.SelRect, rect));
        }

        private void Tileset_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (e.X >> 4) * 16; //locks position of mouse to edge of tiles
            int y = (e.Y >> 4) * 16; //
            if ((x == SelectedTile.X && y == SelectedTile.Y) || (x < 0 || y < 0) || (x > Tileset.BackgroundImage.Width || y > Tileset.BackgroundImage.Height)) //if mouse out of Tileset bounds
                return;
            SelectedTile.X = x;
            SelectedTile.Y = y;
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                int width = Math.Abs((SelectedTile.X) - StartSelection.X) + 16 - 1; //Width and Height of the Selection
                int height = Math.Abs((SelectedTile.Y) - StartSelection.Y) + 16 - 1;//
                Rectangle rect = Tileset.SelRect; //old selection rectangle
                Tileset.SelRect = new Rectangle(Math.Min(StartSelection.X, SelectedTile.X), Math.Min(StartSelection.Y, SelectedTile.Y), width, height);
                Tileset.RedRect = new Rectangle(-1, 0, 0, 0); //This hides the red Rect
                Tileset.Invalidate(Editor.UniteRect(Tileset.SelRect, rect));
                lbl_main_selection_size.Text = $"Selected Area: {(width + 1) / 16} x {(height + 1) / 16}";
            }
            else
            {
                Rectangle rect = Tileset.RedRect; //old Position of the rectangle
                Tileset.RedRect = new Rectangle(SelectedTile.X, SelectedTile.Y, 16 - 1, 16 - 1);
                Tileset.Invalidate(Editor.UniteRect(Tileset.RedRect, rect));
            }
            
        }

        private void Tileset_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateSelectedTiles();
        }
        #endregion

        #region Main Events
        private void main_window_Resize(object sender, EventArgs e)
        {
            grp_main_room_viewer.Width = this.Width - 28 - grp_main_room_viewer.Location.X;
            grp_main_room_viewer.Height = this.Height - 64 - grp_main_room_viewer.Location.Y;
            flw_main_room_view.Width = grp_main_room_viewer.Width - 30;
            flw_main_room_view.Height = grp_main_room_viewer.Height - 30;
        }

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
           UpdateRoom();
        }

        private void main_window_Load(object sender, EventArgs e)
        {

        }

        private void num_main_graphics_offset_ValueChanged(object sender, EventArgs e)
        {
            UpdateTileset();
            UpdateRoom();
        }

        private void num_main_metatile_ValueChanged(object sender, EventArgs e)
        {
            UpdateTileset();
            UpdateRoom();
        }
        #endregion

        #endregion
    }
}