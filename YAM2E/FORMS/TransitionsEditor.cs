using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using YAM2E.Classes;

namespace YAM2E.FORMS;

public partial class TransitionsEditor : Form
{
    //Editor Vars
    //Transition Data
    int TableOffset = 0x142E5;
    int BankOffset = 0x14000;
    int CurrentTransitionOffset;
    int BankTransitionOffset;
    List<byte> Transition = new List<byte>();
    int TransitionLength;
    byte[] OldTransition;
    Dictionary<TreeNode, TreeNodeExtension> NodeData = new Dictionary<TreeNode, TreeNodeExtension>();

    //Selected Transition Data
    TreeNode SelectedNode;
    int SelectedByte;
    int NodeValue;

    public TransitionsEditor()
    {
        InitializeComponent();

        for (int i = 0; i < 512; i++)
        {
            cbb_tred_transition_selection.Items.Add(i.ToString("X3"));
        }
        cbb_tred_transition_selection.SelectedIndex = 0;
    }

    void LoadTransition(int transition)
    {
        //offset for the transition
        int offset = Editor.ROM[TableOffset + (2 * transition)];
        offset += (Editor.ROM[TableOffset + (2 * transition) + 1]) << 8;
        BankTransitionOffset = offset;
        offset += BankOffset - 0x4000;
        CurrentTransitionOffset = offset;

        //loading Transition
        lbl_tred_error_warning.Visible = false;
        bool EndFound = false;
        Transition.Clear();
        for (int i = 0; i < 64; i++)
        {
            byte val = Editor.ROM[offset + i];
            Transition.Add(val);
            if (val == 0xFF)
            {
                EndFound = true;
                break;
            }
        }

        OldTransition = Transition.ToArray();
        TransitionLength = Transition.Count;
        if (!EndFound) lbl_tred_error_warning.Visible = true;
        lbl_tred_transition_length.Text = $"Transition Length: {TransitionLength} bytes";
        num_tred_transition_pointer.Value = BankTransitionOffset;
        UpdateRawData();
    }

    void ReadTransition()
    {
        tre_tred_transition_tree.Nodes.Clear();

        //generating new Tree
        NodeData.Clear();
        try
        {
            for (int i = 0; i < Transition.Count; i++)
            {
                byte opcode = Transition[i];
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

                        parameter = Transition[++i];
                        Parameter = new TreeNode($"From bank: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i });

                        parameter = Transition[++i];
                        parameter2 = Transition[++i];
                        Parameter = new TreeNode($"At offset: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.Pointer });

                        parameter = Transition[++i];
                        parameter2 = Transition[++i];
                        Parameter = new TreeNode($"to offset: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.Pointer });

                        parameter = Transition[++i];
                        parameter2 = Transition[++i];
                        Parameter = new TreeNode($"Data length: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.Pointer });
                        break;

                    case (0x10): //Select metatile table
                        Command = new TreeNode("Select metatiles from");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, ByteRead = ReadByte.HighNybble, OpcodeLength = 1 });

                        Parameter = new TreeNode($"Table: { parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.LowNybble });
                        break;

                    case (0x20): //Select collision table
                        Command = new TreeNode("Select collision from");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, ByteRead = ReadByte.HighNybble, OpcodeLength = 1 });

                        Parameter = new TreeNode($"Table: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.LowNybble });
                        break;

                    case (0x30): //Select solidity indexes
                        Command = new TreeNode("Select solidity indices from");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, ByteRead = ReadByte.HighNybble, OpcodeLength = 1 });

                        Parameter = new TreeNode($"Table: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.LowNybble });
                        break;

                    case (0x40): //Warp
                        Command = new TreeNode("Warp to");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, ByteRead = ReadByte.HighNybble, OpcodeLength = 2 });

                        Parameter = new TreeNode($"Area Bank: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.LowNybble });

                        parameter = Transition[++i];
                        Parameter = new TreeNode($"at Screen Y: {(parameter >> 4):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.HighNybble });

                        Parameter = new TreeNode($"and Screen X: {(parameter & 0xF):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.LowNybble });
                        break;

                    case (0x50): //Retreat from Queen
                        Command = new TreeNode("Retreat from Queen fight");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, OpcodeLength = 1 });
                        break;

                    case (0x60): //Change acid & spike damage
                        Command = new TreeNode("Change acid & spike damage");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, OpcodeLength = 3 });

                        parameter = Transition[++i];
                        Parameter = new TreeNode($"Acid damage: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i });

                        parameter = Transition[++i];
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
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, ByteRead = ReadByte.HighNybble, OpcodeLength = 9 });

