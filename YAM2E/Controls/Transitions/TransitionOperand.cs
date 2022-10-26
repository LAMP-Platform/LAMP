using LAMP.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP.Controls.Transitions
{
    public partial class TransitionOperand : UserControl
    {
        public TransitionOperand(int DataIndex, ReadByte part, TransitionOpcode parent)
        {
            InitializeComponent();

            this.parent = parent;
            this.DataIndex = DataIndex;
            this.part = part;
            SetValue();
        }

        public TransitionOpcode parent; //Parent opcode with the data TODO: maybe wont be used
        public int DataIndex; //The index in the data that the operand represents
        public ReadByte part; //How much of the data at the given index should be read
        /*
        * WholeByte:
        *    Reads the entire byte at DataIndex
        * HighNibble:
        *    Reads the first 4 bits at DataIndex
        * LowNibble:
        *    Reads the last 4 bits at DataIndex
        * Pointer:
        *    Reads the entire byte at DataIndex and DataIndex + 1
        */

        public void ChangeName(string name)
        {
            lblOperandName.Text = name;
        }

        public void SetValue()
        {
            int val = parent.Data[DataIndex];
            switch (part)
            {
                case (ReadByte.WholeByte):
                    //Read value is already whole byte
                    break;
                case (ReadByte.HighNibble):
                    val &= 0xF0;
                    break;
                case (ReadByte.LowNibble):
                    val &= 0xF;
                    break;
                case (ReadByte.Pointer):
                    val = parent.Data[DataIndex + 1] + (val << 8);
                    break;
            }
            txbOperandValue.Text = Format.IntToString(val);
        }
    }
}
