
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
            this.cbb_tileset = new System.Windows.Forms.ComboBox();
            this.cbb_area_bank = new System.Windows.Forms.ComboBox();
            this.lbl_tileset = new System.Windows.Forms.Label();
            this.lbl_area_bank = new System.Windows.Forms.Label();
            this.tool_strip_image_buttons = new System.Windows.Forms.ToolStrip();
            this.btn_open_rom_image = new System.Windows.Forms.ToolStripButton();
            this.btn_save_rom_image = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_open_tweaks_editor_image = new System.Windows.Forms.ToolStripButton();
            this.tool_strip_main_buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grp_data_selector.SuspendLayout();
            this.tool_strip_image_buttons.SuspendLayout();
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
            this.tool_strip_main_buttons.Size = new System.Drawing.Size(849, 25);
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
            this.btn_save_rom.Name = "btn_save_rom";
            this.btn_save_rom.Size = new System.Drawing.Size(151, 22);
            this.btn_save_rom.Text = "Save ROM";
            // 
            // btn_save_rom_as
            // 
            this.btn_save_rom_as.Name = "btn_save_rom_as";
            this.btn_save_rom_as.Size = new System.Drawing.Size(151, 22);
            this.btn_save_rom_as.Text = "Save ROM as...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // btn_create_backup
            // 
            this.btn_create_backup.Name = "btn_create_backup";
            this.btn_create_backup.Size = new System.Drawing.Size(151, 22);
            this.btn_create_backup.Text = "Create Backup";
            // 
            // tool_strip_editors
            // 
            this.tool_strip_editors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tool_strip_editors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_tweaks_editor});
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
            this.grp_data_selector.Controls.Add(this.cbb_tileset);
            this.grp_data_selector.Controls.Add(this.cbb_area_bank);
            this.grp_data_selector.Controls.Add(this.lbl_tileset);
            this.grp_data_selector.Controls.Add(this.lbl_area_bank);
            this.grp_data_selector.Location = new System.Drawing.Point(12, 53);
            this.grp_data_selector.Name = "grp_data_selector";
            this.grp_data_selector.Size = new System.Drawing.Size(134, 85);
            this.grp_data_selector.TabIndex = 1;
            this.grp_data_selector.TabStop = false;
            this.grp_data_selector.Text = "Data Selector";
            // 
            // cbb_tileset
            // 
            this.cbb_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_tileset.FormattingEnabled = true;
            this.cbb_tileset.Items.AddRange(new object[] {
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.cbb_tileset.Location = new System.Drawing.Point(76, 49);
            this.cbb_tileset.Name = "cbb_tileset";
            this.cbb_tileset.Size = new System.Drawing.Size(50, 23);
            this.cbb_tileset.TabIndex = 3;
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
            this.cbb_area_bank.Location = new System.Drawing.Point(76, 20);
            this.cbb_area_bank.Name = "cbb_area_bank";
            this.cbb_area_bank.Size = new System.Drawing.Size(50, 23);
            this.cbb_area_bank.TabIndex = 2;
            this.cbb_area_bank.SelectedIndexChanged += new System.EventHandler(this.cbb_area_bank_SelectedIndexChanged);
            // 
            // lbl_tileset
            // 
            this.lbl_tileset.AutoSize = true;
            this.lbl_tileset.Location = new System.Drawing.Point(6, 52);
            this.lbl_tileset.Name = "lbl_tileset";
            this.lbl_tileset.Size = new System.Drawing.Size(43, 15);
            this.lbl_tileset.TabIndex = 1;
            this.lbl_tileset.Text = "Tileset:";
            // 
            // lbl_area_bank
            // 
            this.lbl_area_bank.AutoSize = true;
            this.lbl_area_bank.Location = new System.Drawing.Point(7, 23);
            this.lbl_area_bank.Name = "lbl_area_bank";
            this.lbl_area_bank.Size = new System.Drawing.Size(63, 15);
            this.lbl_area_bank.TabIndex = 0;
            this.lbl_area_bank.Text = "Area Bank:";
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
            this.tool_strip_image_buttons.Size = new System.Drawing.Size(849, 25);
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
            this.btn_save_rom_image.Image = ((System.Drawing.Image)(resources.GetObject("btn_save_rom_image.Image")));
            this.btn_save_rom_image.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_save_rom_image.Name = "btn_save_rom_image";
            this.btn_save_rom_image.Size = new System.Drawing.Size(23, 22);
            this.btn_save_rom_image.Text = "Save ROM";
            this.btn_save_rom_image.ToolTipText = "Save ROM";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_open_tweaks_editor_image
            // 
            this.btn_open_tweaks_editor_image.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_open_tweaks_editor_image.Image = ((System.Drawing.Image)(resources.GetObject("btn_open_tweaks_editor_image.Image")));
            this.btn_open_tweaks_editor_image.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_open_tweaks_editor_image.Name = "btn_open_tweaks_editor_image";
            this.btn_open_tweaks_editor_image.Size = new System.Drawing.Size(23, 22);
            this.btn_open_tweaks_editor_image.Text = "Open Tweaks Editor";
            this.btn_open_tweaks_editor_image.ToolTipText = "Tweaks Editor";
            this.btn_open_tweaks_editor_image.Click += new System.EventHandler(this.btn_open_tweaks_editor_image_Click);
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 496);
            this.Controls.Add(this.tool_strip_image_buttons);
            this.Controls.Add(this.grp_data_selector);
            this.Controls.Add(this.tool_strip_main_buttons);
            this.Name = "main_window";
            this.Text = "YAM2E";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tool_strip_main_buttons.ResumeLayout(false);
            this.tool_strip_main_buttons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grp_data_selector.ResumeLayout(false);
            this.grp_data_selector.PerformLayout();
            this.tool_strip_image_buttons.ResumeLayout(false);
            this.tool_strip_image_buttons.PerformLayout();
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
        private System.Windows.Forms.Label lbl_tileset;
        private System.Windows.Forms.Label lbl_area_bank;
        private System.Windows.Forms.ComboBox cbb_tileset;
        private System.Windows.Forms.ToolStripDropDownButton tool_strip_editors;
        private System.Windows.Forms.ToolStripMenuItem btn_tweaks_editor;
        private System.Windows.Forms.ToolStrip tool_strip_image_buttons;
        private System.Windows.Forms.ToolStripButton btn_open_rom_image;
        private System.Windows.Forms.ToolStripButton btn_save_rom_image;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_open_tweaks_editor_image;
    }
}

