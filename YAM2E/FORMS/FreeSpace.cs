using System;
using System.Windows.Forms;
using YAM2E.Classes;

namespace YAM2E.FORMS
{
    public partial class FreeSpace : Form
    {
        public FreeSpace()
        {
            InitializeComponent();
        }

        private void btn_object_rearrange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to rearrange the object data?\n" +
                $"This change cannot be undone!",
                "Rearrange Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                /*Goal of the rearrangement: remove all duplicate 0xFF object lists
                 * by pointing every empty screen to the first list.
                 * Move existing data together to remove little freespace holes
                 */

                //Looping through pointer list
                try
                {
                    for (int i = 0; i < 7 * 256; i++)
                    {
                        Pointer currentPtr = new Pointer(0x3, Editor.ROM.Read16(Editor.ROM.ObjectPointerTable.Offset + 2 * i));
                        if (Editor.ROM.Read8(currentPtr.Offset) == 0xFF)
                        {
                            Editor.ROM.Write16(Editor.ROM.ObjectPointerTable.Offset + 2 * i, (ushort)Editor.ROM.ObjectDataLists.bOffset);
                        }
                    }

                    //success
                    MessageBox.Show($"The object data has successfully been rearranged!",
                    "Data Rearranged", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show($"An error occured while rearranging the data!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }

        }
    }
}
