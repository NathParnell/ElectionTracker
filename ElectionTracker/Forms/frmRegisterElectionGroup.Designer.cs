namespace ElectionTracker.Forms
{
    partial class frmRegisterElectionGroup
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
            this.cmbElectionGroup = new System.Windows.Forms.ComboBox();
            this.lblElectionGroup = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbElectionGroup
            // 
            this.cmbElectionGroup.FormattingEnabled = true;
            this.cmbElectionGroup.Location = new System.Drawing.Point(75, 110);
            this.cmbElectionGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cmbElectionGroup.Name = "cmbElectionGroup";
            this.cmbElectionGroup.Size = new System.Drawing.Size(294, 21);
            this.cmbElectionGroup.TabIndex = 0;
            // 
            // lblElectionGroup
            // 
            this.lblElectionGroup.AutoSize = true;
            this.lblElectionGroup.Location = new System.Drawing.Point(73, 95);
            this.lblElectionGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElectionGroup.Name = "lblElectionGroup";
            this.lblElectionGroup.Size = new System.Drawing.Size(77, 13);
            this.lblElectionGroup.TabIndex = 1;
            this.lblElectionGroup.Text = "Election Group";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(73, 165);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(149, 13);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Are you a Voter or an Auditor?";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Voter",
            "Auditor"});
            this.cmbRole.Location = new System.Drawing.Point(75, 180);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(294, 21);
            this.cmbRole.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(145, 290);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(146, 37);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmRegisterElectionGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(436, 563);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblElectionGroup);
            this.Controls.Add(this.cmbElectionGroup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegisterElectionGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Election Tracker - Join Election Group";
            this.Load += new System.EventHandler(this.frmRegisterElectionGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbElectionGroup;
        private System.Windows.Forms.Label lblElectionGroup;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnRegister;
    }
}