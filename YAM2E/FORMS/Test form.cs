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
using LAMP.Controls;
using LAMP.Utilities;

namespace LAMP.FORMS
{
    public partial class Test_form : Form
    {
        public Test_form()
        {
            InitializeComponent();
            gauge1.ChangeValue(0.7);
            //Adding Opcodes
            for (int i = 0; i < 7; i++)
            {
                TransitionOpcode opcode = new TransitionOpcode();
                opcode.lblOpcodeName.Text = $"Transition Opcode {i + 1}";
                flowLayoutPanel1.Controls.Add(opcode);
            }
        }
    }
}
