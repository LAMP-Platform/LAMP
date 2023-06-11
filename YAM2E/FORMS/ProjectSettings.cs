using LAMP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP.FORMS;

public partial class ProjectSettings : Form
{
    public ProjectSettings()
    {
        InitializeComponent();
        chb_rmv_mt_o_list.Checked = Globals.LoadedProject.OptimizeObjectData;
        rbt_use_tilesets.Checked = Globals.LoadedProject.useTilesets;
        txb_rom_path.Text = Globals.LoadedProject.ProjectSpecificROM;
    }

    private void chb_rmv_mt_o_list_CheckedChanged(object sender, EventArgs e)
    {
        Globals.LoadedProject.OptimizeObjectData = chb_rmv_mt_o_list.Checked;
    }

    private void rbt_use_offsets_CheckedChanged(object sender, EventArgs e)
    {
        if (rbt_use_offsets.Checked)
        {
            Globals.LoadedProject.useTilesets = false;
            MainWindow.Current.SwitchTilesetOffsetMode();
        }
    }

    private void rbt_use_tilesets_CheckedChanged(object sender, EventArgs e)
    {
        if (rbt_use_tilesets.Checked)
        {
            Globals.LoadedProject.useTilesets = true;
            MainWindow.Current.SwitchTilesetOffsetMode();
        }
    }

    private void txb_rom_path_TextChanged(object sender, EventArgs e)
    {
        Globals.LoadedProject.ProjectSpecificROM = txb_rom_path.Text;
    }

    private void btn_select_rom_Click(object sender, EventArgs e)
    {
        string path = Editor.ShowOpenDialog("Metroid 2: Return of Samus ROM (*.gb)|*.gb");
        if (path != String.Empty) txb_rom_path.Text = path;
    }
}
