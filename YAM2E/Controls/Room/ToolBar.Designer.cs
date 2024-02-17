namespace LAMP.Controls.Room
{
    partial class ToolBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBar));
            btn_pen = new System.Windows.Forms.Button();
            btn_select = new System.Windows.Forms.Button();
            btn_fill = new System.Windows.Forms.Button();
            btn_flip_hor = new System.Windows.Forms.Button();
            btn_flip_vert = new System.Windows.Forms.Button();
            btn_copy = new System.Windows.Forms.Button();
            btn_paste = new System.Windows.Forms.Button();
            btn_rotate_right = new System.Windows.Forms.Button();
            btn_rotate_left = new System.Windows.Forms.Button();
            flw_controls = new System.Windows.Forms.FlowLayoutPanel();
            btn_move = new System.Windows.Forms.Button();
            sep_copy = new Other.SeperatorVertical();
            sep_transform = new Other.SeperatorVertical();
            sep_zoom = new Other.SeperatorVertical();
            btn_zoom_in = new System.Windows.Forms.Button();
            btn_zoom_out = new System.Windows.Forms.Button();
            sep_undo_redo = new Other.SeperatorVertical();
            btn_undo = new System.Windows.Forms.Button();
            btn_redo = new System.Windows.Forms.Button();
            tlt_button_name = new System.Windows.Forms.ToolTip(components);
            flw_controls.SuspendLayout();
            SuspendLayout();
            // 
            // btn_pen
            // 
            btn_pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_pen.Image = Properties.Resources.PenOne;
            btn_pen.Location = new System.Drawing.Point(24, 0);
            btn_pen.Margin = new System.Windows.Forms.Padding(0);
            btn_pen.Name = "btn_pen";
            btn_pen.Size = new System.Drawing.Size(24, 24);
            btn_pen.TabIndex = 0;
            tlt_button_name.SetToolTip(btn_pen, "Pen");
            btn_pen.UseVisualStyleBackColor = true;
            btn_pen.Click += btn_pen_Click;
            // 
            // btn_select
            // 
            btn_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_select.Image = Properties.Resources.SelectXY;
            btn_select.Location = new System.Drawing.Point(48, 0);
            btn_select.Margin = new System.Windows.Forms.Padding(0);
            btn_select.Name = "btn_select";
            btn_select.Size = new System.Drawing.Size(24, 24);
            btn_select.TabIndex = 1;
            tlt_button_name.SetToolTip(btn_select, "Select");
            btn_select.UseVisualStyleBackColor = true;
            btn_select.Click += btn_select_Click;
            // 
            // btn_fill
            // 
            btn_fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_fill.Image = Properties.Resources.Fill;
            btn_fill.Location = new System.Drawing.Point(72, 0);
            btn_fill.Margin = new System.Windows.Forms.Padding(0);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new System.Drawing.Size(24, 24);
            btn_fill.TabIndex = 2;
            tlt_button_name.SetToolTip(btn_fill, "Fill");
            btn_fill.UseVisualStyleBackColor = true;
            btn_fill.Click += btn_fill_Click;
            // 
            // btn_flip_hor
            // 
            btn_flip_hor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_flip_hor.Image = (System.Drawing.Image)resources.GetObject("btn_flip_hor.Image");
            btn_flip_hor.Location = new System.Drawing.Point(158, 0);
            btn_flip_hor.Margin = new System.Windows.Forms.Padding(0);
            btn_flip_hor.Name = "btn_flip_hor";
            btn_flip_hor.Size = new System.Drawing.Size(24, 24);
            btn_flip_hor.TabIndex = 3;
            tlt_button_name.SetToolTip(btn_flip_hor, "Flip Horizontally");
            btn_flip_hor.UseVisualStyleBackColor = true;
            btn_flip_hor.Click += btn_flip_hor_Click;
            // 
            // btn_flip_vert
            // 
            btn_flip_vert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_flip_vert.Image = (System.Drawing.Image)resources.GetObject("btn_flip_vert.Image");
            btn_flip_vert.Location = new System.Drawing.Point(182, 0);
            btn_flip_vert.Margin = new System.Windows.Forms.Padding(0);
            btn_flip_vert.Name = "btn_flip_vert";
            btn_flip_vert.Size = new System.Drawing.Size(24, 24);
            btn_flip_vert.TabIndex = 4;
            tlt_button_name.SetToolTip(btn_flip_vert, "Flip Vertically");
            btn_flip_vert.UseVisualStyleBackColor = true;
            btn_flip_vert.Click += btn_flip_vert_Click;
            // 
            // btn_copy
            // 
            btn_copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_copy.Image = (System.Drawing.Image)resources.GetObject("btn_copy.Image");
            btn_copy.Location = new System.Drawing.Point(103, 0);
            btn_copy.Margin = new System.Windows.Forms.Padding(0);
            btn_copy.Name = "btn_copy";
            btn_copy.Size = new System.Drawing.Size(24, 24);
            btn_copy.TabIndex = 5;
            tlt_button_name.SetToolTip(btn_copy, "Copy (Ctrl + C)");
            btn_copy.UseVisualStyleBackColor = true;
            btn_copy.Click += btn_copy_Click;
            // 
            // btn_paste
            // 
            btn_paste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_paste.Image = (System.Drawing.Image)resources.GetObject("btn_paste.Image");
            btn_paste.Location = new System.Drawing.Point(127, 0);
            btn_paste.Margin = new System.Windows.Forms.Padding(0);
            btn_paste.Name = "btn_paste";
            btn_paste.Size = new System.Drawing.Size(24, 24);
            btn_paste.TabIndex = 6;
            tlt_button_name.SetToolTip(btn_paste, "Paste (Ctrl + V)");
            btn_paste.UseVisualStyleBackColor = true;
            btn_paste.Click += btn_paste_Click;
            // 
            // btn_rotate_right
            // 
            btn_rotate_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_rotate_right.Image = (System.Drawing.Image)resources.GetObject("btn_rotate_right.Image");
            btn_rotate_right.Location = new System.Drawing.Point(206, 0);
            btn_rotate_right.Margin = new System.Windows.Forms.Padding(0);
            btn_rotate_right.Name = "btn_rotate_right";
            btn_rotate_right.Size = new System.Drawing.Size(24, 24);
            btn_rotate_right.TabIndex = 7;
            tlt_button_name.SetToolTip(btn_rotate_right, "Rotate 90° Right");
            btn_rotate_right.UseVisualStyleBackColor = true;
            btn_rotate_right.Click += btn_rotate_right_Click;
            // 
            // btn_rotate_left
            // 
            btn_rotate_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_rotate_left.Image = (System.Drawing.Image)resources.GetObject("btn_rotate_left.Image");
            btn_rotate_left.Location = new System.Drawing.Point(230, 0);
            btn_rotate_left.Margin = new System.Windows.Forms.Padding(0);
            btn_rotate_left.Name = "btn_rotate_left";
            btn_rotate_left.Size = new System.Drawing.Size(24, 24);
            btn_rotate_left.TabIndex = 8;
            tlt_button_name.SetToolTip(btn_rotate_left, "Rotate 90° Left");
            btn_rotate_left.UseVisualStyleBackColor = true;
            btn_rotate_left.Click += btn_rotate_left_Click;
            // 
            // flw_controls
            // 
            flw_controls.AutoSize = true;
            flw_controls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flw_controls.Controls.Add(btn_move);
            flw_controls.Controls.Add(btn_pen);
            flw_controls.Controls.Add(btn_select);
            flw_controls.Controls.Add(btn_fill);
            flw_controls.Controls.Add(sep_copy);
            flw_controls.Controls.Add(btn_copy);
            flw_controls.Controls.Add(btn_paste);
            flw_controls.Controls.Add(sep_transform);
            flw_controls.Controls.Add(btn_flip_hor);
            flw_controls.Controls.Add(btn_flip_vert);
            flw_controls.Controls.Add(btn_rotate_right);
            flw_controls.Controls.Add(btn_rotate_left);
            flw_controls.Controls.Add(sep_zoom);
            flw_controls.Controls.Add(btn_zoom_in);
            flw_controls.Controls.Add(btn_zoom_out);
            flw_controls.Controls.Add(sep_undo_redo);
            flw_controls.Controls.Add(btn_undo);
            flw_controls.Controls.Add(btn_redo);
            flw_controls.Location = new System.Drawing.Point(0, 0);
            flw_controls.Margin = new System.Windows.Forms.Padding(0);
            flw_controls.Name = "flw_controls";
            flw_controls.Size = new System.Drawing.Size(364, 24);
            flw_controls.TabIndex = 9;
            // 
            // btn_move
            // 
            btn_move.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_move.Image = Properties.Resources.Cursor;
            btn_move.Location = new System.Drawing.Point(0, 0);
            btn_move.Margin = new System.Windows.Forms.Padding(0);
            btn_move.Name = "btn_move";
            btn_move.Size = new System.Drawing.Size(24, 24);
            btn_move.TabIndex = 14;
            tlt_button_name.SetToolTip(btn_move, "Cursor");
            btn_move.UseVisualStyleBackColor = true;
            btn_move.Click += btn_move_Click;
            // 
            // sep_copy
            // 
            sep_copy.BackColor = System.Drawing.SystemColors.ControlDark;
            sep_copy.Location = new System.Drawing.Point(99, 2);
            sep_copy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            sep_copy.Name = "sep_copy";
            sep_copy.Size = new System.Drawing.Size(1, 20);
            sep_copy.TabIndex = 9;
            // 
            // sep_transform
            // 
            sep_transform.BackColor = System.Drawing.SystemColors.ControlDark;
            sep_transform.Location = new System.Drawing.Point(154, 2);
            sep_transform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            sep_transform.Name = "sep_transform";
            sep_transform.Size = new System.Drawing.Size(1, 21);
            sep_transform.TabIndex = 10;
            // 
            // sep_zoom
            // 
            sep_zoom.BackColor = System.Drawing.SystemColors.ControlDark;
            sep_zoom.Location = new System.Drawing.Point(257, 2);
            sep_zoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            sep_zoom.Name = "sep_zoom";
            sep_zoom.Size = new System.Drawing.Size(1, 20);
            sep_zoom.TabIndex = 11;
            // 
            // btn_zoom_in
            // 
            btn_zoom_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_zoom_in.Image = (System.Drawing.Image)resources.GetObject("btn_zoom_in.Image");
            btn_zoom_in.Location = new System.Drawing.Point(261, 0);
            btn_zoom_in.Margin = new System.Windows.Forms.Padding(0);
            btn_zoom_in.Name = "btn_zoom_in";
            btn_zoom_in.Size = new System.Drawing.Size(24, 24);
            btn_zoom_in.TabIndex = 12;
            tlt_button_name.SetToolTip(btn_zoom_in, "Zoom In");
            btn_zoom_in.UseVisualStyleBackColor = true;
            btn_zoom_in.Click += btn_zoom_in_Click;
            // 
            // btn_zoom_out
            // 
            btn_zoom_out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_zoom_out.Image = (System.Drawing.Image)resources.GetObject("btn_zoom_out.Image");
            btn_zoom_out.Location = new System.Drawing.Point(285, 0);
            btn_zoom_out.Margin = new System.Windows.Forms.Padding(0);
            btn_zoom_out.Name = "btn_zoom_out";
            btn_zoom_out.Size = new System.Drawing.Size(24, 24);
            btn_zoom_out.TabIndex = 13;
            tlt_button_name.SetToolTip(btn_zoom_out, "Zoom Out");
            btn_zoom_out.UseVisualStyleBackColor = true;
            btn_zoom_out.Click += btn_zoom_out_Click;
            // 
            // sep_undo_redo
            // 
            sep_undo_redo.BackColor = System.Drawing.SystemColors.ControlDark;
            sep_undo_redo.Location = new System.Drawing.Point(312, 2);
            sep_undo_redo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            sep_undo_redo.Name = "sep_undo_redo";
            sep_undo_redo.Size = new System.Drawing.Size(1, 20);
            sep_undo_redo.TabIndex = 12;
            sep_undo_redo.Visible = false;
            // 
            // btn_undo
            // 
            btn_undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_undo.Enabled = false;
            btn_undo.Image = Properties.Resources.Undo;
            btn_undo.Location = new System.Drawing.Point(316, 0);
            btn_undo.Margin = new System.Windows.Forms.Padding(0);
            btn_undo.Name = "btn_undo";
            btn_undo.Size = new System.Drawing.Size(24, 24);
            btn_undo.TabIndex = 15;
            tlt_button_name.SetToolTip(btn_undo, "Undo");
            btn_undo.UseVisualStyleBackColor = true;
            btn_undo.Visible = false;
            btn_undo.Click += btn_undo_Click;
            // 
            // btn_redo
            // 
            btn_redo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_redo.Enabled = false;
            btn_redo.Image = Properties.Resources.Redo;
            btn_redo.Location = new System.Drawing.Point(340, 0);
            btn_redo.Margin = new System.Windows.Forms.Padding(0);
            btn_redo.Name = "btn_redo";
            btn_redo.Size = new System.Drawing.Size(24, 24);
            btn_redo.TabIndex = 16;
            tlt_button_name.SetToolTip(btn_redo, "Redo");
            btn_redo.UseVisualStyleBackColor = true;
            btn_redo.Visible = false;
            btn_redo.Click += btn_redo_Click;
            // 
            // tlt_button_name
            // 
            tlt_button_name.AutomaticDelay = 1000;
            tlt_button_name.BackColor = System.Drawing.SystemColors.Control;
            // 
            // ToolBar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(flw_controls);
            Name = "ToolBar";
            Size = new System.Drawing.Size(368, 24);
            flw_controls.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_pen;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_flip_hor;
        private System.Windows.Forms.Button btn_flip_vert;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_paste;
        private System.Windows.Forms.Button btn_rotate_right;
        private System.Windows.Forms.Button btn_rotate_left;
        private System.Windows.Forms.FlowLayoutPanel flw_controls;
        private Other.SeperatorVertical sep_copy;
        private Other.SeperatorVertical sep_transform;
        private Other.SeperatorVertical sep_zoom;
        private System.Windows.Forms.Button btn_zoom_in;
        private System.Windows.Forms.Button btn_zoom_out;
        private System.Windows.Forms.ToolTip tlt_button_name;
        private System.Windows.Forms.Button btn_move;
        private Other.SeperatorVertical sep_undo_redo;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.Button btn_redo;
    }
}
