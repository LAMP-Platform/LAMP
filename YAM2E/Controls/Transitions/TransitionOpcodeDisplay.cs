using LAMP.Classes;
using LAMP.Controls;
using LAMP.FORMS;
using LAMP.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LAMP.Controls;

public partial class TransitionOpcodeDisplay : UserControl
{
    #region FIELDS
    TransitionOpcode opcode;

    public List<byte> Data { get; set; }

    public bool Expanded
    {
        get => pnl_parameters.Visible;
        set
        {
            pnl_parameters.Visible = value;
            pnl_footer.Visible = value;
            Seperator.Visible = value;

            if (Expanded) btn_expand.Image = Resources.CollapseArrow;
            else btn_expand.Image = Resources.ExpandArrow;
        }
    }
    #endregion

    //CONSTRUCTOR
    public TransitionOpcodeDisplay(TransitionOpcode o)
    {
        InitializeComponent();
        pnl_parameters.BringToFront();
        opcode = o;
        lbl_opcode_name.Text = o.Description[0];

        btn_expand.Visible = o.isExpandable;
        if (o.isExpandable) return;

        //Move remove button to top header if no parameters exist
        pnl_header.Controls.Add(btn_remove_opcode);
        btn_remove_opcode.Location = btn_expand.Location;
        pnl_footer.Visible = false;
        Seperator.Visible = false;
    }

    #region CUSTOM EVENTS
    public EventHandler onParameterChanged { get; set; }
    public event EventHandler ParameterChanged
    {
        add
        {
            onParameterChanged += value;
        }
        remove
        {
            onParameterChanged -= value;
        }

    }
    public virtual void OnParameterChanged(EventArgs e)
    {
        onParameterChanged?.Invoke(this, e);
    }
    #endregion

    #region Events
    /// <summary>
    /// Clicked somewhere on the header to expand
    /// </summary>
    private void pnl_header_MouseClick(object sender, MouseEventArgs e)
    {
        if (!opcode.isExpandable) return;

        //Opcode can be expandend
        Expanded = !Expanded;
    }

    /// <summary>
    /// Code for handling background color
    /// </summary>
    private void lbl_opcode_name_MouseMove(object sender, MouseEventArgs e)
    {
        if (!opcode.isExpandable) return;
        pnl_header.BackColor = Color.FromArgb(0xFF, 0xd8, 0xd8, 0xd8);
    }
    private void lbl_opcode_name_MouseLeave(object sender, EventArgs e)
    {
        if (!opcode.isExpandable) return;
        pnl_header.BackColor = Color.FromArgb(0xFF, 0xf0, 0xf0, 0xf0);
    }
    #endregion
}
