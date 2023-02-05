namespace ElectionTracker.Forms
{
    partial class frmAcceptUserToElectionGroup
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
            this.cmbSelectUser = new System.Windows.Forms.ComboBox();
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblRequestedRole = new System.Windows.Forms.Label();
            this.btnAcceptUserRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSelectUser
            // 
            this.cmbSelectUser.FormattingEnabled = true;
            this.cmbSelectUser.Location = new System.Drawing.Point(44, 60);
            this.cmbSelectUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSelectUser.Name = "cmbSelectUser";
            this.cmbSelectUser.Size = new System.Drawing.Size(457, 24);
            this.cmbSelectUser.TabIndex = 0;
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Location = new System.Drawing.Point(555, 49);
            this.btnSelectUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(124, 44);
            this.btnSelectUser.TabIndex = 1;
            this.btnSelectUser.Text = "Select User";
            this.btnSelectUser.UseVisualStyleBackColor = true;
            this.btnSelectUser.Click += new System.EventHandler(this.btnSelectUser_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(160, 164);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(47, 16);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(160, 239);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 16);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(160, 298);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(84, 16);
            this.lblDateOfBirth.TabIndex = 4;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // lblRequestedRole
            // 
            this.lblRequestedRole.AutoSize = true;
            this.lblRequestedRole.Location = new System.Drawing.Point(160, 354);
            this.lblRequestedRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestedRole.Name = "lblRequestedRole";
            this.lblRequestedRole.Size = new System.Drawing.Size(109, 16);
            this.lblRequestedRole.TabIndex = 5;
            this.lblRequestedRole.Text = "Requested Role:";
            // 
            // btnAcceptUserRequest
            // 
            this.btnAcceptUserRequest.Location = new System.Drawing.Point(299, 430);
            this.btnAcceptUserRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAcceptUserRequest.Name = "btnAcceptUserRequest";
            this.btnAcceptUserRequest.Size = new System.Drawing.Size(124, 44);
            this.btnAcceptUserRequest.TabIndex = 6;
            this.btnAcceptUserRequest.Text = "Accept User Request";
            this.btnAcceptUserRequest.UseVisualStyleBackColor = true;
            this.btnAcceptUserRequest.Click += new System.EventHandler(this.btnAcceptUserRequest_Click);
            // 
            // frmAcceptUserToElectionGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(715, 633);
            this.Controls.Add(this.btnAcceptUserRequest);
            this.Controls.Add(this.lblRequestedRole);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnSelectUser);
            this.Controls.Add(this.cmbSelectUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAcceptUserToElectionGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAcceptUserToElectionGroup";
            this.Load += new System.EventHandler(this.frmAcceptUserToElectionGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectUser;
        private System.Windows.Forms.Button btnSelectUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblRequestedRole;
        private System.Windows.Forms.Button btnAcceptUserRequest;
    }
}