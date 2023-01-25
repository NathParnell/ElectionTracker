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
            this.lblUserAge = new System.Windows.Forms.Label();
            this.dateTimeAge = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblAddres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbElectionGroup
            // 
            this.cmbElectionGroup.FormattingEnabled = true;
            this.cmbElectionGroup.Location = new System.Drawing.Point(100, 136);
            this.cmbElectionGroup.Name = "cmbElectionGroup";
            this.cmbElectionGroup.Size = new System.Drawing.Size(390, 24);
            this.cmbElectionGroup.TabIndex = 0;
            // 
            // lblElectionGroup
            // 
            this.lblElectionGroup.AutoSize = true;
            this.lblElectionGroup.Location = new System.Drawing.Point(97, 117);
            this.lblElectionGroup.Name = "lblElectionGroup";
            this.lblElectionGroup.Size = new System.Drawing.Size(95, 16);
            this.lblElectionGroup.TabIndex = 1;
            this.lblElectionGroup.Text = "Election Group";
            // 
            // lblUserAge
            // 
            this.lblUserAge.AutoSize = true;
            this.lblUserAge.Location = new System.Drawing.Point(97, 183);
            this.lblUserAge.Name = "lblUserAge";
            this.lblUserAge.Size = new System.Drawing.Size(35, 16);
            this.lblUserAge.TabIndex = 3;
            this.lblUserAge.Text = "Age:";
            // 
            // dateTimeAge
            // 
            this.dateTimeAge.Location = new System.Drawing.Point(100, 202);
            this.dateTimeAge.Name = "dateTimeAge";
            this.dateTimeAge.Size = new System.Drawing.Size(390, 22);
            this.dateTimeAge.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(390, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lblAddres
            // 
            this.lblAddres.AutoSize = true;
            this.lblAddres.Location = new System.Drawing.Point(97, 251);
            this.lblAddres.Name = "lblAddres";
            this.lblAddres.Size = new System.Drawing.Size(35, 16);
            this.lblAddres.TabIndex = 5;
            this.lblAddres.Text = "Age:";
            // 
            // frmRegisterElectionGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(582, 693);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblAddres);
            this.Controls.Add(this.dateTimeAge);
            this.Controls.Add(this.lblUserAge);
            this.Controls.Add(this.lblElectionGroup);
            this.Controls.Add(this.cmbElectionGroup);
            this.Name = "frmRegisterElectionGroup";
            this.Text = "frmRegisterElectionGroup";
            this.Load += new System.EventHandler(this.frmRegisterElectionGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbElectionGroup;
        private System.Windows.Forms.Label lblElectionGroup;
        private System.Windows.Forms.Label lblUserAge;
        private System.Windows.Forms.DateTimePicker dateTimeAge;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblAddres;
    }
}