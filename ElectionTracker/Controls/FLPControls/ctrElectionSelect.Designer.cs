namespace ElectionTracker.Controls.FLPControls
{
    partial class ctrElectionSelect
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
            this.lblElectionName = new System.Windows.Forms.Label();
            this.btnEditElection = new System.Windows.Forms.Button();
            this.btnAddPostalVote = new System.Windows.Forms.Button();
            this.btnAddBallotStationVote = new System.Windows.Forms.Button();
            this.btnCountVotes = new System.Windows.Forms.Button();
            this.btnVote = new System.Windows.Forms.Button();
            this.btnCandidates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblElectionName
            // 
            this.lblElectionName.AutoSize = true;
            this.lblElectionName.Location = new System.Drawing.Point(12, 43);
            this.lblElectionName.Name = "lblElectionName";
            this.lblElectionName.Size = new System.Drawing.Size(95, 16);
            this.lblElectionName.TabIndex = 0;
            this.lblElectionName.Text = "Election Name";
            // 
            // btnEditElection
            // 
            this.btnEditElection.Location = new System.Drawing.Point(428, 38);
            this.btnEditElection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditElection.Name = "btnEditElection";
            this.btnEditElection.Size = new System.Drawing.Size(162, 26);
            this.btnEditElection.TabIndex = 2;
            this.btnEditElection.Text = "Edit Election";
            this.btnEditElection.UseVisualStyleBackColor = true;
            // 
            // btnAddPostalVote
            // 
            this.btnAddPostalVote.Location = new System.Drawing.Point(596, 38);
            this.btnAddPostalVote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPostalVote.Name = "btnAddPostalVote";
            this.btnAddPostalVote.Size = new System.Drawing.Size(162, 26);
            this.btnAddPostalVote.TabIndex = 3;
            this.btnAddPostalVote.Text = "Add Postal Vote";
            this.btnAddPostalVote.UseVisualStyleBackColor = true;
            this.btnAddPostalVote.Click += new System.EventHandler(this.btnAddPostalVote_Click);
            // 
            // btnAddBallotStationVote
            // 
            this.btnAddBallotStationVote.Location = new System.Drawing.Point(764, 38);
            this.btnAddBallotStationVote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBallotStationVote.Name = "btnAddBallotStationVote";
            this.btnAddBallotStationVote.Size = new System.Drawing.Size(162, 26);
            this.btnAddBallotStationVote.TabIndex = 4;
            this.btnAddBallotStationVote.Text = "Add Ballot Station Vote";
            this.btnAddBallotStationVote.UseVisualStyleBackColor = true;
            this.btnAddBallotStationVote.Click += new System.EventHandler(this.btnAddBallotStationVote_Click);
            // 
            // btnCountVotes
            // 
            this.btnCountVotes.Location = new System.Drawing.Point(932, 38);
            this.btnCountVotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCountVotes.Name = "btnCountVotes";
            this.btnCountVotes.Size = new System.Drawing.Size(139, 26);
            this.btnCountVotes.TabIndex = 5;
            this.btnCountVotes.Text = "Count Votes";
            this.btnCountVotes.UseVisualStyleBackColor = true;
            this.btnCountVotes.Click += new System.EventHandler(this.btnCountVotes_Click);
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(1077, 38);
            this.btnVote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(139, 26);
            this.btnVote.TabIndex = 6;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // btnCandidates
            // 
            this.btnCandidates.Location = new System.Drawing.Point(260, 38);
            this.btnCandidates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCandidates.Name = "btnCandidates";
            this.btnCandidates.Size = new System.Drawing.Size(162, 26);
            this.btnCandidates.TabIndex = 7;
            this.btnCandidates.Text = "Candidates";
            this.btnCandidates.UseVisualStyleBackColor = true;
            this.btnCandidates.Click += new System.EventHandler(this.btnCandidates_Click);
            // 
            // ctrElectionSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCandidates);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.btnCountVotes);
            this.Controls.Add(this.btnAddBallotStationVote);
            this.Controls.Add(this.btnAddPostalVote);
            this.Controls.Add(this.btnEditElection);
            this.Controls.Add(this.lblElectionName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrElectionSelect";
            this.Size = new System.Drawing.Size(1226, 106);
            this.Load += new System.EventHandler(this.ctrElectionSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElectionName;
        private System.Windows.Forms.Button btnEditElection;
        private System.Windows.Forms.Button btnAddPostalVote;
        private System.Windows.Forms.Button btnAddBallotStationVote;
        private System.Windows.Forms.Button btnCountVotes;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Button btnCandidates;
    }
}
