namespace ElectionTracker.Forms
{
    partial class frmManageElection
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
            this.btnElectionAction = new System.Windows.Forms.Button();
            this.txtElectionDescription = new System.Windows.Forms.TextBox();
            this.lblElectionDescription = new System.Windows.Forms.Label();
            this.txtElectionName = new System.Windows.Forms.TextBox();
            this.lblElectionName = new System.Windows.Forms.Label();
            this.lblElectionStartDate = new System.Windows.Forms.Label();
            this.dtElectionStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtElectionEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblElectionEndDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtElectionStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtElectionEndTime = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteElection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElectionAction
            // 
            this.btnElectionAction.Location = new System.Drawing.Point(268, 336);
            this.btnElectionAction.Margin = new System.Windows.Forms.Padding(2);
            this.btnElectionAction.Name = "btnElectionAction";
            this.btnElectionAction.Size = new System.Drawing.Size(117, 30);
            this.btnElectionAction.TabIndex = 9;
            this.btnElectionAction.Text = "Create";
            this.btnElectionAction.UseVisualStyleBackColor = true;
            this.btnElectionAction.Click += new System.EventHandler(this.btnElectionAction_Click);
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
            this.dtElectionStartDate.Size = new System.Drawing.Size(144, 20);
            this.dtElectionStartDate.TabIndex = 11;
            this.dtElectionStartDate.Value = new System.DateTime(2023, 3, 16, 0, 0, 0, 0);
            // 
            // dtElectionEndDate
            // 
            this.dtElectionEndDate.Location = new System.Drawing.Point(98, 280);
            this.dtElectionEndDate.Name = "dtElectionEndDate";
            this.dtElectionEndDate.Size = new System.Drawing.Size(144, 20);
            this.dtElectionEndDate.TabIndex = 13;
            this.dtElectionEndDate.Value = new System.DateTime(2023, 3, 16, 0, 0, 0, 0);
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
            // dtElectionStartTime
            // 
            this.dtElectionStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtElectionStartTime.Location = new System.Drawing.Point(268, 228);
            this.dtElectionStartTime.Name = "dtElectionStartTime";
            this.dtElectionStartTime.ShowUpDown = true;
            this.dtElectionStartTime.Size = new System.Drawing.Size(144, 20);
            this.dtElectionStartTime.TabIndex = 15;
            this.dtElectionStartTime.Value = new System.DateTime(2023, 3, 16, 16, 12, 0, 0);
            // 
            // dtElectionEndTime
            // 
            this.dtElectionEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtElectionEndTime.Location = new System.Drawing.Point(268, 280);
            this.dtElectionEndTime.Name = "dtElectionEndTime";
            this.dtElectionEndTime.ShowUpDown = true;
            this.dtElectionEndTime.Size = new System.Drawing.Size(144, 20);
            this.dtElectionEndTime.TabIndex = 16;
            this.dtElectionEndTime.Value = new System.DateTime(2023, 3, 16, 16, 12, 0, 0);
            // 
            // btnDeleteElection
            // 
            this.btnDeleteElection.Location = new System.Drawing.Point(125, 336);
            this.btnDeleteElection.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteElection.Name = "btnDeleteElection";
            this.btnDeleteElection.Size = new System.Drawing.Size(117, 30);
            this.btnDeleteElection.TabIndex = 17;
            this.btnDeleteElection.Text = "Delete Election";
            this.btnDeleteElection.UseVisualStyleBackColor = true;
            this.btnDeleteElection.Click += new System.EventHandler(this.btnDeleteElection_Click);
            // 
            // frmManageElection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(504, 394);
            this.Controls.Add(this.btnDeleteElection);
            this.Controls.Add(this.dtElectionEndTime);
            this.Controls.Add(this.dtElectionStartTime);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dtElectionEndDate);
            this.Controls.Add(this.lblElectionEndDate);
            this.Controls.Add(this.dtElectionStartDate);
            this.Controls.Add(this.lblElectionStartDate);
            this.Controls.Add(this.btnElectionAction);
            this.Controls.Add(this.txtElectionDescription);
            this.Controls.Add(this.lblElectionDescription);
            this.Controls.Add(this.txtElectionName);
            this.Controls.Add(this.lblElectionName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageElection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Election Tracker - Manage Election";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnElectionAction;
        private System.Windows.Forms.TextBox txtElectionDescription;
        private System.Windows.Forms.Label lblElectionDescription;
        private System.Windows.Forms.TextBox txtElectionName;
        private System.Windows.Forms.Label lblElectionName;
        private System.Windows.Forms.Label lblElectionStartDate;
        private System.Windows.Forms.DateTimePicker dtElectionStartDate;
        private System.Windows.Forms.DateTimePicker dtElectionEndDate;
        private System.Windows.Forms.Label lblElectionEndDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtElectionStartTime;
        private System.Windows.Forms.DateTimePicker dtElectionEndTime;
        private System.Windows.Forms.Button btnDeleteElection;
    }
}