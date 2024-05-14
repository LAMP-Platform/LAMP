
namespace LAMP
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            tool_strip_main_buttons = new System.Windows.Forms.ToolStrip();
            tool_strip_file = new System.Windows.Forms.ToolStripDropDownButton();
            btn_new_project = new System.Windows.Forms.ToolStripMenuItem();
            btn_open_rom = new System.Windows.Forms.ToolStripMenuItem();
            btn_save_project = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            btn_create_backup = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            btn_compile_ROM = new System.Windows.Forms.ToolStripMenuItem();
            tool_strip_options = new System.Windows.Forms.ToolStripDropDownButton();
            btn_rom_file = new System.Windows.Forms.ToolStripMenuItem();
            btn_project_settings = new System.Windows.Forms.ToolStripMenuItem();
            tool_strip_tools = new System.Windows.Forms.ToolStripDropDownButton();
            btn_data_viewer = new System.Windows.Forms.ToolStripMenuItem();
            btn_converter = new System.Windows.Forms.ToolStripMenuItem();
            tool_strip_editors = new System.Windows.Forms.ToolStripDropDownButton();
            btn_screen_settings = new System.Windows.Forms.ToolStripMenuItem();
            btn_transition_editor = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            btn_tileset_definitions = new System.Windows.Forms.ToolStripMenuItem();
            btn_graphics_editor = new System.Windows.Forms.ToolStripMenuItem();
            btn_open_collision_editor = new System.Windows.Forms.ToolStripMenuItem();
            btn_solidity_editor = new System.Windows.Forms.ToolStripMenuItem();
            btn_open_palette_editor = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            btn_save_editor = new System.Windows.Forms.ToolStripMenuItem();
            dataChunkManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tool_strip_view = new System.Windows.Forms.ToolStripDropDownButton();
            btn_view_show_objects = new System.Windows.Forms.ToolStripMenuItem();
            btn_show_scroll_bounds = new System.Windows.Forms.ToolStripMenuItem();
            btn_show_screen_outlines = new System.Windows.Forms.ToolStripMenuItem();
            btn_show_duplicate_outlines = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            btn_show_converter = new System.Windows.Forms.ToolStripMenuItem();
            btn_clear = new System.Windows.Forms.ToolStripDropDownButton();
            btn_area_clear = new System.Windows.Forms.ToolStripMenuItem();
            tool_strip_help = new System.Windows.Forms.ToolStripDropDownButton();
            btn_wiki = new System.Windows.Forms.ToolStripMenuItem();
            btn_bug_report = new System.Windows.Forms.ToolStripMenuItem();
            tls_input = new Controls.Other.TilesetInput();
            lbl_area_bank = new System.Windows.Forms.Label();
            cbb_area_bank = new System.Windows.Forms.ComboBox();
            tool_strip_image_buttons = new System.Windows.Forms.ToolStrip();
            btn_open_rom_image = new System.Windows.Forms.ToolStripButton();
            btn_save_rom_image = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            btn_show_objects = new System.Windows.Forms.ToolStripButton();
            btn_show_scrolls = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            btn_open_tweaks_editor_image = new System.Windows.Forms.ToolStripButton();
            btn_open_transition_editor_image = new System.Windows.Forms.ToolStripButton();
            btn_open_tileset_editor = new System.Windows.Forms.ToolStripButton();
            btn_graphics_editor_image = new System.Windows.Forms.ToolStripButton();
            btn_open_solidity_editor = new System.Windows.Forms.ToolStripButton();
            btn_collision_editor = new System.Windows.Forms.ToolStripButton();
            btn_palette_editor = new System.Windows.Forms.ToolStripButton();
            sts_main_status_bar = new System.Windows.Forms.StatusStrip();
            lbl_main_selection_size = new System.Windows.Forms.ToolStripStatusLabel();
            lbl_main_hovered_screen = new System.Windows.Forms.ToolStripStatusLabel();
            lbl_screen_used = new System.Windows.Forms.ToolStripStatusLabel();
            grp_main_tileset_viewer = new System.Windows.Forms.GroupBox();
            btn_edit_tileset = new System.Windows.Forms.Button();
            flw_tileset_view = new System.Windows.Forms.FlowLayoutPanel();
            toolbar_tileset = new Controls.Room.ToolBar();
            grp_main_room_viewer = new System.Windows.Forms.GroupBox();
            flw_main_room_view = new Controls.Overrides.FixedScrollPanel();
            toolbar_room = new Controls.Room.ToolBar();
            ctx_room_context_menu = new System.Windows.Forms.ContextMenuStrip(components);
            ctx_btn_screen_settings = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ctx_btn_add_object = new System.Windows.Forms.ToolStripMenuItem();
            ctx_btn_edit_object = new System.Windows.Forms.ToolStripMenuItem();
            ctx_btn_remove_object = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            ctx_btn_set_start_location = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            ctx_btn_test_here = new System.Windows.Forms.ToolStripMenuItem();
            btnTest = new System.Windows.Forms.Button();
            pnl_main_window_view = new System.Windows.Forms.SplitContainer();
            pnl_tileset = new System.Windows.Forms.Panel();
            pnl_tileset_resize = new System.Windows.Forms.SplitContainer();
            grp_object_inspector = new System.Windows.Forms.GroupBox();
            btn_auto_number = new System.Windows.Forms.Button();
            txb_object_number = new System.Windows.Forms.TextBox();
            txb_obj_type = new System.Windows.Forms.TextBox();
            lbl_obj_number = new System.Windows.Forms.Label();
            lbl_obj_type = new System.Windows.Forms.Label();
            pnl_data_selection = new System.Windows.Forms.Panel();
            grp_data_selector = new System.Windows.Forms.GroupBox();
            Tooltip_info = new System.Windows.Forms.ToolTip(components);
            ctx_select_tool = new System.Windows.Forms.ContextMenuStrip(components);
            replaceSelectedTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btn_compile_ips = new System.Windows.Forms.ToolStripMenuItem();
            tool_strip_main_buttons.SuspendLayout();
            tool_strip_image_buttons.SuspendLayout();
            sts_main_status_bar.SuspendLayout();
            grp_main_tileset_viewer.SuspendLayout();
            grp_main_room_viewer.SuspendLayout();
            ctx_room_context_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnl_main_window_view).BeginInit();
            pnl_main_window_view.Panel1.SuspendLayout();
            pnl_main_window_view.Panel2.SuspendLayout();
            pnl_main_window_view.SuspendLayout();
            pnl_tileset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnl_tileset_resize).BeginInit();
            pnl_tileset_resize.Panel1.SuspendLayout();
            pnl_tileset_resize.Panel2.SuspendLayout();
            pnl_tileset_resize.SuspendLayout();
            grp_object_inspector.SuspendLayout();
            pnl_data_selection.SuspendLayout();
            grp_data_selector.SuspendLayout();
            ctx_select_tool.SuspendLayout();
            SuspendLayout();
            // 
            // tool_strip_main_buttons
            // 
            tool_strip_main_buttons.BackColor = System.Drawing.Color.Gainsboro;
            tool_strip_main_buttons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            tool_strip_main_buttons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tool_strip_file, tool_strip_options, tool_strip_tools, tool_strip_editors, tool_strip_view, btn_clear, tool_strip_help });
            tool_strip_main_buttons.Location = new System.Drawing.Point(0, 0);
            tool_strip_main_buttons.Name = "tool_strip_main_buttons";
            tool_strip_main_buttons.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            tool_strip_main_buttons.Size = new System.Drawing.Size(1218, 25);
            tool_strip_main_buttons.TabIndex = 0;
            tool_strip_main_buttons.Text = "toolStrip2";
            // 
            // tool_strip_file
            // 
            tool_strip_file.AutoToolTip = false;
            tool_strip_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tool_strip_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btn_new_project, btn_open_rom, btn_save_project, toolStripSeparator1, btn_create_backup, toolStripSeparator7, btn_compile_ROM, btn_compile_ips });
            tool_strip_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            tool_strip_file.Name = "tool_strip_file";
            tool_strip_file.ShowDropDownArrow = false;
            tool_strip_file.Size = new System.Drawing.Size(29, 22);
            tool_strip_file.Text = "File";
            // 
            // btn_new_project
            // 
            btn_new_project.Image = Properties.Resources.Add;
            btn_new_project.Name = "btn_new_project";
            btn_new_project.Size = new System.Drawing.Size(180, 22);
            btn_new_project.Text = "New Project";
            btn_new_project.Click += btn_new_project_Click;
            // 
            // btn_open_rom
            // 
            btn_open_rom.Image = Properties.Resources.FolderOpened;
            btn_open_rom.Name = "btn_open_rom";
            btn_open_rom.Size = new System.Drawing.Size(180, 22);
            btn_open_rom.Text = "Open Project";
            btn_open_rom.Click += btn_open_rom_Click;
            // 
            // btn_save_project
            // 
            btn_save_project.Image = Properties.Resources.Save;
            btn_save_project.Name = "btn_save_project";
            btn_save_project.Size = new System.Drawing.Size(180, 22);
            btn_save_project.Text = "Save Project";
            btn_save_project.Click += btn_save_project_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            toolStripSeparator1.Visible = false;
            // 
            // btn_create_backup
            // 
            btn_create_backup.Name = "btn_create_backup";
            btn_create_backup.Size = new System.Drawing.Size(180, 22);
            btn_create_backup.Text = "Create Backup";
            btn_create_backup.Visible = false;
            btn_create_backup.Click += btn_create_backup_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
            // 
            // btn_compile_ROM
            // 
            btn_compile_ROM.Image = Properties.Resources.Compile;
            btn_compile_ROM.Name = "btn_compile_ROM";
            btn_compile_ROM.Size = new System.Drawing.Size(180, 22);
            btn_compile_ROM.Text = "Compile ROM";
            btn_compile_ROM.Click += btn_compile_ROM_Click;
            // 
            // tool_strip_options
            // 
            tool_strip_options.AutoToolTip = false;
            tool_strip_options.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tool_strip_options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btn_rom_file, btn_project_settings });
            tool_strip_options.Image = (System.Drawing.Image)resources.GetObject("tool_strip_options.Image");
            tool_strip_options.ImageTransparentColor = System.Drawing.Color.Magenta;
            tool_strip_options.Name = "tool_strip_options";
            tool_strip_options.ShowDropDownArrow = false;
            tool_strip_options.Size = new System.Drawing.Size(53, 22);
            tool_strip_options.Text = "Options";
            // 
            // btn_rom_file
            // 
            btn_rom_file.Image = Properties.Resources.Settings;
            btn_rom_file.Name = "btn_rom_file";
            btn_rom_file.Size = new System.Drawing.Size(165, 22);
            btn_rom_file.Text = "Program Settings";
            btn_rom_file.Click += rOMFileToolStripMenuItem_Click;
            // 
            // btn_project_settings
            // 
            btn_project_settings.Image = Properties.Resources.Settings;
            btn_project_settings.Name = "btn_project_settings";
            btn_project_settings.Size = new System.Drawing.Size(165, 22);
            btn_project_settings.Text = "Project Settings";
            btn_project_settings.Click += btn_project_settings_Click;
            // 
            // tool_strip_tools
            // 
            tool_strip_tools.AutoToolTip = false;
            tool_strip_tools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tool_strip_tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btn_data_viewer, btn_converter });
            tool_strip_tools.Image = (System.Drawing.Image)resources.GetObject("tool_strip_tools.Image");
            tool_strip_tools.ImageTransparentColor = System.Drawing.Color.Magenta;
            tool_strip_tools.Name = "tool_strip_tools";
            tool_strip_tools.ShowDropDownArrow = false;
            tool_strip_tools.Size = new System.Drawing.Size(38, 22);
            tool_strip_tools.Text = "Tools";
            // 
            // btn_data_viewer
            // 
            btn_data_viewer.Image = Properties.Resources.DataViewer;
            btn_data_viewer.Name = "btn_data_viewer";
            btn_data_viewer.Size = new System.Drawing.Size(136, 22);
            btn_data_viewer.Text = "Data Viewer";
            btn_data_viewer.Click += btn_data_viewer_Click;
            // 
            // btn_converter
            // 
            btn_converter.Name = "btn_converter";
            btn_converter.Size = new System.Drawing.Size(136, 22);
            btn_converter.Text = "Converter";
            btn_converter.Click += btn_converter_Click;
            // 
            // tool_strip_editors
            // 
            tool_strip_editors.AutoToolTip = false;
            tool_strip_editors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tool_strip_editors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btn_screen_settings, btn_transition_editor, toolStripSeparator10, btn_tileset_definitions, btn_graphics_editor, btn_open_collision_editor, btn_solidity_editor, btn_open_palette_editor, toolStripSeparator11, btn_save_editor, dataChunkManagerToolStripMenuItem });
            tool_strip_editors.ImageTransparentColor = System.Drawing.Color.Magenta;
            tool_strip_editors.Name = "tool_strip_editors";
            tool_strip_editors.ShowDropDownArrow = false;
            tool_strip_editors.Size = new System.Drawing.Size(47, 22);
            tool_strip_editors.Text = "Editors";
            // 
            // btn_screen_settings
            // 
            btn_screen_settings.Name = "btn_screen_settings";
            btn_screen_settings.Size = new System.Drawing.Size(186, 22);
            btn_screen_settings.Text = "Screen Settings";
            btn_screen_settings.Click += btn_screen_settings_Click;
            // 
            // btn_transition_editor
            // 
            btn_transition_editor.Image = Properties.Resources.TransitionEditor;
            btn_transition_editor.Name = "btn_transition_editor";
            btn_transition_editor.Size = new System.Drawing.Size(186, 22);
            btn_transition_editor.Text = "Transition Editor";
            btn_transition_editor.Click += btn_transition_editor_Click;
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new System.Drawing.Size(183, 6);
            // 
            // btn_tileset_definitions
            // 
            btn_tileset_definitions.Image = Properties.Resources.TilesetEditor;
            btn_tileset_definitions.Name = "btn_tileset_definitions";
            btn_tileset_definitions.Size = new System.Drawing.Size(186, 22);
            btn_tileset_definitions.Text = "Tileset Editor";
            btn_tileset_definitions.Click += btn_tileset_definitions_Click;
            // 
            // btn_graphics_editor
            // 
            btn_graphics_editor.Image = Properties.Resources.GraphicsEditor;
            btn_graphics_editor.Name = "btn_graphics_editor";
            btn_graphics_editor.Size = new System.Drawing.Size(186, 22);
            btn_graphics_editor.Text = "Graphics Editor";
            btn_graphics_editor.Click += btn_graphics_editor_Click;
            // 
            // btn_open_collision_editor
            // 
            btn_open_collision_editor.Image = Properties.Resources.CollisionEditor;
            btn_open_collision_editor.Name = "btn_open_collision_editor";
            btn_open_collision_editor.Size = new System.Drawing.Size(186, 22);
            btn_open_collision_editor.Text = "Collision Editor";
            btn_open_collision_editor.Click += btn_open_collision_editor_Click;
            // 
            // btn_solidity_editor
            // 
            btn_solidity_editor.Image = Properties.Resources.solidity;
            btn_solidity_editor.Name = "btn_solidity_editor";
            btn_solidity_editor.Size = new System.Drawing.Size(186, 22);
            btn_solidity_editor.Text = "Solidity Editor";
            btn_solidity_editor.Click += btn_solidity_editor_Click;
            // 
            // btn_open_palette_editor
            // 
            btn_open_palette_editor.Image = Properties.Resources.ColorPalette;
            btn_open_palette_editor.Name = "btn_open_palette_editor";
            btn_open_palette_editor.Size = new System.Drawing.Size(186, 22);
            btn_open_palette_editor.Text = "Palette Editor";
            btn_open_palette_editor.Click += btn_palette_editor_Click;
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new System.Drawing.Size(183, 6);
            // 
            // btn_save_editor
            // 
            btn_save_editor.Image = Properties.Resources.SaveEditor;
            btn_save_editor.Name = "btn_save_editor";
            btn_save_editor.Size = new System.Drawing.Size(186, 22);
            btn_save_editor.Text = "Save Editor";
            btn_save_editor.Click += btn_save_editor_Click;
            // 
            // dataChunkManagerToolStripMenuItem
            // 
            dataChunkManagerToolStripMenuItem.Image = Properties.Resources.DataViewer;
            dataChunkManagerToolStripMenuItem.Name = "dataChunkManagerToolStripMenuItem";
            dataChunkManagerToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            dataChunkManagerToolStripMenuItem.Text = "Data Chunk Manager";
            dataChunkManagerToolStripMenuItem.Click += btn_open_tweaks_editor_image_Click;
            // 
            // tool_strip_view
            // 
            tool_strip_view.AutoToolTip = false;
            tool_strip_view.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tool_strip_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btn_view_show_objects, btn_show_scroll_bounds, btn_show_screen_outlines, btn_show_duplicate_outlines, toolStripSeparator8, btn_show_converter });
            tool_strip_view.Image = (System.Drawing.Image)resources.GetObject("tool_strip_view.Image");
            tool_strip_view.ImageTransparentColor = System.Drawing.Color.Magenta;
            tool_strip_view.Name = "tool_strip_view";
            tool_strip_view.ShowDropDownArrow = false;
            tool_strip_view.Size = new System.Drawing.Size(36, 22);
            tool_strip_view.Text = "View";
            // 
            // btn_view_show_objects
            // 
            btn_view_show_objects.Checked = true;
            btn_view_show_objects.CheckState = System.Windows.Forms.CheckState.Checked;
            btn_view_show_objects.Name = "btn_view_show_objects";
            btn_view_show_objects.ShortcutKeys = System.Windows.Forms.Keys.F3;
            btn_view_show_objects.Size = new System.Drawing.Size(228, 22);
            btn_view_show_objects.Text = "Objects";
            btn_view_show_objects.Click += chb_view_objects_CheckedChanged;
            // 
            // btn_show_scroll_bounds
            // 
            btn_show_scroll_bounds.Name = "btn_show_scroll_bounds";
            btn_show_scroll_bounds.ShortcutKeys = System.Windows.Forms.Keys.F4;
            btn_show_scroll_bounds.Size = new System.Drawing.Size(228, 22);
            btn_show_scroll_bounds.Text = "Scroll Boundaries";
            btn_show_scroll_bounds.Click += scrollBoundariesToolStripMenuItem_Click;
            // 
            // btn_show_screen_outlines
            // 
            btn_show_screen_outlines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            btn_show_screen_outlines.Name = "btn_show_screen_outlines";
            btn_show_screen_outlines.ShortcutKeys = System.Windows.Forms.Keys.F5;
            btn_show_screen_outlines.Size = new System.Drawing.Size(228, 22);
            btn_show_screen_outlines.Text = "Screen Outlines";
            btn_show_screen_outlines.Click += btn_show_screen_outlines_Click;
            // 
            // btn_show_duplicate_outlines
            // 
            btn_show_duplicate_outlines.Checked = true;
            btn_show_duplicate_outlines.CheckState = System.Windows.Forms.CheckState.Checked;
            btn_show_duplicate_outlines.Name = "btn_show_duplicate_outlines";
            btn_show_duplicate_outlines.ShortcutKeys = System.Windows.Forms.Keys.F6;
            btn_show_duplicate_outlines.Size = new System.Drawing.Size(228, 22);
            btn_show_duplicate_outlines.Text = "Duplicate Screen Outlines";
            btn_show_duplicate_outlines.Click += btn_show_duplicate_outlines_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new System.Drawing.Size(225, 6);
            // 
            // btn_show_converter
            // 
            btn_show_converter.Name = "btn_show_converter";
            btn_show_converter.Size = new System.Drawing.Size(228, 22);
            btn_show_converter.Text = "Converter";
            btn_show_converter.Click += btn_show_converter_Click;
            // 
            // btn_clear
            // 
            btn_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            btn_clear.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btn_area_clear });
            btn_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_clear.Name = "btn_clear";
            btn_clear.ShowDropDownArrow = false;
            btn_clear.Size = new System.Drawing.Size(38, 22);
            btn_clear.Text = "Clear";
            // 
            // btn_area_clear
            // 
            btn_area_clear.Image = Properties.Resources.Clear;
            btn_area_clear.Name = "btn_area_clear";
            btn_area_clear.Size = new System.Drawing.Size(98, 22);
            btn_area_clear.Text = "Area";
            btn_area_clear.Click += Btn_Area_Clear_Click;
            // 
            // tool_strip_help
            // 
            tool_strip_help.AutoToolTip = false;
            tool_strip_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tool_strip_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btn_wiki, btn_bug_report });
            tool_strip_help.Image = (System.Drawing.Image)resources.GetObject("tool_strip_help.Image");
            tool_strip_help.ImageTransparentColor = System.Drawing.Color.Magenta;
            tool_strip_help.Name = "tool_strip_help";
            tool_strip_help.ShowDropDownArrow = false;
            tool_strip_help.Size = new System.Drawing.Size(36, 22);
            tool_strip_help.Text = "Help";
            // 
            // btn_wiki
            // 
            btn_wiki.Image = Properties.Resources.HelpTableOfContents;
            btn_wiki.Name = "btn_wiki";
            btn_wiki.Size = new System.Drawing.Size(142, 22);
            btn_wiki.Text = "Wiki";
            btn_wiki.Click += btn_wiki_Click;
            // 
            // btn_bug_report
            // 
            btn_bug_report.Image = Properties.Resources.StatusError;
            btn_bug_report.Name = "btn_bug_report";
            btn_bug_report.Size = new System.Drawing.Size(142, 22);
            btn_bug_report.Text = "Report a Bug";
            btn_bug_report.Click += btn_bug_report_Click;
            // 
            // tls_input
            // 
            tls_input.AutoSize = true;
            tls_input.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tls_input.BackColor = System.Drawing.SystemColors.Control;
            tls_input.ForceOffsets = false;
            tls_input.GraphicsOffset = null;
            tls_input.Location = new System.Drawing.Point(9, 51);
            tls_input.MetatilePointer = null;
            tls_input.MetatileTable = 0;
            tls_input.Name = "tls_input";
            tls_input.onDataChanged = null;
            tls_input.SelectedTileset = null;
            tls_input.Size = new System.Drawing.Size(154, 52);
            tls_input.TabIndex = 5;
            tls_input.DataChanged += tls_input_OnDataChanged;
            // 
            // lbl_area_bank
            // 
            lbl_area_bank.AutoSize = true;
            lbl_area_bank.Location = new System.Drawing.Point(9, 25);
            lbl_area_bank.Margin = new System.Windows.Forms.Padding(3);
            lbl_area_bank.Name = "lbl_area_bank";
            lbl_area_bank.Size = new System.Drawing.Size(34, 15);
            lbl_area_bank.TabIndex = 0;
            lbl_area_bank.Text = "Area:";
            // 
            // cbb_area_bank
            // 
            cbb_area_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_area_bank.FormattingEnabled = true;
            cbb_area_bank.Items.AddRange(new object[] { "9", "A", "B", "C", "D", "E", "F" });
            cbb_area_bank.Location = new System.Drawing.Point(108, 22);
            cbb_area_bank.Name = "cbb_area_bank";
            cbb_area_bank.Size = new System.Drawing.Size(55, 23);
            cbb_area_bank.TabIndex = 2;
            cbb_area_bank.SelectedIndexChanged += cbb_area_bank_SelectedIndexChanged;
            // 
            // tool_strip_image_buttons
            // 
            tool_strip_image_buttons.BackColor = System.Drawing.SystemColors.ControlLightLight;
            tool_strip_image_buttons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            tool_strip_image_buttons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btn_open_rom_image, btn_save_rom_image, toolStripSeparator2, btn_show_objects, btn_show_scrolls, toolStripSeparator9, btn_open_tweaks_editor_image, btn_open_transition_editor_image, btn_open_tileset_editor, btn_graphics_editor_image, btn_open_solidity_editor, btn_collision_editor, btn_palette_editor });
            tool_strip_image_buttons.Location = new System.Drawing.Point(0, 25);
            tool_strip_image_buttons.Name = "tool_strip_image_buttons";
            tool_strip_image_buttons.Size = new System.Drawing.Size(1218, 25);
            tool_strip_image_buttons.TabIndex = 2;
            tool_strip_image_buttons.Text = "toolStrip1";
            // 
            // btn_open_rom_image
            // 
            btn_open_rom_image.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_open_rom_image.Image = (System.Drawing.Image)resources.GetObject("btn_open_rom_image.Image");
            btn_open_rom_image.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_open_rom_image.Name = "btn_open_rom_image";
            btn_open_rom_image.Size = new System.Drawing.Size(23, 22);
            btn_open_rom_image.Text = "Open Project";
            btn_open_rom_image.ToolTipText = "Open Project";
            btn_open_rom_image.Click += btn_open_rom_image_Click;
            // 
            // btn_save_rom_image
            // 
            btn_save_rom_image.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_save_rom_image.Image = (System.Drawing.Image)resources.GetObject("btn_save_rom_image.Image");
            btn_save_rom_image.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_save_rom_image.Name = "btn_save_rom_image";
            btn_save_rom_image.Size = new System.Drawing.Size(23, 22);
            btn_save_rom_image.Text = "Save Project";
            btn_save_rom_image.ToolTipText = "Save Project";
            btn_save_rom_image.Click += btn_save_rom_image_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_show_objects
            // 
            btn_show_objects.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_show_objects.Image = (System.Drawing.Image)resources.GetObject("btn_show_objects.Image");
            btn_show_objects.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_show_objects.Name = "btn_show_objects";
            btn_show_objects.Size = new System.Drawing.Size(23, 22);
            btn_show_objects.Text = "Show Objects";
            btn_show_objects.Click += chb_view_objects_CheckedChanged;
            // 
            // btn_show_scrolls
            // 
            btn_show_scrolls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_show_scrolls.Image = (System.Drawing.Image)resources.GetObject("btn_show_scrolls.Image");
            btn_show_scrolls.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_show_scrolls.Name = "btn_show_scrolls";
            btn_show_scrolls.Size = new System.Drawing.Size(23, 22);
            btn_show_scrolls.Text = "Show Scrolls";
            btn_show_scrolls.Click += scrollBoundariesToolStripMenuItem_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_open_tweaks_editor_image
            // 
            btn_open_tweaks_editor_image.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_open_tweaks_editor_image.Image = (System.Drawing.Image)resources.GetObject("btn_open_tweaks_editor_image.Image");
            btn_open_tweaks_editor_image.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_open_tweaks_editor_image.Name = "btn_open_tweaks_editor_image";
            btn_open_tweaks_editor_image.Size = new System.Drawing.Size(23, 22);
            btn_open_tweaks_editor_image.Text = "Data Chunk Manager";
            btn_open_tweaks_editor_image.ToolTipText = "Data Chunk Manager";
            btn_open_tweaks_editor_image.Click += btn_open_tweaks_editor_image_Click;
            // 
            // btn_open_transition_editor_image
            // 
            btn_open_transition_editor_image.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_open_transition_editor_image.Image = (System.Drawing.Image)resources.GetObject("btn_open_transition_editor_image.Image");
            btn_open_transition_editor_image.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_open_transition_editor_image.Name = "btn_open_transition_editor_image";
            btn_open_transition_editor_image.Size = new System.Drawing.Size(23, 22);
            btn_open_transition_editor_image.Text = "Transition Editor";
            btn_open_transition_editor_image.ToolTipText = "Transition Editor";
            btn_open_transition_editor_image.Click += btn_open_transition_editor_image_Click;
            // 
            // btn_open_tileset_editor
            // 
            btn_open_tileset_editor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_open_tileset_editor.Image = (System.Drawing.Image)resources.GetObject("btn_open_tileset_editor.Image");
            btn_open_tileset_editor.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_open_tileset_editor.Name = "btn_open_tileset_editor";
            btn_open_tileset_editor.Size = new System.Drawing.Size(23, 22);
            btn_open_tileset_editor.Text = "Tileset Editor";
            btn_open_tileset_editor.Click += btn_open_tileset_editor_Click;
            // 
            // btn_graphics_editor_image
            // 
            btn_graphics_editor_image.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_graphics_editor_image.Image = (System.Drawing.Image)resources.GetObject("btn_graphics_editor_image.Image");
            btn_graphics_editor_image.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_graphics_editor_image.Name = "btn_graphics_editor_image";
            btn_graphics_editor_image.Size = new System.Drawing.Size(23, 22);
            btn_graphics_editor_image.Text = "Graphics Editor";
            btn_graphics_editor_image.ToolTipText = "Graphics Editor";
            btn_graphics_editor_image.Click += btn_graphics_editor_Click;
            // 
            // btn_open_solidity_editor
            // 
            btn_open_solidity_editor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_open_solidity_editor.Image = (System.Drawing.Image)resources.GetObject("btn_open_solidity_editor.Image");
            btn_open_solidity_editor.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_open_solidity_editor.Name = "btn_open_solidity_editor";
            btn_open_solidity_editor.Size = new System.Drawing.Size(23, 22);
            btn_open_solidity_editor.Text = "Solidity Editor";
            btn_open_solidity_editor.Click += btn_open_solidity_editor_Click;
            // 
            // btn_collision_editor
            // 
            btn_collision_editor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_collision_editor.Image = Properties.Resources.CollisionEditor;
            btn_collision_editor.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_collision_editor.Name = "btn_collision_editor";
            btn_collision_editor.Size = new System.Drawing.Size(23, 22);
            btn_collision_editor.Text = "Collision Editor";
            btn_collision_editor.ToolTipText = "Collision Editor";
            btn_collision_editor.Click += btn_open_collision_editor_Click;
            // 
            // btn_palette_editor
            // 
            btn_palette_editor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btn_palette_editor.Image = Properties.Resources.ColorPalette;
            btn_palette_editor.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_palette_editor.Name = "btn_palette_editor";
            btn_palette_editor.Size = new System.Drawing.Size(23, 22);
            btn_palette_editor.Click += btn_palette_editor_Click;
            // 
            // sts_main_status_bar
            // 
            sts_main_status_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lbl_main_selection_size, lbl_main_hovered_screen, lbl_screen_used });
            sts_main_status_bar.Location = new System.Drawing.Point(0, 747);
            sts_main_status_bar.Name = "sts_main_status_bar";
            sts_main_status_bar.Size = new System.Drawing.Size(1218, 24);
            sts_main_status_bar.TabIndex = 3;
            sts_main_status_bar.Text = "statusStrip1";
            // 
            // lbl_main_selection_size
            // 
            lbl_main_selection_size.AutoSize = false;
            lbl_main_selection_size.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            lbl_main_selection_size.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            lbl_main_selection_size.Name = "lbl_main_selection_size";
            lbl_main_selection_size.Size = new System.Drawing.Size(136, 19);
            lbl_main_selection_size.Text = "Selected Area: 0 x 0";
            lbl_main_selection_size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_main_hovered_screen
            // 
            lbl_main_hovered_screen.AutoSize = false;
            lbl_main_hovered_screen.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            lbl_main_hovered_screen.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            lbl_main_hovered_screen.Name = "lbl_main_hovered_screen";
            lbl_main_hovered_screen.Size = new System.Drawing.Size(129, 19);
            lbl_main_hovered_screen.Text = "Selected Screen: 00, 00";
            lbl_main_hovered_screen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_screen_used
            // 
            lbl_screen_used.AutoSize = false;
            lbl_screen_used.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            lbl_screen_used.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            lbl_screen_used.Name = "lbl_screen_used";
            lbl_screen_used.Size = new System.Drawing.Size(55, 19);
            lbl_screen_used.Text = "Used: 00";
            lbl_screen_used.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grp_main_tileset_viewer
            // 
            grp_main_tileset_viewer.Controls.Add(btn_edit_tileset);
            grp_main_tileset_viewer.Controls.Add(flw_tileset_view);
            grp_main_tileset_viewer.Controls.Add(toolbar_tileset);
            grp_main_tileset_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_main_tileset_viewer.Location = new System.Drawing.Point(9, 6);
            grp_main_tileset_viewer.Name = "grp_main_tileset_viewer";
            grp_main_tileset_viewer.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            grp_main_tileset_viewer.Size = new System.Drawing.Size(274, 187);
            grp_main_tileset_viewer.TabIndex = 4;
            grp_main_tileset_viewer.TabStop = false;
            grp_main_tileset_viewer.Text = "Tileset";
            // 
            // btn_edit_tileset
            // 
            btn_edit_tileset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_edit_tileset.Image = Properties.Resources.PenOneSelected;
            btn_edit_tileset.Location = new System.Drawing.Point(242, 19);
            btn_edit_tileset.Name = "btn_edit_tileset";
            btn_edit_tileset.Size = new System.Drawing.Size(23, 23);
            btn_edit_tileset.TabIndex = 23;
            Tooltip_info.SetToolTip(btn_edit_tileset, "Edit current Tileset");
            btn_edit_tileset.UseVisualStyleBackColor = true;
            btn_edit_tileset.Click += btn_edit_tileset_Click;
            // 
            // flw_tileset_view
            // 
            flw_tileset_view.AutoScroll = true;
            flw_tileset_view.Dock = System.Windows.Forms.DockStyle.Fill;
            flw_tileset_view.Location = new System.Drawing.Point(6, 47);
            flw_tileset_view.Name = "flw_tileset_view";
            flw_tileset_view.Size = new System.Drawing.Size(262, 134);
            flw_tileset_view.TabIndex = 0;
            // 
            // toolbar_tileset
            // 
            toolbar_tileset.Dock = System.Windows.Forms.DockStyle.Top;
            toolbar_tileset.History = null;
            toolbar_tileset.Location = new System.Drawing.Point(6, 19);
            toolbar_tileset.MaxZoom = 10;
            toolbar_tileset.Name = "toolbar_tileset";
            toolbar_tileset.onToolCommandTriggered = null;
            toolbar_tileset.onToolSwitched = null;
            toolbar_tileset.SelectedTool = LampTool.Select;
            toolbar_tileset.Size = new System.Drawing.Size(262, 28);
            toolbar_tileset.TabIndex = 1;
            toolbar_tileset.ZoomLevel = 1;
            toolbar_tileset.ToolCommandTriggered += toolbar_tileset_ToolCommandTriggered;
            // 
            // grp_main_room_viewer
            // 
            grp_main_room_viewer.Controls.Add(flw_main_room_view);
            grp_main_room_viewer.Controls.Add(toolbar_room);
            grp_main_room_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_main_room_viewer.Location = new System.Drawing.Point(3, 6);
            grp_main_room_viewer.Name = "grp_main_room_viewer";
            grp_main_room_viewer.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            grp_main_room_viewer.Size = new System.Drawing.Size(919, 685);
            grp_main_room_viewer.TabIndex = 5;
            grp_main_room_viewer.TabStop = false;
            grp_main_room_viewer.Text = "Room";
            // 
            // flw_main_room_view
            // 
            flw_main_room_view.AutoScroll = true;
            flw_main_room_view.Dock = System.Windows.Forms.DockStyle.Fill;
            flw_main_room_view.Location = new System.Drawing.Point(6, 47);
            flw_main_room_view.Name = "flw_main_room_view";
            flw_main_room_view.Size = new System.Drawing.Size(907, 632);
            flw_main_room_view.TabIndex = 0;
            // 
            // toolbar_room
            // 
            toolbar_room.Dock = System.Windows.Forms.DockStyle.Top;
            toolbar_room.History = null;
            toolbar_room.Location = new System.Drawing.Point(6, 19);
            toolbar_room.MaxZoom = 5;
            toolbar_room.Name = "toolbar_room";
            toolbar_room.onToolCommandTriggered = null;
            toolbar_room.onToolSwitched = null;
            toolbar_room.SelectedTool = LampTool.Pen;
            toolbar_room.Size = new System.Drawing.Size(907, 28);
            toolbar_room.TabIndex = 1;
            toolbar_room.ZoomLevel = 1;
            toolbar_room.ToolSwitched += toolbar_room_ToolSwitched;
            toolbar_room.ToolCommandTriggered += toolbar_room_ToolCommandTriggered;
            // 
            // ctx_room_context_menu
            // 
            ctx_room_context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ctx_btn_screen_settings, toolStripSeparator4, ctx_btn_add_object, ctx_btn_edit_object, ctx_btn_remove_object, toolStripSeparator5, ctx_btn_set_start_location, toolStripSeparator6, ctx_btn_test_here });
            ctx_room_context_menu.Name = "ctx_room_context_menu";
            ctx_room_context_menu.Size = new System.Drawing.Size(167, 154);
            // 
            // ctx_btn_screen_settings
            // 
            ctx_btn_screen_settings.Name = "ctx_btn_screen_settings";
            ctx_btn_screen_settings.Size = new System.Drawing.Size(166, 22);
            ctx_btn_screen_settings.Text = "Screen Settings";
            ctx_btn_screen_settings.Click += ctx_btn_screen_settings_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(163, 6);
            // 
            // ctx_btn_add_object
            // 
            ctx_btn_add_object.Name = "ctx_btn_add_object";
            ctx_btn_add_object.Size = new System.Drawing.Size(166, 22);
            ctx_btn_add_object.Text = "Add Object";
            ctx_btn_add_object.Click += ctx_btn_add_object_Click;
            // 
            // ctx_btn_edit_object
            // 
            ctx_btn_edit_object.Name = "ctx_btn_edit_object";
            ctx_btn_edit_object.Size = new System.Drawing.Size(166, 22);
            ctx_btn_edit_object.Text = "Edit Object";
            ctx_btn_edit_object.Click += ctx_btn_edit_object_Click;
            // 
            // ctx_btn_remove_object
            // 
            ctx_btn_remove_object.Name = "ctx_btn_remove_object";
            ctx_btn_remove_object.Size = new System.Drawing.Size(166, 22);
            ctx_btn_remove_object.Text = "Remove Object";
            ctx_btn_remove_object.Click += ctx_btn_remove_object_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(163, 6);
            toolStripSeparator5.Visible = false;
            // 
            // ctx_btn_set_start_location
            // 
            ctx_btn_set_start_location.Name = "ctx_btn_set_start_location";
            ctx_btn_set_start_location.Size = new System.Drawing.Size(166, 22);
            ctx_btn_set_start_location.Text = "Set Start Location";
            ctx_btn_set_start_location.Visible = false;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(163, 6);
            // 
            // ctx_btn_test_here
            // 
            ctx_btn_test_here.Name = "ctx_btn_test_here";
            ctx_btn_test_here.Size = new System.Drawing.Size(166, 22);
            ctx_btn_test_here.Text = "Test ROM Here";
            ctx_btn_test_here.Click += ctx_btn_test_here_Click;
            // 
            // btnTest
            // 
            btnTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnTest.Location = new System.Drawing.Point(12, 338);
            btnTest.Name = "btnTest";
            btnTest.Size = new System.Drawing.Size(82, 23);
            btnTest.TabIndex = 9;
            btnTest.Text = "Test Button";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += BtnTest_Click;
            // 
            // pnl_main_window_view
            // 
            pnl_main_window_view.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_main_window_view.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            pnl_main_window_view.Location = new System.Drawing.Point(0, 50);
            pnl_main_window_view.Margin = new System.Windows.Forms.Padding(3, 3, 6, 6);
            pnl_main_window_view.Name = "pnl_main_window_view";
            // 
            // pnl_main_window_view.Panel1
            // 
            pnl_main_window_view.Panel1.Controls.Add(pnl_tileset);
            pnl_main_window_view.Panel1.Controls.Add(pnl_data_selection);
            // 
            // pnl_main_window_view.Panel2
            // 
            pnl_main_window_view.Panel2.Controls.Add(grp_main_room_viewer);
            pnl_main_window_view.Panel2.Padding = new System.Windows.Forms.Padding(3, 6, 6, 6);
            pnl_main_window_view.Size = new System.Drawing.Size(1218, 697);
            pnl_main_window_view.SplitterDistance = 286;
            pnl_main_window_view.TabIndex = 6;
            pnl_main_window_view.Visible = false;
            // 
            // pnl_tileset
            // 
            pnl_tileset.Controls.Add(pnl_tileset_resize);
            pnl_tileset.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_tileset.Location = new System.Drawing.Point(0, 127);
            pnl_tileset.Name = "pnl_tileset";
            pnl_tileset.Size = new System.Drawing.Size(286, 570);
            pnl_tileset.TabIndex = 11;
            // 
            // pnl_tileset_resize
            // 
            pnl_tileset_resize.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_tileset_resize.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            pnl_tileset_resize.Location = new System.Drawing.Point(0, 0);
            pnl_tileset_resize.Name = "pnl_tileset_resize";
            pnl_tileset_resize.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // pnl_tileset_resize.Panel1
            // 
            pnl_tileset_resize.Panel1.Controls.Add(grp_main_tileset_viewer);
            pnl_tileset_resize.Panel1.Padding = new System.Windows.Forms.Padding(9, 6, 3, 0);
            // 
            // pnl_tileset_resize.Panel2
            // 
            pnl_tileset_resize.Panel2.Controls.Add(grp_object_inspector);
            pnl_tileset_resize.Panel2.Controls.Add(btnTest);
            pnl_tileset_resize.Panel2.Padding = new System.Windows.Forms.Padding(9, 6, 6, 9);
            pnl_tileset_resize.Size = new System.Drawing.Size(286, 570);
            pnl_tileset_resize.SplitterDistance = 193;
            pnl_tileset_resize.TabIndex = 5;
            // 
            // grp_object_inspector
            // 
            grp_object_inspector.Controls.Add(btn_auto_number);
            grp_object_inspector.Controls.Add(txb_object_number);
            grp_object_inspector.Controls.Add(txb_obj_type);
            grp_object_inspector.Controls.Add(lbl_obj_number);
            grp_object_inspector.Controls.Add(lbl_obj_type);
            grp_object_inspector.Dock = System.Windows.Forms.DockStyle.Top;
            grp_object_inspector.Location = new System.Drawing.Point(9, 6);
            grp_object_inspector.Name = "grp_object_inspector";
            grp_object_inspector.Size = new System.Drawing.Size(271, 88);
            grp_object_inspector.TabIndex = 10;
            grp_object_inspector.TabStop = false;
            grp_object_inspector.Text = "Object Inspector";
            grp_object_inspector.Visible = false;
            // 
            // btn_auto_number
            // 
            btn_auto_number.Location = new System.Drawing.Point(169, 50);
            btn_auto_number.Name = "btn_auto_number";
            btn_auto_number.Size = new System.Drawing.Size(41, 23);
            btn_auto_number.TabIndex = 4;
            btn_auto_number.Text = "Auto";
            Tooltip_info.SetToolTip(btn_auto_number, "Automatically finds a non respawning object\r\nnumber, which is currently unused in the Bank.");
            btn_auto_number.UseVisualStyleBackColor = true;
            btn_auto_number.Click += btn_auto_number_Click;
            // 
            // txb_object_number
            // 
            txb_object_number.Location = new System.Drawing.Point(69, 50);
            txb_object_number.Name = "txb_object_number";
            txb_object_number.Size = new System.Drawing.Size(94, 23);
            txb_object_number.TabIndex = 3;
            txb_object_number.TextChanged += txb_object_number_TextChanged;
            // 
            // txb_obj_type
            // 
            txb_obj_type.Location = new System.Drawing.Point(69, 21);
            txb_obj_type.Name = "txb_obj_type";
            txb_obj_type.Size = new System.Drawing.Size(94, 23);
            txb_obj_type.TabIndex = 2;
            txb_obj_type.TextChanged += txb_obj_type_TextChanged;
            // 
            // lbl_obj_number
            // 
            lbl_obj_number.AutoSize = true;
            lbl_obj_number.Location = new System.Drawing.Point(9, 53);
            lbl_obj_number.Name = "lbl_obj_number";
            lbl_obj_number.Size = new System.Drawing.Size(54, 15);
            lbl_obj_number.TabIndex = 1;
            lbl_obj_number.Text = "Number:";
            // 
            // lbl_obj_type
            // 
            lbl_obj_type.AutoSize = true;
            lbl_obj_type.Location = new System.Drawing.Point(9, 24);
            lbl_obj_type.Name = "lbl_obj_type";
            lbl_obj_type.Size = new System.Drawing.Size(34, 15);
            lbl_obj_type.TabIndex = 0;
            lbl_obj_type.Text = "Type:";
            // 
            // pnl_data_selection
            // 
            pnl_data_selection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnl_data_selection.Controls.Add(grp_data_selector);
            pnl_data_selection.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_data_selection.Location = new System.Drawing.Point(0, 0);
            pnl_data_selection.Name = "pnl_data_selection";
            pnl_data_selection.Padding = new System.Windows.Forms.Padding(9, 6, 3, 6);
            pnl_data_selection.Size = new System.Drawing.Size(286, 127);
            pnl_data_selection.TabIndex = 10;
            // 
            // grp_data_selector
            // 
            grp_data_selector.Controls.Add(tls_input);
            grp_data_selector.Controls.Add(lbl_area_bank);
            grp_data_selector.Controls.Add(cbb_area_bank);
            grp_data_selector.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_data_selector.Location = new System.Drawing.Point(9, 6);
            grp_data_selector.Name = "grp_data_selector";
            grp_data_selector.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            grp_data_selector.Size = new System.Drawing.Size(274, 115);
            grp_data_selector.TabIndex = 0;
            grp_data_selector.TabStop = false;
            grp_data_selector.Text = "Data Selector";
            // 
            // Tooltip_info
            // 
            Tooltip_info.AutomaticDelay = 0;
            Tooltip_info.AutoPopDelay = 0;
            Tooltip_info.InitialDelay = 100;
            Tooltip_info.ReshowDelay = 200;
            Tooltip_info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ctx_select_tool
            // 
            ctx_select_tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { replaceSelectedTileToolStripMenuItem });
            ctx_select_tool.Name = "ctx_select_tool";
            ctx_select_tool.Size = new System.Drawing.Size(184, 26);
            ctx_select_tool.Click += Btn_Area_Replace_Click;
            // 
            // replaceSelectedTileToolStripMenuItem
            // 
            replaceSelectedTileToolStripMenuItem.Name = "replaceSelectedTileToolStripMenuItem";
            replaceSelectedTileToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            replaceSelectedTileToolStripMenuItem.Text = "Replace Selected Tile";
            // 
            // btn_compile_ips
            // 
            btn_compile_ips.Image = Properties.Resources.LIPS;
            btn_compile_ips.Name = "btn_compile_ips";
            btn_compile_ips.Size = new System.Drawing.Size(180, 22);
            btn_compile_ips.Text = "Compile IPS";
            btn_compile_ips.Click += btn_compile_ips_Click;
            // 
            // MainWindow
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1218, 771);
            Controls.Add(pnl_main_window_view);
            Controls.Add(sts_main_status_bar);
            Controls.Add(tool_strip_image_buttons);
            Controls.Add(tool_strip_main_buttons);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MinimumSize = new System.Drawing.Size(553, 810);
            Name = "MainWindow";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            DragDrop += window_file_drop;
            DragOver += window_drag_over;
            KeyDown += MainWindow_KeyDown;
            Resize += MainWindow_Resize;
            tool_strip_main_buttons.ResumeLayout(false);
            tool_strip_main_buttons.PerformLayout();
            tool_strip_image_buttons.ResumeLayout(false);
            tool_strip_image_buttons.PerformLayout();
            sts_main_status_bar.ResumeLayout(false);
            sts_main_status_bar.PerformLayout();
            grp_main_tileset_viewer.ResumeLayout(false);
            grp_main_room_viewer.ResumeLayout(false);
            ctx_room_context_menu.ResumeLayout(false);
            pnl_main_window_view.Panel1.ResumeLayout(false);
            pnl_main_window_view.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnl_main_window_view).EndInit();
            pnl_main_window_view.ResumeLayout(false);
            pnl_tileset.ResumeLayout(false);
            pnl_tileset_resize.Panel1.ResumeLayout(false);
            pnl_tileset_resize.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnl_tileset_resize).EndInit();
            pnl_tileset_resize.ResumeLayout(false);
            grp_object_inspector.ResumeLayout(false);
            grp_object_inspector.PerformLayout();
            pnl_data_selection.ResumeLayout(false);
            grp_data_selector.ResumeLayout(false);
            grp_data_selector.PerformLayout();
            ctx_select_tool.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip tool_strip_main_buttons;
        private System.Windows.Forms.ToolStripDropDownButton tool_strip_file;
        private System.Windows.Forms.ToolStripMenuItem btn_open_rom;
        private System.Windows.Forms.ToolStripMenuItem btn_save_project;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btn_create_backup;
        private System.Windows.Forms.ComboBox cbb_area_bank;
        private System.Windows.Forms.Label lbl_area_bank;
        private System.Windows.Forms.ToolStripDropDownButton tool_strip_editors;
        private System.Windows.Forms.ToolStrip tool_strip_image_buttons;
        private System.Windows.Forms.ToolStripButton btn_open_rom_image;
        private System.Windows.Forms.ToolStripButton btn_save_rom_image;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_open_tweaks_editor_image;
        private System.Windows.Forms.StatusStrip sts_main_status_bar;
        private System.Windows.Forms.GroupBox grp_main_tileset_viewer;
        private System.Windows.Forms.ToolStripStatusLabel lbl_main_selection_size;
        private System.Windows.Forms.GroupBox grp_main_room_viewer;
        private System.Windows.Forms.ToolStripStatusLabel lbl_main_hovered_screen;
        private System.Windows.Forms.ToolStripMenuItem btn_transition_editor;
        private System.Windows.Forms.ToolStripButton btn_open_transition_editor_image;
        private System.Windows.Forms.ToolStripDropDownButton tool_strip_view;
        private System.Windows.Forms.ToolStripMenuItem btn_show_screen_outlines;
        private System.Windows.Forms.ToolStripMenuItem btn_screen_settings;
        private System.Windows.Forms.ContextMenuStrip ctx_room_context_menu;
        private System.Windows.Forms.ToolStripMenuItem ctx_btn_screen_settings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ctx_btn_add_object;
        private System.Windows.Forms.ToolStripMenuItem ctx_btn_edit_object;
        private System.Windows.Forms.ToolStripMenuItem ctx_btn_remove_object;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ctx_btn_set_start_location;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ctx_btn_test_here;
        private System.Windows.Forms.ToolStripMenuItem btn_show_duplicate_outlines;
        private System.Windows.Forms.ToolStripDropDownButton tool_strip_tools;
        private System.Windows.Forms.ToolStripMenuItem btn_data_viewer;
        private System.Windows.Forms.ToolStripDropDownButton tool_strip_options;
        private System.Windows.Forms.ToolStripMenuItem btn_new_project;
        private System.Windows.Forms.ToolStripMenuItem btn_rom_file;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem btn_compile_ROM;
        private System.Windows.Forms.ToolStripMenuItem btn_project_settings;
        private System.Windows.Forms.ToolStripMenuItem btn_tileset_definitions;
        private System.Windows.Forms.ToolStripButton btn_open_tileset_editor;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ToolStripMenuItem btn_show_scroll_bounds;
        private Controls.Other.TilesetInput tls_input;
        private System.Windows.Forms.ToolStripDropDownButton tool_strip_help;
        private System.Windows.Forms.ToolStripMenuItem btn_wiki;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem btn_save_editor;
        private System.Windows.Forms.ToolStripMenuItem btn_bug_report;
        private System.Windows.Forms.ToolStripButton btn_show_objects;
        private System.Windows.Forms.ToolStripButton btn_show_scrolls;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem btn_view_show_objects;
        private System.Windows.Forms.SplitContainer pnl_main_window_view;
        private System.Windows.Forms.Panel pnl_tileset;
        private System.Windows.Forms.Panel pnl_data_selection;
        private System.Windows.Forms.GroupBox grp_data_selector;
        private System.Windows.Forms.FlowLayoutPanel flw_tileset_view;
        private System.Windows.Forms.SplitContainer pnl_tileset_resize;
        private Controls.Overrides.FixedScrollPanel flw_main_room_view;
        private System.Windows.Forms.ToolStripStatusLabel lbl_screen_used;
        private Controls.Room.ToolBar toolbar_room;
        private Controls.Room.ToolBar toolbar_tileset;
        private System.Windows.Forms.ToolStripMenuItem btn_graphics_editor;
        private System.Windows.Forms.ToolStripButton btn_graphics_editor_image;
        private System.Windows.Forms.ToolStripMenuItem btn_converter;
        private System.Windows.Forms.ToolStripMenuItem btn_show_converter;
        private System.Windows.Forms.ToolStripMenuItem btn_solidity_editor;
        private System.Windows.Forms.ToolStripButton btn_open_solidity_editor;
        private System.Windows.Forms.GroupBox grp_object_inspector;
        private System.Windows.Forms.Label lbl_obj_number;
        private System.Windows.Forms.Label lbl_obj_type;
        private System.Windows.Forms.TextBox txb_object_number;
        private System.Windows.Forms.TextBox txb_obj_type;
        private System.Windows.Forms.Button btn_auto_number;
        private System.Windows.Forms.ToolTip Tooltip_info;
        private System.Windows.Forms.ToolStripMenuItem btn_open_collision_editor;
        private System.Windows.Forms.ToolStripButton btn_collision_editor;
        private System.Windows.Forms.ToolStripMenuItem dataChunkManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btn_clear;
        private System.Windows.Forms.ToolStripMenuItem btn_area_clear;
        private System.Windows.Forms.ContextMenuStrip ctx_select_tool;
        private System.Windows.Forms.ToolStripMenuItem replaceSelectedTileToolStripMenuItem;
        private System.Windows.Forms.Button btn_edit_tileset;
        private System.Windows.Forms.ToolStripButton btn_palette_editor;
        private System.Windows.Forms.ToolStripMenuItem btn_open_palette_editor;
        private System.Windows.Forms.ToolStripMenuItem btn_compile_ips;
    }
}

