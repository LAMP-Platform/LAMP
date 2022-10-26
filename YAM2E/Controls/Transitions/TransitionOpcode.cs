using LAMP.Controls.Transitions;
using LAMP.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LAMP.Controls
{
    public partial class TransitionOpcode : UserControl
    {
        public TransitionOpcode()
        {
            InitializeComponent();
        }

        public TransitionOpcode(List<Byte> data, TransitionsEditor editor)
        {
            InitializeComponent();

            if (data != null)
            {
                Data = data;
                this.editor = editor;
                PopulateOperands();
            }

        }

        //Fields
        private TransitionsEditor editor;
        public List<Byte> Data;
        private bool isEnd = false;

        //Functions
        public void PopulateOperands()
        {
            int opcode = Data[0] & 0xF0;
            int parameter = Data[0] & 0xF;
            string name = "Unknown Opcode";

            switch (opcode)
            {
                case (0x00): //VRAM / Data Block Transfer
                    if (parameter == 2)
                    {
                        name = "Save Sprite Tileset";
                    }
                    else if (parameter == 1)
                    {
                        name = "Save Background Tileset";
                    }
                    else
                    {
                        name = "Copy Data";
                    }
                    AddText("Save Data from");
                    AddOperand("Source Bank", 1, ReadByte.WholeByte);
                    AddOperand("Source Offset", 2, ReadByte.Pointer);
                    AddText("to");
                    AddOperand("Destination Offset", 4, ReadByte.Pointer);
                    AddOperand("Length", 6, ReadByte.Pointer);
                    break;

                case (0x10): //Select metatile table
                    name = "Select Metatile Table";
                    AddOperand("Table", 0, ReadByte.LowNibble);
                    break;

                case (0x20): //Select collision table
                    name = "Select Collision Table";
                    AddOperand("Table", 0, ReadByte.LowNibble);
                    break;

                case (0x30): //Select solidity indexes
                    name = "Select Solidity Indices Table";
                    AddOperand("Table", 0, ReadByte.LowNibble);
                    break;

                case (0x40): //Warp
                    name = "Warp";
                    AddOperand("Map Bank", 0, ReadByte.LowNibble);
                    AddOperand("X", 1, ReadByte.LowNibble);     //Internally its first Y then X
                    AddOperand("Y", 1, ReadByte.HighNibble);
                    break;

                case (0x50): //Retreat from Queen
                    name = "Queen Retreat";
                    break;

                case (0x60): //Change acid & spike damage
                    name = "Set Acid/Spike Damage";
                    AddOperand("Acid Damage", 1, ReadByte.WholeByte);
                    AddOperand("Spike Damage", 2, ReadByte.WholeByte);
                    break;

                case (0x70): //Exit Queen
                    name = "Queen Exit";
                    break;

                case (0x80): //Enter Queen
                    name = "Queen Entrance";
                    AddOperand("Bank", 0, ReadByte.LowNibble);
                    AddOperand("Scroll X", 3, ReadByte.Pointer);    //same as above. First Y then X
                    AddOperand("Scroll Y", 1, ReadByte.Pointer);
                    AddOperand("Samus X", 7, ReadByte.Pointer);
                    AddOperand("Samus Y", 5, ReadByte.Pointer);
                    break;

                case (0x90): //Conditional Transition
                    name = "Conditional Transition";
                    AddText("If");
                    AddOperand("Metroids <", 1, ReadByte.WholeByte);
                    AddText("Trigger");
                    AddOperand("Transition", 2, ReadByte.Pointer);
                    break;

                case (0xA0): //Fadeout
                    name = "Fadeout";
                    break;

                case (0xB0): //Load Graphics page
                    if (parameter == 1) name = "Load Background Graphics";
                    if (parameter == 2) name = "Load Sprite Graphics";
                    AddOperand("Bank", 1, ReadByte.LowNibble);
                    AddOperand("Offset", 2, ReadByte.Pointer);
                    break;

                case (0xC0): //Change Music
                    name = "Select Music";
                    AddOperand("Track", 0, ReadByte.LowNibble);
                    break;

                case (0xD0): //Load Message / Special Graphics
                    name = "Load Special Graphics";
                    AddOperand("Graphics", 0, ReadByte.LowNibble);
                    break;

                case (0xF0): //Exit Transition
                    name = "End Transition";
                    isEnd = true;
                    break;

                default:
                    name = "Unknown Opcode";
                    AddOperand("Opcode Value", 0, ReadByte.WholeByte);
                    AddText("LAMP Does not know this");
                    AddText("Opcode value. Maybe it");
                    AddText("was added through code?");
                    break;
            }
            lblOpcodeName.Text = name;

            //Disable the collapse/expand arrow if its the end opcode
            if (!isEnd) return;
            pbxCollapse.Visible = false;
            pbxExpand.Visible = false;
        }

        public void AddOperand(string Name, int index, ReadByte read)
        {
            TransitionOperand operand = new TransitionOperand(index, read, this);
            operand.ChangeName(Name);
            pnlOperands.Controls.Add(operand);
        }

        public void AddText(string text) 
        {
            pnlOperands.Controls.Add(new TextInsert(text));
        }

        //Events
        private void pnlBasicInfo_Click(object sender, EventArgs e)
        {
            if (isEnd) return;
            pnlEdit.Visible = !pnlEdit.Visible;
            seperator.Visible = pnlEdit.Visible;
            pbxCollapse.Visible = pnlEdit.Visible;
            pbxExpand.Visible = !pnlEdit.Visible;
        }

        private void pnlBasicInfo_MouseMove(object sender, MouseEventArgs e)
        {
            pnlBasicInfo.BackColor = Color.FromArgb(0xFF, 0xe6, 0xe6, 0xe6);
        }

        private void pnlBasicInfo_MouseLeave(object sender, EventArgs e)
        {
            pnlBasicInfo.BackColor = Color.FromArgb(0xFF, 0xf0, 0xf0, 0xf0);
        }

        private void btnRemoveOpcode_Click(object sender, EventArgs e)
        {
            editor.TransitionLength -= Data.Count();
            editor.UpdateTransitionLength();
            this.Dispose();
        }
    }
}
