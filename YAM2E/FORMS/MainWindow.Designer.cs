
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tool_strip_main_buttons = new System.Windows.Forms.ToolStrip();
            this.tool_strip_file = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_new_project = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_open_rom = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_save_project = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_create_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_compile_ROM = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_options = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_rom_file = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_project_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tileset_definitions = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_tools = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_data_viewer = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_editors = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_tweaks_editor = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_transition_editor = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_screen_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_view = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_show_screen_outlines = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_show_duplicate_outlines = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grp_data_selector = new System.Windows.Forms.GroupBox();
            this.grp_main_area = new System.Windows.Forms.GroupBox();
            this.lbl_area_bank = new System.Windows.Forms.Label();
            this.cbb_area_bank = new System.Windows.Forms.ComboBox();
            this.grp_main_tileset = new System.Windows.Forms.GroupBox();
            this.cbb_metatile_table = new System.Windows.Forms.ComboBox();
            this.lbl_main_graphics_pointer = new System.Windows.Forms.Label();
            this.lbl_main_metatile = new System.Windows.Forms.Label();
            this.num_main_graphics_offset = new System.Windows.Forms.NumericUpDown();
            this.tool_strip_image_buttons = new System.Windows.Forms.ToolStrip();
            this.btn_open_rom_image = new System.Windows.Forms.ToolStripButton();
            this.btn_save_rom_image = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_tile_mode = new System.Windows.Forms.ToolStripButton();
            this.btn_object_mode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_open_transition_editor_image = new System.Windows.Forms.ToolStripButton();
            this.btn_open_tweaks_editor_image = new System.Windows.Forms.ToolStripButton();
            this.sts_main_status_bar = new System.Windows.Forms.StatusStrip();
            this.lbl_main_selection_size = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_main_hovered_screen = new System.Windows.Forms.ToolStripStatusLabel();
            this.grp_main_tileset_viewer = new System.Windows.Forms.GroupBox();
            this.grp_main_room_viewer = new System.Windows.Forms.GroupBox();
            this.flw_main_room_view = new System.Windows.Forms.FlowLayoutPanel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.grp_main_view = new System.Windows.Forms.GroupBox();
            this.chb_view_objects = new System.Windows.Forms.CheckBox();
            this.ctx_room_context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctx_btn_screen_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ctx_btn_add_object = new System.Windows.Forms.ToolStripMenuItem();
            this.ctx_btn_edit_object = new System.Windows.Forms.ToolStripMenuItem();
            this.ctx_btn_remove_object = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ctx_btn_set_start_location = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ctx_btn_test_here = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_main_buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grp_data_selector.SuspendLayout();
            this.grp_main_area.SuspendLayout();
            this.grp_main_tileset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_main_graphics_offset)).BeginInit();
            this.tool_strip_image_buttons.SuspendLayout();
            this.sts_main_status_bar.SuspendLayout();
            this.grp_main_room_viewer.SuspendLayout();
            this.grp_main_view.SuspendLayout();
            this.ctx_room_context_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tool_strip_main_buttons
            // 
            this.tool_strip_main_buttons.BackColor = System.Drawing.Color.Gainsboro;
            this.tool_strip_main_buttons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tool_strip_main_buttons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_strip_file,
            this.tool_strip_options,
            this.tool_strip_tools,
            this.tool_strip_editors,
            this.tool_strip_view});
            this.tool_strip_main_buttons.Location = new System.Drawing.Point(0, 0);
            this.tool_strip_main_buttons.Name = "tool_strip_main_buttons";
            this.tool_strip_main_buttons.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tool_strip_main_buttons.Size = new System.Drawing.Size(1233, 25);
            this.tool_strip_main_buttons.TabIndex = 0;
            this.tool_strip_main_buttons.Text = "toolStrip2";
            // 
            // tool_strip_file
            // 
            this.tool_strip_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tool_strip_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_new_project,
            this.btn_open_rom,
            this.btn_save_project,
            this.toolStripSeparator1,
            this.btn_create_backup,
            this.toolStripSeparator7,
            this.btn_compile_ROM});
            this.tool_strip_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_strip_file.Name = "tool_strip_file";
            this.tool_strip_file.ShowDropDownArrow = false;
            this.tool_strip_file.Size = new System.Drawing.Size(29, 22);
            this.tool_strip_file.Text = "File";
            // 
            // btn_new_project
            // 
            this.btn_new_project.Name = "btn_new_project";
            this.btn_new_project.Size = new System.Drawing.Size(150, 22);
            this.btn_new_project.Text = "New Project";
            this.btn_new_project.Click += new System.EventHandler(this.btn_new_project_Click);
            // 
            // btn_open_rom
            // 
            this.btn_open_rom.Name = "btn_open_rom";
            this.btn_open_rom.Size = new System.Drawing.Size(150, 22);
            this.btn_open_rom.Text = "Open Project";
            this.btn_open_rom.Click += new System.EventHandler(this.btn_open_rom_Click);
            // 
            // btn_save_project
            // 
            this.btn_save_project.Enabled = false;
            this.btn_save_project.Name = "btn_save_project";
            this.btn_save_project.Size = new System.Drawing.Size(150, 22);
            this.btn_save_project.Text = "Save Project";
            this.btn_save_project.Click += new System.EventHandler(this.btn_save_project_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // btn_create_backup
            // 
            this.btn_create_backup.Enabled = false;
            this.btn_create_backup.Name = "btn_create_backup";
            this.btn_create_backup.Size = new System.Drawing.Size(150, 22);
            this.btn_create_backup.Text = "Create Backup";
            this.btn_create_backup.Visible = false;
            this.btn_create_backup.Click += new System.EventHandler(this.btn_create_backup_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(147, 6);
            // 
            // btn_compile_ROM
            // 
            this.btn_compile_ROM.Enabled = false;
            this.btn_compile_ROM.Name = "btn_compile_ROM";
            this.btn_compile_ROM.Size = new System.Drawing.Size(150, 22);
            this.btn_compile_ROM.Text = "Compile ROM";
            this.btn_compile_ROM.Click += new System.EventHandler(this.btn_compile_ROM_Click);
            // 
            // tool_strip_options
            // 
            this.tool_strip_options.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tool_strip_options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_rom_file,
            this.btn_project_settings,
            this.btn_tileset_definitions});
            this.tool_strip_options.Image = ((System.Drawing.Image)(resources.GetObject("tool_strip_options.Image")));
            this.tool_strip_options.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_strip_options.Name = "tool_strip_options";
            this.tool_strip_options.ShowDropDownArrow = false;
            this.tool_strip_options.Size = new System.Drawing.Size(53, 22);
            this.tool_strip_options.Text = "Options";
            // 
            // btn_rom_file
            // 
            this.btn_rom_file.Name = "btn_rom_file";
            this.btn_rom_file.Size = new System.Drawing.Size(180, 22);
            this.btn_rom_file.Text = "ROM File";
            this.btn_rom_file.Click += new System.EventHandler(this.rOMFileToolStripMenuItem_Click);
            // 
            // btn_project_settings
            // 
            this.btn_project_settings.Enabled = false;
            this.btn_project_settings.Name = "btn_project_settings";
            this.btn_project_settings.Size = new System.Drawing.Size(180, 22);
            this.btn_project_settings.Text = "Project Settings";
            this.btn_project_settings.Click += new System.EventHandler(this.btn_project_settings_Click);
            // 
            // btn_tileset_definitions
            // 
            this.btn_tileset_definitions.Enabled = false;
            this.btn_tileset_definitions.Name = "btn_tileset_definitions";
            this.btn_tileset_definitions.Size = new System.Drawing.Size(180, 22);
            this.btn_tileset_definitions.Text = "Tileset Definitions";
            this.btn_tileset_definitions.Visible = false;
            this.btn_tileset_definitions.Click += new System.EventHandler(this.btn_tileset_definitions_Click);
            // 
            // tool_strip_tools
            // 
            this.tool_strip_tools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tool_strip_tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_data_viewer});
            this.tool_strip_tools.Enabled = false;
            this.tool_strip_tools.Image = ((System.Drawing.Image)(resources.GetObject("tool_strip_tools.Image")));
            this.tool_strip_tools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_strip_tools.Name = "tool_strip_tools";
            this.tool_strip_tools.ShowDropDownArrow = false;
            this.tool_strip_tools.Size = new System.Drawing.Size(38, 22);
            this.tool_strip_tools.Text = "Tools";
            this.tool_strip_tools.Visible = false;
            // 
            // btn_data_viewer
            // 
            this.btn_data_viewer.Name = "btn_data_viewer";
            this.btn_data_viewer.Size = new System.Drawing.Size(136, 22);
            this.btn_data_viewer.Text = "Data Viewer";
            this.btn_data_viewer.Click += new System.EventHandler(this.btn_data_viewer_Click);
            // 
            // tool_strip_editors
            // 
            this.tool_strip_editors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tool_strip_editors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_tweaks_editor,
            this.btn_transition_editor,
            this.btn_screen_settings});
            this.tool_strip_editors.Enabled = false;
            this.tool_strip_editors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_strip_editors.Name = "tool_strip_editors";
            this.tool_strip_editors.ShowDropDownArrow = false;
            this.tool_strip_editors.Size = new System.Drawing.Size(47, 22);
            this.tool_strip_editors.Text = "Editors";
            // 
            // btn_tweaks_editor
            // 
            this.btn_tweaks_editor.Name = "btn_tweaks_editor";
            this.btn_tweaks_editor.Size = new System.Drawing.Size(159, 22);
            this.btn_tweaks_editor.Text = "Tweaks Editor";
            this.btn_tweaks_editor.Click += new System.EventHandler(this.btn_tweaks_editor_Click);
            // 
            // btn_transition_editor
            // 
            this.btn_transition_editor.Name = "btn_transition_editor";
            this.btn_transition_editor.Size = new System.Drawing.Size(159, 22);
            this.btn_transition_editor.Text = "Transition Editor";
            this.btn_transition_editor.Click += new System.EventHandler(this.btn_transition_editor_Click);
            // 
            // btn_screen_settings
            // 
            this.btn_screen_settings.Name = "btn_screen_settings";
            this.btn_screen_settings.Size = new System.Drawing.Size(159, 22);
            this.btn_screen_settings.Text = "Screen Settings";
            this.btn_screen_settings.Click += new System.EventHandler(this.btn_screen_settings_Click);
            // 
            // tool_strip_view
            // 
            this.tool_strip_view.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tool_strip_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_show_screen_outlines,
            this.btn_show_duplicate_outlines});
            this.tool_strip_view.Enabled = false;
            this.tool_strip_view.Image = ((System.Drawing.Image)(resources.GetObject("tool_strip_view.Image")));
            this.tool_strip_view.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_strip_view.Name = "tool_strip_view";
            this.tool_strip_view.ShowDropDownArrow = false;
            this.tool_strip_view.Size = new System.Drawing.Size(36, 22);
            this.tool_strip_view.Text = "View";
            // 
            // btn_show_screen_outlines
            // 
            this.btn_show_screen_outlines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_show_screen_outlines.Name = "btn_show_screen_outlines";
            this.btn_show_screen_outlines.Size = new System.Drawing.Size(209, 22);
            this.btn_show_screen_outlines.Text = "Screen Outlines";
            this.btn_show_screen_outlines.Click += new System.EventHandler(this.btn_show_screen_outlines_Click);
            // 
            // btn_show_duplicate_outlines
            // 
            this.btn_show_duplicate_outlines.Checked = true;
            this.btn_show_duplicate_outlines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_show_duplicate_outlines.Name = "btn_show_duplicate_outlines";
            this.btn_show_duplicate_outlines.Size = new System.Drawing.Size(209, 22);
            this.btn_show_duplicate_outlines.Text = "Duplicate Screen Outlines";
            this.btn_show_duplicate_outlines.Click += new System.EventHandler(this.btn_show_duplicate_outlines_Click);
            // 
            // grp_data_selector
            // 
            this.grp_data_selector.Controls.Add(this.grp_main_area);
            this.grp_data_selector.Controls.Add(this.grp_main_tileset);
            this.grp_data_selector.Location = new System.Drawing.Point(12, 53);
            this.grp_data_selector.Name = "grp_data_selector";
            this.grp_data_selector.Size = new System.Drawing.Size(180, 174);
            this.grp_data_selector.TabIndex = 1;
            this.grp_data_selector.TabStop = false;
            this.grp_data_selector.Text = "Data Selector";
            this.grp_data_selector.Visible = false;
            // 
            // grp_main_area
            // 
            this.grp_main_area.Controls.Add(this.lbl_area_bank);
            this.grp_main_area.Controls.Add(this.cbb_area_bank);
            this.grp_main_area.Location = new System.Drawing.Point(7, 23);
            this.grp_main_area.Name = "grp_main_area";
            this.grp_main_area.Size = new System.Drawing.Size(166, 50);
            this.grp_main_area.TabIndex = 4;
            this.grp_main_area.TabStop = false;
            this.grp_main_area.Text = "Area Data";
            // 
            // lbl_area_bank
            // 
            this.lbl_area_bank.AutoSize = true;
            this.lbl_area_bank.Location = new System.Drawing.Point(6, 19);
            this.lbl_area_bank.Name = "lbl_area_bank";
            this.lbl_area_bank.Size = new System.Drawing.Size(63, 15);
            this.lbl_area_bank.TabIndex = 0;
            this.lbl_area_bank.Text = "Area Bank:";
            // 
            // cbb_area_bank
            // 
            this.cbb_area_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_area_bank.FormattingEnabled = true;
            this.cbb_area_bank.Items.AddRange(new object[] {
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.cbb_area_bank.Location = new System.Drawing.Point(103, 16);
            this.cbb_area_bank.Name = "cbb_area_bank";
            this.cbb_area_bank.Size = new System.Drawing.Size(55, 23);
            this.cbb_area_bank.TabIndex = 2;
            this.cbb_area_bank.SelectedIndexChanged += new System.EventHandler(this.cbb_area_bank_SelectedIndexChanged);
            // 
            // grp_main_tileset
            // 
            this.grp_main_tileset.Controls.Add(this.cbb_metatile_table);
            this.grp_main_tileset.Controls.Add(this.lbl_main_graphics_pointer);
            this.grp_main_tileset.Controls.Add(this.lbl_main_metatile);
            this.grp_main_tileset.Controls.Add(this.num_main_graphics_offset);
            this.grp_main_tileset.Location = new System.Drawing.Point(7, 79);
            this.grp_main_tileset.Name = "grp_main_tileset";
            this.grp_main_tileset.Size = new System.Drawing.Size(166, 89);
            this.grp_main_tileset.TabIndex = 3;
            this.grp_main_tileset.TabStop = false;
            this.grp_main_tileset.Text = "Tileset Data";
            // 
            // cbb_metatile_table
            // 
            this.cbb_metatile_table.FormattingEnabled = true;
            this.cbb_metatile_table.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbb_metatile_table.Location = new System.Drawing.Point(103, 52);
            this.cbb_metatile_table.Name = "cbb_metatile_table";
            this.cbb_metatile_table.Size = new System.Drawing.Size(55, 23);
            this.cbb_metatile_table.TabIndex = 9;
            this.cbb_metatile_table.SelectedIndexChanged += new System.EventHandler(this.cbb_metatile_table_SelectedIndexChanged);
            // 
            // lbl_main_graphics_pointer
            // 
            this.lbl_main_graphics_pointer.AutoSize = true;
            this.lbl_main_graphics_pointer.Location = new System.Drawing.Point(6, 19);
            this.lbl_main_graphics_pointer.Name = "lbl_main_graphics_pointer";
            this.lbl_main_graphics_pointer.Size = new System.Drawing.Size(91, 15);
            this.lbl_main_graphics_pointer.TabIndex = 0;
            this.lbl_main_graphics_pointer.Text = "Graphics Offset:";
            // 
            // lbl_main_metatile
            // 
            this.lbl_main_metatile.AutoSize = true;
            this.lbl_main_metatile.Location = new System.Drawing.Point(6, 55);
            this.lbl_main_metatile.Name = "lbl_main_metatile";
            this.lbl_main_metatile.Size = new System.Drawing.Size(88, 15);
            this.lbl_main_metatile.TabIndex = 8;
            this.lbl_main_metatile.Text = "Metatile Offset:";
            // 
            // num_main_graphics_offset
            // 
            this.num_main_graphics_offset.Hexadecimal = true;
            this.num_main_graphics_offset.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.num_main_graphics_offset.Location = new System.Drawing.Point(103, 17);
            this.num_main_graphics_offset.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_main_graphics_offset.Name = "num_main_graphics_offset";
            this.num_main_graphics_offset.Size = new System.Drawing.Size(55, 23);
            this.num_main_graphics_offset.TabIndex = 7;
            this.num_main_graphics_offset.Value = new decimal(new int[] {
            141756,
            0,
            0,
            0});
            this.num_main_graphics_offset.ValueChanged += new System.EventHandler(this.num_main_graphics_offset_ValueChanged);
            // 
            // tool_strip_image_buttons
            // 
            this.tool_strip_image_buttons.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tool_strip_image_buttons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tool_strip_image_buttons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_open_rom_image,
            this.btn_save_rom_image,
            this.toolStripSeparator2,
            this.btn_tile_mode,
            this.btn_object_mode,
            this.toolStripSeparator3,
            this.btn_open_transition_editor_image,
            this.btn_open_tweaks_editor_image});
            this.tool_strip_image_buttons.Location = new System.Drawing.Point(0, 25);
            this.tool_strip_image_buttons.Name = "tool_strip_image_buttons";
            this.tool_strip_image_buttons.Size = new System.Drawing.Size(1233, 25);
            this.tool_strip_image_buttons.TabIndex = 2;
            this.tool_strip_image_buttons.Text = "toolStrip1";
            // 
            // btn_open_rom_image
            // 
            this.btn_open_rom_image.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_open_rom_image.Image = ((System.Drawing.Image)(resources.GetObject("btn_open_rom_image.Image")));
            this.btn_open_rom_image.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_open_rom_image.Name = "btn_open_rom_image";
            this.btn_open_rom_image.Size = new System.Drawing.Size(23, 22);
            this.btn_open_rom_image.Text = "Open Project";
            this.btn_open_rom_image.ToolTipText = "Open Project";
            this.btn_open_rom_image.Click += new System.EventHandler(this.btn_open_rom_image_Click);
            // 
            // btn_save_rom_image
            // 
            this.btn_save_rom_image.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_save_rom_image.Enabled = false;
            this.btn_save_rom_image.Image = ((System.Drawing.Image)(resources.GetObject("btn_save_rom_image.Image")));
            this.btn_save_rom_image.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_save_rom_image.Name = "btn_save_rom_image";
            this.btn_save_rom_image.Size = new System.Drawing.Size(23, 22);
            this.btn_save_rom_image.Text = "Save Project";
            this.btn_save_rom_image.ToolTipText = "Save Project";
            this.btn_save_rom_image.Click += new System.EventHandler(this.btn_save_rom_image_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_tile_mode
            // 
            this.btn_tile_mode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_tile_mode.Enabled = false;
            this.btn_tile_mode.Image = ((System.Drawing.Image)(resources.GetObject("btn_tile_mode.Image")));
            this.btn_tile_mode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_tile_mode.Name = "btn_tile_mode";
            this.btn_tile_mode.Size = new System.Drawing.Size(23, 22);
            this.btn_tile_mode.Text = "Tile editing mode";
            this.btn_tile_mode.Click += new System.EventHandler(this.btn_tile_mode_Click);
            // 
            // btn_object_mode
            // 
            this.btn_object_mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_object_mode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_object_mode.Enabled = false;
            this.btn_object_mode.Image = ((System.Drawing.Image)(resources.GetObject("btn_object_mode.Image")));
            this.btn_object_mode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_object_mode.Name = "btn_object_mode";
            this.btn_object_mode.Size = new System.Drawing.Size(23, 22);
            this.btn_object_mode.Text = "Object editing mode";
            this.btn_object_mode.Click += new System.EventHandler(this.btn_object_mode_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_open_transition_editor_image
            // 
            this.btn_open_transition_editor_image.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_open_transition_editor_image.Enabled = false;
            this.btn_open_transition_editor_image.Image = ((System.Drawing.Image)(resources.GetObject("btn_open_transition_editor_image.Image")));
            this.btn_open_transition_editor_image.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_open_transition_editor_image.Name = "btn_open_transition_editor_image";
            this.btn_open_transition_editor_image.Size = new System.Drawing.Size(23, 22);
            this.btn_open_transition_editor_image.Text = "Open Transition Editor";
            this.btn_open_transition_editor_image.ToolTipText = "Transition Editor";
            this.btn_open_transition_editor_image.Click += new System.EventHandler(this.btn_open_transition_editor_image_Click);
            // 
            // btn_open_tweaks_editor_image
            // 
            this.btn_open_tweaks_editor_image.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_open_tweaks_editor_image.Enabled = false;
            this.btn_open_tweaks_editor_image.Image = ((System.Drawing.Image)(resources.GetObject("btn_open_tweaks_editor_image.Image")));
            this.btn_open_tweaks_editor_image.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_open_tweaks_editor_image.Name = "btn_open_tweaks_editor_image";
            this.btn_open_tweaks_editor_image.Size = new System.Drawing.Size(23, 22);
            this.btn_open_tweaks_editor_image.Text = "Open Tweaks Editor";
            this.btn_open_tweaks_editor_image.ToolTipText = "Tweaks Editor";
            this.btn_open_tweaks_editor_image.Click += new System.EventHandler(this.btn_open_tweaks_editor_image_Click);
            // 
            // sts_main_status_bar
            // 
            this.sts_main_status_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_main_selection_size,
            this.lbl_main_hovered_screen});
            this.sts_main_status_bar.Location = new System.Drawing.Point(0, 749);
            this.sts_main_status_bar.Name = "sts_main_status_bar";
            this.sts_main_status_bar.Size = new System.Drawing.Size(1233, 22);
            this.sts_main_status_bar.TabIndex = 3;
            this.sts_main_status_bar.Text = "statusStrip1";
            // 
            // lbl_main_selection_size
            // 
            this.lbl_main_selection_size.Name = "lbl_main_selection_size";
            this.lbl_main_selection_size.Size = new System.Drawing.Size(108, 17);
            this.lbl_main_selection_size.Text = "Selected Area: 0 x 0";
            // 
            // lbl_main_hovered_screen
            // 
            this.lbl_main_hovered_screen.Name = "lbl_main_hovered_screen";
            this.lbl_main_hovered_screen.Size = new System.Drawing.Size(92, 17);
            this.lbl_main_hovered_screen.Text = "Selected Screen:";
            // 
            // grp_main_tileset_viewer
            // 
            this.grp_main_tileset_viewer.Location = new System.Drawing.Point(12, 233);
            this.grp_main_tileset_viewer.Name = "grp_main_tileset_viewer";
            this.grp_main_tileset_viewer.Size = new System.Drawing.Size(286, 150);
            this.grp_main_tileset_viewer.TabIndex = 4;
            this.grp_main_tileset_viewer.TabStop = false;
            this.grp_main_tileset_viewer.Text = "Tileset";
            this.grp_main_tileset_viewer.Visible = false;
            // 
            // grp_main_room_viewer
            // 
            this.grp_main_room_viewer.Controls.Add(this.flw_main_room_view);
            this.grp_main_room_viewer.Location = new System.Drawing.Point(304, 53);
            this.grp_main_room_viewer.Name = "grp_main_room_viewer";
            this.grp_main_room_viewer.Size = new System.Drawing.Size(917, 693);
            this.grp_main_room_viewer.TabIndex = 5;
            this.grp_main_room_viewer.TabStop = false;
            this.grp_main_room_viewer.Text = "Room";
            this.grp_main_room_viewer.Visible = false;
            // 
            // flw_main_room_view
            // 
            this.flw_main_room_view.AutoScroll = true;
            this.flw_main_room_view.Location = new System.Drawing.Point(12, 22);
            this.flw_main_room_view.Name = "flw_main_room_view";
            this.flw_main_room_view.Size = new System.Drawing.Size(899, 665);
            this.flw_main_room_view.TabIndex = 0;
            // 
            // grp_main_view
            // 
            this.grp_main_view.Controls.Add(this.chb_view_objects);
            this.grp_main_view.Location = new System.Drawing.Point(198, 53);
            this.grp_main_view.Name = "grp_main_view";
            this.grp_main_view.Size = new System.Drawing.Size(100, 174);
            this.grp_main_view.TabIndex = 6;
            this.grp_main_view.TabStop = false;
            this.grp_main_view.Text = "View";
            this.grp_main_view.Visible = false;
            // 
            // chb_view_objects
            // 
            this.chb_view_objects.AutoSize = true;
            this.chb_view_objects.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_view_objects.Checked = true;
            this.chb_view_objects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_view_objects.Location = new System.Drawing.Point(17, 22);
            this.chb_view_objects.Name = "chb_view_objects";
            this.chb_view_objects.Size = new System.Drawing.Size(66, 19);
            this.chb_view_objects.TabIndex = 1;
            this.chb_view_objects.Text = "Objects";
            this.chb_view_objects.UseVisualStyleBackColor = true;
            this.chb_view_objects.CheckedChanged += new System.EventHandler(this.chb_view_objects_CheckedChanged);
            // 
            // ctx_room_context_menu
            // 
            this.ctx_room_context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctx_btn_screen_settings,
            this.toolStripSeparator4,
            this.ctx_btn_add_object,
            this.ctx_btn_edit_object,
            this.ctx_btn_remove_object,
            this.toolStripSeparator5,
            this.ctx_btn_set_start_location,
            this.toolStripSeparator6,
            this.ctx_btn_test_here});
            this.ctx_room_context_menu.Name = "ctx_room_context_menu";
            this.ctx_room_context_menu.Size = new System.Drawing.Size(167, 154);
            // 
            // ctx_btn_screen_settings
            // 
            this.ctx_btn_screen_settings.Name = "ctx_btn_screen_settings";
            this.ctx_btn_screen_settings.Size = new System.Drawing.Size(166, 22);
            this.ctx_btn_screen_settings.Text = "Screen Settings";
            this.ctx_btn_screen_settings.Click += new System.EventHandler(this.ctx_btn_screen_settings_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(163, 6);
            // 
            // ctx_btn_add_object
            // 
            this.ctx_btn_add_object.Name = "ctx_btn_add_object";
            this.ctx_btn_add_object.Size = new System.Drawing.Size(166, 22);
            this.ctx_btn_add_object.Text = "Add Object";
            this.ctx_btn_add_object.Click += new System.EventHandler(this.ctx_btn_add_object_Click);
            // 
            // ctx_btn_edit_object
            // 
            this.ctx_btn_edit_object.Name = "ctx_btn_edit_object";
            this.ctx_btn_edit_object.Size = new System.Drawing.Size(166, 22);
            this.ctx_btn_edit_object.Text = "Edit Object";
            this.ctx_btn_edit_object.Click += new System.EventHandler(this.ctx_btn_edit_object_Click);
            // 
            // ctx_btn_remove_object
            // 
            this.ctx_btn_remove_object.Name = "ctx_btn_remove_object";
            this.ctx_btn_remove_object.Size = new System.Drawing.Size(166, 22);
            this.ctx_btn_remove_object.Text = "Remove Object";
            this.ctx_btn_remove_object.Click += new System.EventHandler(this.ctx_btn_remove_object_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(163, 6);
            this.toolStripSeparator5.Visible = false;
            // 
            // ctx_btn_set_start_location
            // 
            this.ctx_btn_set_start_location.Name = "ctx_btn_set_start_location";
            this.ctx_btn_set_start_location.Size = new System.Drawing.Size(166, 22);
            this.ctx_btn_set_start_location.Text = "Set Start Location";
            this.ctx_btn_set_start_location.Visible = false;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(163, 6);
            this.toolStripSeparator6.Visible = false;
            // 
            // ctx_btn_test_here
            // 
            this.ctx_btn_test_here.Name = "ctx_btn_test_here";
            this.ctx_btn_test_here.Size = new System.Drawing.Size(166, 22);
            this.ctx_btn_test_here.Text = "Test Game Here";
            this.ctx_btn_test_here.Visible = false;
            this.ctx_btn_test_here.Click += new System.EventHandler(this.ctx_btn_test_here_Click);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 771);
            this.Controls.Add(this.grp_main_view);
            this.Controls.Add(this.grp_main_room_viewer);
            this.Controls.Add(this.grp_main_tileset_viewer);
            this.Controls.Add(this.sts_main_status_bar);
            this.Controls.Add(this.tool_strip_image_buttons);
            this.Controls.Add(this.grp_data_selector);
            this.Controls.Add(this.tool_strip_main_buttons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(553, 810);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAMP";
            this.Load += new System.EventHandler(this.main_window_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.window_file_drop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.window_drag_over);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_window_KeyDown);
            this.Resize += new System.EventHandler(this.main_window_Resize);
            this.tool_strip_main_buttons.ResumeLayout(false);
            this.tool_strip_main_buttons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grp_data_selector.ResumeLayout(false);
            this.grp_main_area.ResumeLayout(false);
            this.grp_main_area.PerformLayout();
            this.grp_main_tileset.ResumeLayout(false);
            this.grp_main_tileset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_main_graphics_offset)).EndInit();
            this.tool_strip_image_buttons.ResumeLayout(false);
            this.tool_strip_image_buttons.PerformLayout();
            this.sts_main_status_bar.ResumeLayout(false);
            this.sts_main_status_bar.PerformLayout();
            this.grp_main_room_viewer.ResumeLayout(false);
            this.grp_main_view.ResumeLayout(false);
            this.grp_main_view.PerformLayout();
            this.ctx_room_context_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tool_strip_main_buttons;
        private System.Windows.Forms.ToolStripDropDownButton tool_strip_file;
        private System.Windows.Forms.ToolStripMenuItem btn_open_rom;
        private System.Windows.Forms.ToolStripMenuItem btn_save_project;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btn_create_backup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox grp_data_selector;
        private System.Windows.Forms.ComboBox cbb_area_bank;
        private System.Windows.Forms.Label lbl_area_bank;
        private System.Windows.Forms.ToolStripDropDownButton tool_strip_editors;
        private System.Windows.Forms.ToolStripMenuItem btn_tweaks_editor;
        private System.Windows.Forms.ToolStrip tool_strip_image_buttons;
        private System.Windows.Forms.ToolStripButton btn_open_rom_image;
        private System.Windows.Forms.ToolStripButton btn_save_rom_image;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_open_tweaks_editor_image;
        private System.Windows.Forms.StatusStrip sts_main_status_bar;
        private System.Windows.Forms.GroupBox grp_main_area;
        private System.Windows.Forms.GroupBox grp_main_tileset;
        private System.Windows.Forms.Label lbl_main_graphics_pointer;
        private System.Windows.Forms.Label lbl_main_metatile;
        private System.Windows.Forms.NumericUpDown num_main_graphics_offset;
        private System.Windows.Forms.GroupBox grp_main_tileset_viewer;
        private System.Windows.Forms.ToolStripStatusLabel lbl_main_selection_size;
        private System.Windows.Forms.GroupBox grp_main_room_viewer;
        private System.Windows.Forms.FlowLayoutPanel flw_main_room_view;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_main_hovered_screen;
        private System.Windows.Forms.ToolStripMenuItem btn_transition_editor;
        private System.Windows.Forms.ToolStripButton btn_open_transition_editor_image;
        private System.Windows.Forms.ToolStripDropDownButton tool_strip_view;
        private System.Windows.Forms.ToolStripMenuItem btn_show_screen_outlines;
        private System.Windows.Forms.ToolStripMenuItem btn_screen_settings;
        private System.Windows.Forms.GroupBox grp_main_view;
        private System.Windows.Forms.ToolStripButton btn_tile_mode;
        private System.Windows.Forms.ToolStripButton btn_object_mode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.CheckBox chb_view_objects;
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
        private System.Windows.Forms.ToolStripMenuItem btn_tileset_definitions;
        private System.Windows.Forms.ToolStripMenuItem btn_new_project;
        private System.Windows.Forms.ToolStripMenuItem btn_rom_file;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem btn_compile_ROM;
        private System.Windows.Forms.ComboBox cbb_metatile_table;
        private System.Windows.Forms.ToolStripMenuItem btn_project_settings;
    }
}

