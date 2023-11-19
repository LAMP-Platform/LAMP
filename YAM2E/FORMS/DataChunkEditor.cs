using LAMP.Classes.M2_Data;
using LAMP.Controls.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP.FORMS
{
    public partial class DataChunkEditor : Form
    {
        public DataChunkEditor()
        {
            InitializeComponent();

            foreach (DataChunk dc in Globals.DataChunks)
            {
                DataChunkDisplay dcd = new DataChunkDisplay(dc);
                dcd.RemoveThisChunk += PressedRemoveDataChunk;
                dcd.Dock = DockStyle.Fill;

                Panel p = new Panel()
                {
                    Padding = new Padding(3, 3, 3, 0),
                    Height = dcd.Height + 3,
                    Dock = DockStyle.Top
                };

                p.Controls.Add(dcd);
                Controls.Add(p);
            }
        }

        public void PressedRemoveDataChunk(object sender, EventArgs e)
        {
            DataChunkDisplay dcd = sender as DataChunkDisplay;
            Globals.DataChunks.Remove(dcd.Chunk);
            Controls.Remove(dcd);
        }
    }
}
