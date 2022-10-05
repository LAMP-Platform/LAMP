using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP.FORMS
{
    public partial class ProjectSettings : Form
    {
        public ProjectSettings()
        {
            InitializeComponent();
            chb_rmv_mt_o_list.Checked = Globals.LoadedProject.OptimizeObjectData;
            rbt_use_tilesets.Checked = Globals.LoadedProject.useTilesets;
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
            }
        }

        private void rbt_use_tilesets_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_use_tilesets.Checked)
            {
                Globals.LoadedProject.useTilesets = true;
            }
        }
    }
}