                        Parameter = new TreeNode($"Bank for current room: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.LowNybble });

                        parameter = Transition[++i];
                        parameter2 = Transition[++i];
                        Parameter = new TreeNode($"Scroll Y position: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.Pointer });

                        parameter = Transition[++i];
                        parameter2 = Transition[++i];
                        Parameter = new TreeNode($"Scroll X position: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.Pointer });

                        parameter = Transition[++i];
                        parameter2 = Transition[++i];
                        Parameter = new TreeNode($"Samus Y position: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.Pointer });

                        parameter = Transition[++i];
                        parameter2 = Transition[++i];
                        Parameter = new TreeNode($"Samus X position: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.Pointer });
                        break;

                    case (0x90): //Conditional Transition
                        Command = new TreeNode("Go to a different Transition if");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, OpcodeLength = 4 });

                        parameter = Transition[++i];
                        Parameter = new TreeNode($"Metroids alive <= {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i });

                        parameter = Transition[++i];
                        parameter2 = Transition[++i];
                        Parameter = new TreeNode($"New Transition offset: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.Pointer });
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

                        parameter = Transition[++i];
                        Parameter = new TreeNode($"Bank: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i });

                        parameter = Transition[++i];
                        parameter2 = Transition[++i];
                        Parameter = new TreeNode($"At offset: {parameter + (parameter2 << 8):X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.Pointer });
                        break;

                    case (0xC0): //Change Music
                        Command = new TreeNode("Change music to");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, ByteRead = ReadByte.HighNybble, OpcodeLength = 1 });

                        Parameter = new TreeNode($"Number: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.LowNybble });
                        break;

                    case (0xD0): //Load Message / Special Graphics
                        Command = new TreeNode("Change special graphics to");
                        NodeData.Add(Command, new TreeNodeExtension() { Byte = i, IsOpcode = true, ByteRead = ReadByte.HighNybble, OpcodeLength = 1 });

                        Parameter = new TreeNode($"Number: {parameter:X}");
                        Command.Nodes.Add(Parameter);
                        NodeData.Add(Parameter, new TreeNodeExtension() { Byte = i, ByteRead = ReadByte.LowNybble });
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
        }
        catch
        {
            MessageBox.Show("An error has occured while loading the Transition.\nMaybe the data is corrupt?", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        tre_tred_transition_tree.ExpandAll();
    }

    void ReloadTransition()
    {
        try
        {
            LoadTransition(cbb_tred_transition_selection.SelectedIndex);
            ReadTransition();
        }
        catch
        {
            MessageBox.Show("An error has occured while loading the Transition.\nMaybe the data is corrupt?", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    void UpdateRawData()
    {
        //updates the Text box to show the raw data
        txt_tred_transition_data.Text = Editor.GetRawDataString(CurrentTransitionOffset, TransitionLength);
    }

    void EnableEdit()
    {
        DisableEdit();
        TreeNodeExtension Data = NodeData.GetValueOrDefault(tre_tred_transition_tree.SelectedNode);
        if (!Data.IsOpcode)
        {
            num_tred_value.Enabled = true;
            lbl_tred_value.Enabled = true;
        }
        else
        {
            btn_tred_add_opcode.Enabled = true;
            btn_tred_remove_opcode.Enabled = true;
            btn_tred_move_opcode_down.Enabled = true;
            btn_tred_move_opcode_up.Enabled = true;
        }
        num_tred_value.Value = NodeValue;
    }

    void EnableApply()
    {
        btn_tred_apply_changes.Enabled = true;
        btn_tred_discard_changes.Enabled = true;
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

    }

    void DisableApply()
    {
        btn_tred_apply_changes.Enabled = false;
        btn_tred_discard_changes.Enabled = false;
    }

    void UpdateTransitionValue()
    {
        try
        {
            if (tre_tred_transition_tree.SelectedNode == null) return;
            int value = (int)num_tred_value.Value;
            TreeNodeExtension Data = NodeData.GetValueOrDefault(SelectedNode);
            SelectedByte = Data.Byte;
            if (Data.ByteRead == ReadByte.Whole)
            {
                Transition[SelectedByte] = (byte)value;
            }
            if (Data.ByteRead == ReadByte.HighNybble)
            {
                Transition[SelectedByte] = (byte)((Transition[SelectedByte] & 0xF) + (value << 4));
            }
            if (Data.ByteRead == ReadByte.LowNybble)
            {
                Transition[SelectedByte] = (byte)((Transition[SelectedByte] & 0xF0) + (value & 0xF));
            }
            if (Data.ByteRead == ReadByte.Pointer)
            {
                Transition[SelectedByte - 1] = (byte)(value & 0xFF);
                Transition[SelectedByte] = (byte)(value >> 8);
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

    int GetOpcodeLength(int offset)
    {
        int Value = Transition[offset];
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
                return 0xFF;

            default:
                return 1;
        }
    }

    #region Events
    private void tre_tred_transition_tree_AfterSelect(object sender, TreeViewEventArgs e)
    {
        SelectedNode = tre_tred_transition_tree.SelectedNode;
        TreeNodeExtension Data = NodeData.GetValueOrDefault(SelectedNode);
        SelectedByte = Data.Byte;
        NodeValue = Transition[SelectedByte];
        num_tred_value.Maximum = 0xFF;
        if (Data.ByteRead == ReadByte.HighNybble)
        {
            NodeValue >>= 4;
            num_tred_value.Maximum = 0xF;
        }
        if (Data.ByteRead == ReadByte.LowNybble)
        {
            NodeValue &= 0xF;
            num_tred_value.Maximum = 0xF;
        }
        if (Data.ByteRead == ReadByte.Pointer)
        {
            NodeValue = Transition[SelectedByte - 1] + (NodeValue << 8);
            num_tred_value.Maximum = 0xFFFF;
        }
        EnableEdit();
    }

    private void cbb_tred_transition_selection_SelectedIndexChanged(object sender, EventArgs e)
    {
        ReloadTransition();
        DisableEdit();
        DisableApply();
    }

    private void num_tred_transition_pointer_ValueChanged(object sender, EventArgs e)
    {
        if (BankTransitionOffset != num_tred_transition_pointer.Value)
        {
            btn_tred_repoint_transition.Enabled = true;
        }
        else btn_tred_repoint_transition.Enabled = false;
    }

    private void btn_tred_repoint_transition_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show($"Are you sure you want to change this Pointer?\n\n" +
                            $"This changes the location that Transition {cbb_tred_transition_selection.SelectedIndex:X4} gets read from.\n" +
                            $"It will not move the data of the Transition, therefore, it might be lost forever.\n" +
                            $"YAM2E will try to automatically repoint the Transition if needed, " +
                            $"however, if this Transition is faulty and can not be read correctly, a new pointer might help.",
                "Change Pointer?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            Editor.WritePointerLittleEndian(TableOffset + (2 * cbb_tred_transition_selection.SelectedIndex), (int)num_tred_transition_pointer.Value);
            ReloadTransition();
        }
        else
        {
            num_tred_transition_pointer.Value = BankTransitionOffset;
        }
    }

    private void btn_tred_transition_update_Click(object sender, EventArgs e)
    {
        UpdateTransitionValue();
    }

    private void num_tred_value_ValueChanged(object sender, EventArgs e)
    {
        if (num_tred_value.Value != NodeValue)
        {
            btn_tred_transition_update.Enabled = true;
            EnableApply();
        }
        else
        {
            btn_tred_transition_update.Enabled = false;
            if (Enumerable.SequenceEqual(OldTransition, Transition))
            {
                DisableApply();
            }
        }
    }

    private void btn_tred_apply_changes_Click(object sender, EventArgs e)
    {
        UpdateTransitionValue();
        if (Transition.Count > OldTransition.Length)
        {
            MessageBox.Show("The Transition exceeds its original length.\n" +
                            "Without repointing it would overwrite existing data.\n" +
                            "Currently that feature is not implemented!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {

        }
    }

    private void btn_tred_discard_changes_Click(object sender, EventArgs e)
    {
        Transition = OldTransition.ToList();
        DisableEdit();
        DisableApply();
        ReloadTransition();
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
            Transition.RemoveAt(Data.Byte);
        }
        DisableEdit();
        EnableApply();
        ReadTransition();
    }

    private void btn_tred_move_opcode_up_Click(object sender, EventArgs e)
    {
        TreeNodeExtension Data = NodeData.GetValueOrDefault(SelectedNode);

        //Dont want to move up if its last or first instruction
        if (Data.Byte == 0) return;
        if (Transition[Data.Byte] == 0xFF) return;

        //finding instruction above
        int AboveByte = 0;
        for (int i = 0; i < Transition.Count;)
        {
            int len = GetOpcodeLength(i);
            if (i + len == Data.Byte) //above instruction has been found
            {
                AboveByte = i;
            }
            i += len;
        }

        //moving data
        List<byte> MovedData = Transition.GetRange(Data.Byte, Data.OpcodeLength);
        for (int i = 0; i < Data.OpcodeLength; i++)
        {
            Transition.RemoveAt(Data.Byte);
        }
        Transition.InsertRange(AboveByte, MovedData);
        DisableEdit();
        EnableApply();
        ReadTransition();
    }

    private void btn_tred_move_opcode_down_Click(object sender, EventArgs e)
    {
        TreeNodeExtension Data = NodeData.GetValueOrDefault(SelectedNode);

        //Dont want to move down if last instruction or only last instruction left below
        if (Data.OpcodeLength == 0xFF) return;
        int NextCodeLength = GetOpcodeLength(Data.Byte + Data.OpcodeLength);
        if (Data.Byte + Data.OpcodeLength == Transition.Count) return;
        if (NextCodeLength == 0xFF) return;

        //moving data
        List<byte> MovedData = Transition.GetRange(Data.Byte, Data.OpcodeLength);
        for (int i = 0; i < Data.OpcodeLength; i++)
        {
            Transition.RemoveAt(Data.Byte);
        }
        Transition.InsertRange(Data.Byte + NextCodeLength, MovedData);
        DisableEdit();
        EnableApply();
        ReadTransition();
    }
    #endregion
}