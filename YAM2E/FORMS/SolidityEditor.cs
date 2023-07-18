using LAMP.Classes;
using LAMP.Classes.M2_Data;
using LAMP.Utilities;
using System;
using System.Drawing.Design;
using System.Windows.Forms;

namespace LAMP.FORMS;

public partial class SolidityEditor : Form
{
    Pointer gfxOverlay = null;
    Pointer tableStart = new Pointer(0x8, 0x7EFA);
    Pointer currentOffset = null;

    public SolidityEditor(int index = 0, Pointer gfxOffset = null)
    {
        InitializeComponent();
        gfxOverlay = gfxOffset;
        txb_offset.Text = Format.PointerToString(gfxOffset);
        cbb_solidity_table.SelectedIndex = index;
    }

    private void cbb_solidity_table_SelectedIndexChanged(object sender, EventArgs e)
    {
        currentOffset = tableStart + 4 * cbb_solidity_table.SelectedIndex;
        txb_samus.Text = Format.IntToString(Editor.ROM.Read8(currentOffset));
        txb_objects.Text = Format.IntToString(Editor.ROM.Read8(currentOffset + 1));
        txb_projectiles.Text = Format.IntToString(Editor.ROM.Read8(currentOffset + 2));
    }

    private void btn_apply_Click(object sender, EventArgs e)
    {
        byte samus = (byte)Format.StringToInt(txb_samus.Text, 0x7F);
        byte objects = (byte)Format.StringToInt(txb_objects.Text, 0x7F);
        byte projectiles = (byte)Format.StringToInt(txb_projectiles.Text, 0x7F);

        //Saving the data
        DataChunk dc = new DataChunk(currentOffset, new byte[] { samus, objects, projectiles, 0xFF });
        Editor.AddDataChunk(dc);

        //Changing txb text
        txb_samus.Text = Format.IntToString(samus);
        txb_objects.Text = Format.IntToString(objects);
        txb_projectiles.Text = Format.IntToString(projectiles);
    }
}
