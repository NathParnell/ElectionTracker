namespace ElectionTracker.Forms
{
    partial class frmVote
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
            this.cmbCandidate = new System.Windows.Forms.ComboBox();
            this.btnVote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCandidate
            // 
            this.cmbCandidate.FormattingEnabled = true;
            this.cmbCandidate.Location = new System.Drawing.Point(94, 50);
            this.cmbCandidate.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCandidate.Name = "cmbCandidate";
            this.cmbCandidate.Size = new System.Drawing.Size(224, 21);
            this.cmbCandidate.TabIndex = 0;
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(166, 102);
            this.btnVote.Margin = new System.Windows.Forms.Padding(2);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(83, 21);
            this.btnVote.TabIndex = 1;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // frmVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(415, 176);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.cmbCandidate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Election Tracker - Vote";
            this.Load += new System.EventHandler(this.frmVote_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCandidate;
        private System.Windows.Forms.Button btnVote;
    }
}