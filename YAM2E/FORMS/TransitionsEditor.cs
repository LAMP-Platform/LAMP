using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Windows.Forms;
using LAMP.Classes.M2_Data;
using LAMP.Controls;

namespace LAMP.FORMS;

public partial class TransitionsEditor : Form
{
    //Editor Vars
    public TransitionsEditor Current;

    //Transition Data
    Transition LoadedTransition;
    public int TransitionLength { get; set; }
    Dictionary<TreeNode, TreeNodeExtension> NodeData = new Dictionary<TreeNode, TreeNodeExtension>();
    public List<TransitionOpcode> Opcodes = new List<TransitionOpcode>();

    //Selected Transition Data
    TreeNode SelectedNode;
    int SelectedByte;
    int NodeValue;

    public TransitionsEditor(int TransitionIndex = 0)
    {
        Current = this;
        InitializeComponent();

        for (int i = 0; i < Globals.Transitions.Count; i++)
        {
            cbb_tred_transition_selection.Items.Add(i.ToString("X3"));
        }
        cbb_tred_transition_selection.SelectedIndex = TransitionIndex;
        cbb_tred_opcode_add.SelectedIndex = 0; //TODO: probably not needed after rewrite
    }

    void LoadTransition(int transition)
    {
        LoadedTransition = Globals.Transitions[transition];
        if (LoadedTransition.CopyOf != -1) //Transition is a duplicate
        {
            grp_transition_warning.Visible = true;

            string newLine = Environment.NewLine;
            txb_transition_info.Text = $"This Transition shares it's data with" + newLine + newLine +
                $"Transition {LoadedTransition.CopyOf.ToString("X3")}." + newLine + newLine +
                $"Every change applied to this Transition will also be applied to the base Transition " +
                $"and every other duplicate!";
            LoadedTransition = Globals.Transitions[LoadedTransition.CopyOf];
        }
        else
        {
            grp_transition_warning.Visible = false;
        }
    }

