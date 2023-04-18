using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAMP.Classes;
using System.IO;

namespace LAMP.FORMS
{
    public partial class ProgramSettins : Form
    {
        public ProgramSettins()
        {
            InitializeComponent();
            txb_rom_path.Text = Globals.RomPath;

            //Set radio buttons
            if (Globals.hexPrefix == "" && Globals.hexSuffix == "") rbt_no_indication.Checked = true;
            if (Globals.hexPrefix == "0x") rbt_0x_prefix.Checked = true;
            if (Globals.hexPrefix == "$") rbt_dollar_prefix.Checked = true;
            if (Globals.hexSuffix == "h") rbt_h_suffix.Checked = true;

            if (Globals.bankOffsets) rbt_bank_style.Checked = true;
            else rbt_offset_style.Checked = true;
        }

        private void btn_select_rom_Click(object sender, EventArgs e)
        {
            string path = Editor.ShowOpenDialog("Metroid 2: Return of Samus ROM (*.gb)|*.gb");
            if (path != String.Empty) txb_rom_path.Text = path;
        }

        private void txb_rom_path_TextChanged(object sender, EventArgs e)
        {
            Globals.RomPath = txb_rom_path.Text;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/LAMP/rompath.txt";
            File.WriteAllText(path, Globals.RomPath);
        }

        private void clearIndication()
        {
            Globals.hexPrefix = "";
            Globals.hexSuffix = "";
        }

        private void SaveSettings()
        {
            Properties.programsettings.Default.hexPrefix = Globals.hexPrefix;
            Properties.programsettings.Default.hexSuffix = Globals.hexSuffix;
            Properties.programsettings.Default.bankOffsets = Globals.bankOffsets;

            Properties.programsettings.Default.Save();
        }

        private void rbt_no_indication_CheckedChanged(object sender, EventArgs e)
        {
            clearIndication();
            if (rbt_no_indication.Checked) SaveSettings();
        }

        private void rbt_0x_prefix_CheckedChanged(object sender, EventArgs e)
        {
            clearIndication();
            if (rbt_0x_prefix.Checked)
            {
                Globals.hexPrefix = "0x";
                SaveSettings();
            }
        }

        private void rbt_dollar_prefix_CheckedChanged(object sender, EventArgs e)
        {
            clearIndication();
            if (rbt_dollar_prefix.Checked)
            {
                Globals.hexPrefix = "$";
                SaveSettings();
            }
        }

        private void rbt_h_suffix_CheckedChanged(object sender, EventArgs e)
        {
            clearIndication();
            if (rbt_h_suffix.Checked)
            {
                Globals.hexSuffix = "h";
                SaveSettings();
            }
        }

        private void rbt_bank_style_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
            if (rbt_bank_style.Checked) Globals.bankOffsets = true;
        }

        private void rbt_offset_style_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_offset_style.Checked) Globals.bankOffsets = false;
            SaveSettings();
        }
    }
}
