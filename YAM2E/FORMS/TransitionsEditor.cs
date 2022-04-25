using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YAM2E.Classes;
using YAM2E.FORMS;

namespace YAM2E.FORMS
{
    public partial class TransitionsEditor : Form
    {
        //Editor Vars
        int TableOffset = 0x142E5;
        int BankOffset = 0x14000;
        int CurrentTransitionOfsset;
        List<byte> Transition = new List<byte>();

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
            offset += BankOffset - 0x4000;
            CurrentTransitionOfsset = offset;
            string DataText = "";

            //loading Transition
            Transition.Clear();
            for (int i = 0; i < 64; i++)
            {
                byte val = Editor.ROM[offset + i];
                Transition.Add(val);
                DataText += " " + val.ToString("X");
                if (val == 0xFF)
                {
                    lbl_tred_transition_length.Text = $"Transition Length: {Transition.Count} bytes";
                    txt_tred_transition_data.Text = DataText;
                    return;
                }
            }
            Transition.Clear();
            lbl_tred_transition_length.Text = $"After 64 bytes (Max Length) no end operant has been found";
            txt_tred_transition_data.Text = "This is likely not a transition: " + DataText;
        }

        void ReadTransition()
        {
            tre_tred_transition_tree.Nodes.Clear();

            //generating new Tree
            for (int i = 0; i < Transition.Count; i++)
            {
                byte opcode = Transition[i];
                byte parameter = (byte)(opcode & 0xF);
                byte parameter2;
                opcode &= 0xF0;

                TreeNode Command = new TreeNode("");

                //library of opcodes
                switch (opcode)
                {
                    case (0x00): //VRAM / Data Block Transfer
                        if (parameter == 0x1) Command.Text = "Saves the bank and offset of a BG tileset";
                        if (parameter == 0x2) Command.Text = "Saves the offset of a sprite tileset";
                        else Command.Text = "Copies the data";
                        i++;
                        parameter = Transition[i++];
                        Command.Nodes.Add(new TreeNode("From bank: " + parameter.ToString("X")));
                        parameter = Transition[i++];
                        parameter2 = Transition[i++];
                        Command.Nodes.Add(new TreeNode("At offset: " + (parameter + (parameter2 << 8)).ToString("X")));
                        parameter = Transition[i++];
                        parameter2 = Transition[i++];
                        Command.Nodes.Add(new TreeNode("to offset: " + (parameter + (parameter2 << 8)).ToString("X")));
                        parameter = Transition[i++];
                        parameter2 = Transition[i];
                        Command.Nodes.Add(new TreeNode("Data length: " + (parameter + (parameter2 << 8)).ToString("X")));
                        break;

                    case (0x10): //Select metatile table
                        Command.Text = "Select metatiles from";
                        Command.Nodes.Add(new TreeNode("Table: " + parameter.ToString("X")));
                        Command.
                        break;

                    case (0x20): //Select collision table
                        Command.Text = "Select collision from";
                        Command.Nodes.Add(new TreeNode("Table: " + parameter.ToString("X")));
                        break;

                    case (0x30): //Select solidity indexes
                        Command.Text = "Select solidity indices from";
                        Command.Nodes.Add(new TreeNode("Table: " + parameter.ToString("X")));
                        break;

                    case (0x40): //Warp
                        Command.Text = "Warp to";
                        Command.Nodes.Add(new TreeNode("Area Bank: " + parameter.ToString("X")));
                        i++;
                        parameter = Transition[i];
                        Command.Nodes.Add(new TreeNode("at Screen Y: " + (parameter >> 4).ToString("X")));
                        Command.Nodes.Add(new TreeNode("and Screen X: " + (parameter & 0xF).ToString("X")));
                        break;

                    case (0x50): //Retreat from Queen
                        Command.Text = "Retreat from Queen fight";
                        break;

                    case (0x60): //Change acid & spike damage
                        Command.Text = "Change acid & spike damage";
                        i++;
                        parameter = Transition[i++];
                        Command.Nodes.Add(new TreeNode("Acid damage: " + parameter.ToString("X")));
                        parameter = Transition[i];
                        Command.Nodes.Add(new TreeNode("Spike damage: " + parameter.ToString("X")));
                        break;

                    case (0x70): //Exit Queen
                        Command.Text = "Exit Queen fight";
                        break;

                    case (0x80): //Enter Queen
                        Command.Text = "Enter Queen fight";
                        Command.Nodes.Add(new TreeNode("Bank for current room: " + parameter.ToString("X")));
                        i++;
                        parameter = Transition[i++];
                        parameter2 = Transition[i++];
                        Command.Nodes.Add(new TreeNode("Scroll Y position: " + (parameter + (parameter2 << 8)).ToString("X")));
                        parameter = Transition[i++];
                        parameter2 = Transition[i++];
                        Command.Nodes.Add(new TreeNode("Scroll X position: " + (parameter + (parameter2 << 8)).ToString("X")));
                        parameter = Transition[i++];
                        parameter2 = Transition[i++];
                        Command.Nodes.Add(new TreeNode("Samus Y position: " + (parameter + (parameter2 << 8)).ToString("X")));
                        parameter = Transition[i++];
                        parameter2 = Transition[i];
                        Command.Nodes.Add(new TreeNode("Samus X position: " + (parameter + (parameter2 << 8)).ToString("X")));
                        break;

                    case (0x90): //Conditional Transition
                        Command.Text = "Go to a different Transition if";
                        i++;
                        parameter = Transition[i++];
                        Command.Nodes.Add(new TreeNode("Metroids alive <= " + parameter.ToString("X")));
                        parameter = Transition[i++];
                        parameter2 = Transition[i];
                        Command.Nodes.Add(new TreeNode("New Transition offset: " + (parameter + (parameter2 << 8)).ToString("X")));
                        break;

                    case (0xA0): //Fadeout
                        Command.Text = "Fadeout";
                        break;

                    case (0xB0): //Load Graphics page
                        if (parameter == 0x1) Command.Text = "Load Background graphics page from";
                        if (parameter == 0x2) Command.Text = "Load Sprite graphics page from";
                        i++;
                        parameter = Transition[i++];
                        Command.Nodes.Add(new TreeNode("Bank: " + parameter.ToString("X")));
                        parameter = Transition[i++];
                        parameter2 = Transition[i];
                        Command.Nodes.Add(new TreeNode("At offset: " + (parameter + (parameter2 << 8)).ToString("X")));
                        break;

                    case (0xC0): //Change Music
                        Command.Text = "Change music to";
                        Command.Nodes.Add(new TreeNode("Number: " + parameter.ToString("X")));
                        break;

                    case (0xD0): //Load Message / Special Graphics
                        Command.Text = "Change special graphics to";
                        Command.Nodes.Add(new TreeNode("Number: " + parameter.ToString("X")));
                        break;

                    case (0xF0): //Exit Transition
                        if (parameter == 0xF) Command.Text = "END TRANSITION";
                        else Command.Text = "! i n v a l i d !";
                        break;

                    default:
                        Command.Text = $"{opcode + parameter}";
                        break;
                }
                tre_tred_transition_tree.Nodes.Add(Command);
            }
            tre_tred_transition_tree.ExpandAll();
        }

        private void tre_tred_transition_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void cbb_tred_transition_selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTransition(cbb_tred_transition_selection.SelectedIndex);
            ReadTransition();
        }
    }
}
