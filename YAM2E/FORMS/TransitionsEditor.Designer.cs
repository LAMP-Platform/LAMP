
namespace YAM2E.FORMS
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
            this.grp_tred_selection = new System.Windows.Forms.GroupBox();
            this.lbl_tred_transition_selection = new System.Windows.Forms.Label();
            this.cbb_tred_transition_selection = new System.Windows.Forms.ComboBox();
            this.grp_tred_transition = new System.Windows.Forms.GroupBox();
            this.tre_tred_transition_tree = new System.Windows.Forms.TreeView();
            this.grp_tred_edits = new System.Windows.Forms.GroupBox();
            this.sts_tred_status_strip = new System.Windows.Forms.StatusStrip();
            this.lbl_tred_transition_length = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_tred_transition_data = new System.Windows.Forms.TextBox();
            this.grp_tred_raw_data = new System.Windows.Forms.GroupBox();
            this.grp_tred_selection.SuspendLayout();
            this.grp_tred_transition.SuspendLayout();
            this.sts_tred_status_strip.SuspendLayout();
            this.grp_tred_raw_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_tred_selection
            // 
            this.grp_tred_selection.Controls.Add(this.lbl_tred_transition_selection);
            this.grp_tred_selection.Controls.Add(this.cbb_tred_transition_selection);
            this.grp_tred_selection.Location = new System.Drawing.Point(13, 13);
            this.grp_tred_selection.Name = "grp_tred_selection";
            this.grp_tred_selection.Size = new System.Drawing.Size(125, 58);
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
            this.cbb_tred_transition_selection.Size = new System.Drawing.Size(45, 23);
            this.cbb_tred_transition_selection.TabIndex = 0;
            this.cbb_tred_transition_selection.SelectedIndexChanged += new System.EventHandler(this.cbb_tred_transition_selection_SelectedIndexChanged);
            // 
            // grp_tred_transition
            // 
            this.grp_tred_transition.Controls.Add(this.tre_tred_transition_tree);
            this.grp_tred_transition.Location = new System.Drawing.Point(144, 13);
            this.grp_tred_transition.Name = "grp_tred_transition";
            this.grp_tred_transition.Size = new System.Drawing.Size(320, 415);
            this.grp_tred_transition.TabIndex = 1;
            this.grp_tred_transition.TabStop = false;
            this.grp_tred_transition.Text = "Transition";
            // 
            // tre_tred_transition_tree
            // 
            this.tre_tred_transition_tree.Location = new System.Drawing.Point(7, 22);
            this.tre_tred_transition_tree.Name = "tre_tred_transition_tree";
            this.tre_tred_transition_tree.ShowNodeToolTips = true;
            this.tre_tred_transition_tree.Size = new System.Drawing.Size(307, 387);
            this.tre_tred_transition_tree.TabIndex = 0;
            this.tre_tred_transition_tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tre_tred_transition_tree_AfterSelect);
            // 
            // grp_tred_edits
            // 
            this.grp_tred_edits.Location = new System.Drawing.Point(13, 78);
            this.grp_tred_edits.Name = "grp_tred_edits";
            this.grp_tred_edits.Size = new System.Drawing.Size(125, 350);
            this.grp_tred_edits.TabIndex = 2;
            this.grp_tred_edits.TabStop = false;
            this.grp_tred_edits.Text = "Edit";
            // 
            // sts_tred_status_strip
            // 
            this.sts_tred_status_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_tred_transition_length});
            this.sts_tred_status_strip.Location = new System.Drawing.Point(0, 560);
            this.sts_tred_status_strip.Name = "sts_tred_status_strip";
            this.sts_tred_status_strip.Size = new System.Drawing.Size(468, 22);
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
            this.grp_tred_raw_data.Size = new System.Drawing.Size(452, 122);
            this.grp_tred_raw_data.TabIndex = 4;
            this.grp_tred_raw_data.TabStop = false;
            this.grp_tred_raw_data.Text = "Raw data";
            // 
            // TransitionsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 582);
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
            this.grp_tred_transition.ResumeLayout(false);
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
    }
}