namespace LAMP.FORMS
{
    partial class GraphicsEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicsEditor));
            status_strip = new System.Windows.Forms.StatusStrip();
            spring = new System.Windows.Forms.ToolStripStatusLabel();
            btn_import = new System.Windows.Forms.ToolStripDropDownButton();
            btn_import_gfx = new System.Windows.Forms.ToolStripMenuItem();
            btn_import_meta = new System.Windows.Forms.ToolStripMenuItem();
            btn_export = new System.Windows.Forms.ToolStripDropDownButton();
            btn_export_gfx = new System.Windows.Forms.ToolStripMenuItem();
            btn_export_meta = new System.Windows.Forms.ToolStripMenuItem();
            grp_data_selector = new System.Windows.Forms.GroupBox();
            num_height = new System.Windows.Forms.NumericUpDown();
            lbl_times = new System.Windows.Forms.Label();
            txb_offset = new System.Windows.Forms.TextBox();
            num_width = new System.Windows.Forms.NumericUpDown();
            btn_accept = new System.Windows.Forms.Button();
            lbl_offset = new System.Windows.Forms.Label();
            txb_meta_offset = new System.Windows.Forms.TextBox();
            lbl_meta_offset = new System.Windows.Forms.Label();
            grp_graphics = new System.Windows.Forms.GroupBox();
            chb_graphics_grid = new System.Windows.Forms.CheckBox();
            pnl_graphics_view = new System.Windows.Forms.Panel();
            pnl_colors = new System.Windows.Forms.Panel();
            chb_neighbouring = new System.Windows.Forms.CheckBox();
            pnl_current_color = new System.Windows.Forms.Panel();
            lbl_current_color = new System.Windows.Forms.Label();
            pnl_black = new System.Windows.Forms.Panel();
            pnl_white = new System.Windows.Forms.Panel();
            panel_light_gray = new System.Windows.Forms.Panel();
            pnl_dark_gray = new System.Windows.Forms.Panel();
            toolbar_graphics = new Controls.Room.ToolBar();
            pnl_meta_input = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_hex_input = new System.Windows.Forms.Label();
            txb_hex_input = new System.Windows.Forms.TextBox();
            grp_metatiles = new System.Windows.Forms.GroupBox();
            chb_metatiles_grid = new System.Windows.Forms.CheckBox();
            flw_metatile_view = new System.Windows.Forms.FlowLayoutPanel();
            toolbar_metatiles = new Controls.Room.ToolBar();
            pnl_main = new System.Windows.Forms.SplitContainer();
            pnl_gfx_view = new System.Windows.Forms.SplitContainer();
            pnl_apply = new System.Windows.Forms.Panel();
            btn_apply = new System.Windows.Forms.Button();
            status_strip.SuspendLayout();
            grp_data_selector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_width).BeginInit();
            grp_graphics.SuspendLayout();
            pnl_colors.SuspendLayout();
            pnl_meta_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grp_metatiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnl_main).BeginInit();
            pnl_main.Panel1.SuspendLayout();
            pnl_main.Panel2.SuspendLayout();
            pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnl_gfx_view).BeginInit();
            pnl_gfx_view.Panel1.SuspendLayout();
            pnl_gfx_view.Panel2.SuspendLayout();
            pnl_gfx_view.SuspendLayout();
            pnl_apply.SuspendLayout();
            SuspendLayout();
            // 
            // status_strip
            // 
            status_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { spring, btn_import, btn_export });
            status_strip.Location = new System.Drawing.Point(0, 565);
            status_strip.Name = "status_strip";
            status_strip.Size = new System.Drawing.Size(739, 22);
            status_strip.TabIndex = 0;
            status_strip.Text = "statusStrip1";
            // 
            // spring
            // 
            spring.Name = "spring";
            spring.Size = new System.Drawing.Size(600, 17);
            spring.Spring = true;
            // 
            // btn_import
            // 
            btn_import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btn_import_gfx, btn_import_meta });
            btn_import.Image = Properties.Resources.Import;
            btn_import.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_import.Name = "btn_import";
            btn_import.ShowDropDownArrow = false;
            btn_import.Size = new System.Drawing.Size(63, 20);
            btn_import.Text = "Import";
            btn_import.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // btn_import_gfx
            // 
            btn_import_gfx.Name = "btn_import_gfx";
            btn_import_gfx.Size = new System.Drawing.Size(122, 22);
            btn_import_gfx.Text = "Graphics";
            btn_import_gfx.Click += btn_import_gfx_Click;
            // 
            // btn_import_meta
            // 
            btn_import_meta.Name = "btn_import_meta";
            btn_import_meta.Size = new System.Drawing.Size(122, 22);
            btn_import_meta.Text = "Metatiles";
            btn_import_meta.Click += btn_import_meta_Click;
            // 
            // btn_export
            // 
            btn_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btn_export_gfx, btn_export_meta });
            btn_export.Image = Properties.Resources.Export;
            btn_export.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_export.Name = "btn_export";
            btn_export.ShowDropDownArrow = false;
            btn_export.Size = new System.Drawing.Size(61, 20);
            btn_export.Text = "Export";
            btn_export.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // btn_export_gfx
            // 
            btn_export_gfx.Name = "btn_export_gfx";
            btn_export_gfx.Size = new System.Drawing.Size(122, 22);
            btn_export_gfx.Text = "Graphics";
            btn_export_gfx.Click += btn_export_gfx_Click;
            // 
            // btn_export_meta
            // 
            btn_export_meta.Name = "btn_export_meta";
            btn_export_meta.Size = new System.Drawing.Size(122, 22);
            btn_export_meta.Text = "Metatiles";
            btn_export_meta.Click += btn_export_meta_Click;
            // 
            // grp_data_selector
            // 
            grp_data_selector.Controls.Add(num_height);
            grp_data_selector.Controls.Add(lbl_times);
            grp_data_selector.Controls.Add(txb_offset);
            grp_data_selector.Controls.Add(num_width);
            grp_data_selector.Controls.Add(btn_accept);
            grp_data_selector.Controls.Add(lbl_offset);
            grp_data_selector.Controls.Add(txb_meta_offset);
            grp_data_selector.Controls.Add(lbl_meta_offset);
            grp_data_selector.Dock = System.Windows.Forms.DockStyle.Top;
            grp_data_selector.Location = new System.Drawing.Point(9, 6);
            grp_data_selector.Name = "grp_data_selector";
            grp_data_selector.Size = new System.Drawing.Size(167, 139);
            grp_data_selector.TabIndex = 1;
            grp_data_selector.TabStop = false;
            grp_data_selector.Text = "Data Selector";
            // 
            // num_height
            // 
            num_height.Hexadecimal = true;
            num_height.Location = new System.Drawing.Point(129, 51);
            num_height.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            num_height.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_height.Name = "num_height";
            num_height.Size = new System.Drawing.Size(33, 23);
            num_height.TabIndex = 7;
            num_height.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // lbl_times
            // 
            lbl_times.AutoSize = true;
            lbl_times.Location = new System.Drawing.Point(109, 53);
            lbl_times.Name = "lbl_times";
            lbl_times.Size = new System.Drawing.Size(14, 15);
            lbl_times.TabIndex = 2;
            lbl_times.Text = "X";
            // 
            // txb_offset
            // 
            txb_offset.Location = new System.Drawing.Point(70, 22);
            txb_offset.Name = "txb_offset";
            txb_offset.Size = new System.Drawing.Size(92, 23);
            txb_offset.TabIndex = 1;
            // 
            // num_width
            // 
            num_width.Hexadecimal = true;
            num_width.Location = new System.Drawing.Point(70, 51);
            num_width.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            num_width.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_width.Name = "num_width";
            num_width.Size = new System.Drawing.Size(33, 23);
            num_width.TabIndex = 6;
            num_width.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // btn_accept
            // 
            btn_accept.Location = new System.Drawing.Point(71, 109);
            btn_accept.Name = "btn_accept";
            btn_accept.Size = new System.Drawing.Size(92, 23);
            btn_accept.TabIndex = 8;
            btn_accept.Text = "View";
            btn_accept.UseVisualStyleBackColor = true;
            btn_accept.Click += btn_accept_Click;
            // 
            // lbl_offset
            // 
            lbl_offset.AutoSize = true;
            lbl_offset.Location = new System.Drawing.Point(6, 25);
            lbl_offset.Name = "lbl_offset";
            lbl_offset.Size = new System.Drawing.Size(42, 15);
            lbl_offset.TabIndex = 0;
            lbl_offset.Text = "Offset:";
            // 
            // txb_meta_offset
            // 
            txb_meta_offset.Location = new System.Drawing.Point(71, 80);
            txb_meta_offset.Name = "txb_meta_offset";
            txb_meta_offset.Size = new System.Drawing.Size(92, 23);
            txb_meta_offset.TabIndex = 5;
            // 
            // lbl_meta_offset
            // 
            lbl_meta_offset.AutoSize = true;
            lbl_meta_offset.Location = new System.Drawing.Point(6, 83);
            lbl_meta_offset.Name = "lbl_meta_offset";
            lbl_meta_offset.Size = new System.Drawing.Size(58, 15);
            lbl_meta_offset.TabIndex = 4;
            lbl_meta_offset.Text = "Metatiles:";
            // 
            // grp_graphics
            // 
            grp_graphics.Controls.Add(chb_graphics_grid);
            grp_graphics.Controls.Add(pnl_graphics_view);
            grp_graphics.Controls.Add(pnl_colors);
            grp_graphics.Controls.Add(toolbar_graphics);
            grp_graphics.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_graphics.Location = new System.Drawing.Point(3, 6);
            grp_graphics.Name = "grp_graphics";
            grp_graphics.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            grp_graphics.Size = new System.Drawing.Size(544, 233);
            grp_graphics.TabIndex = 5;
            grp_graphics.TabStop = false;
            grp_graphics.Text = "Graphics";
            // 
            // chb_graphics_grid
            // 
            chb_graphics_grid.AutoSize = true;
            chb_graphics_grid.Location = new System.Drawing.Point(322, 22);
            chb_graphics_grid.Name = "chb_graphics_grid";
            chb_graphics_grid.Size = new System.Drawing.Size(48, 19);
            chb_graphics_grid.TabIndex = 6;
            chb_graphics_grid.Text = "Grid";
            chb_graphics_grid.UseVisualStyleBackColor = true;
            chb_graphics_grid.CheckedChanged += chb_graphics_grid_CheckedChanged;
            // 
            // pnl_graphics_view
            // 
            pnl_graphics_view.AutoScroll = true;
            pnl_graphics_view.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_graphics_view.Location = new System.Drawing.Point(6, 71);
            pnl_graphics_view.Name = "pnl_graphics_view";
            pnl_graphics_view.Size = new System.Drawing.Size(532, 156);
            pnl_graphics_view.TabIndex = 2;
            pnl_graphics_view.MouseDown += pnl_graphics_view_MouseDown;
            // 
            // pnl_colors
            // 
            pnl_colors.Controls.Add(chb_neighbouring);
            pnl_colors.Controls.Add(pnl_current_color);
            pnl_colors.Controls.Add(lbl_current_color);
            pnl_colors.Controls.Add(pnl_black);
            pnl_colors.Controls.Add(pnl_white);
            pnl_colors.Controls.Add(panel_light_gray);
            pnl_colors.Controls.Add(pnl_dark_gray);
            pnl_colors.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_colors.Location = new System.Drawing.Point(6, 47);
            pnl_colors.Name = "pnl_colors";
            pnl_colors.Size = new System.Drawing.Size(532, 24);
            pnl_colors.TabIndex = 5;
            // 
            // chb_neighbouring
            // 
            chb_neighbouring.AutoSize = true;
            chb_neighbouring.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chb_neighbouring.Checked = true;
            chb_neighbouring.CheckState = System.Windows.Forms.CheckState.Checked;
            chb_neighbouring.Location = new System.Drawing.Point(182, 2);
            chb_neighbouring.Name = "chb_neighbouring";
            chb_neighbouring.Size = new System.Drawing.Size(103, 19);
            chb_neighbouring.TabIndex = 6;
            chb_neighbouring.Text = "Neighbouring:";
            chb_neighbouring.UseVisualStyleBackColor = true;
            chb_neighbouring.Visible = false;
            // 
            // pnl_current_color
            // 
            pnl_current_color.BackColor = System.Drawing.Color.FromArgb(107, 107, 107);
            pnl_current_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_current_color.Location = new System.Drawing.Point(155, 0);
            pnl_current_color.Margin = new System.Windows.Forms.Padding(0);
            pnl_current_color.Name = "pnl_current_color";
            pnl_current_color.Size = new System.Drawing.Size(24, 24);
            pnl_current_color.TabIndex = 4;
            pnl_current_color.Tag = "1";
            // 
            // lbl_current_color
            // 
            lbl_current_color.AutoSize = true;
            lbl_current_color.Location = new System.Drawing.Point(102, 3);
            lbl_current_color.Name = "lbl_current_color";
            lbl_current_color.Size = new System.Drawing.Size(50, 15);
            lbl_current_color.TabIndex = 5;
            lbl_current_color.Text = "Current:";
            // 
            // pnl_black
            // 
            pnl_black.BackColor = System.Drawing.Color.Black;
            pnl_black.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_black.Location = new System.Drawing.Point(3, 0);
            pnl_black.Margin = new System.Windows.Forms.Padding(0);
            pnl_black.Name = "pnl_black";
            pnl_black.Size = new System.Drawing.Size(24, 24);
            pnl_black.TabIndex = 2;
            pnl_black.Tag = "0";
            pnl_black.Click += pnl_color_Click;
            // 
            // pnl_white
            // 
            pnl_white.BackColor = System.Drawing.Color.FromArgb(239, 239, 239);
            pnl_white.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_white.Location = new System.Drawing.Point(75, 0);
            pnl_white.Margin = new System.Windows.Forms.Padding(0);
            pnl_white.Name = "pnl_white";
            pnl_white.Size = new System.Drawing.Size(24, 24);
            pnl_white.TabIndex = 3;
            pnl_white.Tag = "1";
            pnl_white.Click += pnl_color_Click;
            // 
            // panel_light_gray
            // 
            panel_light_gray.BackColor = System.Drawing.Color.FromArgb(165, 165, 165);
            panel_light_gray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel_light_gray.Location = new System.Drawing.Point(51, 0);
            panel_light_gray.Margin = new System.Windows.Forms.Padding(0);
            panel_light_gray.Name = "panel_light_gray";
            panel_light_gray.Size = new System.Drawing.Size(24, 24);
            panel_light_gray.TabIndex = 4;
            panel_light_gray.Tag = "2";
            panel_light_gray.Click += pnl_color_Click;
            // 
            // pnl_dark_gray
            // 
            pnl_dark_gray.BackColor = System.Drawing.Color.FromArgb(107, 107, 107);
            pnl_dark_gray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_dark_gray.Location = new System.Drawing.Point(27, 0);
            pnl_dark_gray.Margin = new System.Windows.Forms.Padding(0);
            pnl_dark_gray.Name = "pnl_dark_gray";
            pnl_dark_gray.Size = new System.Drawing.Size(24, 24);
            pnl_dark_gray.TabIndex = 3;
            pnl_dark_gray.Tag = "3";
            pnl_dark_gray.Click += pnl_color_Click;
            // 
            // toolbar_graphics
            // 
            toolbar_graphics.Dock = System.Windows.Forms.DockStyle.Top;
            toolbar_graphics.Location = new System.Drawing.Point(6, 19);
            toolbar_graphics.MaxZoom = 15;
            toolbar_graphics.Name = "toolbar_graphics";
            toolbar_graphics.onToolCommandTriggered = null;
            toolbar_graphics.onToolSwitched = null;
            toolbar_graphics.SelectedTool = LampTool.Pen;
            toolbar_graphics.Size = new System.Drawing.Size(532, 28);
            toolbar_graphics.TabIndex = 1;
            toolbar_graphics.ZoomLevel = 2;
            toolbar_graphics.ToolSwitched += toolbar_graphics_ToolSwitched;
            toolbar_graphics.ToolCommandTriggered += toolbar_graphics_ToolCommandTriggered;
            // 
            // pnl_meta_input
            // 
            pnl_meta_input.Controls.Add(pictureBox1);
            pnl_meta_input.Controls.Add(lbl_hex_input);
            pnl_meta_input.Controls.Add(txb_hex_input);
            pnl_meta_input.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_meta_input.Location = new System.Drawing.Point(6, 47);
            pnl_meta_input.Name = "pnl_meta_input";
            pnl_meta_input.Size = new System.Drawing.Size(532, 24);
            pnl_meta_input.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pictureBox1.Location = new System.Drawing.Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(18, 24);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lbl_hex_input
            // 
            lbl_hex_input.AutoSize = true;
            lbl_hex_input.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbl_hex_input.Location = new System.Drawing.Point(19, 4);
            lbl_hex_input.Name = "lbl_hex_input";
            lbl_hex_input.Size = new System.Drawing.Size(28, 15);
            lbl_hex_input.TabIndex = 4;
            lbl_hex_input.Text = "Tile:";
            // 
            // txb_hex_input
            // 
            txb_hex_input.Location = new System.Drawing.Point(53, 1);
            txb_hex_input.Name = "txb_hex_input";
            txb_hex_input.Size = new System.Drawing.Size(35, 23);
            txb_hex_input.TabIndex = 1;
            txb_hex_input.Text = "0xFF";
            txb_hex_input.TextChanged += txb_hex_input_TextChanged;
            // 
            // grp_metatiles
            // 
            grp_metatiles.Controls.Add(chb_metatiles_grid);
            grp_metatiles.Controls.Add(flw_metatile_view);
            grp_metatiles.Controls.Add(pnl_meta_input);
            grp_metatiles.Controls.Add(toolbar_metatiles);
            grp_metatiles.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_metatiles.Location = new System.Drawing.Point(3, 3);
            grp_metatiles.Name = "grp_metatiles";
            grp_metatiles.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            grp_metatiles.Size = new System.Drawing.Size(544, 280);
            grp_metatiles.TabIndex = 6;
            grp_metatiles.TabStop = false;
            grp_metatiles.Text = "Metatiles";
            // 
            // chb_metatiles_grid
            // 
            chb_metatiles_grid.AutoSize = true;
            chb_metatiles_grid.Location = new System.Drawing.Point(322, 22);
            chb_metatiles_grid.Name = "chb_metatiles_grid";
            chb_metatiles_grid.Size = new System.Drawing.Size(48, 19);
            chb_metatiles_grid.TabIndex = 7;
            chb_metatiles_grid.Text = "Grid";
            chb_metatiles_grid.UseVisualStyleBackColor = true;
            chb_metatiles_grid.CheckedChanged += chb_metatiles_grid_CheckedChanged;
            // 
            // flw_metatile_view
            // 
            flw_metatile_view.AutoScroll = true;
            flw_metatile_view.Dock = System.Windows.Forms.DockStyle.Fill;
            flw_metatile_view.Location = new System.Drawing.Point(6, 71);
            flw_metatile_view.Name = "flw_metatile_view";
            flw_metatile_view.Size = new System.Drawing.Size(532, 203);
            flw_metatile_view.TabIndex = 0;
            // 
            // toolbar_metatiles
            // 
            toolbar_metatiles.Dock = System.Windows.Forms.DockStyle.Top;
            toolbar_metatiles.Location = new System.Drawing.Point(6, 19);
            toolbar_metatiles.MaxZoom = 10;
            toolbar_metatiles.Name = "toolbar_metatiles";
            toolbar_metatiles.onToolCommandTriggered = null;
            toolbar_metatiles.onToolSwitched = null;
            toolbar_metatiles.SelectedTool = LampTool.Pen;
            toolbar_metatiles.Size = new System.Drawing.Size(532, 28);
            toolbar_metatiles.TabIndex = 1;
            toolbar_metatiles.ZoomLevel = 1;
            toolbar_metatiles.ToolCommandTriggered += toolbar_metatiles_ToolCommandTriggered;
            // 
            // pnl_main
            // 
            pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            pnl_main.Location = new System.Drawing.Point(0, 0);
            pnl_main.Name = "pnl_main";
            // 
            // pnl_main.Panel1
            // 
            pnl_main.Panel1.Controls.Add(grp_data_selector);
            pnl_main.Panel1.Padding = new System.Windows.Forms.Padding(9, 6, 3, 6);
            // 
            // pnl_main.Panel2
            // 
            pnl_main.Panel2.Controls.Add(pnl_gfx_view);
            pnl_main.Size = new System.Drawing.Size(739, 565);
            pnl_main.SplitterDistance = 179;
            pnl_main.TabIndex = 7;
            // 
            // pnl_gfx_view
            // 
            pnl_gfx_view.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_gfx_view.Location = new System.Drawing.Point(0, 0);
            pnl_gfx_view.Name = "pnl_gfx_view";
            pnl_gfx_view.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // pnl_gfx_view.Panel1
            // 
            pnl_gfx_view.Panel1.Controls.Add(grp_graphics);
            pnl_gfx_view.Panel1.Padding = new System.Windows.Forms.Padding(3, 6, 9, 3);
            // 
            // pnl_gfx_view.Panel2
            // 
            pnl_gfx_view.Panel2.Controls.Add(grp_metatiles);
            pnl_gfx_view.Panel2.Controls.Add(pnl_apply);
            pnl_gfx_view.Panel2.Padding = new System.Windows.Forms.Padding(3, 3, 9, 6);
            pnl_gfx_view.Size = new System.Drawing.Size(556, 565);
            pnl_gfx_view.SplitterDistance = 242;
            pnl_gfx_view.TabIndex = 0;
            // 
            // pnl_apply
            // 
            pnl_apply.Controls.Add(btn_apply);
            pnl_apply.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_apply.Location = new System.Drawing.Point(3, 283);
            pnl_apply.Name = "pnl_apply";
            pnl_apply.Size = new System.Drawing.Size(544, 30);
            pnl_apply.TabIndex = 7;
            // 
            // btn_apply
            // 
            btn_apply.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_apply.Image = Properties.Resources.Save;
            btn_apply.Location = new System.Drawing.Point(480, 4);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new System.Drawing.Size(64, 23);
            btn_apply.TabIndex = 2;
            btn_apply.Text = "Apply";
            btn_apply.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            btn_apply.UseVisualStyleBackColor = true;
            btn_apply.Click += btn_apply_Click;
            // 
            // GraphicsEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(739, 587);
            Controls.Add(pnl_main);
            Controls.Add(status_strip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(530, 500);
            Name = "GraphicsEditor";
            Text = "Graphics Editor";
            status_strip.ResumeLayout(false);
            status_strip.PerformLayout();
            grp_data_selector.ResumeLayout(false);
            grp_data_selector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_height).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_width).EndInit();
            grp_graphics.ResumeLayout(false);
            grp_graphics.PerformLayout();
            pnl_colors.ResumeLayout(false);
            pnl_colors.PerformLayout();
            pnl_meta_input.ResumeLayout(false);
            pnl_meta_input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grp_metatiles.ResumeLayout(false);
            grp_metatiles.PerformLayout();
            pnl_main.Panel1.ResumeLayout(false);
            pnl_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnl_main).EndInit();
            pnl_main.ResumeLayout(false);
            pnl_gfx_view.Panel1.ResumeLayout(false);
            pnl_gfx_view.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnl_gfx_view).EndInit();
            pnl_gfx_view.ResumeLayout(false);
            pnl_apply.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip status_strip;
        private System.Windows.Forms.GroupBox grp_data_selector;
        private System.Windows.Forms.TextBox txb_offset;
        private System.Windows.Forms.Label lbl_offset;
        private System.Windows.Forms.NumericUpDown num_height;
        private System.Windows.Forms.NumericUpDown num_width;
        private System.Windows.Forms.TextBox txb_meta_offset;
        private System.Windows.Forms.Label lbl_meta_offset;
        private System.Windows.Forms.Label lbl_times;
        private System.Windows.Forms.GroupBox grp_graphics;
        private Controls.Room.ToolBar toolbar_graphics;
        private System.Windows.Forms.GroupBox grp_metatiles;
        private System.Windows.Forms.FlowLayoutPanel flw_metatile_view;
        private Controls.Room.ToolBar toolbar_metatiles;
        private System.Windows.Forms.SplitContainer pnl_main;
        private System.Windows.Forms.SplitContainer pnl_gfx_view;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Panel pnl_apply;
        private System.Windows.Forms.ToolStripStatusLabel spring;
        private System.Windows.Forms.ToolStripDropDownButton btn_import;
        private System.Windows.Forms.ToolStripDropDownButton btn_export;
        private System.Windows.Forms.ToolStripMenuItem btn_import_gfx;
        private System.Windows.Forms.ToolStripMenuItem btn_import_meta;
        private System.Windows.Forms.ToolStripMenuItem btn_export_gfx;
        private System.Windows.Forms.ToolStripMenuItem btn_export_meta;
        private System.Windows.Forms.Panel pnl_graphics_view;
        private System.Windows.Forms.Panel pnl_black;
        private System.Windows.Forms.Panel pnl_dark_gray;
        private System.Windows.Forms.Panel pnl_white;
        private System.Windows.Forms.Panel panel_light_gray;
        private System.Windows.Forms.Panel pnl_colors;
        private System.Windows.Forms.TextBox txb_hex_input;
        private System.Windows.Forms.Panel pnl_meta_input;
        private System.Windows.Forms.Panel pnl_current_color;
        private System.Windows.Forms.Label lbl_current_color;
        private System.Windows.Forms.CheckBox chb_neighbouring;
        private System.Windows.Forms.CheckBox chb_graphics_grid;
        private System.Windows.Forms.Label lbl_hex_input;
        private System.Windows.Forms.CheckBox chb_metatiles_grid;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}