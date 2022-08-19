using System;
using System.Windows.Forms;
using LAMP.Classes;
using LAMP.FORMS;

namespace LAMP.FORMS
{
    public partial class DataViewer : Form
    {
        public DataViewer()
        {
            InitializeComponent();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            int offset = (int)num_offset.Value;
            if (chb_bank_offset.Checked == true)
            {
                offset = (int)((num_offset.Value - 0x4000) + num_bank.Value * 0x4000);
            }

            txb_raw_data.Text = Editor.ROM.GetRawDataString(offset, (int)num_length.Value);
        }

        private void chb_bank_offset_CheckedChanged(object sender, EventArgs e)
        {
            lbl_bank.Visible = chb_bank_offset.Checked;
            num_bank.Visible = chb_bank_offset.Checked;

            if (chb_bank_offset.Checked == true)
            {
                //current Bank
                int bankNr = (int)Math.Floor(num_offset.Value / 0x4000);
                num_bank.Value = bankNr;

                //current offset in Bank
                int offset = bankNr * 0x4000;
                offset = (int)num_offset.Value - offset + 0x4000;
                num_offset.Value = offset;
            }
            else
            {
                int offset = (int)((num_offset.Value - 0x4000) + num_bank.Value * 0x4000);
                num_offset.Value = offset;
            }
        }

        private void btn_rewrite_Click(object sender, EventArgs e)
        {
            int offset = (int)num_offset.Value;
            if (chb_bank_offset.Checked == true)
            {
                offset = (int)((num_offset.Value - 0x4000) + num_bank.Value * 0x4000);
            }

            //converting the string back to Hex
            string data = txb_raw_data.Text;
            char[] separators = new char[] { ' ' };
            string[] dataSplit = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int len = dataSplit.Length;
            byte[] write = new byte[len];

            for (int i = 0; i < len; i++) 
            {
                int val = Convert.ToInt32(dataSplit[i], 16);
                write[i] = (byte)val;
            }
            Editor.ROM.ReplaceBytes(offset, write);
        }
    }
}
