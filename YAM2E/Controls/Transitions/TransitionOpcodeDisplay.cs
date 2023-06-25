using LAMP.Classes;
using LAMP.Controls;
using LAMP.FORMS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LAMP.Controls;

public partial class TransitionOpcodeDisplay : UserControl
{
    public TransitionOpcodeDisplay(TransitionOpcode o)
    { 
        InitializeComponent();
        pnl_parameters.BringToFront();
        lbl_opcode_name.Text = o.Description[0];
    }

    public List<byte> Data { get; set; }

    public bool Expanded
    {
        get => pnl_footer.Visible;
        set
        {
            pnl_footer.Visible = value;
            pnl_parameters.Visible = value;
        }
    }
}
