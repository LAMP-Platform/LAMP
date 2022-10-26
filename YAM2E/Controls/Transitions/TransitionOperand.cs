using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP.Controls.Transitions
{
    public partial class TransitionOperand : UserControl
    {
        public TransitionOperand()
        {
            InitializeComponent();
        }

        public void ChangeName(string name)
        {
            lblOperandName.Text = name;
        }
    }
}
