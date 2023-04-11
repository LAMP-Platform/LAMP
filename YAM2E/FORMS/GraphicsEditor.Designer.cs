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
            this.status_strip = new System.Windows.Forms.StatusStrip();
            this.grp_data_selector = new System.Windows.Forms.GroupBox();
            this.lbl_offset = new System.Windows.Forms.Label();
            this.txb_offset = new System.Windows.Forms.TextBox();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.lbl_meta_offset = new System.Windows.Forms.Label();
            this.txb_meta_offset = new System.Windows.Forms.TextBox();
            this.num_width = new System.Windows.Forms.NumericUpDown();
            this.num_height = new System.Windows.Forms.NumericUpDown();
            this.grp_graphics = new System.Windows.Forms.GroupBox();
            this.flw_graphics_view = new System.Windows.Forms.FlowLayoutPanel();
            this.toolbar_graphics = new LAMP.Controls.Room.ToolBar();
            this.grp_metatiles = new System.Windows.Forms.GroupBox();
            this.flw_metatile_view = new System.Windows.Forms.FlowLayoutPanel();
            this.toolbar_metatiles = new LAMP.Controls.Room.ToolBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grp_data_selector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_height)).BeginInit();
            this.grp_graphics.SuspendLayout();
            this.grp_metatiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_strip
            // 
            this.status_strip.Location = new System.Drawing.Point(0, 707);
            this.status_strip.Name = "status_strip";
            this.status_strip.Size = new System.Drawing.Size(1153, 22);
            this.status_strip.TabIndex = 0;
            this.status_strip.Text = "statusStrip1";
            // 
            // grp_data_selector
            // 
            this.grp_data_selector.Controls.Add(this.num_height);
            this.grp_data_selector.Controls.Add(this.txb_meta_offset);
            this.grp_data_selector.Controls.Add(this.lbl_meta_offset);
            this.grp_data_selector.Controls.Add(this.num_width);
            this.grp_data_selector.Controls.Add(this.txb_offset);
            this.grp_data_selector.Controls.Add(this.lbl_offset);
            this.grp_data_selector.Controls.Add(this.lbl_width);
            this.grp_data_selector.Controls.Add(this.lbl_height);
            this.grp_data_selector.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_data_selector.Location = new System.Drawing.Point(9, 6);
            this.grp_data_selector.Name = "grp_data_selector";
            this.grp_data_selector.Size = new System.Drawing.Size(167, 139);
            this.grp_data_selector.TabIndex = 1;
            this.grp_data_selector.TabStop = false;
            this.grp_data_selector.Text = "Data Selector";
            // 
            // lbl_offset
            // 
            this.lbl_offset.AutoSize = true;
            this.lbl_offset.Location = new System.Drawing.Point(6, 25);
            this.lbl_offset.Name = "lbl_offset";
            this.lbl_offset.Size = new System.Drawing.Size(42, 15);
            this.lbl_offset.TabIndex = 0;
            this.lbl_offset.Text = "Offset:";
            // 
            // txb_offset
            // 
            this.txb_offset.Location = new System.Drawing.Point(70, 22);
            this.txb_offset.Name = "txb_offset";
            this.txb_offset.Size = new System.Drawing.Size(92, 23);
            this.txb_offset.TabIndex = 1;
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Location = new System.Drawing.Point(6, 82);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(42, 15);
            this.lbl_width.TabIndex = 2;
            this.lbl_width.Text = "Width:";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(6, 111);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(46, 15);
            this.lbl_height.TabIndex = 3;
            this.lbl_height.Text = "Height:";
            // 
            // lbl_meta_offset
            // 
            this.lbl_meta_offset.AutoSize = true;
            this.lbl_meta_offset.Location = new System.Drawing.Point(6, 54);
            this.lbl_meta_offset.Name = "lbl_meta_offset";
            this.lbl_meta_offset.Size = new System.Drawing.Size(58, 15);
            this.lbl_meta_offset.TabIndex = 4;
            this.lbl_meta_offset.Text = "Metatiles:";
            // 
            // txb_meta_offset
            // 
            this.txb_meta_offset.Location = new System.Drawing.Point(70, 51);
            this.txb_meta_offset.Name = "txb_meta_offset";
            this.txb_meta_offset.Size = new System.Drawing.Size(92, 23);
            this.txb_meta_offset.TabIndex = 5;
            // 
            // num_width
            // 
            this.num_width.Location = new System.Drawing.Point(70, 80);
            this.num_width.Name = "num_width";
            this.num_width.Size = new System.Drawing.Size(92, 23);
            this.num_width.TabIndex = 6;
            // 
            // num_height
            // 
            this.num_height.Location = new System.Drawing.Point(70, 109);
            this.num_height.Name = "num_height";
            this.num_height.Size = new System.Drawing.Size(92, 23);
            this.num_height.TabIndex = 7;
            // 
            // grp_graphics
            // 
            this.grp_graphics.Controls.Add(this.flw_graphics_view);
            this.grp_graphics.Controls.Add(this.toolbar_graphics);
            this.grp_graphics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_graphics.Location = new System.Drawing.Point(3, 6);
            this.grp_graphics.Name = "grp_graphics";
            this.grp_graphics.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.grp_graphics.Size = new System.Drawing.Size(958, 320);
            this.grp_graphics.TabIndex = 5;
            this.grp_graphics.TabStop = false;
            this.grp_graphics.Text = "Graphics";
            // 
            // flw_graphics_view
            // 
            this.flw_graphics_view.AutoScroll = true;
            this.flw_graphics_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flw_graphics_view.Location = new System.Drawing.Point(6, 47);
            this.flw_graphics_view.Name = "flw_graphics_view";
            this.flw_graphics_view.Size = new System.Drawing.Size(946, 267);
            this.flw_graphics_view.TabIndex = 0;
            // 
            // toolbar_graphics
            // 
            this.toolbar_graphics.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar_graphics.Location = new System.Drawing.Point(6, 19);
            this.toolbar_graphics.Name = "toolbar_graphics";
            this.toolbar_graphics.onToolCommandTriggered = null;
            this.toolbar_graphics.onToolSwitched = null;
            this.toolbar_graphics.SelectedTool = LAMP.Controls.Room.LampTool.Pen;
            this.toolbar_graphics.Size = new System.Drawing.Size(946, 28);
            this.toolbar_graphics.TabIndex = 1;
            // 
            // grp_metatiles
            // 
            this.grp_metatiles.Controls.Add(this.flw_metatile_view);
            this.grp_metatiles.Controls.Add(this.toolbar_metatiles);
            this.grp_metatiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_metatiles.Location = new System.Drawing.Point(3, 3);
            this.grp_metatiles.Name = "grp_metatiles";
            this.grp_metatiles.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.grp_metatiles.Size = new System.Drawing.Size(958, 365);
            this.grp_metatiles.TabIndex = 6;
            this.grp_metatiles.TabStop = false;
            this.grp_metatiles.Text = "Graphics";
            // 
            // flw_metatile_view
            // 
            this.flw_metatile_view.AutoScroll = true;
            this.flw_metatile_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flw_metatile_view.Location = new System.Drawing.Point(6, 47);
            this.flw_metatile_view.Name = "flw_metatile_view";
            this.flw_metatile_view.Size = new System.Drawing.Size(946, 312);
            this.flw_metatile_view.TabIndex = 0;
            // 
            // toolbar_metatiles
            // 
            this.toolbar_metatiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar_metatiles.Location = new System.Drawing.Point(6, 19);
            this.toolbar_metatiles.Name = "toolbar_metatiles";
            this.toolbar_metatiles.onToolCommandTriggered = null;
            this.toolbar_metatiles.onToolSwitched = null;
            this.toolbar_metatiles.SelectedTool = LAMP.Controls.Room.LampTool.Pen;
            this.toolbar_metatiles.Size = new System.Drawing.Size(946, 28);
            this.toolbar_metatiles.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grp_data_selector);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(9, 6, 3, 6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1153, 707);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grp_graphics);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(3, 6, 9, 3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grp_metatiles);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(3, 3, 9, 6);
            this.splitContainer2.Size = new System.Drawing.Size(970, 707);
            this.splitContainer2.SplitterDistance = 329;
            this.splitContainer2.TabIndex = 0;
            // 
            // GraphicsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 729);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.status_strip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GraphicsEditor";
            this.Text = "Graphics Editor";
            this.grp_data_selector.ResumeLayout(false);
            this.grp_data_selector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_height)).EndInit();
            this.grp_graphics.ResumeLayout(false);
            this.grp_metatiles.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}