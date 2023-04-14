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
using LAMP.Classes;
using LAMP.FORMS;

namespace LAMP.Controls.Other
{
    public partial class RecentFiles : UserControl
    {
        public RecentFiles()
        {
            InitializeComponent();

            LoadRecentFileControls();
        }

        private void LoadRecentFileControls()
        {
            List<string> obsoletes = new List<string>(); //List which holds the non existing projects

            foreach (string path in Globals.recentFiles)
            {
                if (!File.Exists(path))
                {
                    obsoletes.Add(path);
                    continue;
                }

                //Adding recent file display control
                RecentFileDisplay display = new RecentFileDisplay(Path.GetFileNameWithoutExtension(path), path);
                Panel p = new Panel();

                //creating a base panel
                pnl_recent_files.Controls.Add(p);
                p.Dock = DockStyle.Top;
                p.Height = 66;
                p.Padding = new Padding(3, 3, 3, 3);
                p.BringToFront();

                //adding recent file display onto it
                p.Controls.Add(display);
                display.Dock = DockStyle.Fill;
            }

            foreach (string s in obsoletes) { Globals.recentFiles.Remove(s); }
        }

        private void btn_create_project_Click(object sender, EventArgs e)
        {
            Editor.OpenProjectAndLoad();
        }

        private void btn_open_project_Click(object sender, EventArgs e)
        {
            Editor.CreateNewProject();
        }

        private void btn_project_settings_Click(object sender, EventArgs e)
        {
            new ProgramSettins().ShowDialog();
        }
    }
}
