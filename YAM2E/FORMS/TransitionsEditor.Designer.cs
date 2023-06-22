
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
            chb_expand_all = new System.Windows.Forms.CheckBox();
            lbl_tred_transition_selection = new System.Windows.Forms.Label();
            cbb_tred_transition_selection = new System.Windows.Forms.ComboBox();
            grp_tred_transition = new System.Windows.Forms.GroupBox();
            tre_tred_transition_tree = new System.Windows.Forms.TreeView();
            grp_tred_edits = new System.Windows.Forms.GroupBox();
            cbb_tred_opcode_add = new System.Windows.Forms.ComboBox();
            btn_tred_move_opcode_up = new System.Windows.Forms.Button();
            btn_tred_move_opcode_down = new System.Windows.Forms.Button();
            lbl_tred_opcodes = new System.Windows.Forms.Label();
            btn_tred_add_opcode = new System.Windows.Forms.Button();
            btn_tred_remove_opcode = new System.Windows.Forms.Button();
            btn_tred_transition_update = new System.Windows.Forms.Button();
            num_tred_value = new System.Windows.Forms.NumericUpDown();
            lbl_tred_value = new System.Windows.Forms.Label();
            sts_tred_status_strip = new System.Windows.Forms.StatusStrip();
            lbl_tred_transition_length = new System.Windows.Forms.ToolStripStatusLabel();
            tlt_tred_warning = new System.Windows.Forms.ToolTip(components);
            txb_transition_info = new System.Windows.Forms.TextBox();
            btn_seperate_transition = new System.Windows.Forms.Button();
            grp_transition_warning = new System.Windows.Forms.GroupBox();
            gauTransitionLength = new Controls.Other.Gauge();
            grpTransition = new System.Windows.Forms.GroupBox();
            pnlTransition = new System.Windows.Forms.FlowLayoutPanel();
            grp_tred_selection.SuspendLayout();
            grp_tred_transition.SuspendLayout();
            grp_tred_edits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_tred_value).BeginInit();
            sts_tred_status_strip.SuspendLayout();
            grp_transition_warning.SuspendLayout();
            grpTransition.SuspendLayout();
            SuspendLayout();
            // 
            // grp_tred_selection
            // 
            grp_tred_selection.Controls.Add(txb_transition_name);
            grp_tred_selection.Controls.Add(lbl_transition_name);
            grp_tred_selection.Controls.Add(chb_expand_all);
            grp_tred_selection.Controls.Add(lbl_tred_transition_selection);
            grp_tred_selection.Controls.Add(cbb_tred_transition_selection);
            grp_tred_selection.Location = new System.Drawing.Point(13, 13);
            grp_tred_selection.Name = "grp_tred_selection";
            grp_tred_selection.Size = new System.Drawing.Size(153, 102);
            grp_tred_selection.TabIndex = 0;
            grp_tred_selection.TabStop = false;
            grp_tred_selection.Text = "Selection";
            // 
            // txb_transition_name
            // 
            txb_transition_name.Location = new System.Drawing.Point(73, 50);
            txb_transition_name.Name = "txb_transition_name";
            txb_transition_name.Size = new System.Drawing.Size(74, 23);
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
            // chb_expand_all
            // 
            chb_expand_all.AutoSize = true;
            chb_expand_all.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chb_expand_all.Location = new System.Drawing.Point(6, 79);
            chb_expand_all.Name = "chb_expand_all";
            chb_expand_all.Size = new System.Drawing.Size(82, 19);
            chb_expand_all.TabIndex = 2;
            chb_expand_all.Text = "Expand All";
            chb_expand_all.UseVisualStyleBackColor = true;
            chb_expand_all.CheckedChanged += chb_expand_all_CheckedChanged;
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
            cbb_tred_transition_selection.DropDownWidth = 74;
            cbb_tred_transition_selection.FormattingEnabled = true;
            cbb_tred_transition_selection.Location = new System.Drawing.Point(73, 22);
            cbb_tred_transition_selection.Name = "cbb_tred_transition_selection";
            cbb_tred_transition_selection.Size = new System.Drawing.Size(74, 23);
            cbb_tred_transition_selection.TabIndex = 0;
            cbb_tred_transition_selection.SelectedIndexChanged += cbb_tred_transition_selection_SelectedIndexChanged;
            // 
            // grp_tred_transition
            // 
            grp_tred_transition.Controls.Add(tre_tred_transition_tree);
            grp_tred_transition.Location = new System.Drawing.Point(172, 13);
            grp_tred_transition.Name = "grp_tred_transition";
            grp_tred_transition.Size = new System.Drawing.Size(320, 544);
            grp_tred_transition.TabIndex = 1;
            grp_tred_transition.TabStop = false;
            grp_tred_transition.Text = "Transition";
            // 
            // tre_tred_transition_tree
            // 
            tre_tred_transition_tree.Location = new System.Drawing.Point(7, 22);
            tre_tred_transition_tree.Name = "tre_tred_transition_tree";
            tre_tred_transition_tree.ShowPlusMinus = false;
            tre_tred_transition_tree.Size = new System.Drawing.Size(307, 516);
            tre_tred_transition_tree.TabIndex = 0;
            tre_tred_transition_tree.AfterSelect += tre_tred_transition_tree_AfterSelect;
            // 
            // grp_tred_edits
            // 
            grp_tred_edits.Controls.Add(cbb_tred_opcode_add);
            grp_tred_edits.Controls.Add(btn_tred_move_opcode_up);
            grp_tred_edits.Controls.Add(btn_tred_move_opcode_down);
            grp_tred_edits.Controls.Add(lbl_tred_opcodes);
            grp_tred_edits.Controls.Add(btn_tred_add_opcode);
            grp_tred_edits.Controls.Add(btn_tred_remove_opcode);
            grp_tred_edits.Controls.Add(btn_tred_transition_update);
            grp_tred_edits.Controls.Add(num_tred_value);
            grp_tred_edits.Controls.Add(lbl_tred_value);
            grp_tred_edits.Location = new System.Drawing.Point(13, 121);
            grp_tred_edits.Name = "grp_tred_edits";
            grp_tred_edits.Size = new System.Drawing.Size(153, 167);
            grp_tred_edits.TabIndex = 2;
            grp_tred_edits.TabStop = false;
            grp_tred_edits.Text = "Edit";
            // 
            // cbb_tred_opcode_add
            // 
            cbb_tred_opcode_add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_tred_opcode_add.DropDownWidth = 240;
            cbb_tred_opcode_add.FormattingEnabled = true;
            cbb_tred_opcode_add.Items.AddRange(new object[] { "Save the bank and offset of a BG tileset", "Save the offset of a sprite tileset", "Copy data", "Select metatile table", "Select collision table", "Select solidity indeces", "Warp", "Retreat from Queen", "Change acid & spike damage", "Exit from Queen", "Enter Queen", "Conditional Transition", "Fadeout", "Load background graphics", "Load sprite graphics", "Change music", "Change special graphics", "END TRANSITION" });
            cbb_tred_opcode_add.Location = new System.Drawing.Point(7, 108);
            cbb_tred_opcode_add.Name = "cbb_tred_opcode_add";
            cbb_tred_opcode_add.Size = new System.Drawing.Size(140, 23);
            cbb_tred_opcode_add.TabIndex = 10;
            // 
            // btn_tred_move_opcode_up
            // 
            btn_tred_move_opcode_up.Image = (System.Drawing.Image)resources.GetObject("btn_tred_move_opcode_up.Image");
            btn_tred_move_opcode_up.Location = new System.Drawing.Point(7, 137);
            btn_tred_move_opcode_up.Name = "btn_tred_move_opcode_up";
            btn_tred_move_opcode_up.Size = new System.Drawing.Size(27, 23);
            btn_tred_move_opcode_up.TabIndex = 9;
            btn_tred_move_opcode_up.UseVisualStyleBackColor = true;
            btn_tred_move_opcode_up.Click += btn_tred_move_opcode_up_Click;
            // 
            // btn_tred_move_opcode_down
            // 
            btn_tred_move_opcode_down.Image = (System.Drawing.Image)resources.GetObject("btn_tred_move_opcode_down.Image");
            btn_tred_move_opcode_down.Location = new System.Drawing.Point(40, 137);
            btn_tred_move_opcode_down.Name = "btn_tred_move_opcode_down";
            btn_tred_move_opcode_down.Size = new System.Drawing.Size(27, 23);
            btn_tred_move_opcode_down.TabIndex = 8;
            btn_tred_move_opcode_down.UseVisualStyleBackColor = true;
            btn_tred_move_opcode_down.Click += btn_tred_move_opcode_down_Click;
            // 
            // lbl_tred_opcodes
            // 
            lbl_tred_opcodes.AutoSize = true;
            lbl_tred_opcodes.Location = new System.Drawing.Point(6, 83);
            lbl_tred_opcodes.Name = "lbl_tred_opcodes";
            lbl_tred_opcodes.Size = new System.Drawing.Size(52, 15);
            lbl_tred_opcodes.TabIndex = 7;
            lbl_tred_opcodes.Text = "Opcode:";
            // 
            // btn_tred_add_opcode
            // 
            btn_tred_add_opcode.Image = (System.Drawing.Image)resources.GetObject("btn_tred_add_opcode.Image");
            btn_tred_add_opcode.Location = new System.Drawing.Point(73, 79);
            btn_tred_add_opcode.Name = "btn_tred_add_opcode";
            btn_tred_add_opcode.Size = new System.Drawing.Size(75, 23);
            btn_tred_add_opcode.TabIndex = 6;
            btn_tred_add_opcode.UseVisualStyleBackColor = true;
            btn_tred_add_opcode.Click += btn_tred_add_opcode_Click;
            // 
            // btn_tred_remove_opcode
            // 
            btn_tred_remove_opcode.Image = (System.Drawing.Image)resources.GetObject("btn_tred_remove_opcode.Image");
            btn_tred_remove_opcode.Location = new System.Drawing.Point(73, 137);
            btn_tred_remove_opcode.Name = "btn_tred_remove_opcode";
            btn_tred_remove_opcode.Size = new System.Drawing.Size(74, 23);
            btn_tred_remove_opcode.TabIndex = 5;
            btn_tred_remove_opcode.UseVisualStyleBackColor = true;
            btn_tred_remove_opcode.Click += btn_tred_remove_opcode_Click;
            // 
            // btn_tred_transition_update
            // 
            btn_tred_transition_update.Enabled = false;
            btn_tred_transition_update.Location = new System.Drawing.Point(73, 50);
            btn_tred_transition_update.Name = "btn_tred_transition_update";
            btn_tred_transition_update.Size = new System.Drawing.Size(74, 23);
            btn_tred_transition_update.TabIndex = 2;
            btn_tred_transition_update.Text = "Change";
            btn_tred_transition_update.UseVisualStyleBackColor = true;
            btn_tred_transition_update.Click += btn_tred_transition_update_Click;
            // 
            // num_tred_value
            // 
            num_tred_value.Enabled = false;
            num_tred_value.Hexadecimal = true;
            num_tred_value.Location = new System.Drawing.Point(73, 21);
            num_tred_value.Name = "num_tred_value";
            num_tred_value.Size = new System.Drawing.Size(74, 23);
            num_tred_value.TabIndex = 1;
            // 
            // lbl_tred_value
            // 
            lbl_tred_value.AutoSize = true;
            lbl_tred_value.Enabled = false;
            lbl_tred_value.Location = new System.Drawing.Point(7, 23);
            lbl_tred_value.Name = "lbl_tred_value";
            lbl_tred_value.Size = new System.Drawing.Size(38, 15);
            lbl_tred_value.TabIndex = 0;
            lbl_tred_value.Text = "Value:";
            // 
            // sts_tred_status_strip
            // 
            sts_tred_status_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lbl_tred_transition_length });
            sts_tred_status_strip.Location = new System.Drawing.Point(0, 582);
            sts_tred_status_strip.Name = "sts_tred_status_strip";
            sts_tred_status_strip.Size = new System.Drawing.Size(862, 22);
            sts_tred_status_strip.TabIndex = 3;
            sts_tred_status_strip.Text = "statusStrip1";
            // 
            // lbl_tred_transition_length
            // 
            lbl_tred_transition_length.Name = "lbl_tred_transition_length";
            lbl_tred_transition_length.Size = new System.Drawing.Size(104, 17);
            lbl_tred_transition_length.Text = "Transition Length: ";
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
            txb_transition_info.Location = new System.Drawing.Point(6, 20);
            txb_transition_info.Multiline = true;
            txb_transition_info.Name = "txb_transition_info";
            txb_transition_info.ReadOnly = true;
            txb_transition_info.Size = new System.Drawing.Size(141, 161);
            txb_transition_info.TabIndex = 4;
            txb_transition_info.TabStop = false;
            // 
            // btn_seperate_transition
            // 
            btn_seperate_transition.Location = new System.Drawing.Point(6, 187);
            btn_seperate_transition.Name = "btn_seperate_transition";
            btn_seperate_transition.Size = new System.Drawing.Size(140, 23);
            btn_seperate_transition.TabIndex = 5;
            btn_seperate_transition.Text = "Seperate Transitions";
            btn_seperate_transition.UseVisualStyleBackColor = true;
            btn_seperate_transition.Click += btn_seperate_transition_Click;
            // 
            // grp_transition_warning
            // 
            grp_transition_warning.Controls.Add(txb_transition_info);
            grp_transition_warning.Controls.Add(btn_seperate_transition);
            grp_transition_warning.Location = new System.Drawing.Point(13, 294);
            grp_transition_warning.Name = "grp_transition_warning";
            grp_transition_warning.Size = new System.Drawing.Size(153, 217);
            grp_transition_warning.TabIndex = 6;
            grp_transition_warning.TabStop = false;
            grp_transition_warning.Text = "Warning";
            // 
            // gauTransitionLength
            // 
            gauTransitionLength.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gauTransitionLength.BackColor = System.Drawing.Color.FromArgb(188, 188, 188);
            gauTransitionLength.Color = System.Drawing.Color.FromArgb(0, 192, 192);
            gauTransitionLength.Location = new System.Drawing.Point(13, 563);
            gauTransitionLength.Name = "gauTransitionLength";
            gauTransitionLength.Size = new System.Drawing.Size(837, 10);
            gauTransitionLength.TabIndex = 7;
            gauTransitionLength.Value = 0D;
            // 
            // grpTransition
            // 
            grpTransition.BackColor = System.Drawing.SystemColors.Control;
            grpTransition.Controls.Add(pnlTransition);
            grpTransition.Location = new System.Drawing.Point(498, 13);
            grpTransition.Name = "grpTransition";
            grpTransition.Size = new System.Drawing.Size(352, 544);
            grpTransition.TabIndex = 8;
            grpTransition.TabStop = false;
            grpTransition.Text = "Transition";
            // 
            // pnlTransition
            // 
            pnlTransition.AutoScroll = true;
            pnlTransition.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            pnlTransition.Location = new System.Drawing.Point(6, 22);
            pnlTransition.Name = "pnlTransition";
            pnlTransition.Size = new System.Drawing.Size(340, 516);
            pnlTransition.TabIndex = 0;
            pnlTransition.WrapContents = false;
            // 
            // TransitionsEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(862, 604);
            Controls.Add(grpTransition);
            Controls.Add(gauTransitionLength);
            Controls.Add(grp_transition_warning);
            Controls.Add(sts_tred_status_strip);
            Controls.Add(grp_tred_edits);
            Controls.Add(grp_tred_transition);
            Controls.Add(grp_tred_selection);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(520, 643);
            Name = "TransitionsEditor";
            Text = "Transitions Editor";
            grp_tred_selection.ResumeLayout(false);
            grp_tred_selection.PerformLayout();
            grp_tred_transition.ResumeLayout(false);
            grp_tred_edits.ResumeLayout(false);
            grp_tred_edits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_tred_value).EndInit();
            sts_tred_status_strip.ResumeLayout(false);
            sts_tred_status_strip.PerformLayout();
            grp_transition_warning.ResumeLayout(false);
            grp_transition_warning.PerformLayout();
            grpTransition.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grp_tred_selection;
        private System.Windows.Forms.Label lbl_tred_transition_selection;
        private System.Windows.Forms.ComboBox cbb_tred_transition_selection;
        private System.Windows.Forms.GroupBox grp_tred_transition;
        private System.Windows.Forms.TreeView tre_tred_transition_tree;
        private System.Windows.Forms.GroupBox grp_tred_edits;
        private System.Windows.Forms.StatusStrip sts_tred_status_strip;
        private System.Windows.Forms.ToolStripStatusLabel lbl_tred_transition_length;
        private System.Windows.Forms.NumericUpDown num_tred_value;
        private System.Windows.Forms.Label lbl_tred_value;
        private System.Windows.Forms.Button btn_tred_transition_update;
        private System.Windows.Forms.ToolTip tlt_tred_warning;
        private System.Windows.Forms.Button btn_tred_add_opcode;
        private System.Windows.Forms.Button btn_tred_remove_opcode;
        private System.Windows.Forms.Label lbl_tred_opcodes;
        private System.Windows.Forms.Button btn_tred_move_opcode_up;
        private System.Windows.Forms.Button btn_tred_move_opcode_down;
        private System.Windows.Forms.ComboBox cbb_tred_opcode_add;
        private System.Windows.Forms.TextBox txb_transition_info;
        private System.Windows.Forms.Button btn_seperate_transition;
        private System.Windows.Forms.GroupBox grp_transition_warning;
        private Controls.Other.Gauge gauTransitionLength;
        private System.Windows.Forms.GroupBox grpTransition;
        private System.Windows.Forms.FlowLayoutPanel pnlTransition;
        private System.Windows.Forms.CheckBox chb_expand_all;
        private System.Windows.Forms.TextBox txb_transition_name;
        private System.Windows.Forms.Label lbl_transition_name;
    }
}