    void ReadTransition()
    {
        tre_tred_transition_tree.Nodes.Clear();

        //generating new Tree
        NodeData.Clear();
        pnlTransition.Controls.Clear();
        Opcodes.Clear();
        //try
        //{
            //NEW TRANSITION LOADING
            for (int i = 0; i < LoadedTransition.Data.Count;)
            {
                //putting data for each opcode into lists
                int length = GetOpcodeLength(LoadedTransition.Data[i]);
                List<Byte> data = LoadedTransition.Data.GetRange(i, length);

                Opcodes.Add(new TransitionOpcode(data, this));
                pnlTransition.Controls.Add(Opcodes[Opcodes.Count - 1]);
                i += length;
            }

            //OLD TRANSITION LOADING
            for (int i = 0; i < LoadedTransition.Data.Count; i++)
            {
                byte opcode = LoadedTransition.Data[i];
                byte parameter = (byte)(opcode & 0xF);
                byte parameter2;
                opcode &= 0xF0;

                TreeNode Command = null;
                TreeNode Parameter;

                //library of opcodes
                switch (opcode)
                {
                    case (0x00): //VRAM / Data Block Transfer
                        if (parameter == 0x1) Command = new TreeNode("Saves the bank and offset of a BG tileset");
                        if (parameter == 0x2) Command = new TreeNode("Saves the offset of a sprite tileset");
                        else Command = new TreeNode("Copies the data");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, OpcodeLength = 8 });

                        parameter = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"From bank: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i });

                        parameter = LoadedTransition.Data[++i];
                        parameter2 = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"At offset: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.Pointer });

                        parameter = LoadedTransition.Data[++i];
                        parameter2 = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"to offset: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.Pointer });

                        parameter = LoadedTransition.Data[++i];
                        parameter2 = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"Data length: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.Pointer });
                        break;

                    case (0x10): //Select metatile table
                        Command = new TreeNode("Select metatile table from");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, WhichByteToRead = ReadByte.HighNibble, OpcodeLength = 1 });

                        Parameter = new TreeNode($"Table: { parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.LowNibble });
                        break;

                    case (0x20): //Select collision table
                        Command = new TreeNode("Select collision table from");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, WhichByteToRead = ReadByte.HighNibble, OpcodeLength = 1 });

                        Parameter = new TreeNode($"Table: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.LowNibble });
                        break;

                    case (0x30): //Select solidity indexes
                        Command = new TreeNode("Select solidity indices from");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, WhichByteToRead = ReadByte.HighNibble, OpcodeLength = 1 });

                        Parameter = new TreeNode($"Table: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.LowNibble });
                        break;

                    case (0x40): //Warp
                        Command = new TreeNode("Warp to");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, WhichByteToRead = ReadByte.HighNibble, OpcodeLength = 2 });

                        Parameter = new TreeNode($"Area Bank: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.LowNibble });

                        parameter = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"and Screen X: {(parameter & 0xF):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.LowNibble });

                        Parameter = new TreeNode($"at Screen Y: {(parameter >> 4):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.HighNibble });
                        break;

                    case (0x50): //Retreat from Queen
                        Command = new TreeNode("Retreat from Queen fight");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, OpcodeLength = 1 });
                        break;

                    case (0x60): //Change acid & spike damage
                        Command = new TreeNode("Change acid & spike damage");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, OpcodeLength = 3 });

                        parameter = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"Acid damage: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i });

                        parameter = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"Spike damage: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i });
                        break;

                    case (0x70): //Exit Queen
                        Command = new TreeNode("Exit Queen fight");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, OpcodeLength = 1 });
                        break;

                    case (0x80): //Enter Queen
                        Command = new TreeNode("Enter Queen fight");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, WhichByteToRead = ReadByte.HighNibble, OpcodeLength = 9 });

                        Parameter = new TreeNode($"Bank for current room: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.LowNibble });

                        parameter = LoadedTransition.Data[++i];
                        parameter2 = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"Scroll Y position: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.Pointer });

                        parameter = LoadedTransition.Data[++i];
                        parameter2 = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"Scroll X position: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.Pointer });

                        parameter = LoadedTransition.Data[++i];
                        parameter2 = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"Samus Y position: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.Pointer });

                        parameter = LoadedTransition.Data[++i];
                        parameter2 = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"Samus X position: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.Pointer });
                        break;

                    case (0x90): //Conditional Transition
                        Command = new TreeNode("If");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, OpcodeLength = 4 });

                        parameter = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"Metroids alive <= {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i });

                        parameter = LoadedTransition.Data[++i];
                        parameter2 = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"Go to Transition index: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.Pointer });
                        break;

                    case (0xA0): //Fadeout
                        Command = new TreeNode("Fadeout");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, OpcodeLength = 1 });
                        break;

                    case (0xB0): //Load Graphics page
                        if (parameter == 0x1) Command = new TreeNode("Load Background graphics page from");
                        else if (parameter == 0x2) Command = new TreeNode("Load Sprite graphics page from");
                        else Command = new TreeNode("! Load graphics page operator incorrect !");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, OpcodeLength = 4 });

                        parameter = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"Bank: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i });

                        parameter = LoadedTransition.Data[++i];
                        parameter2 = LoadedTransition.Data[++i];
                        Parameter = new TreeNode($"At offset: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.Pointer });
                        break;

                    case (0xC0): //Change Music
                        Command = new TreeNode("Change music to");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, WhichByteToRead = ReadByte.HighNibble, OpcodeLength = 1 });

                        Parameter = new TreeNode($"Number: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.LowNibble });
                        break;

                    case (0xD0): //Load Message / Special Graphics
                        Command = new TreeNode("Change special graphics to");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, WhichByteToRead = ReadByte.HighNibble, OpcodeLength = 1 });

                        Parameter = new TreeNode($"Number: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, WhichByteToRead = ReadByte.LowNibble });
                        break;

                    case (0xF0): //Exit Transition
                        if (parameter == 0xF) Command = new TreeNode("END TRANSITION");
                        else Command = new TreeNode("! i n v a l i d !");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true });
                        break;

                    default:
                        Command = new TreeNode($"{opcode + parameter:X2}");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i });
                        break;
                }
                tre_tred_transition_tree.Nodes.Add(Command);
            }
        //}
        /*catch
        {
            MessageBox.Show("An error has occured while loading the Transition.\nMaybe the data is corrupt?", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }*/
        tre_tred_transition_tree.ExpandAll();
        TransitionLength = LoadedTransition.Data.Count;
        UpdateTransitionLength();
    }

    void ReloadTransition()
    {
        //try
        //{
            LoadTransition(cbb_tred_transition_selection.SelectedIndex);
            ReadTransition();
        //}
        /*catch
        {
            MessageBox.Show("An error has occured while loading the Transition.\nMaybe the data is corrupt?", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }*/
    }

    void EnableEdit()
    {
        DisableEdit();
        TreeNodeExtension Data = NodeData.GetValueOrDefault(tre_tred_transition_tree.SelectedNode);
        if (!Data.IsOpcode)
        {
            num_tred_value.Enabled = true;
            lbl_tred_value.Enabled = true;
            btn_tred_transition_update.Enabled = true;
        }
        else
        {
            btn_tred_add_opcode.Enabled = true;
            btn_tred_remove_opcode.Enabled = true;
            btn_tred_move_opcode_down.Enabled = true;
            btn_tred_move_opcode_up.Enabled = true;
            cbb_tred_opcode_add.Enabled = true;
        }
        num_tred_value.Value = NodeValue;
    }

    void DisableEdit()
    {
        num_tred_value.Enabled = false;
        lbl_tred_value.Enabled = false;
        btn_tred_transition_update.Enabled = false;
        btn_tred_add_opcode.Enabled = false;
        btn_tred_remove_opcode.Enabled = false;
        btn_tred_move_opcode_down.Enabled = false;
        btn_tred_move_opcode_up.Enabled = false;
        cbb_tred_opcode_add.Enabled = false;
    }

    public void SaveTransition()
    {
        LoadedTransition.Data.Clear();

        //Add all the data from all the Opcodes
        foreach(TransitionOpcode o in Opcodes)
        {
            for (int i = 0; i < o.Data.Count; i++)
            {
                LoadedTransition.Data.Add(o.Data[i]);
            }
        }
    }

    void UpdateTransitionValue()
    {
        try
        {
            if (tre_tred_transition_tree.SelectedNode == null) return;
            int value = (int)num_tred_value.Value;
            TreeNodeExtension Data = NodeData.GetValueOrDefault(SelectedNode);
            SelectedByte = Data.Byte;
            if (Data.WhichByteToRead == ReadByte.WholeByte)
            {
                LoadedTransition.Data[SelectedByte] = (byte)value;
            }
            if (Data.WhichByteToRead == ReadByte.HighNibble)
            {
                LoadedTransition.Data[SelectedByte] = (byte)((LoadedTransition.Data[SelectedByte] & 0xF) + (value << 4));
            }
            if (Data.WhichByteToRead == ReadByte.LowNibble)
            {
                LoadedTransition.Data[SelectedByte] = (byte)((LoadedTransition.Data[SelectedByte] & 0xF0) + (value & 0xF));
            }
            if (Data.WhichByteToRead == ReadByte.Pointer)
            {
                LoadedTransition.Data[SelectedByte - 1] = (byte)(value & 0xFF);
                LoadedTransition.Data[SelectedByte] = (byte)(value >> 8);
            }
            ReadTransition();

            DisableEdit();
        }
        catch
        {
            MessageBox.Show("An error has occured while changing the value. This is not supposed to happen. Please report this issue", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void UpdateTransitionLength()
    {
        lbl_tred_transition_length.Text = $"Transition Length: {TransitionLength} out of 64 bytes";
        gauTransitionLength.ChangeValue((double)TransitionLength / (double)64);
    }

    /// <summary>
    /// Returns the number of bytes that the opcode uses
    /// </summary>
    int GetOpcodeLength(byte Value)
    {
        Value &= 0xF0;
        switch (Value)
        {
            case 0x00:
                return 8;

            case 0x10:
                return 1;

            case 0x20:
                return 1;

            case 0x30:
                return 1;

            case 0x40:
                return 2;

            case 0x50:
                return 1;

            case 0x60:
                return 3;

            case 0x70:
                return 1;

            case 0x80:
                return 9;

            case 0x90:
                return 4;

            case 0xA0:
                return 1;

            case 0xB0:
                return 4;

            case 0xC0:
                return 1;

            case 0xD0:
                return 1;

            case 0xF0:
                return 1;

            default:
                return 1;
        }

        
    }

    /// <summary>
    /// Returns the number of bytes that the opcode at the given position in the transition uses
    /// </summary>
    int GetOpcodeLength(int Offset)
    {
        return (GetOpcodeLength(LoadedTransition.Data[Offset]));
    }

    #region Events
    private void tre_tred_transition_tree_AfterSelect(object sender, TreeViewEventArgs e)
    {
        SelectedNode = tre_tred_transition_tree.SelectedNode;
        TreeNodeExtension Data = NodeData.GetValueOrDefault(SelectedNode);
        SelectedByte = Data.Byte;
        NodeValue = LoadedTransition.Data[SelectedByte];
        num_tred_value.Maximum = 0xFF;
        if (Data.WhichByteToRead == ReadByte.HighNibble)
        {
            NodeValue >>= 4;
            num_tred_value.Maximum = 0xF;
        }
        if (Data.WhichByteToRead == ReadByte.LowNibble)
        {
            NodeValue &= 0xF;
            num_tred_value.Maximum = 0xF;
        }
        if (Data.WhichByteToRead == ReadByte.Pointer)
        {
            NodeValue = LoadedTransition.Data[SelectedByte - 1] + (NodeValue << 8);
            num_tred_value.Maximum = 0xFFFF;
        }

        EnableEdit();
    }

    private void cbb_tred_transition_selection_SelectedIndexChanged(object sender, EventArgs e)
    {
        ReloadTransition();
        DisableEdit();
    }

    private void btn_tred_transition_update_Click(object sender, EventArgs e)
    {
        UpdateTransitionValue();
    }

    private void btn_tred_remove_opcode_Click(object sender, EventArgs e)
    {
        TreeNodeExtension Data = NodeData.GetValueOrDefault(SelectedNode);
        if (Data.OpcodeLength == 0)
        {
            MessageBox.Show("A Transition has to end.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        for (int i = 0; i < Data.OpcodeLength; i++)
        {
            LoadedTransition.Data.RemoveAt(Data.Byte);
        }
        DisableEdit();
        ReadTransition();
    }

    private void btn_tred_move_opcode_up_Click(object sender, EventArgs e)
    {
        TreeNodeExtension Data = NodeData.GetValueOrDefault(SelectedNode);

        //Dont want to move up if its last or first instruction
        if (Data.Byte == 0) return;
        if (LoadedTransition.Data[Data.Byte] == 0xFF) return;

        //finding instruction above
        int AboveByte = 0;
        for (int i = 0; i < LoadedTransition.Data.Count;)
        {
            int len = GetOpcodeLength(i);
            if (i + len == Data.Byte) //above instruction has been found
            {
                AboveByte = i;
            }
            i += len;
        }

        //moving data
        List<byte> MovedData = LoadedTransition.Data.GetRange(Data.Byte, Data.OpcodeLength);
        for (int i = 0; i < Data.OpcodeLength; i++)
        {
            LoadedTransition.Data.RemoveAt(Data.Byte);
        }
        LoadedTransition.Data.InsertRange(AboveByte, MovedData);
        DisableEdit();
        ReadTransition();
    }

    private void btn_tred_move_opcode_down_Click(object sender, EventArgs e)
    {
        TreeNodeExtension Data = NodeData.GetValueOrDefault(SelectedNode);

        //Dont want to move down if last instruction or only last instruction left below
        if (Data.OpcodeLength == 0xFF) return;
        int NextCodeLength = GetOpcodeLength(Data.Byte + Data.OpcodeLength);
        if (Data.Byte + Data.OpcodeLength == LoadedTransition.Data.Count) return;
        if (NextCodeLength == 0xFF) return;

        //moving data
        List<byte> MovedData = LoadedTransition.Data.GetRange(Data.Byte, Data.OpcodeLength);
        for (int i = 0; i < Data.OpcodeLength; i++)
        {
            LoadedTransition.Data.RemoveAt(Data.Byte);
        }
        LoadedTransition.Data.InsertRange(Data.Byte + NextCodeLength, MovedData);
        DisableEdit();
        ReadTransition();
    }

    private void btn_tred_add_opcode_Click(object sender, EventArgs e)
    {
        byte[] codeData;
        TreeNodeExtension Data = NodeData.GetValueOrDefault(SelectedNode);
        switch (cbb_tred_opcode_add.SelectedIndex)
        {
            case 0: //save Bank offset BG tileset
                codeData = new byte[] { 0x01, 0, 0, 0, 0, 0, 0, 0 };
                break;

            case 1: //save offset of sprite tileset
                codeData = new byte[] { 0x02, 0, 0, 0, 0, 0, 0, 0 };
                break;

            case 2: //copies data
                codeData = new byte[] { 0x00, 0, 0, 0, 0, 0, 0, 0 };
                break;

            case 3: //metatile table
                codeData = new byte[] { 0x10 };
                break;

            case 4: //collision table
                codeData = new byte[] { 0x20 };
                break;

            case 5: //solidity table
                codeData = new byte[] { 0x30 };
                break;

            case 6: //warp
                codeData = new byte[] { 0x40, 0 };
                break;

            case 7: //retreat queen
                codeData = new byte[] { 0x50 };
                break;

            case 8: //change acid spike damage
                codeData = new byte[] { 0x60, 2, 8 };
                break;

            case 9: //exit queen
                codeData = new byte[] { 0x70 };
                break;

            case 10: //transition queen
                codeData = new byte[] { 0x80, 0, 0, 0, 0, 0, 0, 0, 0 };
                break;

            case 11: //conditional operator
                codeData = new byte[] { 0x90, 0, 0, 0 };
                break;

            case 12: //fadeout
                codeData = new byte[] { 0xA0 };
                break;

            case 13: //load bg graphics
                codeData = new byte[] { 0xB1, 0, 0, 0 };
                break;

            case 14: //load sprite graphics
                codeData = new byte[] { 0xB2, 0, 0, 0 };
                break;

            case 15: //change music
                codeData = new byte[] { 0xC0 };
                break;

            case 16: //change special graphics
                codeData = new byte[] { 0xD0 };
                break;

            case 17: //End
                codeData = new byte[] { 0xFF };
                if (LoadedTransition.Data[LoadedTransition.Data.Count - 1] == 0xFF) //End already exists
                {
                    MessageBox.Show("An end already exists.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                break;

            default:
                codeData = new byte[0];
                break;
        }

        //Checking that the data doesnt get longer than 66 bytes
        int len = GetOpcodeLength(codeData[0]);
        if (LoadedTransition.Data.Count + len > 64)
        {
            MessageBox.Show($"A new Opcode cannot be added.\n" +
                            $"The transition cannot exceed a length of 64 bytes!\n\n" +
                            $"Remove existing Opcodes to reduce the length of the Transition.\n",
                            "Length limit reached!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        //adding Data
        LoadedTransition.Data.InsertRange(Data.Byte, codeData);
        if (codeData[0] == 0xFF)
        {
            //remove data after end
            LoadedTransition.Data.RemoveRange(Data.Byte + 1, LoadedTransition.Data.Count - Data.Byte - 1);
        }
        DisableEdit();
        ReadTransition();
    }

    private void btn_seperate_transition_Click(object sender, EventArgs e)
    {
        Transition t = Globals.Transitions[cbb_tred_transition_selection.SelectedIndex];
        t.Data = new List<byte>(LoadedTransition.Data);
        t.CopyOf = -1;
        ReloadTransition();
    }
    #endregion
}