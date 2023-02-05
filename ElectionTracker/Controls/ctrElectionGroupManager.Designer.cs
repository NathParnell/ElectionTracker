namespace ElectionTracker.Controls
{
    partial class ctrElectionGroupManager
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
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblElectionGroupName = new System.Windows.Forms.Label();
            this.btnCreateElection = new System.Windows.Forms.Button();
            this.btnAcceptElectionGroupMembers = new System.Windows.Forms.Button();
            this.flpActiveElections = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::ElectionTracker.Properties.Resources.ElectionTrackerLogo;
            this.pbxLogo.Location = new System.Drawing.Point(3, 2);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(445, 113);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 8;
            this.pbxLogo.TabStop = false;
            // 
            // lblElectionGroupName
            // 
            this.lblElectionGroupName.AutoSize = true;
            this.lblElectionGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectionGroupName.Location = new System.Drawing.Point(392, 183);
            this.lblElectionGroupName.Name = "lblElectionGroupName";
            this.lblElectionGroupName.Size = new System.Drawing.Size(618, 69);
            this.lblElectionGroupName.TabIndex = 9;
            this.lblElectionGroupName.Text = "Election Group Name";
            // 
            // btnCreateElection
            // 
            this.btnCreateElection.BackColor = System.Drawing.Color.LightGray;
            this.btnCreateElection.Location = new System.Drawing.Point(487, 2);
            this.btnCreateElection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateElection.Name = "btnCreateElection";
            this.btnCreateElection.Size = new System.Drawing.Size(261, 113);
            this.btnCreateElection.TabIndex = 10;
            this.btnCreateElection.Text = "Create Election";
            this.btnCreateElection.UseVisualStyleBackColor = false;
            this.btnCreateElection.Click += new System.EventHandler(this.btnCreateElection_Click);
            // 
            // btnAcceptElectionGroupMembers
            // 
            this.btnAcceptElectionGroupMembers.BackColor = System.Drawing.Color.LightGray;
            this.btnAcceptElectionGroupMembers.Location = new System.Drawing.Point(753, 2);
            this.btnAcceptElectionGroupMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAcceptElectionGroupMembers.Name = "btnAcceptElectionGroupMembers";
            this.btnAcceptElectionGroupMembers.Size = new System.Drawing.Size(261, 113);
            this.btnAcceptElectionGroupMembers.TabIndex = 11;
            this.btnAcceptElectionGroupMembers.Text = "Accept Election Group Members";
            this.btnAcceptElectionGroupMembers.UseVisualStyleBackColor = false;
            this.btnAcceptElectionGroupMembers.Click += new System.EventHandler(this.btnAcceptElectionGroupMembers_Click);
            // 
            // flpActiveElections
            // 
            this.flpActiveElections.AutoScroll = true;
            this.flpActiveElections.Location = new System.Drawing.Point(103, 300);
            this.flpActiveElections.Margin = new System.Windows.Forms.Padding(4);
            this.flpActiveElections.Name = "flpActiveElections";
            this.flpActiveElections.Size = new System.Drawing.Size(1259, 473);
            this.flpActiveElections.TabIndex = 12;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.LightGray;
            this.btnMainMenu.Location = new System.Drawing.Point(1020, 2);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(201, 113);
            this.btnMainMenu.TabIndex = 13;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LightGray;
            this.btnLogOut.Location = new System.Drawing.Point(1227, 2);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(201, 113);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // ctrElectionGroupManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.flpActiveElections);
            this.Controls.Add(this.btnAcceptElectionGroupMembers);
            this.Controls.Add(this.btnCreateElection);
            this.Controls.Add(this.lblElectionGroupName);
            this.Controls.Add(this.pbxLogo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1467, 805);
            this.MinimumSize = new System.Drawing.Size(1467, 805);
            this.Name = "ctrElectionGroupManager";
            this.Size = new System.Drawing.Size(1467, 805);
            this.Load += new System.EventHandler(this.ctrElectionGroupManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblElectionGroupName;
        private System.Windows.Forms.Button btnCreateElection;
        private System.Windows.Forms.Button btnAcceptElectionGroupMembers;
        private System.Windows.Forms.FlowLayoutPanel flpActiveElections;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnLogOut;
    }
}
