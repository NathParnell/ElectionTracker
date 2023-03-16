namespace ElectionTracker.Forms
{
    partial class frmCountVotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCountVotes));
            this.flpCandidateVotes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpCandidateVotes
            // 
            this.flpCandidateVotes.AutoScroll = true;
            this.flpCandidateVotes.Location = new System.Drawing.Point(20, 84);
            this.flpCandidateVotes.Margin = new System.Windows.Forms.Padding(2);
            this.flpCandidateVotes.Name = "flpCandidateVotes";
            this.flpCandidateVotes.Size = new System.Drawing.Size(345, 434);
            this.flpCandidateVotes.TabIndex = 0;
            // 
            // frmCountVotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(387, 582);
            this.Controls.Add(this.flpCandidateVotes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCountVotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Election Tracker - Count Votes";
            this.Load += new System.EventHandler(this.frmCountVotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCandidateVotes;
    }
}