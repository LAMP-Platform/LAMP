using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAM2E.FORMS
{
    public partial class ScreenSettings : Form
    {
        public ScreenSettings()
        {
            InitializeComponent();

            for (int i = 0; i < 512; i++)
            {
                cbb_scse_transition_index.Items.Add(i.ToString("X3"));
            }
            for (int i = 0; i < 59; i++)
            {
                cbb_scse_screen_used.Items.Add(i.ToString("X2"));
            }
            for (int i = 0; i < 256; i++)
            {
                cbb_scse_screen.Items.Add(i.ToString("X2"));
            }
        }
    }
}
