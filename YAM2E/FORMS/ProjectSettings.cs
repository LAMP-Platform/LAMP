using LAMP.Classes;
using LAMP.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP.FORMS;

public partial class ProjectSettings : Form
{
    bool construct;

    public ProjectSettings()
    {
        construct = true;

        InitializeComponent();
        chb_rmv_mt_o_list.Checked = Globals.LoadedProject.OptimizeObjectData;
        chb_fix_object_loading.Checked = Globals.LoadedProject.FixVerticalObjectLoading;
        rbt_use_tilesets.Checked = Globals.LoadedProject.useTilesets;
        txb_rom_path.Text = Globals.LoadedProject.ProjectSpecificROM;
        txb_disassembly_path.Text = Globals.LoadedProject.DisassemblyPath;
        txb_default_tile.Text = Format.IntToString(Globals.LoadedProject.FillTile);
        chb_assemble_compile.Checked = Globals.LoadedProject.BuildAssemblyWhenCompiling;

        LoadOffsets();
        construct = false;
    }

    private void LoadOffsets()
    {
        foreach (KeyValuePair<string, Pointer> entry in Globals.LoadedProject.WriteOffsets)
        {
            //create new panel which will house a label and a text box
            Panel Base = new Panel()
            {
                Dock = DockStyle.Top,
                Padding = new Padding(0, 3, 3, 0),
                Height = 35,
            };

            //Label
            Label label = new Label()
            {
                Text = entry.Key,
                Width = 149,
                Location = new Point(0, 9),
            };

            //Text box input
            TextBox Input = new TextBox()
            {
                Text = Format.PointerToString(entry.Value),
                Location = new Point(150, 6),
                Tag = entry.Key,
                //Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
            };

            Input.TextChanged += OffsetValueChanged;
            Input.Leave += LeftOffsetTextbox;

            Base.Controls.Add(label);
            Base.Controls.Add(Input);
            pnl_offsets.Controls.Add(Base);
        }
    }

    public void OffsetValueChanged(object sender, EventArgs e)
    {
        if (construct) return;
        TextBox b = sender as TextBox;
        Globals.LoadedProject.WriteOffsets[b.Tag.ToString()] = Format.StringToPointer(b.Text);
    }

    public void LeftOffsetTextbox(object sender, EventArgs e)
    {
        if (construct) return;
        TextBox b = sender as TextBox;
        b.Text = Format.PointerToString(Globals.LoadedProject.WriteOffsets[b.Tag.ToString()]);
    }

    private void chb_rmv_mt_o_list_CheckedChanged(object sender, EventArgs e)
    {
        Globals.LoadedProject.OptimizeObjectData = chb_rmv_mt_o_list.Checked;
    }

    private void rbt_use_offsets_CheckedChanged(object sender, EventArgs e)
    {
        if (rbt_use_offsets.Checked)
        {
            Globals.LoadedProject.useTilesets = false;
            MainWindow.Current.SwitchTilesetOffsetMode();
        }
    }

    private void rbt_use_tilesets_CheckedChanged(object sender, EventArgs e)
    {
        if (rbt_use_tilesets.Checked)
        {
            Globals.LoadedProject.useTilesets = true;
            MainWindow.Current.SwitchTilesetOffsetMode();
        }
    }

    private void txb_rom_path_TextChanged(object sender, EventArgs e)
    {
        Globals.LoadedProject.ProjectSpecificROM = txb_rom_path.Text;

        string checkPath = txb_rom_path.Text;
        if (!Path.IsPathRooted(checkPath)) checkPath = Path.Combine(Globals.ProjDirectory, checkPath);

        if (!File.Exists(checkPath))
        {
            Editor.LoadRomFromPath(Globals.RomPath, true);
            return;
        }

        Editor.LoadRomFromPath(Globals.LoadedProject.ProjectSpecificROM, true);
    }

    private void btn_select_rom_Click(object sender, EventArgs e)
    {
        string path = Editor.ShowOpenDialog("Metroid 2: Return of Samus ROM (*.gb)|*.gb");
        if (path != String.Empty) txb_rom_path.Text = path;
    }

    private void chb_fix_object_loading_CheckedChanged(object sender, EventArgs e)
    {
        Globals.LoadedProject.FixVerticalObjectLoading = chb_fix_object_loading.Checked;
    }

    private void txb_default_tile_TextChanged(object sender, EventArgs e)
    {
        Globals.LoadedProject.FillTile = (byte)Format.StringToInt(txb_default_tile.Text, 0xFF);
    }

    private void btn_assemble_compile_CheckedChanged(object sender, EventArgs e)
    {
        Globals.LoadedProject.BuildAssemblyWhenCompiling = chb_assemble_compile.Checked;
    }

    private void txb_disassembly_path_TextChanged(object sender, EventArgs e)
    {
        Globals.LoadedProject.DisassemblyPath = txb_disassembly_path.Text;

        string checkPath = txb_disassembly_path.Text;
        if (!Path.IsPathRooted(checkPath)) checkPath = Path.Combine(Globals.ProjDirectory, checkPath);

        chb_assemble_compile.Enabled = File.Exists(Path.Combine(checkPath, "build.bat"));
    }

    private void btn_select_disassembly_Click(object sender, EventArgs e)
    {
        using (FolderBrowserDialog fbd = new FolderBrowserDialog())
        {
            if (fbd.ShowDialog() == DialogResult.OK && fbd.SelectedPath != String.Empty)   
                txb_disassembly_path.Text = fbd.SelectedPath;
        }
    }
}
