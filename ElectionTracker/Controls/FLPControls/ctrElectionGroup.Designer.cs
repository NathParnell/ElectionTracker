namespace ElectionTracker.Controls.FLPControls
{
    partial class ctrElectionGroup
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
            this.lblRole = new System.Windows.Forms.Label();
            this.lblElectionGroupName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(87, 48);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(36, 16);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role";
            this.lblRole.Click += new System.EventHandler(this.electionGroupClicked);
            // 
            // lblElectionGroupName
            // 
            this.lblElectionGroupName.AutoSize = true;
            this.lblElectionGroupName.Location = new System.Drawing.Point(503, 48);
            this.lblElectionGroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElectionGroupName.Name = "lblElectionGroupName";
            this.lblElectionGroupName.Size = new System.Drawing.Size(95, 16);
            this.lblElectionGroupName.TabIndex = 1;
            this.lblElectionGroupName.Text = "Election Group";
            this.lblElectionGroupName.Click += new System.EventHandler(this.electionGroupClicked);
            // 
            // ctrElectionGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblElectionGroupName);
            this.Controls.Add(this.lblRole);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ctrElectionGroup";
            this.Size = new System.Drawing.Size(1139, 106);
            this.Load += new System.EventHandler(this.ctrElectionGroup_Load);
            this.Click += new System.EventHandler(this.electionGroupClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblElectionGroupName;
    }
}
