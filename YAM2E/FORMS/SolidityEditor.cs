using LAMP.Classes;
using LAMP.Utilities;
using System;
using System.Windows.Forms;

namespace LAMP.FORMS;

public partial class SolidityEditor : Form
{
    Pointer gfxOverlay = null;
    Pointer tableStart = new Pointer(0x8, 0x7EFA);

    public SolidityEditor(int index = 0, Pointer gfxOffset = null)
    {
        InitializeComponent();
        gfxOverlay = gfxOffset;
        txb_offset.Text = Format.PointerToString(gfxOffset);
        cbb_solidity_table.SelectedIndex = index;
    }

    private void cbb_solidity_table_SelectedIndexChanged(object sender, EventArgs e)
    {
        Pointer offset = tableStart + 4 * cbb_solidity_table.SelectedIndex;
        txb_samus.Text = Format.IntToString(Editor.ROM.Read8(offset));
        txb_objects.Text = Format.IntToString(Editor.ROM.Read8(offset + 1));
        txb_projectiles.Text = Format.IntToString(Editor.ROM.Read8(offset + 2));
    }
}
