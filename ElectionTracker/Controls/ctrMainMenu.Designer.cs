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
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnElectionGroupRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentUserName
            // 
            this.lblCurrentUserName.AutoSize = true;
            this.lblCurrentUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUserName.Location = new System.Drawing.Point(18, 129);
            this.lblCurrentUserName.MaximumSize = new System.Drawing.Size(250, 29);
            this.lblCurrentUserName.MinimumSize = new System.Drawing.Size(250, 29);
            this.lblCurrentUserName.Name = "lblCurrentUserName";
            this.lblCurrentUserName.Size = new System.Drawing.Size(250, 29);
            this.lblCurrentUserName.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnCreateElectionGroup
            // 
            this.btnCreateElectionGroup.Location = new System.Drawing.Point(527, 45);
            this.btnCreateElectionGroup.Name = "btnCreateElectionGroup";
            this.btnCreateElectionGroup.Size = new System.Drawing.Size(417, 71);
            this.btnCreateElectionGroup.TabIndex = 2;
            this.btnCreateElectionGroup.Text = "Create Election Group";
            this.btnCreateElectionGroup.UseVisualStyleBackColor = true;
            this.btnCreateElectionGroup.Click += new System.EventHandler(this.btnCreateElectionGroup_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::ElectionTracker.Properties.Resources.ElectionTrackerLogo;
            this.pbxLogo.Location = new System.Drawing.Point(3, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(446, 113);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // btnElectionGroupRegister
            // 
            this.btnElectionGroupRegister.Location = new System.Drawing.Point(527, 166);
            this.btnElectionGroupRegister.Name = "btnElectionGroupRegister";
            this.btnElectionGroupRegister.Size = new System.Drawing.Size(417, 71);
            this.btnElectionGroupRegister.TabIndex = 3;
            this.btnElectionGroupRegister.Text = "Register To Join Election Group";
            this.btnElectionGroupRegister.UseVisualStyleBackColor = true;
            this.btnElectionGroupRegister.Click += new System.EventHandler(this.btnElectionGroupRegister_Click);
            // 
            // ctrMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnElectionGroupRegister);
            this.Controls.Add(this.btnCreateElectionGroup);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblCurrentUserName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1467, 805);
            this.Name = "ctrMainMenu";
            this.Size = new System.Drawing.Size(1467, 805);
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
    }
}
