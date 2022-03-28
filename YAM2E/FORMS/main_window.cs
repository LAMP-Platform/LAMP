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

        public main_window()
        {
            Current = this;
            InitializeComponent();
            updateButtonStatus();
        }

        public void updateButtonStatus() //greys out buttons or enables them if ROM is loaded
        {
            bool value = Globals.rom_loaded;
            btn_save_rom.Enabled = value;
            btn_save_rom_as.Enabled = value;
            btn_create_backup.Enabled = value;
            tool_strip_editors.Enabled = value;
            grp_data_selector.Visible = value;
            btn_open_tweaks_editor_image.Enabled = value;
            btn_save_rom_image.Enabled = value;
        }

        private void btn_open_rom_Click(object sender, EventArgs e) //Open ROM button
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
            Point p = new Point(0, 0);
            Bitmap bmp = new Bitmap(1000, 1000);
            //Editor.DrawTile8Set((int)num_main_graphics_offset.Value, bmp, p, 16, 8);
            Editor.DrawScreen((int)num_main_graphics_offset.Value, (int)num_main_metatile.Value, bmp, p);
            pictureBox1.Image = bmp;
        }

        private void num_main_metatile_ValueChanged(object sender, EventArgs e)
        {
            Point p = new Point(0, 0);
            Bitmap bmp = new Bitmap(256, 256);
            //Editor.DrawTileSet((int)num_main_graphics_offset.Value, (int)num_main_metatile.Value, bmp, p, 16, 8);
            Editor.DrawScreen((int)num_main_graphics_offset.Value, (int)num_main_metatile.Value, bmp, p);
            pictureBox1.Image = bmp;
        }
    }
}