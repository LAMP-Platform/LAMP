using LAMP.Classes;
using LAMP.Classes.M2_Data;
using LAMP.FORMS;
using LAMP.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP.Controls.Other
{
    public partial class TweakDisplay : UserControl
    {
        public Tweak Tweak { get; set; }
        public event EventHandler? RemoveThisTweak;

        public TweakDisplay(Tweak tweak)
        {
            InitializeComponent();

            this.Tweak = tweak;
            txb_description.Text = tweak.Description;
        }

        private void chb_include_CheckedChanged(object sender, EventArgs e) => Tweak.Include = chb_include.Checked;

        private void btn_remove_Click(object sender, EventArgs e) => RemoveThisTweak?.Invoke(this, new EventArgs());

        private void btn_export_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txb_description_TextChanged(object sender, EventArgs e)
        {
            //Adjust Text field size
            SizeF MessageSize = txb_description.CreateGraphics().MeasureString(
                txb_description.Text,
                txb_description.Font,
                txb_description.Width,
                new StringFormat(0));
            txb_description.Height = (int)MessageSize.Height;
        }
    }
}
