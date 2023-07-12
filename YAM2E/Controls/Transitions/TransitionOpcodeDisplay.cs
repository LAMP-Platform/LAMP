using LAMP.Classes;
using LAMP.Controls;
using LAMP.Controls.Other;
using LAMP.FORMS;
using LAMP.Properties;
using LAMP.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LAMP.Controls;

public partial class TransitionOpcodeDisplay : UserControl
{
    #region FIELDS
    TransitionOpcode Opcode;

    bool init = true;

    public List<byte> Data { get; set; }
    private List<OpcodeParameter> Parameters { get; set; } = new List<OpcodeParameter>();

    /// <summary>
    /// Whether the parameters are shown or not
    /// </summary>
    public bool Expanded
    {
        get => pnl_parameters.Visible;
        set
        {
            if (!Opcode.isExpandable) return;

            pnl_parameters.Visible = value;
            pnl_footer.Visible = value;
            Seperator.Visible = value;

            if (Expanded) btn_expand.Image = Resources.CollapseArrow;
            else btn_expand.Image = Resources.ExpandArrow;

            //generating the parameters if they dont exist
            if (Parameters.Count == 0) PopulateParameters();
        }
    }
    #endregion

    //CONSTRUCTOR
    public TransitionOpcodeDisplay(TransitionOpcode o)
    {
        InitializeComponent();
        pnl_parameters.BringToFront();
        Opcode = o;
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

    private void PopulateParameters()
    {
        for (int i = 1; i < Opcode.Description.Length; i++)
        {
            string currentTitle = Opcode.Description[i];
            OpcodeParameter parameter = new OpcodeParameter(currentTitle, Opcode.NybbleIndices[i] != null);
            parameter.Dock = DockStyle.Top;
            parameter.Visible = true;
            pnl_parameters.Controls.Add(parameter);
            parameter.BringToFront();
            Parameters.Add(parameter);

            if (parameter.txb_Parameter == null) continue;

            //Adding event
            parameter.txb_Parameter.TextChanged += txb_parameter_TextChanged;

            //Adding data
            if (Opcode.NybbleIndices[i] == null) continue;

            int dataStart = (int)Opcode.NybbleIndices[i];
            int dataLength = Opcode.ParameterLength[i];

            int value = 0;

            for (int j = 0; j < dataLength; j++)
            {
                int writeHeadPosition = dataLength - 1 - j; //The data will be read per nybble 
                value += ByteOp.GetNybble(Data, dataStart + j) << (4 * writeHeadPosition);
            }

            //switching the bytes if length is 4 nybbles
            if (dataLength == 4) value = ByteOp.SwitchBytes(value);

            parameter.txb_Parameter.Text = Format.IntToString(value);
        }

        init = false;
    }

    #region Events
    /// <summary>
    /// Clicked somewhere on the header to expand
    /// </summary>
    private void pnl_header_MouseClick(object sender, MouseEventArgs e)
    {
        if (!Opcode.isExpandable) return;

        //Opcode can be expandend
        Expanded = !Expanded;
    }

    /// <summary>
    /// Code for handling background color
    /// </summary>
    private void lbl_opcode_name_MouseMove(object sender, MouseEventArgs e)
    {
        if (!Opcode.isExpandable) return;
        pnl_header.BackColor = Color.FromArgb(0xFF, 0xd8, 0xd8, 0xd8);
    }
    private void lbl_opcode_name_MouseLeave(object sender, EventArgs e)
    {
        if (!Opcode.isExpandable) return;
        pnl_header.BackColor = Color.FromArgb(0xFF, 0xf0, 0xf0, 0xf0);
    }

    public void txb_parameter_TextChanged(object sender, EventArgs e)
    {
        if (init) return;
        TextBox box = (TextBox)sender;

        //Figuring out at which position the opcode is
        for (int i = 0; i < Parameters.Count; i++)
        {
            if (Parameters[i].txb_Parameter != box) continue;
            box.Text = i.ToString();
            return;
        }
    }
    #endregion
}
