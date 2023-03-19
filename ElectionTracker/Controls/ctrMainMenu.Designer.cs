namespace ElectionTracker.Controls
{
    partial class ctrMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.lblCurrentUserName = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnCreateElectionGroup = new System.Windows.Forms.Button();
            this.btnElectionGroupRegister = new System.Windows.Forms.Button();
            this.flpUserElectionGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentUserName
            // 
            this.lblCurrentUserName.AutoSize = true;
            this.lblCurrentUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUserName.Location = new System.Drawing.Point(24, 113);
            this.lblCurrentUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentUserName.MaximumSize = new System.Drawing.Size(500, 24);
            this.lblCurrentUserName.MinimumSize = new System.Drawing.Size(188, 24);
            this.lblCurrentUserName.Name = "lblCurrentUserName";
            this.lblCurrentUserName.Size = new System.Drawing.Size(188, 24);
            this.lblCurrentUserName.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnCreateElectionGroup
            // 
            this.btnCreateElectionGroup.BackColor = System.Drawing.Color.LightGray;
            this.btnCreateElectionGroup.Location = new System.Drawing.Point(381, 2);
            this.btnCreateElectionGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateElectionGroup.Name = "btnCreateElectionGroup";
            this.btnCreateElectionGroup.Size = new System.Drawing.Size(230, 92);
            this.btnCreateElectionGroup.TabIndex = 2;
            this.btnCreateElectionGroup.Text = "Create Election Group";
            this.btnCreateElectionGroup.UseVisualStyleBackColor = false;
            this.btnCreateElectionGroup.Click += new System.EventHandler(this.btnCreateElectionGroup_Click);
            // 
            // btnElectionGroupRegister
            // 
            this.btnElectionGroupRegister.BackColor = System.Drawing.Color.LightGray;
            this.btnElectionGroupRegister.Location = new System.Drawing.Point(623, 2);
            this.btnElectionGroupRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnElectionGroupRegister.Name = "btnElectionGroupRegister";
            this.btnElectionGroupRegister.Size = new System.Drawing.Size(230, 92);
            this.btnElectionGroupRegister.TabIndex = 3;
            this.btnElectionGroupRegister.Text = "Register To Join Election Group";
            this.btnElectionGroupRegister.UseVisualStyleBackColor = false;
            this.btnElectionGroupRegister.Click += new System.EventHandler(this.btnElectionGroupRegister_Click);
            // 
            // flpUserElectionGroups
            // 
            this.flpUserElectionGroups.AutoScroll = true;
            this.flpUserElectionGroups.Location = new System.Drawing.Point(75, 180);
            this.flpUserElectionGroups.Name = "flpUserElectionGroups";
            this.flpUserElectionGroups.Size = new System.Drawing.Size(944, 401);
            this.flpUserElectionGroups.TabIndex = 4;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::ElectionTracker.Properties.Resources.ElectionTrackerLogo;
            this.pbxLogo.Location = new System.Drawing.Point(2, 2);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(334, 92);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightGray;
            this.btnLogout.Location = new System.Drawing.Point(868, 2);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(230, 92);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ctrMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.flpUserElectionGroups);
            this.Controls.Add(this.btnElectionGroupRegister);
            this.Controls.Add(this.btnCreateElectionGroup);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblCurrentUserName);
            this.MaximumSize = new System.Drawing.Size(1100, 654);
            this.Name = "ctrMainMenu";
            this.Size = new System.Drawing.Size(1100, 654);
            this.Load += new System.EventHandler(this.ctrMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentUserName;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnCreateElectionGroup;
        private System.Windows.Forms.Button btnElectionGroupRegister;
        private System.Windows.Forms.FlowLayoutPanel flpUserElectionGroups;
        private System.Windows.Forms.Button btnLogout;
    }
}
