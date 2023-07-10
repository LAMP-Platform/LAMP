using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LAMP.Classes;
using LAMP.Classes.M2_Data;
using LAMP.Controls;
using LAMP.Utilities;

namespace LAMP.FORMS;

public partial class TransitionsEditor : Form
{
    //Transition Editor Fields
    public int TransitionLength
    {
        get => transitionLength;
        set
        {
            if (transitionLength == value) return;
            transitionLength = value;

            lbl_tred_transition_length.Text = $"Transition Length: {Format.IntToString(value)} out of {Format.IntToString(64)} bytes";
            gau_transition_length.Value = value / 64d;
        }
    }
    int transitionLength;

    int SelectedIndex
    {
        get => selectedIndex;
        set
        {
            if (selectedIndex == value) return;
            selectedIndex = value;

            ReloadTransition();
        }
    }
    int selectedIndex = -1; //This is set to -1 because the index will initially be 0, therefore, we still want to trigger this once

    public List<TransitionOpcodeDisplay> Opcodes = new List<TransitionOpcodeDisplay>();

    Transition LoadedTransition
    {
        get => loadedTransition;
        set
        {
            if (loadedTransition == value) return;
            loadedTransition = value;

            LoadTransition();
        }
    }
    Transition loadedTransition;

    //Constructor
    public TransitionsEditor(int TransitionIndex = 0)
    {
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

    void LoadTransition()
    {
        if (LoadedTransition.CopyOf != -1) //Transition is a duplicate
        {
            pnlTransition.Controls.Clear();
            pnl_warning.Visible = true;

            string newLine = Environment.NewLine;
            txb_transition_info.Text = $"This Transition shares it's data with" + newLine + newLine +
                $"Transition {LoadedTransition.CopyOf:X3}.";
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

        //Set Transition name
        txb_transition_name.Text = LoadedTransition.Name;

        //Clear existing controls of prior transiition
        pnlTransition.Controls.Clear();

        for (int i = 0; i < LoadedTransition.Data.Count;)
        {
            //Finding the current opcode
            TransitionOpcode currentOpcode = Globals.LoadedProject.TransitionOpcodes[0];
            foreach (TransitionOpcode code in Globals.LoadedProject.TransitionOpcodes)
            {
                byte currentByte = LoadedTransition.Data[i]; //The opcode Index
                if (code.OpcodeIndex < 0x10) currentByte = (byte)(currentByte >> 4); //We have to shift the byte so the index can overlap if its only 4 bits long
                if (code.OpcodeIndex == currentByte)
                {
                    currentOpcode = code;
                    break;
                }
            }

            //putting data for each opcode into lists
            int length = currentOpcode.OpcodeLength;
            List<Byte> data = LoadedTransition.Data.GetRange(i, length);

            TransitionOpcodeDisplay o = new TransitionOpcodeDisplay(currentOpcode)
            {
                Dock = DockStyle.Top
            };
            Opcodes.Add(o);
            pnlTransition.Controls.Add(Opcodes[Opcodes.Count - 1]);
            o.BringToFront();
            i += length;
        }

        TransitionLength = LoadedTransition.Data.Count;
        pnlTransition.ResumeLayout();
    }

    void ReloadTransition()
    {
        //try
        //{
            LoadedTransition = Globals.Transitions[SelectedIndex];
            ReadTransition();
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show($"An error has occured while loading the Transition.\n\n{ex}\n\nMaybe the data is corrupt?", "Error",
        //        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
    }

    public void SaveTransition()
    {
        //TODO: Rewrite
    }

    #region Events
    private void cbb_tred_transition_selection_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectedIndex = cbb_tred_transition_selection.SelectedIndex;
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
        int index = SelectedIndex;
        if (LoadedTransition.Name == txb_transition_name.Text) return;

        LoadedTransition.Name = txb_transition_name.Text;
        string name = LoadedTransition.Name != "" ? $" - {LoadedTransition.Name}" : "";

        cbb_tred_transition_selection.Items[index] = index.ToString("X3") + name;

        ComboboxOp.AutoSize(cbb_tred_transition_selection);
    }

    #endregion
}