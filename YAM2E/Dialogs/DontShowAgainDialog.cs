using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP.Dialogs
{
    public partial class DontShowAgainDialog : Form
    {
        public bool DoNotShowAgain => chb_dontshowagain.Checked;
        public string DoNotShowAgainText 
        { 
            set => chb_dontshowagain.Text = value;
        }

        public DontShowAgainDialog(string Title = "Warning", string Text = "Warning")
        {
            InitializeComponent();

            this.Text = Title;
            txb_text.Text = Text;
            DialogResult = DialogResult.Cancel;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
