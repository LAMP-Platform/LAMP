using LAMP.Classes;
using LAMP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP.Controls.Transitions
{
    public partial class OpcodeTemplate : UserControl
    {
        public TransitionOpcode opcode { get; set; }

        public OpcodeTemplate(TransitionOpcode opcode)
        {
            InitializeComponent();

            this.opcode = opcode;
            lbl_opcode_title.Text = opcode.Description[0];
            pcb_add.BackgroundImage = null;
        }

        public EventHandler onAddOpcode { get; set; }
        public event EventHandler AddOpcode
        {
            add
            {
                AddOpcode += value;
            }
            remove
            {
                AddOpcode -= value;
            }
        }

        private void pnl_main_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_main.BackColor = Color.FromArgb(0xFF, 0xd8, 0xd8, 0xd8);
            pcb_add.BackgroundImage = Resources.Add;
        }

        private void pnl_main_MouseLeave(object sender, EventArgs e)
        {
            pnl_main.BackColor = Color.FromArgb(0xFF, 0xf0, 0xf0, 0xf0);
            pcb_add.BackgroundImage = null;
        }

        private void pnl_main_MouseUp(object sender, MouseEventArgs e)
        {
            onAddOpcode?.Invoke(this, e);
        }
    }
}
