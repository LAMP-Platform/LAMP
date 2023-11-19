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

namespace LAMP.Controls.Other
{
    public partial class DataChunkDisplay : UserControl
    {
        public int ChunkID { get; set; }
        public DataChunk Chunk { get; set; }
        public event EventHandler RemoveThisChunk;

        public DataChunkDisplay(DataChunk chunk)
        {
            InitializeComponent();

            this.Chunk = chunk;

            lbl_type.Text = chunk.DataType;
            lbl_range.Text = $"Location: {Format.PointerToString(chunk.DataStart)} - {Format.PointerToString(chunk.DataStart + chunk.DataLength - 1)}";
            chb_include.Checked = chunk.Include;
        }

        private void chb_include_CheckedChanged(object sender, EventArgs e)
        {
            Chunk.Include = chb_include.Checked;
        }

        private void btn_remove_Click(object sender, EventArgs e) => RemoveThisChunk.Invoke(this, new EventArgs());
    }
}
