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
        }

        private void chb_rmv_mt_o_list_CheckedChanged(object sender, EventArgs e)
        {
            Globals.LoadedProject.OptimizeObjectData = chb_rmv_mt_o_list.Checked;
        }
    }
}
