namespace ElectionTracker.Forms
{
    partial class frmCreateElection
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
            this.btnCreateElection = new System.Windows.Forms.Button();
            this.txtElectionDescription = new System.Windows.Forms.TextBox();
            this.lblElectionDescription = new System.Windows.Forms.Label();
            this.txtElectionName = new System.Windows.Forms.TextBox();
            this.lblElectionName = new System.Windows.Forms.Label();
            this.lblElectionStartDate = new System.Windows.Forms.Label();
            this.dtElectionStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtElectionEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblElectionEndDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateElection
            // 
            this.btnCreateElection.Location = new System.Drawing.Point(182, 340);
            this.btnCreateElection.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateElection.Name = "btnCreateElection";
            this.btnCreateElection.Size = new System.Drawing.Size(114, 19);
            this.btnCreateElection.TabIndex = 9;
            this.btnCreateElection.Text = "Create";
            this.btnCreateElection.UseVisualStyleBackColor = true;
            this.btnCreateElection.Click += new System.EventHandler(this.btnCreateElection_Click);
            // 
            // txtElectionDescription
            // 
            this.txtElectionDescription.Location = new System.Drawing.Point(98, 170);
            this.txtElectionDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtElectionDescription.Name = "txtElectionDescription";
            this.txtElectionDescription.Size = new System.Drawing.Size(302, 20);
            this.txtElectionDescription.TabIndex = 8;
            // 
            // lblElectionDescription
            // 
            this.lblElectionDescription.AutoSize = true;
            this.lblElectionDescription.Location = new System.Drawing.Point(79, 154);
            this.lblElectionDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElectionDescription.Name = "lblElectionDescription";
            this.lblElectionDescription.Size = new System.Drawing.Size(63, 13);
            this.lblElectionDescription.TabIndex = 7;
            this.lblElectionDescription.Text = "Description:";
            // 
            // txtElectionName
            // 
            this.txtElectionName.Location = new System.Drawing.Point(98, 107);
            this.txtElectionName.Margin = new System.Windows.Forms.Padding(2);
            this.txtElectionName.Name = "txtElectionName";
            this.txtElectionName.Size = new System.Drawing.Size(302, 20);
            this.txtElectionName.TabIndex = 6;
            // 
            // lblElectionName
            // 
            this.lblElectionName.AutoSize = true;
            this.lblElectionName.Location = new System.Drawing.Point(79, 92);
            this.lblElectionName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElectionName.Name = "lblElectionName";
            this.lblElectionName.Size = new System.Drawing.Size(38, 13);
            this.lblElectionName.TabIndex = 5;
            this.lblElectionName.Text = "Name:";
            // 
            // lblElectionStartDate
            // 
            this.lblElectionStartDate.AutoSize = true;
            this.lblElectionStartDate.Location = new System.Drawing.Point(79, 212);
            this.lblElectionStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElectionStartDate.Name = "lblElectionStartDate";
            this.lblElectionStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblElectionStartDate.TabIndex = 10;
            this.lblElectionStartDate.Text = "Start Date:";
            // 
            // dtElectionStartDate
            // 
            this.dtElectionStartDate.Location = new System.Drawing.Point(98, 228);
            this.dtElectionStartDate.Name = "dtElectionStartDate";
            this.dtElectionStartDate.Size = new System.Drawing.Size(302, 20);
            this.dtElectionStartDate.TabIndex = 11;
            // 
            // dtElectionEndDate
            // 
            this.dtElectionEndDate.Location = new System.Drawing.Point(98, 280);
            this.dtElectionEndDate.Name = "dtElectionEndDate";
            this.dtElectionEndDate.Size = new System.Drawing.Size(302, 20);
            this.dtElectionEndDate.TabIndex = 13;
            // 
            // lblElectionEndDate
            // 
            this.lblElectionEndDate.AutoSize = true;
            this.lblElectionEndDate.Location = new System.Drawing.Point(79, 264);
            this.lblElectionEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElectionEndDate.Name = "lblElectionEndDate";
            this.lblElectionEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblElectionEndDate.TabIndex = 12;
            this.lblElectionEndDate.Text = "End Date:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(72, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(367, 55);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Create Election";
            // 
            // frmCreateElection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(504, 394);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dtElectionEndDate);
            this.Controls.Add(this.lblElectionEndDate);
            this.Controls.Add(this.dtElectionStartDate);
            this.Controls.Add(this.lblElectionStartDate);
            this.Controls.Add(this.btnCreateElection);
            this.Controls.Add(this.txtElectionDescription);
            this.Controls.Add(this.lblElectionDescription);
            this.Controls.Add(this.txtElectionName);
            this.Controls.Add(this.lblElectionName);
            this.Name = "frmCreateElection";
            this.Text = "frmCreateElection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateElection;
        private System.Windows.Forms.TextBox txtElectionDescription;
        private System.Windows.Forms.Label lblElectionDescription;
        private System.Windows.Forms.TextBox txtElectionName;
        private System.Windows.Forms.Label lblElectionName;
        private System.Windows.Forms.Label lblElectionStartDate;
        private System.Windows.Forms.DateTimePicker dtElectionStartDate;
        private System.Windows.Forms.DateTimePicker dtElectionEndDate;
        private System.Windows.Forms.Label lblElectionEndDate;
        private System.Windows.Forms.Label lblTitle;
    }
}