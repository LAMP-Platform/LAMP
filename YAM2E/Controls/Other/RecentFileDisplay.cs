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

namespace LAMP.Controls.Other
{
    public partial class RecentFileDisplay : UserControl
    {
        public RecentFileDisplay(String title, String path)
        {
            InitializeComponent();

            lbl_title.Text = title;
            lbl_path.Text = path;
        }

        public void SetBackground(Color c)
        {
            pnl_main.BackColor = c;
        }

        private void pnl_main_MouseEnter(object sender, EventArgs e)
        {
            SetBackground(Color.FromArgb(0xFF, 0xd8, 0xd8, 0xd8));
        }

        private void pnl_main_MouseLeave(object sender, EventArgs e)
        {
            SetBackground(Color.FromArgb(0xFF, 0xf0, 0xf0, 0xf0));
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {
            Editor.OpenProjectAndLoad(lbl_path.Text);
        }
    }
}
