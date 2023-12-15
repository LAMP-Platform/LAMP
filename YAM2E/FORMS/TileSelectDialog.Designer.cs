namespace LAMP.FORMS
{
    partial class TileSelectDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TileSelectDialog));
            tool_bar = new Controls.Room.ToolBar();
            btn_cancel = new System.Windows.Forms.Button();
            btn_replace = new System.Windows.Forms.Button();
            grp_main = new System.Windows.Forms.GroupBox();
            pnl_tile_view = new System.Windows.Forms.Panel();
            tile_viewer = new Controls.TileViewer();
            pnl_buttons = new System.Windows.Forms.Panel();
            grp_main.SuspendLayout();
            pnl_tile_view.SuspendLayout();
            pnl_buttons.SuspendLayout();
            SuspendLayout();
            // 
            // tool_bar
            // 
            tool_bar.Dock = System.Windows.Forms.DockStyle.Top;
            tool_bar.Location = new System.Drawing.Point(3, 19);
            tool_bar.MaxZoom = 10;
            tool_bar.Name = "tool_bar";
            tool_bar.onToolCommandTriggered = null;
            tool_bar.onToolSwitched = null;
            tool_bar.SelectedTool = LampTool.Select;
            tool_bar.Size = new System.Drawing.Size(262, 24);
            tool_bar.TabIndex = 1;
            tool_bar.ZoomLevel = 1;
            tool_bar.ToolCommandTriggered += tool_bar_ToolCommandTriggered;
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_cancel.Location = new System.Drawing.Point(103, 5);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new System.Drawing.Size(75, 23);
            btn_cancel.TabIndex = 2;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_replace
            // 
            btn_replace.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_replace.DialogResult = System.Windows.Forms.DialogResult.OK;
            btn_replace.Enabled = false;
            btn_replace.Location = new System.Drawing.Point(184, 5);
            btn_replace.Name = "btn_replace";
            btn_replace.Size = new System.Drawing.Size(75, 23);
            btn_replace.TabIndex = 3;
            btn_replace.Text = "Replace";
            btn_replace.UseVisualStyleBackColor = true;
            btn_replace.Click += btn_replace_Click;
            // 
            // grp_main
            // 
            grp_main.Controls.Add(pnl_tile_view);
            grp_main.Controls.Add(tool_bar);
            grp_main.Controls.Add(pnl_buttons);
            grp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_main.Location = new System.Drawing.Point(6, 6);
            grp_main.Name = "grp_main";
            grp_main.Size = new System.Drawing.Size(268, 211);
            grp_main.TabIndex = 4;
            grp_main.TabStop = false;
            grp_main.Text = "Tileset";
            // 
            // pnl_tile_view
            // 
            pnl_tile_view.AutoScroll = true;
            pnl_tile_view.Controls.Add(tile_viewer);
            pnl_tile_view.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_tile_view.Location = new System.Drawing.Point(3, 43);
            pnl_tile_view.Name = "pnl_tile_view";
            pnl_tile_view.Size = new System.Drawing.Size(262, 134);
            pnl_tile_view.TabIndex = 4;
            // 
            // tile_viewer
            // 
            tile_viewer.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            tile_viewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tile_viewer.Location = new System.Drawing.Point(3, 3);
            tile_viewer.Name = "tile_viewer";
            tile_viewer.PixelTileSize = 16;
            tile_viewer.RedRect = new System.Drawing.Rectangle(-1, -1, 0, 0);
            tile_viewer.SelectedTool = LampTool.Select;
            tile_viewer.SelRect = new System.Drawing.Rectangle(-1, -1, 0, 0);
            tile_viewer.Size = new System.Drawing.Size(199, 76);
            tile_viewer.TabIndex = 1;
            tile_viewer.Text = "Tile Viewer";
            tile_viewer.Zoom = 1;
            tile_viewer.MouseDown += tile_viewer_MouseDown;
            tile_viewer.MouseMove += tile_viewer_MouseMove;
            // 
            // pnl_buttons
            // 
            pnl_buttons.Controls.Add(btn_cancel);
            pnl_buttons.Controls.Add(btn_replace);
            pnl_buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_buttons.Location = new System.Drawing.Point(3, 177);
            pnl_buttons.Name = "pnl_buttons";
            pnl_buttons.Size = new System.Drawing.Size(262, 31);
            pnl_buttons.TabIndex = 5;
            // 
            // TileSelectDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(280, 223);
            Controls.Add(grp_main);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(296, 262);
            Name = "TileSelectDialog";
            Padding = new System.Windows.Forms.Padding(6);
            Text = "Select Tile";
            grp_main.ResumeLayout(false);
            pnl_tile_view.ResumeLayout(false);
            pnl_buttons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Controls.Room.ToolBar tool_bar;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.GroupBox grp_main;
        private System.Windows.Forms.Panel pnl_tile_view;
        private System.Windows.Forms.Panel pnl_buttons;
        private Controls.TileViewer tile_viewer;
    }
}