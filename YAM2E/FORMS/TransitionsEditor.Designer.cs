
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Fadeout");
            this.grp_tred_selection = new System.Windows.Forms.GroupBox();
            this.lbl_tred_transition_selection = new System.Windows.Forms.Label();
            this.cbb_tred_transition_selection = new System.Windows.Forms.ComboBox();
            this.grp_tred_transition = new System.Windows.Forms.GroupBox();
            this.tre_tred_transition_tree = new System.Windows.Forms.TreeView();
            this.grp_tred_selection.SuspendLayout();
            this.grp_tred_transition.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_tred_selection
            // 
            this.grp_tred_selection.Controls.Add(this.lbl_tred_transition_selection);
            this.grp_tred_selection.Controls.Add(this.cbb_tred_transition_selection);
            this.grp_tred_selection.Location = new System.Drawing.Point(13, 13);
            this.grp_tred_selection.Name = "grp_tred_selection";
            this.grp_tred_selection.Size = new System.Drawing.Size(124, 415);
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
            // 
            // grp_tred_transition
            // 
            this.grp_tred_transition.Controls.Add(this.tre_tred_transition_tree);
            this.grp_tred_transition.Location = new System.Drawing.Point(144, 13);
            this.grp_tred_transition.Name = "grp_tred_transition";
            this.grp_tred_transition.Size = new System.Drawing.Size(701, 415);
            this.grp_tred_transition.TabIndex = 1;
            this.grp_tred_transition.TabStop = false;
            this.grp_tred_transition.Text = "Transition";
            // 
            // tre_tred_transition_tree
            // 
            this.tre_tred_transition_tree.Location = new System.Drawing.Point(7, 22);
            this.tre_tred_transition_tree.Name = "tre_tred_transition_tree";
            treeNode1.BackColor = System.Drawing.Color.Silver;
            treeNode1.Name = "Test";
            treeNode1.Text = "Fadeout";
            treeNode1.ToolTipText = "This fades out the screen. Use in combination of a tileset switch!";
            this.tre_tred_transition_tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tre_tred_transition_tree.ShowNodeToolTips = true;
            this.tre_tred_transition_tree.Size = new System.Drawing.Size(688, 387);
            this.tre_tred_transition_tree.TabIndex = 0;
            // 
            // TransitionsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 480);
            this.Controls.Add(this.grp_tred_transition);
            this.Controls.Add(this.grp_tred_selection);
            this.MaximizeBox = false;
            this.Name = "TransitionsEditor";
            this.Text = "Transitions Editor";
            this.grp_tred_selection.ResumeLayout(false);
            this.grp_tred_selection.PerformLayout();
            this.grp_tred_transition.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_tred_selection;
        private System.Windows.Forms.Label lbl_tred_transition_selection;
        private System.Windows.Forms.ComboBox cbb_tred_transition_selection;
        private System.Windows.Forms.GroupBox grp_tred_transition;
        private System.Windows.Forms.TreeView tre_tred_transition_tree;
    }
}