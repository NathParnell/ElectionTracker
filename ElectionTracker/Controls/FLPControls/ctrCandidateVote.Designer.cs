namespace ElectionTracker.Controls.FLPControls
{
    partial class ctrCandidateVote
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
            this.lblCandidateName = new System.Windows.Forms.Label();
            this.lblCandidateVotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCandidateName
            // 
            this.lblCandidateName.AutoSize = true;
            this.lblCandidateName.Location = new System.Drawing.Point(16, 20);
            this.lblCandidateName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCandidateName.Name = "lblCandidateName";
            this.lblCandidateName.Size = new System.Drawing.Size(86, 13);
            this.lblCandidateName.TabIndex = 0;
            this.lblCandidateName.Text = "Candidate Name";
            // 
            // lblCandidateVotes
            // 
            this.lblCandidateVotes.AutoSize = true;
            this.lblCandidateVotes.Location = new System.Drawing.Point(258, 20);
            this.lblCandidateVotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCandidateVotes.Name = "lblCandidateVotes";
            this.lblCandidateVotes.Size = new System.Drawing.Size(85, 13);
            this.lblCandidateVotes.TabIndex = 1;
            this.lblCandidateVotes.Text = "Candidate Votes";
            // 
            // ctrCandidateVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCandidateVotes);
            this.Controls.Add(this.lblCandidateName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ctrCandidateVote";
            this.Size = new System.Drawing.Size(311, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCandidateName;
        private System.Windows.Forms.Label lblCandidateVotes;
    }
}
