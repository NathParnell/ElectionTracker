namespace ElectionTracker
{
    partial class frmElectionTracker
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
            this.pnlElectionTracker = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlElectionTracker
            // 
            this.pnlElectionTracker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlElectionTracker.Location = new System.Drawing.Point(0, 0);
            this.pnlElectionTracker.Name = "pnlElectionTracker";
            this.pnlElectionTracker.Size = new System.Drawing.Size(1467, 805);
            this.pnlElectionTracker.TabIndex = 0;
            // 
            // frmElectionTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 805);
            this.Controls.Add(this.pnlElectionTracker);
            this.MaximumSize = new System.Drawing.Size(1485, 852);
            this.MinimumSize = new System.Drawing.Size(1485, 852);
            this.Name = "frmElectionTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Election Tracker";
            this.Load += new System.EventHandler(this.frmElectionTracker_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlElectionTracker;
    }
}

