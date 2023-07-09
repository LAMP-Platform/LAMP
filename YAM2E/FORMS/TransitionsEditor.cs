using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Windows.Forms;
using LAMP.Classes;
using LAMP.Classes.M2_Data;
using LAMP.Controls;
using LAMP.Controls.Other;
using LAMP.Utilities;

namespace LAMP.FORMS;

public partial class TransitionsEditor : Form
{
    //Editor Vars
    public TransitionsEditor Current;

    //Transition Data
    Transition LoadedTransition;
    public int TransitionLength { get; set; }
    Dictionary<TreeNode, TreeNodeExtension> NodeData = new Dictionary<TreeNode, TreeNodeExtension>();
    public List<TransitionOpcodeDisplay> Opcodes = new List<TransitionOpcodeDisplay>();

    //Held Opcode data
    //for moving the opcodes around
    public TransitionOpcodeDisplay HeldOpcode = null;

    //Warning Panel
    Panel warningPanel;


    bool preventSave = false; //When changing transitions it saves the old transition on the new one
                              //preventSave should be set after switching a transition to prevent this
    bool preventReload = false; //Prevents the combobox from reloading the transition if a rename was done

    public TransitionsEditor(int TransitionIndex = 0)
    {
        Current = this;
        InitializeComponent();
        txb_warning_header.BackColor = DefaultBackColor;

        for (int i = 0; i < Globals.Transitions.Count; i++)
        {
            Transition check = Globals.Transitions[i];
            string name = check.Name != "" ? $" - {check.Name}" : "";
            cbb_tred_transition_selection.Items.Add(i.ToString("X3") + name);
        }
        ComboboxOp.AutoSize(cbb_tred_transition_selection);
        cbb_tred_transition_selection.SelectedIndex = TransitionIndex;

        string txt = "";
        string newLine = Environment.NewLine;
        foreach (TransitionOpcode o in Globals.LoadedProject.TransitionOpcodes)
        {
            txt += o.Description[0] + newLine;
        }
        txb_opcodes.Text = txt;
    }

    void LoadTransition(int transition)
    {
        SaveTransition();
        preventSave = true; //preventing copy of old transition

        LoadedTransition = Globals.Transitions[transition];
        if (LoadedTransition.CopyOf != -1) //Transition is a duplicate
        {
            pnlTransition.Controls.Clear();
            pnl_warning.Visible = true;

            string newLine = Environment.NewLine;
            txb_transition_info.Text = $"This Transition shares it's data with" + newLine + newLine +
                $"Transition {LoadedTransition.CopyOf.ToString("X3")}.";
            LoadedTransition = Globals.Transitions[LoadedTransition.CopyOf];
        }
        else
        {
            pnl_warning.Visible = false;
        }
    }

    void ReadTransition()
    {
        pnlTransition.SuspendLayout();

        //Transition name
        txb_transition_name.Text = LoadedTransition.Name;
        preventReload = false;

        pnlTransition.Controls.Clear();
        //try
        //{
        //NEW TRANSITION LOADING
        for (int i = 0; i < LoadedTransition.Data.Count;)
        {
            //putting data for each opcode into lists
            int length = 1;
            List<Byte> data = LoadedTransition.Data.GetRange(i, length);

            TransitionOpcodeDisplay o = new TransitionOpcodeDisplay(Globals.LoadedProject.TransitionOpcodes[0])
            {
                Dock = DockStyle.Top
            };
            Opcodes.Add(o);
            pnlTransition.Controls.Add(Opcodes[Opcodes.Count - 1]);
            i += length;
        }
        //}
        /*catch
        {
            MessageBox.Show("An error has occured while loading the Transition.\nMaybe the data is corrupt?", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }*/
        TransitionLength = LoadedTransition.Data.Count;
        UpdateTransitionLength();
        pnlTransition.ResumeLayout();
    }

    void ReloadTransition()
    {
        try
        {
        LoadTransition(cbb_tred_transition_selection.SelectedIndex);
        ReadTransition();
        }
        catch(Exception ex)
        {
            MessageBox.Show($"An error has occured while loading the Transition.\n\n{ex}\n\nMaybe the data is corrupt?", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void SaveTransition()
    {
        if (LoadedTransition == null || preventSave)
        {
            preventSave = false;
            return;
        }

        LoadedTransition.Data.Clear();

        //Add all the data from all the Opcodes
        foreach (TransitionOpcodeDisplay o in pnlTransition.Controls)
        {
        }
    }

    public void UpdateTransitionLength()
    {
        lbl_tred_transition_length.Text = $"Transition Length: {Format.IntToString(TransitionLength)} out of {Format.IntToString(64)} bytes";
        gau_transition_length.Value = TransitionLength / 64d;
    }

    #region Events
    private void cbb_tred_transition_selection_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (preventReload)
        {
            preventReload = false;
            return;
        }

        ReloadTransition();
    }

    private void btn_seperate_transition_Click(object sender, EventArgs e)
    {
        Transition t = Globals.Transitions[cbb_tred_transition_selection.SelectedIndex];
        t.Data = new List<byte>(LoadedTransition.Data);
        t.CopyOf = -1;
        ReloadTransition();
    }

    private void txb_transition_name_TextChanged(object sender, EventArgs e)
    {
        int index = cbb_tred_transition_selection.SelectedIndex;

        LoadedTransition.Name = txb_transition_name.Text;
        string name = LoadedTransition.Name != "" ? $" - {LoadedTransition.Name}" : "";

        preventReload = true;
        cbb_tred_transition_selection.Items[index] = index.ToString("X3") + name;

        ComboboxOp.AutoSize(cbb_tred_transition_selection);
    }

    #endregion
}