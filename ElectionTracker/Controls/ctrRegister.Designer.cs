namespace ElectionTracker.Controls
{
    partial class ctrRegister
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegistrationError = new System.Windows.Forms.Label();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(452, 71);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 55);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Register";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(356, 200);
            this.lblForename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(70, 13);
            this.lblForename.TabIndex = 11;
            this.lblForename.Text = "First Name/s:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(358, 215);
            this.txtForename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(172, 20);
            this.txtForename.TabIndex = 10;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(565, 200);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 13;
            this.lblSurname.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(567, 215);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(172, 20);
            this.txtSurname.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(356, 308);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(358, 323);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPassword.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(356, 254);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(358, 269);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(381, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(356, 365);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(77, 13);
            this.lblAccountType.TabIndex = 19;
            this.lblAccountType.Text = "Account Type:";
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Items.AddRange(new object[] {
            "Administrator",
            "Auditor",
            "Voter"});
            this.cmbAccountType.Location = new System.Drawing.Point(358, 380);
            this.cmbAccountType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(381, 21);
            this.cmbAccountType.TabIndex = 20;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(458, 159);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(177, 13);
            this.lblMessage.TabIndex = 21;
            this.lblMessage.Text = "Please note: All fields are mandatory";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(358, 432);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(380, 32);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblRegistrationError
            // 
            this.lblRegistrationError.AutoSize = true;
            this.lblRegistrationError.ForeColor = System.Drawing.Color.Red;
            this.lblRegistrationError.Location = new System.Drawing.Point(440, 492);
            this.lblRegistrationError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistrationError.Name = "lblRegistrationError";
            this.lblRegistrationError.Size = new System.Drawing.Size(0, 13);
            this.lblRegistrationError.TabIndex = 24;
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(565, 308);
            this.lblRePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(73, 13);
            this.lblRePassword.TabIndex = 26;
            this.lblRePassword.Text = "Re-Password:";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(567, 323);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(172, 20);
            this.txtRePassword.TabIndex = 25;
            // 
            // ctrRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lblRePassword);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.lblRegistrationError);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1100, 654);
            this.MinimumSize = new System.Drawing.Size(1100, 654);
            this.Name = "ctrRegister";
            this.Size = new System.Drawing.Size(1100, 654);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblRegistrationError;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.TextBox txtRePassword;
    }
}
