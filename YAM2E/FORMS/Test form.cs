using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAMP.Classes;
using LAMP.Utilities;

namespace LAMP.FORMS
{
    public partial class Test_form : Form
    {
        public Test_form()
        {
            InitializeComponent();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            Pointer p = Format.StringToPointer(txt_input.Text);
            if (p != null) lbl_offset_test.Text = "Offset Value: " + Format.PointerToString(p);
        }
    }
}
