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
            this.flpCandidateVotes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpCandidateVotes
            // 
            this.flpCandidateVotes.AutoScroll = true;
            this.flpCandidateVotes.Location = new System.Drawing.Point(27, 104);
            this.flpCandidateVotes.Name = "flpCandidateVotes";
            this.flpCandidateVotes.Size = new System.Drawing.Size(460, 534);
            this.flpCandidateVotes.TabIndex = 0;
            // 
            // frmCountVotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(516, 716);
            this.Controls.Add(this.flpCandidateVotes);
            this.Name = "frmCountVotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCountVotes";
            this.Load += new System.EventHandler(this.frmCountVotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCandidateVotes;
    }
}