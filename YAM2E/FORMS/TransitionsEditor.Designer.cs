
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
            this.lbl_tred_transition_selection = new System.Windows.Forms.Label();
            this.cbb_tred_transition_selection = new System.Windows.Forms.ComboBox();
            this.grp_tred_transition = new System.Windows.Forms.GroupBox();
            this.tre_tred_transition_tree = new System.Windows.Forms.TreeView();
            this.grp_tred_edits = new System.Windows.Forms.GroupBox();
            this.cbb_tred_opcode_add = new System.Windows.Forms.ComboBox();
            this.btn_tred_move_opcode_up = new System.Windows.Forms.Button();
            this.btn_tred_move_opcode_down = new System.Windows.Forms.Button();
            this.lbl_tred_opcodes = new System.Windows.Forms.Label();
            this.btn_tred_add_opcode = new System.Windows.Forms.Button();
            this.btn_tred_remove_opcode = new System.Windows.Forms.Button();
            this.btn_tred_transition_update = new System.Windows.Forms.Button();
            this.num_tred_value = new System.Windows.Forms.NumericUpDown();
            this.lbl_tred_value = new System.Windows.Forms.Label();
            this.sts_tred_status_strip = new System.Windows.Forms.StatusStrip();
            this.lbl_tred_transition_length = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlt_tred_warning = new System.Windows.Forms.ToolTip(this.components);
            this.txb_transition_info = new System.Windows.Forms.TextBox();
            this.btn_seperate_transition = new System.Windows.Forms.Button();
            this.grp_transition_warning = new System.Windows.Forms.GroupBox();
            this.gauTransitionLength = new LAMP.Controls.Other.Gauge();
            this.grpTransition = new System.Windows.Forms.GroupBox();
            this.pnlTransition = new System.Windows.Forms.FlowLayoutPanel();
            this.grp_tred_selection.SuspendLayout();
            this.grp_tred_transition.SuspendLayout();
            this.grp_tred_edits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tred_value)).BeginInit();
            this.sts_tred_status_strip.SuspendLayout();
            this.grp_transition_warning.SuspendLayout();
            this.grpTransition.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_tred_selection
            // 
            this.grp_tred_selection.Controls.Add(this.lbl_tred_transition_selection);
            this.grp_tred_selection.Controls.Add(this.cbb_tred_transition_selection);
            this.grp_tred_selection.Location = new System.Drawing.Point(13, 13);
            this.grp_tred_selection.Name = "grp_tred_selection";
            this.grp_tred_selection.Size = new System.Drawing.Size(153, 58);
            this.grp_tred_selection.TabIndex = 0;
            this.grp_tred_selection.TabStop = false;
            this.grp_tred_selection.Text = "Selection";
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
            // cbb_tred_transition_selection
            // 
            this.cbb_tred_transition_selection.FormattingEnabled = true;
            this.cbb_tred_transition_selection.Location = new System.Drawing.Point(73, 22);
            this.cbb_tred_transition_selection.Name = "cbb_tred_transition_selection";
            this.cbb_tred_transition_selection.Size = new System.Drawing.Size(74, 23);
            this.cbb_tred_transition_selection.TabIndex = 0;
            this.cbb_tred_transition_selection.SelectedIndexChanged += new System.EventHandler(this.cbb_tred_transition_selection_SelectedIndexChanged);
            // 
            // grp_tred_transition
            // 
            this.grp_tred_transition.Controls.Add(this.tre_tred_transition_tree);
            this.grp_tred_transition.Location = new System.Drawing.Point(172, 13);
            this.grp_tred_transition.Name = "grp_tred_transition";
            this.grp_tred_transition.Size = new System.Drawing.Size(320, 544);
            this.grp_tred_transition.TabIndex = 1;
            this.grp_tred_transition.TabStop = false;
            this.grp_tred_transition.Text = "Transition";
            // 
            // tre_tred_transition_tree
            // 
            this.tre_tred_transition_tree.Location = new System.Drawing.Point(7, 22);
            this.tre_tred_transition_tree.Name = "tre_tred_transition_tree";
            this.tre_tred_transition_tree.ShowPlusMinus = false;
            this.tre_tred_transition_tree.Size = new System.Drawing.Size(307, 516);
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
            this.grp_tred_edits.Controls.Add(this.btn_tred_transition_update);
            this.grp_tred_edits.Controls.Add(this.num_tred_value);
            this.grp_tred_edits.Controls.Add(this.lbl_tred_value);
            this.grp_tred_edits.Location = new System.Drawing.Point(13, 77);
            this.grp_tred_edits.Name = "grp_tred_edits";
            this.grp_tred_edits.Size = new System.Drawing.Size(153, 167);
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
            this.sts_tred_status_strip.Location = new System.Drawing.Point(0, 582);
            this.sts_tred_status_strip.Name = "sts_tred_status_strip";
            this.sts_tred_status_strip.Size = new System.Drawing.Size(985, 22);
            this.sts_tred_status_strip.TabIndex = 3;
            this.sts_tred_status_strip.Text = "statusStrip1";
            // 
            // lbl_tred_transition_length
            // 
            this.lbl_tred_transition_length.Name = "lbl_tred_transition_length";
            this.lbl_tred_transition_length.Size = new System.Drawing.Size(104, 17);
            this.lbl_tred_transition_length.Text = "Transition Length: ";
            // 
            // tlt_tred_warning
            // 
            this.tlt_tred_warning.AutoPopDelay = 0;
            this.tlt_tred_warning.InitialDelay = 0;
            this.tlt_tred_warning.ReshowDelay = 100;
            this.tlt_tred_warning.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.tlt_tred_warning.ToolTipTitle = "Warning";
            // 
            // txb_transition_info
            // 
            this.txb_transition_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_transition_info.Location = new System.Drawing.Point(6, 20);
            this.txb_transition_info.Multiline = true;
            this.txb_transition_info.Name = "txb_transition_info";
            this.txb_transition_info.ReadOnly = true;
            this.txb_transition_info.Size = new System.Drawing.Size(141, 161);
            this.txb_transition_info.TabIndex = 4;
            this.txb_transition_info.TabStop = false;
            // 
            // btn_seperate_transition
            // 
            this.btn_seperate_transition.Location = new System.Drawing.Point(6, 187);
            this.btn_seperate_transition.Name = "btn_seperate_transition";
            this.btn_seperate_transition.Size = new System.Drawing.Size(140, 23);
            this.btn_seperate_transition.TabIndex = 5;
            this.btn_seperate_transition.Text = "Seperate Transitions";
            this.btn_seperate_transition.UseVisualStyleBackColor = true;
            this.btn_seperate_transition.Click += new System.EventHandler(this.btn_seperate_transition_Click);
            // 
            // grp_transition_warning
            // 
            this.grp_transition_warning.Controls.Add(this.txb_transition_info);
            this.grp_transition_warning.Controls.Add(this.btn_seperate_transition);
            this.grp_transition_warning.Location = new System.Drawing.Point(13, 250);
            this.grp_transition_warning.Name = "grp_transition_warning";
            this.grp_transition_warning.Size = new System.Drawing.Size(153, 217);
            this.grp_transition_warning.TabIndex = 6;
            this.grp_transition_warning.TabStop = false;
            this.grp_transition_warning.Text = "Warning";
            // 
            // gauTransitionLength
            // 
            this.gauTransitionLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.gauTransitionLength.Location = new System.Drawing.Point(13, 563);
            this.gauTransitionLength.Name = "gauTransitionLength";
            this.gauTransitionLength.Size = new System.Drawing.Size(479, 10);
            this.gauTransitionLength.TabIndex = 7;
            // 
            // grpTransition
            // 
            this.grpTransition.BackColor = System.Drawing.SystemColors.Control;
            this.grpTransition.Controls.Add(this.pnlTransition);
            this.grpTransition.Location = new System.Drawing.Point(498, 13);
            this.grpTransition.Name = "grpTransition";
            this.grpTransition.Size = new System.Drawing.Size(352, 544);
            this.grpTransition.TabIndex = 8;
            this.grpTransition.TabStop = false;
            this.grpTransition.Text = "Transition";
            // 
            // pnlTransition
            // 
            this.pnlTransition.AutoScroll = true;
            this.pnlTransition.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlTransition.Location = new System.Drawing.Point(6, 22);
            this.pnlTransition.Name = "pnlTransition";
            this.pnlTransition.Size = new System.Drawing.Size(340, 516);
            this.pnlTransition.TabIndex = 0;
            this.pnlTransition.WrapContents = false;
            // 
            // TransitionsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 604);
            this.Controls.Add(this.grpTransition);
            this.Controls.Add(this.gauTransitionLength);
            this.Controls.Add(this.grp_transition_warning);
            this.Controls.Add(this.sts_tred_status_strip);
            this.Controls.Add(this.grp_tred_edits);
            this.Controls.Add(this.grp_tred_transition);
            this.Controls.Add(this.grp_tred_selection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(520, 620);
            this.Name = "TransitionsEditor";
            this.Text = "Transitions Editor";
            this.grp_tred_selection.ResumeLayout(false);
            this.grp_tred_selection.PerformLayout();
            this.grp_tred_transition.ResumeLayout(false);
            this.grp_tred_edits.ResumeLayout(false);
            this.grp_tred_edits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tred_value)).EndInit();
            this.sts_tred_status_strip.ResumeLayout(false);
            this.sts_tred_status_strip.PerformLayout();
            this.grp_transition_warning.ResumeLayout(false);
            this.grp_transition_warning.PerformLayout();
            this.grpTransition.ResumeLayout(false);
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
    }
}