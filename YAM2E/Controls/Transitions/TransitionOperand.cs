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
                    val = (val & 0xF0) >> 4;
                    break;
                case (ReadByte.LowNibble):
                    val &= 0xF;
                    break;
                case (ReadByte.Pointer):
                    val = (parent.Data[DataIndex + 1] << 8) | val;
                    break;
            }
            txbOperandValue.Text = Format.IntToString(val);
        }

        public void SaveValue()
        {
            //write value back to parent data
            int maxVal;
            byte val;
            switch (part)
            {
                case (ReadByte.WholeByte):
                    maxVal = 0xFF;
                    val = (byte)Format.StringToInt(txbOperandValue.Text, maxVal);
                    parent.Data[DataIndex] = val;
                    break;
                case (ReadByte.HighNibble):
                    maxVal = 0xF;
                    val = (byte)((parent.Data[DataIndex] & 0xF) | (Format.StringToInt(txbOperandValue.Text, maxVal) << 4));
                    parent.Data[DataIndex] = val;
                    break;
                case (ReadByte.LowNibble):
                    maxVal = 0xF;
                    val = (byte)((parent.Data[DataIndex] & 0xF0) | Format.StringToInt(txbOperandValue.Text, maxVal));
                    parent.Data[DataIndex] = val;
                    break;
                case (ReadByte.Pointer):
                    maxVal = 0xFFFF;
                    val = (byte)((Format.StringToInt(txbOperandValue.Text, maxVal) & 0xFF00) >> 8);
                    byte val2 = (byte)(Format.StringToInt(txbOperandValue.Text, maxVal) & 0xFF);
                    parent.Data[DataIndex] = val2;
                    parent.Data[DataIndex + 1] = val;
                    break;
            }

            //Updating text field
            SetValue();
        }

        private void txbOperandValue_Leave(object sender, EventArgs e)
        {
            parent.editor.SaveTransition();
        }
    }
}

/// <summary>
/// Describes different ways on how bytes can be read.
/// </summary>
public enum ReadByte
{
    /// <summary>
    /// Whether to read a whole Byte.
    /// </summary>
    WholeByte,
    /// <summary>
    /// Whether to read the high nibble (first 4 bits).
    /// </summary>
    HighNibble,
    /// <summary>
    /// Whether to read the low nibble (last 4 bits).
    /// </summary>
    LowNibble,
    /// <summary>
    /// Whether to read a Pointer.
    /// </summary>
    Pointer
}
