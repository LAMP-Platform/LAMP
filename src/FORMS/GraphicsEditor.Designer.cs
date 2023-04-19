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
            grp_data_selector = new System.Windows.Forms.GroupBox();
            btn_accept = new System.Windows.Forms.Button();
            num_height = new System.Windows.Forms.NumericUpDown();
            txb_meta_offset = new System.Windows.Forms.TextBox();
            lbl_meta_offset = new System.Windows.Forms.Label();
            num_width = new System.Windows.Forms.NumericUpDown();
            txb_offset = new System.Windows.Forms.TextBox();
            lbl_offset = new System.Windows.Forms.Label();
            lbl_width = new System.Windows.Forms.Label();
            lbl_height = new System.Windows.Forms.Label();
            grp_graphics = new System.Windows.Forms.GroupBox();
            flw_graphics_view = new System.Windows.Forms.FlowLayoutPanel();
            toolbar_graphics = new Controls.Room.ToolBar();
            grp_metatiles = new System.Windows.Forms.GroupBox();
            flw_metatile_view = new System.Windows.Forms.FlowLayoutPanel();
            toolbar_metatiles = new Controls.Room.ToolBar();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            btn_apply = new System.Windows.Forms.Button();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            grp_data_selector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_width).BeginInit();
            grp_graphics.SuspendLayout();
            grp_metatiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // status_strip
            // 
            status_strip.Location = new System.Drawing.Point(0, 535);
            status_strip.Name = "status_strip";
            status_strip.Size = new System.Drawing.Size(739, 22);
            status_strip.TabIndex = 0;
            status_strip.Text = "statusStrip1";
            // 
            // grp_data_selector
            // 
            grp_data_selector.Controls.Add(btn_accept);
            grp_data_selector.Controls.Add(num_height);
            grp_data_selector.Controls.Add(txb_meta_offset);
            grp_data_selector.Controls.Add(lbl_meta_offset);
            grp_data_selector.Controls.Add(num_width);
            grp_data_selector.Controls.Add(txb_offset);
            grp_data_selector.Controls.Add(lbl_offset);
            grp_data_selector.Controls.Add(lbl_width);
            grp_data_selector.Controls.Add(lbl_height);
            grp_data_selector.Dock = System.Windows.Forms.DockStyle.Top;
            grp_data_selector.Location = new System.Drawing.Point(9, 6);
            grp_data_selector.Name = "grp_data_selector";
            grp_data_selector.Size = new System.Drawing.Size(167, 168);
            grp_data_selector.TabIndex = 1;
            grp_data_selector.TabStop = false;
            grp_data_selector.Text = "Data Selector";
            // 
            // btn_accept
            // 
            btn_accept.Location = new System.Drawing.Point(70, 138);
            btn_accept.Name = "btn_accept";
            btn_accept.Size = new System.Drawing.Size(92, 23);
            btn_accept.TabIndex = 8;
            btn_accept.Text = "View";
            btn_accept.UseVisualStyleBackColor = true;
            btn_accept.Click += btn_accept_Click;
            // 
            // num_height
            // 
            num_height.Location = new System.Drawing.Point(70, 109);
            num_height.Name = "num_height";
            num_height.Size = new System.Drawing.Size(92, 23);
            num_height.TabIndex = 7;
            // 
            // txb_meta_offset
            // 
            txb_meta_offset.Location = new System.Drawing.Point(70, 51);
            txb_meta_offset.Name = "txb_meta_offset";
            txb_meta_offset.Size = new System.Drawing.Size(92, 23);
            txb_meta_offset.TabIndex = 5;
            // 
            // lbl_meta_offset
            // 
            lbl_meta_offset.AutoSize = true;
            lbl_meta_offset.Location = new System.Drawing.Point(6, 54);
            lbl_meta_offset.Name = "lbl_meta_offset";
            lbl_meta_offset.Size = new System.Drawing.Size(58, 15);
            lbl_meta_offset.TabIndex = 4;
            lbl_meta_offset.Text = "Metatiles:";
            // 
            // num_width
            // 
            num_width.Location = new System.Drawing.Point(70, 80);
            num_width.Name = "num_width";
            num_width.Size = new System.Drawing.Size(92, 23);
            num_width.TabIndex = 6;
            // 
            // txb_offset
            // 
            txb_offset.Location = new System.Drawing.Point(70, 22);
            txb_offset.Name = "txb_offset";
            txb_offset.Size = new System.Drawing.Size(92, 23);
            txb_offset.TabIndex = 1;
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
            // lbl_width
            // 
            lbl_width.AutoSize = true;
            lbl_width.Location = new System.Drawing.Point(6, 82);
            lbl_width.Name = "lbl_width";
            lbl_width.Size = new System.Drawing.Size(42, 15);
            lbl_width.TabIndex = 2;
            lbl_width.Text = "Width:";
            // 
            // lbl_height
            // 
            lbl_height.AutoSize = true;
            lbl_height.Location = new System.Drawing.Point(6, 111);
            lbl_height.Name = "lbl_height";
            lbl_height.Size = new System.Drawing.Size(46, 15);
            lbl_height.TabIndex = 3;
            lbl_height.Text = "Height:";
            // 
            // grp_graphics
            // 
            grp_graphics.Controls.Add(flw_graphics_view);
            grp_graphics.Controls.Add(toolbar_graphics);
            grp_graphics.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_graphics.Location = new System.Drawing.Point(3, 6);
            grp_graphics.Name = "grp_graphics";
            grp_graphics.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            grp_graphics.Size = new System.Drawing.Size(544, 252);
            grp_graphics.TabIndex = 5;
            grp_graphics.TabStop = false;
            grp_graphics.Text = "Graphics";
            // 
            // flw_graphics_view
            // 
            flw_graphics_view.AutoScroll = true;
            flw_graphics_view.Dock = System.Windows.Forms.DockStyle.Fill;
            flw_graphics_view.Location = new System.Drawing.Point(6, 47);
            flw_graphics_view.Name = "flw_graphics_view";
            flw_graphics_view.Size = new System.Drawing.Size(532, 199);
            flw_graphics_view.TabIndex = 0;
            // 
            // toolbar_graphics
            // 
            toolbar_graphics.Dock = System.Windows.Forms.DockStyle.Top;
            toolbar_graphics.Location = new System.Drawing.Point(6, 19);
            toolbar_graphics.MaxZoom = 15;
            toolbar_graphics.Name = "toolbar_graphics";
            toolbar_graphics.onToolCommandTriggered = null;
            toolbar_graphics.onToolSwitched = null;
            toolbar_graphics.SelectedTool = LAMP.Controls.Room.LampTool.Pen;
            toolbar_graphics.Size = new System.Drawing.Size(532, 28);
            toolbar_graphics.TabIndex = 1;
            toolbar_graphics.ZoomLevel = 2;
            toolbar_graphics.ToolCommandTriggered += toolbar_graphics_ToolCommandTriggered;
            // 
            // grp_metatiles
            // 
            grp_metatiles.Controls.Add(flw_metatile_view);
            grp_metatiles.Controls.Add(toolbar_metatiles);
            grp_metatiles.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_metatiles.Location = new System.Drawing.Point(3, 3);
            grp_metatiles.Name = "grp_metatiles";
            grp_metatiles.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            grp_metatiles.Size = new System.Drawing.Size(544, 261);
            grp_metatiles.TabIndex = 6;
            grp_metatiles.TabStop = false;
            grp_metatiles.Text = "Metatiles";
            // 
            // flw_metatile_view
            // 
            flw_metatile_view.AutoScroll = true;
            flw_metatile_view.Dock = System.Windows.Forms.DockStyle.Fill;
            flw_metatile_view.Location = new System.Drawing.Point(6, 47);
            flw_metatile_view.Name = "flw_metatile_view";
            flw_metatile_view.Size = new System.Drawing.Size(532, 208);
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
            toolbar_metatiles.SelectedTool = LAMP.Controls.Room.LampTool.Pen;
            toolbar_metatiles.Size = new System.Drawing.Size(532, 28);
            toolbar_metatiles.TabIndex = 1;
            toolbar_metatiles.ZoomLevel = 1;
            toolbar_metatiles.ToolCommandTriggered += toolbar_metatiles_ToolCommandTriggered;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btn_apply);
            splitContainer1.Panel1.Controls.Add(grp_data_selector);
            splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(9, 6, 3, 6);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new System.Drawing.Size(739, 535);
            splitContainer1.SplitterDistance = 179;
            splitContainer1.TabIndex = 7;
            // 
            // btn_apply
            // 
            btn_apply.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_apply.Location = new System.Drawing.Point(79, 500);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new System.Drawing.Size(92, 23);
            btn_apply.TabIndex = 2;
            btn_apply.Text = "Apply";
            btn_apply.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(grp_graphics);
            splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(3, 6, 9, 3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(grp_metatiles);
            splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(3, 3, 9, 6);
            splitContainer2.Size = new System.Drawing.Size(556, 535);
            splitContainer2.SplitterDistance = 261;
            splitContainer2.TabIndex = 0;
            // 
            // GraphicsEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(739, 557);
            Controls.Add(splitContainer1);
            Controls.Add(status_strip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(530, 500);
            Name = "GraphicsEditor";
            Text = "Graphics Editor";
            grp_data_selector.ResumeLayout(false);
            grp_data_selector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_height).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_width).EndInit();
            grp_graphics.ResumeLayout(false);
            grp_metatiles.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.GroupBox grp_graphics;
        private System.Windows.Forms.FlowLayoutPanel flw_graphics_view;
        private Controls.Room.ToolBar toolbar_graphics;
        private System.Windows.Forms.GroupBox grp_metatiles;
        private System.Windows.Forms.FlowLayoutPanel flw_metatile_view;
        private Controls.Room.ToolBar toolbar_metatiles;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_apply;
    }
}