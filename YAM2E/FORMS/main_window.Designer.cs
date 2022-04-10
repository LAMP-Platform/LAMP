
namespace YAM2E
{
    partial class main_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_window));
            this.tool_strip_main_buttons = new System.Windows.Forms.ToolStrip();
            this.tool_strip_file = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_open_rom = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_save_rom = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_save_rom_as = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_create_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_editors = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_tweaks_editor = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grp_data_selector = new System.Windows.Forms.GroupBox();
            this.grp_main_area = new System.Windows.Forms.GroupBox();
            this.lbl_area_bank = new System.Windows.Forms.Label();
            this.cbb_area_bank = new System.Windows.Forms.ComboBox();
            this.grp_main_tileset = new System.Windows.Forms.GroupBox();
            this.num_main_metatile = new System.Windows.Forms.NumericUpDown();
            this.lbl_main_graphics_pointer = new System.Windows.Forms.Label();
            this.lbl_main_metatile = new System.Windows.Forms.Label();
            this.num_main_graphics_offset = new System.Windows.Forms.NumericUpDown();
            this.tool_strip_image_buttons = new System.Windows.Forms.ToolStrip();
            this.btn_open_rom_image = new System.Windows.Forms.ToolStripButton();
            this.btn_save_rom_image = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_open_tweaks_editor_image = new System.Windows.Forms.ToolStripButton();
            this.sts_main_status_bar = new System.Windows.Forms.StatusStrip();
            this.lbl_main_selection_size = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_main_hovered_screen = new System.Windows.Forms.ToolStripStatusLabel();
            this.grp_main_tileset_viewer = new System.Windows.Forms.GroupBox();
            this.grp_main_room_viewer = new System.Windows.Forms.GroupBox();
            this.flw_main_room_view = new System.Windows.Forms.FlowLayoutPanel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.tool_strip_main_buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grp_data_selector.SuspendLayout();
            this.grp_main_area.SuspendLayout();
            this.grp_main_tileset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_main_metatile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_main_graphics_offset)).BeginInit();
            this.tool_strip_image_buttons.SuspendLayout();
            this.sts_main_status_bar.SuspendLayout();
            this.grp_main_room_viewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tool_strip_main_buttons
            // 
            this.tool_strip_main_buttons.BackColor = System.Drawing.Color.Gainsboro;
            this.tool_strip_main_buttons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tool_strip_main_buttons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_strip_file,
            this.tool_strip_editors});
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
            this.btn_open_rom,
            this.btn_save_rom,
            this.btn_save_rom_as,
            this.toolStripSeparator1,
            this.btn_create_backup});
            this.tool_strip_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_strip_file.Name = "tool_strip_file";
            this.tool_strip_file.ShowDropDownArrow = false;
            this.tool_strip_file.Size = new System.Drawing.Size(29, 22);
            this.tool_strip_file.Text = "File";
            // 
            // btn_open_rom
            // 
            this.btn_open_rom.Name = "btn_open_rom";
            this.btn_open_rom.Size = new System.Drawing.Size(151, 22);
            this.btn_open_rom.Text = "Open ROM";
            this.btn_open_rom.Click += new System.EventHandler(this.btn_open_rom_Click);
            // 
            // btn_save_rom
            // 
            this.btn_save_rom.Enabled = false;
            this.btn_save_rom.Name = "btn_save_rom";
            this.btn_save_rom.Size = new System.Drawing.Size(151, 22);
            this.btn_save_rom.Text = "Save ROM";
            // 
            // btn_save_rom_as
            // 
            this.btn_save_rom_as.Enabled = false;
            this.btn_save_rom_as.Name = "btn_save_rom_as";
            this.btn_save_rom_as.Size = new System.Drawing.Size(151, 22);
            this.btn_save_rom_as.Text = "Save ROM as...";
            this.btn_save_rom_as.Click += new System.EventHandler(this.btn_save_rom_as_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // btn_create_backup
            // 
            this.btn_create_backup.Enabled = false;
            this.btn_create_backup.Name = "btn_create_backup";
            this.btn_create_backup.Size = new System.Drawing.Size(151, 22);
            this.btn_create_backup.Text = "Create Backup";
            // 
            // tool_strip_editors
            // 
            this.tool_strip_editors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tool_strip_editors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_tweaks_editor});
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
            this.btn_tweaks_editor.Size = new System.Drawing.Size(145, 22);
            this.btn_tweaks_editor.Text = "Tweaks Editor";
            this.btn_tweaks_editor.Click += new System.EventHandler(this.btn_tweaks_editor_Click);
            // 
            // grp_data_selector
            // 
            this.grp_data_selector.Controls.Add(this.grp_main_area);
            this.grp_data_selector.Controls.Add(this.grp_main_tileset);
            this.grp_data_selector.Location = new System.Drawing.Point(12, 53);
            this.grp_data_selector.Name = "grp_data_selector";
            this.grp_data_selector.Size = new System.Drawing.Size(286, 174);
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
            this.grp_main_area.Size = new System.Drawing.Size(273, 50);
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
            this.cbb_area_bank.Size = new System.Drawing.Size(164, 23);
            this.cbb_area_bank.TabIndex = 2;
            this.cbb_area_bank.SelectedIndexChanged += new System.EventHandler(this.cbb_area_bank_SelectedIndexChanged);
            // 
            // grp_main_tileset
            // 
            this.grp_main_tileset.Controls.Add(this.num_main_metatile);
            this.grp_main_tileset.Controls.Add(this.lbl_main_graphics_pointer);
            this.grp_main_tileset.Controls.Add(this.lbl_main_metatile);
            this.grp_main_tileset.Controls.Add(this.num_main_graphics_offset);
            this.grp_main_tileset.Location = new System.Drawing.Point(7, 79);
            this.grp_main_tileset.Name = "grp_main_tileset";
            this.grp_main_tileset.Size = new System.Drawing.Size(273, 89);
            this.grp_main_tileset.TabIndex = 3;
            this.grp_main_tileset.TabStop = false;
            this.grp_main_tileset.Text = "Tileset Data";
            // 
            // num_main_metatile
            // 
            this.num_main_metatile.Hexadecimal = true;
            this.num_main_metatile.Location = new System.Drawing.Point(103, 53);
            this.num_main_metatile.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_main_metatile.Name = "num_main_metatile";
            this.num_main_metatile.Size = new System.Drawing.Size(164, 23);
            this.num_main_metatile.TabIndex = 9;
            this.num_main_metatile.Value = new decimal(new int[] {
            137148,
            0,
            0,
            0});
            this.num_main_metatile.ValueChanged += new System.EventHandler(this.num_main_metatile_ValueChanged);
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
            this.num_main_graphics_offset.Size = new System.Drawing.Size(164, 23);
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
            this.btn_open_rom_image.Text = "Open ROM";
            this.btn_open_rom_image.ToolTipText = "Open ROM";
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
            this.btn_save_rom_image.Text = "Save ROM";
            this.btn_save_rom_image.ToolTipText = "Save ROM";
            this.btn_save_rom_image.Click += new System.EventHandler(this.btn_save_rom_image_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.grp_main_tileset_viewer.Size = new System.Drawing.Size(286, 100);
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
            // main_window
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 771);
            this.Controls.Add(this.grp_main_room_viewer);
            this.Controls.Add(this.grp_main_tileset_viewer);
            this.Controls.Add(this.sts_main_status_bar);
            this.Controls.Add(this.tool_strip_image_buttons);
            this.Controls.Add(this.grp_data_selector);
            this.Controls.Add(this.tool_strip_main_buttons);
            this.MinimumSize = new System.Drawing.Size(553, 810);
            this.Name = "main_window";
            this.Text = "YAM2E";
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
            ((System.ComponentModel.ISupportInitialize)(this.num_main_metatile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_main_graphics_offset)).EndInit();
            this.tool_strip_image_buttons.ResumeLayout(false);
            this.tool_strip_image_buttons.PerformLayout();
            this.sts_main_status_bar.ResumeLayout(false);
            this.sts_main_status_bar.PerformLayout();
            this.grp_main_room_viewer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tool_strip_main_buttons;
        private System.Windows.Forms.ToolStripDropDownButton tool_strip_file;
        private System.Windows.Forms.ToolStripMenuItem btn_open_rom;
        private System.Windows.Forms.ToolStripMenuItem btn_save_rom;
        private System.Windows.Forms.ToolStripMenuItem btn_save_rom_as;
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
        private System.Windows.Forms.NumericUpDown num_main_metatile;
        private System.Windows.Forms.Label lbl_main_graphics_pointer;
        private System.Windows.Forms.Label lbl_main_metatile;
        private System.Windows.Forms.NumericUpDown num_main_graphics_offset;
        private System.Windows.Forms.GroupBox grp_main_tileset_viewer;
        private System.Windows.Forms.ToolStripStatusLabel lbl_main_selection_size;
        private System.Windows.Forms.GroupBox grp_main_room_viewer;
        private System.Windows.Forms.FlowLayoutPanel flw_main_room_view;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_main_hovered_screen;
    }
}

