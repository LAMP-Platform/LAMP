
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransitionsEditor));
            this.grp_tred_selection = new System.Windows.Forms.GroupBox();
            this.btn_tred_repoint_transition = new System.Windows.Forms.Button();
            this.lbl_tred_transition_selection = new System.Windows.Forms.Label();
            this.num_tred_transition_pointer = new System.Windows.Forms.NumericUpDown();
            this.cbb_tred_transition_selection = new System.Windows.Forms.ComboBox();
            this.lbl_tred_transition_pointer = new System.Windows.Forms.Label();
            this.grp_tred_transition = new System.Windows.Forms.GroupBox();
            this.lbl_tred_error_warning = new System.Windows.Forms.Label();
            this.tre_tred_transition_tree = new System.Windows.Forms.TreeView();
            this.grp_tred_edits = new System.Windows.Forms.GroupBox();
            this.cbb_tred_opcode_add = new System.Windows.Forms.ComboBox();
            this.btn_tred_move_opcode_up = new System.Windows.Forms.Button();
            this.btn_tred_move_opcode_down = new System.Windows.Forms.Button();
            this.lbl_tred_opcodes = new System.Windows.Forms.Label();
            this.btn_tred_add_opcode = new System.Windows.Forms.Button();
            this.btn_tred_remove_opcode = new System.Windows.Forms.Button();
            this.btn_tred_discard_changes = new System.Windows.Forms.Button();
            this.btn_tred_apply_changes = new System.Windows.Forms.Button();
            this.btn_tred_transition_update = new System.Windows.Forms.Button();
            this.num_tred_value = new System.Windows.Forms.NumericUpDown();
            this.lbl_tred_value = new System.Windows.Forms.Label();
            this.sts_tred_status_strip = new System.Windows.Forms.StatusStrip();
            this.lbl_tred_transition_length = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_tred_transition_data = new System.Windows.Forms.TextBox();
            this.grp_tred_raw_data = new System.Windows.Forms.GroupBox();
            this.tlt_tred_warning = new System.Windows.Forms.ToolTip(this.components);
            this.grp_tred_selection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tred_transition_pointer)).BeginInit();
            this.grp_tred_transition.SuspendLayout();
            this.grp_tred_edits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tred_value)).BeginInit();
            this.sts_tred_status_strip.SuspendLayout();
            this.grp_tred_raw_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_tred_selection
            // 
            this.grp_tred_selection.Controls.Add(this.btn_tred_repoint_transition);
            this.grp_tred_selection.Controls.Add(this.lbl_tred_transition_selection);
            this.grp_tred_selection.Controls.Add(this.num_tred_transition_pointer);
            this.grp_tred_selection.Controls.Add(this.cbb_tred_transition_selection);
            this.grp_tred_selection.Controls.Add(this.lbl_tred_transition_pointer);
            this.grp_tred_selection.Location = new System.Drawing.Point(13, 13);
            this.grp_tred_selection.Name = "grp_tred_selection";
            this.grp_tred_selection.Size = new System.Drawing.Size(153, 111);
            this.grp_tred_selection.TabIndex = 0;
            this.grp_tred_selection.TabStop = false;
            this.grp_tred_selection.Text = "Selection";
            // 
            // btn_tred_repoint_transition
            // 
            this.btn_tred_repoint_transition.Enabled = false;
            this.btn_tred_repoint_transition.Location = new System.Drawing.Point(73, 80);
            this.btn_tred_repoint_transition.Name = "btn_tred_repoint_transition";
            this.btn_tred_repoint_transition.Size = new System.Drawing.Size(74, 23);
            this.btn_tred_repoint_transition.TabIndex = 2;
            this.btn_tred_repoint_transition.Text = "Repoint";
            this.btn_tred_repoint_transition.UseVisualStyleBackColor = true;
            this.btn_tred_repoint_transition.Click += new System.EventHandler(this.btn_tred_repoint_transition_Click);
            // 
            // lbl_tred_transition_selection
            // 
            this.lbl_tred_transition_selection.AutoSize = true;
            this.lbl_tred_transition_selection.Location = new System.Drawing.Point(6, 25);
            this.lbl_tred_transition_selection.Name = "lbl_tred_transition_selection";
            this.lbl_tred_transition_selection.Size = new System.Drawing.Size(61, 15);
            this.lbl_tred_transition_selection.TabIndex = 1;
            this.lbl_tred_transition_selection.Text = "Transition:";
            // 
            // num_tred_transition_pointer
            // 
            this.num_tred_transition_pointer.Hexadecimal = true;
            this.num_tred_transition_pointer.Location = new System.Drawing.Point(73, 51);
            this.num_tred_transition_pointer.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.num_tred_transition_pointer.Minimum = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            this.num_tred_transition_pointer.Name = "num_tred_transition_pointer";
            this.num_tred_transition_pointer.Size = new System.Drawing.Size(74, 23);
            this.num_tred_transition_pointer.TabIndex = 1;
            this.num_tred_transition_pointer.Value = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            this.num_tred_transition_pointer.ValueChanged += new System.EventHandler(this.num_tred_transition_pointer_ValueChanged);
            // 
            // cbb_tred_transition_selection
            // 
            this.cbb_tred_transition_selection.FormattingEnabled = true;
            this.cbb_tred_transition_selection.Location = new System.Drawing.Point(73, 22);
            this.cbb_tred_transition_selection.Name = "cbb_tred_transition_selection";
            this.cbb_tred_transition_selection.Size = new System.Drawing.Size(74, 23);
            this.cbb_tred_transition_selection.TabIndex = 0;
            this.cbb_tred_transition_selection.SelectedIndexChanged += new System.EventHandler(this.cbb_tred_transition_selection_SelectedIndexChanged);
            // 
            // lbl_tred_transition_pointer
            // 
            this.lbl_tred_transition_pointer.AutoSize = true;
            this.lbl_tred_transition_pointer.Location = new System.Drawing.Point(6, 53);
            this.lbl_tred_transition_pointer.Name = "lbl_tred_transition_pointer";
            this.lbl_tred_transition_pointer.Size = new System.Drawing.Size(48, 15);
            this.lbl_tred_transition_pointer.TabIndex = 0;
            this.lbl_tred_transition_pointer.Text = "Pointer:";
            // 
            // grp_tred_transition
            // 
            this.grp_tred_transition.Controls.Add(this.lbl_tred_error_warning);
            this.grp_tred_transition.Controls.Add(this.tre_tred_transition_tree);
            this.grp_tred_transition.Location = new System.Drawing.Point(172, 13);
            this.grp_tred_transition.Name = "grp_tred_transition";
            this.grp_tred_transition.Size = new System.Drawing.Size(320, 415);
            this.grp_tred_transition.TabIndex = 1;
            this.grp_tred_transition.TabStop = false;
            this.grp_tred_transition.Text = "Transition";
            // 
            // lbl_tred_error_warning
            // 
            this.lbl_tred_error_warning.AutoSize = true;
            this.lbl_tred_error_warning.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_tred_error_warning.Location = new System.Drawing.Point(234, 25);
            this.lbl_tred_error_warning.Name = "lbl_tred_error_warning";
            this.lbl_tred_error_warning.Size = new System.Drawing.Size(76, 15);
            this.lbl_tred_error_warning.TabIndex = 1;
            this.lbl_tred_error_warning.Text = "WARNING (!)";
            this.tlt_tred_warning.SetToolTip(this.lbl_tred_error_warning, resources.GetString("lbl_tred_error_warning.ToolTip"));
            this.lbl_tred_error_warning.Visible = false;
            // 
            // tre_tred_transition_tree
            // 
            this.tre_tred_transition_tree.Location = new System.Drawing.Point(7, 22);
            this.tre_tred_transition_tree.Name = "tre_tred_transition_tree";
            this.tre_tred_transition_tree.ShowPlusMinus = false;
            this.tre_tred_transition_tree.Size = new System.Drawing.Size(307, 387);
            this.tre_tred_transition_tree.TabIndex = 0;
            this.tre_tred_transition_tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tre_tred_transition_tree_AfterSelect);
            // 
            // grp_tred_edits
            // 
            this.grp_tred_edits.Controls.Add(this.cbb_tred_opcode_add);
            this.grp_tred_edits.Controls.Add(this.btn_tred_move_opcode_up);
            this.grp_tred_edits.Controls.Add(this.btn_tred_move_opcode_down);
            this.grp_tred_edits.Controls.Add(this.lbl_tred_opcodes);
            this.grp_tred_edits.Controls.Add(this.btn_tred_add_opcode);
            this.grp_tred_edits.Controls.Add(this.btn_tred_remove_opcode);
            this.grp_tred_edits.Controls.Add(this.btn_tred_discard_changes);
            this.grp_tred_edits.Controls.Add(this.btn_tred_apply_changes);
            this.grp_tred_edits.Controls.Add(this.btn_tred_transition_update);
            this.grp_tred_edits.Controls.Add(this.num_tred_value);
            this.grp_tred_edits.Controls.Add(this.lbl_tred_value);
            this.grp_tred_edits.Location = new System.Drawing.Point(13, 130);
            this.grp_tred_edits.Name = "grp_tred_edits";
            this.grp_tred_edits.Size = new System.Drawing.Size(153, 298);
            this.grp_tred_edits.TabIndex = 2;
            this.grp_tred_edits.TabStop = false;
            this.grp_tred_edits.Text = "Edit";
            // 
            // cbb_tred_opcode_add
            // 
            this.cbb_tred_opcode_add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_tred_opcode_add.DropDownWidth = 240;
            this.cbb_tred_opcode_add.FormattingEnabled = true;
            this.cbb_tred_opcode_add.Items.AddRange(new object[] {
            "Save the bank and offset of a BG tileset",
            "Save the offset of a sprite tileset",
            "Copy data",
            "Select metatile table",
            "Select collision table",
            "Select solidity indeces",
            "Warp",
            "Retreat from Queen",
            "Change acid & spike damage",
            "Exit from Queen",
            "Enter Queen",
            "Conditional Transition",
            "Fadeout",
            "Load background graphics",
            "Load sprite graphics",
            "Change music",
            "Change special graphics",
            "END TRANSITION"});
            this.cbb_tred_opcode_add.Location = new System.Drawing.Point(7, 108);
            this.cbb_tred_opcode_add.Name = "cbb_tred_opcode_add";
            this.cbb_tred_opcode_add.Size = new System.Drawing.Size(140, 23);
            this.cbb_tred_opcode_add.TabIndex = 10;
            // 
            // btn_tred_move_opcode_up
            // 
            this.btn_tred_move_opcode_up.Image = ((System.Drawing.Image)(resources.GetObject("btn_tred_move_opcode_up.Image")));
            this.btn_tred_move_opcode_up.Location = new System.Drawing.Point(7, 137);
            this.btn_tred_move_opcode_up.Name = "btn_tred_move_opcode_up";
            this.btn_tred_move_opcode_up.Size = new System.Drawing.Size(27, 23);
            this.btn_tred_move_opcode_up.TabIndex = 9;
            this.btn_tred_move_opcode_up.UseVisualStyleBackColor = true;
            this.btn_tred_move_opcode_up.Click += new System.EventHandler(this.btn_tred_move_opcode_up_Click);
            // 
            // btn_tred_move_opcode_down
            // 
            this.btn_tred_move_opcode_down.Image = ((System.Drawing.Image)(resources.GetObject("btn_tred_move_opcode_down.Image")));
            this.btn_tred_move_opcode_down.Location = new System.Drawing.Point(40, 137);
            this.btn_tred_move_opcode_down.Name = "btn_tred_move_opcode_down";
            this.btn_tred_move_opcode_down.Size = new System.Drawing.Size(27, 23);
            this.btn_tred_move_opcode_down.TabIndex = 8;
            this.btn_tred_move_opcode_down.UseVisualStyleBackColor = true;
            this.btn_tred_move_opcode_down.Click += new System.EventHandler(this.btn_tred_move_opcode_down_Click);
            // 
            // lbl_tred_opcodes
            // 
            this.lbl_tred_opcodes.AutoSize = true;
            this.lbl_tred_opcodes.Location = new System.Drawing.Point(6, 83);
            this.lbl_tred_opcodes.Name = "lbl_tred_opcodes";
            this.lbl_tred_opcodes.Size = new System.Drawing.Size(52, 15);
            this.lbl_tred_opcodes.TabIndex = 7;
            this.lbl_tred_opcodes.Text = "Opcode:";
            // 
            // btn_tred_add_opcode
            // 
            this.btn_tred_add_opcode.Image = ((System.Drawing.Image)(resources.GetObject("btn_tred_add_opcode.Image")));
            this.btn_tred_add_opcode.Location = new System.Drawing.Point(73, 79);
            this.btn_tred_add_opcode.Name = "btn_tred_add_opcode";
            this.btn_tred_add_opcode.Size = new System.Drawing.Size(75, 23);
            this.btn_tred_add_opcode.TabIndex = 6;
            this.btn_tred_add_opcode.UseVisualStyleBackColor = true;
            this.btn_tred_add_opcode.Click += new System.EventHandler(this.btn_tred_add_opcode_Click);
            // 
            // btn_tred_remove_opcode
            // 
            this.btn_tred_remove_opcode.Image = ((System.Drawing.Image)(resources.GetObject("btn_tred_remove_opcode.Image")));
            this.btn_tred_remove_opcode.Location = new System.Drawing.Point(73, 137);
            this.btn_tred_remove_opcode.Name = "btn_tred_remove_opcode";
            this.btn_tred_remove_opcode.Size = new System.Drawing.Size(74, 23);
            this.btn_tred_remove_opcode.TabIndex = 5;
            this.btn_tred_remove_opcode.UseVisualStyleBackColor = true;
            this.btn_tred_remove_opcode.Click += new System.EventHandler(this.btn_tred_remove_opcode_Click);
            // 
            // btn_tred_discard_changes
            // 
            this.btn_tred_discard_changes.Enabled = false;
            this.btn_tred_discard_changes.Location = new System.Drawing.Point(7, 269);
            this.btn_tred_discard_changes.Name = "btn_tred_discard_changes";
            this.btn_tred_discard_changes.Size = new System.Drawing.Size(60, 23);
            this.btn_tred_discard_changes.TabIndex = 4;
            this.btn_tred_discard_changes.Text = "Cancel";
            this.btn_tred_discard_changes.UseVisualStyleBackColor = true;
            this.btn_tred_discard_changes.Click += new System.EventHandler(this.btn_tred_discard_changes_Click);
            // 
            // btn_tred_apply_changes
            // 
            this.btn_tred_apply_changes.Enabled = false;
            this.btn_tred_apply_changes.Location = new System.Drawing.Point(73, 269);
            this.btn_tred_apply_changes.Name = "btn_tred_apply_changes";
            this.btn_tred_apply_changes.Size = new System.Drawing.Size(74, 23);
            this.btn_tred_apply_changes.TabIndex = 3;
            this.btn_tred_apply_changes.Text = "Apply";
            this.btn_tred_apply_changes.UseVisualStyleBackColor = true;
            this.btn_tred_apply_changes.Click += new System.EventHandler(this.btn_tred_apply_changes_Click);
            // 
            // btn_tred_transition_update
            // 
            this.btn_tred_transition_update.Enabled = false;
            this.btn_tred_transition_update.Location = new System.Drawing.Point(73, 50);
            this.btn_tred_transition_update.Name = "btn_tred_transition_update";
            this.btn_tred_transition_update.Size = new System.Drawing.Size(74, 23);
            this.btn_tred_transition_update.TabIndex = 2;
            this.btn_tred_transition_update.Text = "Change";
            this.btn_tred_transition_update.UseVisualStyleBackColor = true;
            this.btn_tred_transition_update.Click += new System.EventHandler(this.btn_tred_transition_update_Click);
            // 
            // num_tred_value
            // 
            this.num_tred_value.Enabled = false;
            this.num_tred_value.Hexadecimal = true;
            this.num_tred_value.Location = new System.Drawing.Point(73, 21);
            this.num_tred_value.Name = "num_tred_value";
            this.num_tred_value.Size = new System.Drawing.Size(74, 23);
            this.num_tred_value.TabIndex = 1;
            this.num_tred_value.ValueChanged += new System.EventHandler(this.num_tred_value_ValueChanged);
            // 
            // lbl_tred_value
            // 
            this.lbl_tred_value.AutoSize = true;
            this.lbl_tred_value.Enabled = false;
            this.lbl_tred_value.Location = new System.Drawing.Point(6, 23);
            this.lbl_tred_value.Name = "lbl_tred_value";
            this.lbl_tred_value.Size = new System.Drawing.Size(38, 15);
            this.lbl_tred_value.TabIndex = 0;
            this.lbl_tred_value.Text = "Value:";
            // 
            // sts_tred_status_strip
            // 
            this.sts_tred_status_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_tred_transition_length});
            this.sts_tred_status_strip.Location = new System.Drawing.Point(0, 560);
            this.sts_tred_status_strip.Name = "sts_tred_status_strip";
            this.sts_tred_status_strip.Size = new System.Drawing.Size(504, 22);
            this.sts_tred_status_strip.TabIndex = 3;
            this.sts_tred_status_strip.Text = "statusStrip1";
            // 
            // lbl_tred_transition_length
            // 
            this.lbl_tred_transition_length.Name = "lbl_tred_transition_length";
            this.lbl_tred_transition_length.Size = new System.Drawing.Size(104, 17);
            this.lbl_tred_transition_length.Text = "Transition Length: ";
            // 
            // txt_tred_transition_data
            // 
            this.txt_tred_transition_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tred_transition_data.Location = new System.Drawing.Point(7, 22);
            this.txt_tred_transition_data.Multiline = true;
            this.txt_tred_transition_data.Name = "txt_tred_transition_data";
            this.txt_tred_transition_data.ReadOnly = true;
            this.txt_tred_transition_data.Size = new System.Drawing.Size(439, 94);
            this.txt_tred_transition_data.TabIndex = 4;
            // 
            // grp_tred_raw_data
            // 
            this.grp_tred_raw_data.Controls.Add(this.txt_tred_transition_data);
            this.grp_tred_raw_data.Location = new System.Drawing.Point(12, 435);
            this.grp_tred_raw_data.Name = "grp_tred_raw_data";
            this.grp_tred_raw_data.Size = new System.Drawing.Size(480, 122);
            this.grp_tred_raw_data.TabIndex = 4;
            this.grp_tred_raw_data.TabStop = false;
            this.grp_tred_raw_data.Text = "Raw data";
            // 
            // tlt_tred_warning
            // 
            this.tlt_tred_warning.AutoPopDelay = 0;
            this.tlt_tred_warning.InitialDelay = 0;
            this.tlt_tred_warning.ReshowDelay = 100;
            this.tlt_tred_warning.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.tlt_tred_warning.ToolTipTitle = "Warning";
            // 
            // TransitionsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 582);
            this.Controls.Add(this.grp_tred_raw_data);
            this.Controls.Add(this.sts_tred_status_strip);
            this.Controls.Add(this.grp_tred_edits);
            this.Controls.Add(this.grp_tred_transition);
            this.Controls.Add(this.grp_tred_selection);
            this.MaximizeBox = false;
            this.Name = "TransitionsEditor";
            this.Text = "Transitions Editor";
            this.grp_tred_selection.ResumeLayout(false);
            this.grp_tred_selection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tred_transition_pointer)).EndInit();
            this.grp_tred_transition.ResumeLayout(false);
            this.grp_tred_transition.PerformLayout();
            this.grp_tred_edits.ResumeLayout(false);
            this.grp_tred_edits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tred_value)).EndInit();
            this.sts_tred_status_strip.ResumeLayout(false);
            this.sts_tred_status_strip.PerformLayout();
            this.grp_tred_raw_data.ResumeLayout(false);
            this.grp_tred_raw_data.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txt_tred_transition_data;
        private System.Windows.Forms.GroupBox grp_tred_raw_data;
        private System.Windows.Forms.NumericUpDown num_tred_transition_pointer;
        private System.Windows.Forms.Label lbl_tred_transition_pointer;
        private System.Windows.Forms.Button btn_tred_repoint_transition;
        private System.Windows.Forms.NumericUpDown num_tred_value;
        private System.Windows.Forms.Label lbl_tred_value;
        private System.Windows.Forms.Button btn_tred_transition_update;
        private System.Windows.Forms.Label lbl_tred_error_warning;
        private System.Windows.Forms.ToolTip tlt_tred_warning;
        private System.Windows.Forms.Button btn_tred_apply_changes;
        private System.Windows.Forms.Button btn_tred_discard_changes;
        private System.Windows.Forms.Button btn_tred_add_opcode;
        private System.Windows.Forms.Button btn_tred_remove_opcode;
        private System.Windows.Forms.Label lbl_tred_opcodes;
        private System.Windows.Forms.Button btn_tred_move_opcode_up;
        private System.Windows.Forms.Button btn_tred_move_opcode_down;
        private System.Windows.Forms.ComboBox cbb_tred_opcode_add;
    }
}