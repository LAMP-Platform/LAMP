using LAMP.Classes.M2_Data;
using LAMP.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP.Controls
{
    public partial class DataChunkView : UserControl
    {
        public DataChunkView()
        {
            InitializeComponent();
        }

        private void DataChunkView_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(255, 0xe3, 0xe3, 0xe3);
        }

        private void DataChunkView_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 0xf0, 0xf0, 0xf0);
        }
    }
}
