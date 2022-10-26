using LAMP.Controls.Transitions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LAMP.Controls
{
    public partial class TransitionOpcode : UserControl
    {
        public TransitionOpcode()
        {
            InitializeComponent();

            for (int i = 0; i < new Random().Next(1, 4); i++)
            {
                AddOperand($"Operand {i + 1}");
            }
        }

        //Functions
        public void AddOperand(string Name)
        {
            TransitionOperand operand = new TransitionOperand();
            operand.ChangeName(Name);
            pnlOperands.Controls.Add(operand);
        }

        private void pnlBasicInfo_Click(object sender, EventArgs e)
        {
            pnlOperands.Visible = !pnlOperands.Visible;
            seperator.Visible = pnlOperands.Visible;
        }

        private void pnlBasicInfo_MouseMove(object sender, MouseEventArgs e)
        {
            pnlBasicInfo.BackColor = Color.FromArgb(0xFF, 0xe6, 0xe6, 0xe6);
        }

        private void pnlBasicInfo_MouseLeave(object sender, EventArgs e)
        {
            pnlBasicInfo.BackColor = Color.FromArgb(0xFF, 0xf0, 0xf0, 0xf0);
        }
    }
}
