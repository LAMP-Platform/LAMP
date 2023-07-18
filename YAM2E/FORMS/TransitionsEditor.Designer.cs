
namespace LAMP.FORMS
{
    partial class TransitionsEditor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransitionsEditor));
            grp_tred_selection = new System.Windows.Forms.GroupBox();
            txb_transition_name = new System.Windows.Forms.TextBox();
            lbl_transition_name = new System.Windows.Forms.Label();
            lbl_tred_transition_selection = new System.Windows.Forms.Label();
            cbb_tred_transition_selection = new System.Windows.Forms.ComboBox();
            sts_tred_status_strip = new System.Windows.Forms.StatusStrip();
            lbl_tred_transition_length = new System.Windows.Forms.ToolStripStatusLabel();
            status_spring = new System.Windows.Forms.ToolStripStatusLabel();
            btn_remove_all = new System.Windows.Forms.ToolStripSplitButton();
            tlt_tred_warning = new System.Windows.Forms.ToolTip(components);
            txb_transition_info = new System.Windows.Forms.TextBox();
            btn_seperate_transition = new System.Windows.Forms.Button();
            gau_transition_length = new Controls.Other.Gauge();
            grpTransition = new System.Windows.Forms.GroupBox();
            pnlTransition = new System.Windows.Forms.Panel();
            pnl_warning = new System.Windows.Forms.Panel();
            txb_warning_header = new System.Windows.Forms.TextBox();
            pnl_seperate_button_dock = new System.Windows.Forms.Panel();
            splt_main = new System.Windows.Forms.SplitContainer();
            grp_opcodes = new System.Windows.Forms.GroupBox();
            pnl_opcodes = new System.Windows.Forms.Panel();
            grp_tilesets = new System.Windows.Forms.GroupBox();
            btn_add_tileset = new System.Windows.Forms.Button();
            cbb_tileset_select = new System.Windows.Forms.ComboBox();
            pnl_gauge = new System.Windows.Forms.Panel();
            grp_tred_selection.SuspendLayout();
            sts_tred_status_strip.SuspendLayout();
            grpTransition.SuspendLayout();
            pnl_warning.SuspendLayout();
            pnl_seperate_button_dock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splt_main).BeginInit();
            splt_main.Panel1.SuspendLayout();
            splt_main.Panel2.SuspendLayout();
            splt_main.SuspendLayout();
            grp_opcodes.SuspendLayout();
            grp_tilesets.SuspendLayout();
            pnl_gauge.SuspendLayout();
            SuspendLayout();
            // 
            // grp_tred_selection
            // 
            grp_tred_selection.Controls.Add(txb_transition_name);
            grp_tred_selection.Controls.Add(lbl_transition_name);
            grp_tred_selection.Controls.Add(lbl_tred_transition_selection);
            grp_tred_selection.Controls.Add(cbb_tred_transition_selection);
            grp_tred_selection.Dock = System.Windows.Forms.DockStyle.Top;
            grp_tred_selection.Location = new System.Drawing.Point(9, 3);
            grp_tred_selection.Name = "grp_tred_selection";
            grp_tred_selection.Size = new System.Drawing.Size(262, 89);
            grp_tred_selection.TabIndex = 0;
            grp_tred_selection.TabStop = false;
            grp_tred_selection.Text = "Selection";
            // 
            // txb_transition_name
            // 
            txb_transition_name.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txb_transition_name.Location = new System.Drawing.Point(73, 50);
            txb_transition_name.Name = "txb_transition_name";
            txb_transition_name.Size = new System.Drawing.Size(183, 23);
            txb_transition_name.TabIndex = 4;
            txb_transition_name.TextChanged += txb_transition_name_TextChanged;
            // 
            // lbl_transition_name
            // 
            lbl_transition_name.AutoSize = true;
            lbl_transition_name.Location = new System.Drawing.Point(7, 53);
            lbl_transition_name.Name = "lbl_transition_name";
            lbl_transition_name.Size = new System.Drawing.Size(42, 15);
            lbl_transition_name.TabIndex = 3;
            lbl_transition_name.Text = "Name:";
            // 
            // lbl_tred_transition_selection
            // 
            lbl_tred_transition_selection.AutoSize = true;
            lbl_tred_transition_selection.Location = new System.Drawing.Point(6, 25);
            lbl_tred_transition_selection.Name = "lbl_tred_transition_selection";
            lbl_tred_transition_selection.Size = new System.Drawing.Size(61, 15);
            lbl_tred_transition_selection.TabIndex = 1;
            lbl_tred_transition_selection.Text = "Transition:";
            // 
            // cbb_tred_transition_selection
            // 
            cbb_tred_transition_selection.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbb_tred_transition_selection.DropDownWidth = 74;
            cbb_tred_transition_selection.FormattingEnabled = true;
            cbb_tred_transition_selection.Location = new System.Drawing.Point(73, 22);
            cbb_tred_transition_selection.Name = "cbb_tred_transition_selection";
            cbb_tred_transition_selection.Size = new System.Drawing.Size(183, 23);
            cbb_tred_transition_selection.TabIndex = 0;
            cbb_tred_transition_selection.SelectedIndexChanged += cbb_tred_transition_selection_SelectedIndexChanged;
            // 
            // sts_tred_status_strip
            // 
            sts_tred_status_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lbl_tred_transition_length, status_spring, btn_remove_all });
            sts_tred_status_strip.Location = new System.Drawing.Point(0, 584);
            sts_tred_status_strip.Name = "sts_tred_status_strip";
            sts_tred_status_strip.Size = new System.Drawing.Size(569, 22);
            sts_tred_status_strip.TabIndex = 3;
            sts_tred_status_strip.Text = "statusStrip1";
            // 
            // lbl_tred_transition_length
            // 
            lbl_tred_transition_length.Name = "lbl_tred_transition_length";
            lbl_tred_transition_length.Size = new System.Drawing.Size(104, 17);
            lbl_tred_transition_length.Text = "Transition Length: ";
            // 
            // status_spring
            // 
            status_spring.Name = "status_spring";
            status_spring.Size = new System.Drawing.Size(362, 17);
            status_spring.Spring = true;
            // 
            // btn_remove_all
            // 
            btn_remove_all.DropDownButtonWidth = 0;
            btn_remove_all.Image = Properties.Resources.Remove;
            btn_remove_all.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_remove_all.Name = "btn_remove_all";
            btn_remove_all.Size = new System.Drawing.Size(88, 20);
            btn_remove_all.Text = "Remove All";
            btn_remove_all.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            btn_remove_all.ToolTipText = "Remove all opcodes at once";
            btn_remove_all.ButtonClick += btn_remove_all_ButtonClick;
            // 
            // tlt_tred_warning
            // 
            tlt_tred_warning.AutoPopDelay = 0;
            tlt_tred_warning.InitialDelay = 0;
            tlt_tred_warning.ReshowDelay = 100;
            tlt_tred_warning.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            tlt_tred_warning.ToolTipTitle = "Warning";
            // 
            // txb_transition_info
            // 
            txb_transition_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txb_transition_info.Dock = System.Windows.Forms.DockStyle.Fill;
            txb_transition_info.Location = new System.Drawing.Point(3, 29);
            txb_transition_info.Multiline = true;
            txb_transition_info.Name = "txb_transition_info";
            txb_transition_info.ReadOnly = true;
            txb_transition_info.Size = new System.Drawing.Size(256, 55);
            txb_transition_info.TabIndex = 4;
            txb_transition_info.TabStop = false;
            txb_transition_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_seperate_transition
            // 
            btn_seperate_transition.Dock = System.Windows.Forms.DockStyle.Fill;
            btn_seperate_transition.Location = new System.Drawing.Point(40, 0);
            btn_seperate_transition.Name = "btn_seperate_transition";
            btn_seperate_transition.Size = new System.Drawing.Size(176, 27);
            btn_seperate_transition.TabIndex = 5;
            btn_seperate_transition.Text = "Seperate Transitions";
            btn_seperate_transition.UseVisualStyleBackColor = true;
            btn_seperate_transition.Click += btn_seperate_transition_Click;
            // 
            // gau_transition_length
            // 
            gau_transition_length.BackColor = System.Drawing.Color.FromArgb(188, 188, 188);
            gau_transition_length.Color = System.Drawing.Color.FromArgb(0, 192, 192);
            gau_transition_length.Dock = System.Windows.Forms.DockStyle.Fill;
            gau_transition_length.Location = new System.Drawing.Point(9, 3);
            gau_transition_length.Name = "gau_transition_length";
            gau_transition_length.Size = new System.Drawing.Size(551, 9);
            gau_transition_length.TabIndex = 7;
            gau_transition_length.Value = 0D;
            // 
            // grpTransition
            // 
            grpTransition.BackColor = System.Drawing.SystemColors.Control;
            grpTransition.Controls.Add(pnlTransition);
            grpTransition.Dock = System.Windows.Forms.DockStyle.Fill;
            grpTransition.Location = new System.Drawing.Point(3, 3);
            grpTransition.Name = "grpTransition";
            grpTransition.Size = new System.Drawing.Size(279, 563);
            grpTransition.TabIndex = 8;
            grpTransition.TabStop = false;
            grpTransition.Text = "Transition";
            // 
            // pnlTransition
            // 
            pnlTransition.AutoScroll = true;
            pnlTransition.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlTransition.Location = new System.Drawing.Point(3, 19);
            pnlTransition.Name = "pnlTransition";
            pnlTransition.Padding = new System.Windows.Forms.Padding(6, 3, 6, 0);
            pnlTransition.Size = new System.Drawing.Size(273, 541);
            pnlTransition.TabIndex = 0;
            // 
            // pnl_warning
            // 
            pnl_warning.Controls.Add(txb_transition_info);
            pnl_warning.Controls.Add(txb_warning_header);
            pnl_warning.Controls.Add(pnl_seperate_button_dock);
            pnl_warning.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_warning.Location = new System.Drawing.Point(9, 452);
            pnl_warning.Name = "pnl_warning";
            pnl_warning.Padding = new System.Windows.Forms.Padding(3);
            pnl_warning.Size = new System.Drawing.Size(262, 114);
            pnl_warning.TabIndex = 7;
            // 
            // txb_warning_header
            // 
            txb_warning_header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txb_warning_header.Dock = System.Windows.Forms.DockStyle.Top;
            txb_warning_header.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            txb_warning_header.ForeColor = System.Drawing.Color.Red;
            txb_warning_header.Location = new System.Drawing.Point(3, 3);
            txb_warning_header.Multiline = true;
            txb_warning_header.Name = "txb_warning_header";
            txb_warning_header.ReadOnly = true;
            txb_warning_header.Size = new System.Drawing.Size(256, 26);
            txb_warning_header.TabIndex = 5;
            txb_warning_header.TabStop = false;
            txb_warning_header.Text = "WARNING";
            txb_warning_header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_seperate_button_dock
            // 
            pnl_seperate_button_dock.Controls.Add(btn_seperate_transition);
            pnl_seperate_button_dock.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_seperate_button_dock.Location = new System.Drawing.Point(3, 84);
            pnl_seperate_button_dock.Name = "pnl_seperate_button_dock";
            pnl_seperate_button_dock.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            pnl_seperate_button_dock.Size = new System.Drawing.Size(256, 27);
            pnl_seperate_button_dock.TabIndex = 8;
            // 
            // splt_main
            // 
            splt_main.Dock = System.Windows.Forms.DockStyle.Fill;
            splt_main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splt_main.Location = new System.Drawing.Point(0, 0);
            splt_main.Name = "splt_main";
            // 
            // splt_main.Panel1
            // 
            splt_main.Panel1.Controls.Add(grp_opcodes);
            splt_main.Panel1.Controls.Add(grp_tred_selection);
            splt_main.Panel1.Controls.Add(grp_tilesets);
            splt_main.Panel1.Controls.Add(pnl_warning);
            splt_main.Panel1.Padding = new System.Windows.Forms.Padding(9, 3, 3, 3);
            // 
            // splt_main.Panel2
            // 
            splt_main.Panel2.Controls.Add(grpTransition);
            splt_main.Panel2.Padding = new System.Windows.Forms.Padding(3, 3, 9, 3);
            splt_main.Size = new System.Drawing.Size(569, 569);
            splt_main.SplitterDistance = 274;
            splt_main.TabIndex = 9;
            // 
            // grp_opcodes
            // 
            grp_opcodes.Controls.Add(pnl_opcodes);
            grp_opcodes.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_opcodes.Location = new System.Drawing.Point(9, 92);
            grp_opcodes.Name = "grp_opcodes";
            grp_opcodes.Size = new System.Drawing.Size(262, 303);
            grp_opcodes.TabIndex = 8;
            grp_opcodes.TabStop = false;
            grp_opcodes.Text = "Opcodes";
            // 
            // pnl_opcodes
            // 
            pnl_opcodes.AutoScroll = true;
            pnl_opcodes.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_opcodes.Location = new System.Drawing.Point(3, 19);
            pnl_opcodes.Name = "pnl_opcodes";
            pnl_opcodes.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            pnl_opcodes.Size = new System.Drawing.Size(256, 281);
            pnl_opcodes.TabIndex = 0;
            // 
            // grp_tilesets
            // 
            grp_tilesets.Controls.Add(btn_add_tileset);
            grp_tilesets.Controls.Add(cbb_tileset_select);
            grp_tilesets.Dock = System.Windows.Forms.DockStyle.Bottom;
            grp_tilesets.Location = new System.Drawing.Point(9, 395);
            grp_tilesets.Name = "grp_tilesets";
            grp_tilesets.Size = new System.Drawing.Size(262, 57);
            grp_tilesets.TabIndex = 9;
            grp_tilesets.TabStop = false;
            grp_tilesets.Text = "Tileset";
            grp_tilesets.Visible = false;
            // 
            // btn_add_tileset
            // 
            btn_add_tileset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_add_tileset.Image = Properties.Resources.Add;
            btn_add_tileset.Location = new System.Drawing.Point(233, 22);
            btn_add_tileset.Name = "btn_add_tileset";
            btn_add_tileset.Size = new System.Drawing.Size(23, 23);
            btn_add_tileset.TabIndex = 1;
            btn_add_tileset.UseVisualStyleBackColor = true;
            btn_add_tileset.Click += btn_add_tileset_Click;
            // 
            // cbb_tileset_select
            // 
            cbb_tileset_select.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbb_tileset_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_tileset_select.FormattingEnabled = true;
            cbb_tileset_select.Location = new System.Drawing.Point(7, 22);
            cbb_tileset_select.Name = "cbb_tileset_select";
            cbb_tileset_select.Size = new System.Drawing.Size(220, 23);
            cbb_tileset_select.TabIndex = 0;
            // 
            // pnl_gauge
            // 
            pnl_gauge.Controls.Add(gau_transition_length);
            pnl_gauge.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_gauge.Location = new System.Drawing.Point(0, 569);
            pnl_gauge.Name = "pnl_gauge";
            pnl_gauge.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            pnl_gauge.Size = new System.Drawing.Size(569, 15);
            pnl_gauge.TabIndex = 8;
            // 
            // TransitionsEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(569, 606);
            Controls.Add(splt_main);
            Controls.Add(pnl_gauge);
            Controls.Add(sts_tred_status_strip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(585, 500);
            Name = "TransitionsEditor";
            Text = "Transition Editor";
            grp_tred_selection.ResumeLayout(false);
            grp_tred_selection.PerformLayout();
            sts_tred_status_strip.ResumeLayout(false);
            sts_tred_status_strip.PerformLayout();
            grpTransition.ResumeLayout(false);
            pnl_warning.ResumeLayout(false);
            pnl_warning.PerformLayout();
            pnl_seperate_button_dock.ResumeLayout(false);
            splt_main.Panel1.ResumeLayout(false);
            splt_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splt_main).EndInit();
            splt_main.ResumeLayout(false);
            grp_opcodes.ResumeLayout(false);
            grp_tilesets.ResumeLayout(false);
            pnl_gauge.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grp_tred_selection;
        private System.Windows.Forms.Label lbl_tred_transition_selection;
        private System.Windows.Forms.ComboBox cbb_tred_transition_selection;
        private System.Windows.Forms.StatusStrip sts_tred_status_strip;
        private System.Windows.Forms.ToolStripStatusLabel lbl_tred_transition_length;
        private System.Windows.Forms.ToolTip tlt_tred_warning;
        private System.Windows.Forms.TextBox txb_transition_info;
        private System.Windows.Forms.Button btn_seperate_transition;
        private Controls.Other.Gauge gau_transition_length;
        private System.Windows.Forms.GroupBox grpTransition;
        private System.Windows.Forms.TextBox txb_transition_name;
        private System.Windows.Forms.Label lbl_transition_name;
        private System.Windows.Forms.SplitContainer splt_main;
        private System.Windows.Forms.Panel pnl_gauge;
        private System.Windows.Forms.Panel pnlTransition;
        private System.Windows.Forms.Panel pnl_warning;
        private System.Windows.Forms.TextBox txb_warning_header;
        private System.Windows.Forms.Panel pnl_seperate_button_dock;
        private System.Windows.Forms.GroupBox grp_opcodes;
        private System.Windows.Forms.GroupBox grp_tilesets;
        private System.Windows.Forms.Button btn_add_tileset;
        private System.Windows.Forms.ComboBox cbb_tileset_select;
        private System.Windows.Forms.ToolStripStatusLabel status_spring;
        private System.Windows.Forms.ToolStripSplitButton btn_remove_all;
        private System.Windows.Forms.Panel pnl_opcodes;
    }
}