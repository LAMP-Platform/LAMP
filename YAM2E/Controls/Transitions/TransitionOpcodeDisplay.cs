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
    bool appliedChange = false;

    public List<byte> Data { get; set; }
    private List<OpcodeParameter> Parameters { get; set; } = new List<OpcodeParameter>();
    public int Length
    {
        get => Opcode.OpcodeLength;
    }

    public bool MoveUpEnabled
    {
        get => btn_move_up.Enabled;
        set
        {
            btn_move_up.Enabled = value;
        }
    }
    public bool MoveDownEnabled
    {
        get => btn_move_down.Enabled;
        set
        {
            btn_move_down.Enabled = value;
        }
    }

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

        //Move the buttons to top header if no parameters exist
        pnl_header.Controls.Add(btn_remove_opcode);
        pnl_header.Controls.Add(btn_move_down);
        pnl_header.Controls.Add(btn_move_up);
        btn_remove_opcode.Location = btn_expand.Location;
        btn_move_down.Location = new Point(btn_expand.Location.X - 26, btn_expand.Location.Y);
        btn_move_up.Location = new Point(btn_move_down.Location.X - 26, btn_move_down.Location.Y);

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

    public EventHandler onRemoveOpcode { get; set; }
    public event EventHandler RemoveOpcode
    {
        add
        {
            onRemoveOpcode += value;
        }
        remove
        {
            onRemoveOpcode -= value;
        }
    }

    public EventHandler onMoveOpcodeUp { get; set; }
    public event EventHandler MoveOpcodeUp
    {
        add
        {
            onMoveOpcodeUp += value;
        }
        remove
        {
            onMoveOpcodeUp -= value;
        }
    }

    public EventHandler onMoveOpcodeDown { get; set; }
    public event EventHandler MoveOpcodeDown
    {
        add
        {
            onMoveOpcodeDown += value;
        }
        remove
        {
            onMoveOpcodeDown -= value;
        }
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
            parameter.txb_Parameter.Leave += txb_parameter_Leave;

            //Adding data
            if (Opcode.NybbleIndices[i] == null) continue;

            parameter.txb_Parameter.Text = Format.IntToString(getParameterValue(i));
        }

        init = false;
    }
    private int getParameterValue(int parameterIndex)
    {
        int dataStart = (int)Opcode.NybbleIndices[parameterIndex];
        int dataLength = Opcode.ParameterLength[parameterIndex];

        int value = 0;

        for (int j = 0; j < dataLength; j++)
        {
            int writeHeadPosition = dataLength - 1 - j; //The data will be read per nybble 
            value += ByteOp.GetNybble(Data, dataStart + j) << (4 * writeHeadPosition);
        }

        //switching the bytes if length is 4 nybbles
        if (dataLength == 4) value = ByteOp.SwitchBytes(value);

        return value;
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
        if (appliedChange)
        {
            appliedChange = false;
            return;
        }

        TextBox box = (TextBox)sender;
        int boxindex = 0;

        //Figuring out at which index the parameter is
        for (int i = 0; i < Parameters.Count; i++)
        {
            if (Parameters[i].txb_Parameter != box) continue;
            boxindex = i + 1; // +1 since the first index is for the opcode title
            break;
        }

        //Writing back that value
        int dataStart = (int)Opcode.NybbleIndices[boxindex];
        int dataLength = Opcode.ParameterLength[boxindex];
        int value = Format.StringToInt(box.Text, (int)Math.Pow(16, dataLength) - 1);
        if (dataLength == 4) value = ByteOp.SwitchBytes(value); //Switching if 2 bytes

        //Writing the data to the array
        for (int i = 0; i < dataLength; i++)
        {
            ByteOp.SetNybble(Data, dataStart + i, (byte)((value >> ((dataLength - 1 - i) * 4)) & 0xF));
        }

        OnParameterChanged(new EventArgs());
    }

    public void txb_parameter_Leave(object sender, EventArgs e)
    {
        TextBox box = (TextBox)sender;
        int boxindex = 0;

        //Figuring out at which index the parameter is
        for (int i = 0; i < Parameters.Count; i++)
        {
            if (Parameters[i].txb_Parameter != box) continue;
            boxindex = i + 1; // +1 since the first index is for the opcode title
            break;
        }

        appliedChange = true;
        box.Text = Format.IntToString(getParameterValue(boxindex));
    }

    private void btn_remove_opcode_Click(object sender, EventArgs e) => onRemoveOpcode?.Invoke(this, e);

    private void btn_move_down_Click(object sender, EventArgs e) => onMoveOpcodeDown?.Invoke(this, e);

    private void btn_move_up_Click(object sender, EventArgs e) => onMoveOpcodeUp?.Invoke(this, e);
    #endregion
}
