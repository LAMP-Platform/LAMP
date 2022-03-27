using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
            grp_data_selector.Enabled = value;
            btn_open_tweaks_editor_image.Enabled = value;
            btn_save_rom_image.Enabled = value;
        }

        private void btn_open_rom_Click(object sender, EventArgs e) //Open ROM button
        {
            Editor.open_rom();
        }

        private void cbb_area_bank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_tweaks_editor_Click(object sender, EventArgs e)
        {
            new tweaks_editor().Show();
        }

        private void btn_open_rom_image_Click(object sender, EventArgs e)
        {
            Editor.open_rom();
        }

        private void btn_open_tweaks_editor_image_Click(object sender, EventArgs e)
        {
            new tweaks_editor().Show();
        }
    }
}