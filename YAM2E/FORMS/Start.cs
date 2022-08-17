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
using System.IO;

namespace YAM2E.FORMS
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            txb_rom_path.Text = Globals.RomPath;
        }

        private void btn_select_rom_Click(object sender, EventArgs e)
        {
            string path = Editor.ShowOpenDialog("Metroid 2: Return of Samus ROM (*.gb)|*.gb");
            if (path != String.Empty) txb_rom_path.Text = path;
        }

        private void txb_rom_path_TextChanged(object sender, EventArgs e)
        {
            Globals.RomPath = txb_rom_path.Text;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/YAM2E/rompath.txt";
            File.WriteAllText(path, Globals.RomPath);
        }
    }
}
