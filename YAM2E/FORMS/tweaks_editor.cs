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

namespace YAM2E.FORMS
{
    public partial class tweaks_editor : Form
    {
        public tweaks_editor()
        {
            InitializeComponent();
        }

        public void ApplyTweak(int offset, byte value)
            => Editor.ROM[offset] = value;

        public void ApplyTweak(int offset, byte[] values)
        {
            for (int i = 0; i < values.Length; i++)
                Editor.ROM[offset + i] = values[i];
        }

        public void ApplyTweak(int[] offsets, byte[] values)
        {
            for (int i = 0; i < values.Length; i++)
                Editor.ROM[offsets[i]] = values[i];
        }

        private void btn_close_tweaks_Click(object sender, EventArgs e)
            => Close();
    }
}
