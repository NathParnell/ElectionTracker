namespace ElectionTracker.Forms
{
    partial class frmCandidates
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
            this.btnAddCandidate = new System.Windows.Forms.Button();
            this.lblCandidateForename = new System.Windows.Forms.Label();
            this.txtCandidateForename = new System.Windows.Forms.TextBox();
            this.lblCandidateSurname = new System.Windows.Forms.Label();
            this.txtCandidateSurname = new System.Windows.Forms.TextBox();
            this.txtCandidateEmail = new System.Windows.Forms.TextBox();
            this.lblCandidateEmail = new System.Windows.Forms.Label();
            this.txtCandidateDescription = new System.Windows.Forms.TextBox();
            this.lblCandidateDescription = new System.Windows.Forms.Label();
            this.txtCandidatePartyname = new System.Windows.Forms.TextBox();
            this.lblCandidatePartyname = new System.Windows.Forms.Label();
            this.btnDeleteCandidate = new System.Windows.Forms.Button();
            this.cmbCandidates = new System.Windows.Forms.ComboBox();
            this.btnNewEntry = new System.Windows.Forms.Button();
            this.lblSelectCandidate = new System.Windows.Forms.Label();
            this.lblCandidateDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCandidate
            // 
            this.btnAddCandidate.Location = new System.Drawing.Point(124, 562);
            this.btnAddCandidate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCandidate.Name = "btnAddCandidate";
            this.btnAddCandidate.Size = new System.Drawing.Size(160, 28);
            this.btnAddCandidate.TabIndex = 0;
            this.btnAddCandidate.Text = "Add Candidate";
            this.btnAddCandidate.UseVisualStyleBackColor = true;
            this.btnAddCandidate.Click += new System.EventHandler(this.btnAddCandidate_Click);
            // 
            // lblCandidateForename
            // 
            this.lblCandidateForename.AutoSize = true;
            this.lblCandidateForename.Location = new System.Drawing.Point(40, 398);
            this.lblCandidateForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCandidateForename.Name = "lblCandidateForename";
            this.lblCandidateForename.Size = new System.Drawing.Size(72, 16);
            this.lblCandidateForename.TabIndex = 1;
            this.lblCandidateForename.Text = "Forename:";
            // 
            // txtCandidateForename
            // 
            this.txtCandidateForename.Location = new System.Drawing.Point(124, 395);
            this.txtCandidateForename.Margin = new System.Windows.Forms.Padding(4);
            this.txtCandidateForename.Name = "txtCandidateForename";
            this.txtCandidateForename.Size = new System.Drawing.Size(161, 22);
            this.txtCandidateForename.TabIndex = 2;
            // 
            // lblCandidateSurname
            // 
            this.lblCandidateSurname.AutoSize = true;
            this.lblCandidateSurname.Location = new System.Drawing.Point(299, 398);
            this.lblCandidateSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCandidateSurname.Name = "lblCandidateSurname";
            this.lblCandidateSurname.Size = new System.Drawing.Size(64, 16);
            this.lblCandidateSurname.TabIndex = 3;
            this.lblCandidateSurname.Text = "Surname:";
            // 
            // txtCandidateSurname
            // 
            this.txtCandidateSurname.Location = new System.Drawing.Point(383, 395);
            this.txtCandidateSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtCandidateSurname.Name = "txtCandidateSurname";
            this.txtCandidateSurname.Size = new System.Drawing.Size(161, 22);
            this.txtCandidateSurname.TabIndex = 4;
            // 
            // txtCandidateEmail
            // 
            this.txtCandidateEmail.Location = new System.Drawing.Point(124, 434);
            this.txtCandidateEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtCandidateEmail.Name = "txtCandidateEmail";
            this.txtCandidateEmail.Size = new System.Drawing.Size(420, 22);
            this.txtCandidateEmail.TabIndex = 6;
            // 
            // lblCandidateEmail
            // 
            this.lblCandidateEmail.AutoSize = true;
            this.lblCandidateEmail.Location = new System.Drawing.Point(40, 438);
            this.lblCandidateEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCandidateEmail.Name = "lblCandidateEmail";
            this.lblCandidateEmail.Size = new System.Drawing.Size(44, 16);
            this.lblCandidateEmail.TabIndex = 5;
            this.lblCandidateEmail.Text = "Email:";
            // 
            // txtCandidateDescription
            // 
            this.txtCandidateDescription.Location = new System.Drawing.Point(124, 475);
            this.txtCandidateDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtCandidateDescription.Name = "txtCandidateDescription";
            this.txtCandidateDescription.Size = new System.Drawing.Size(420, 22);
            this.txtCandidateDescription.TabIndex = 8;
            // 
            // lblCandidateDescription
            // 
            this.lblCandidateDescription.AutoSize = true;
            this.lblCandidateDescription.Location = new System.Drawing.Point(40, 479);
            this.lblCandidateDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCandidateDescription.Name = "lblCandidateDescription";
            this.lblCandidateDescription.Size = new System.Drawing.Size(78, 16);
            this.lblCandidateDescription.TabIndex = 7;
            this.lblCandidateDescription.Text = "Description:";
            // 
            // txtCandidatePartyname
            // 
            this.txtCandidatePartyname.Location = new System.Drawing.Point(124, 518);
            this.txtCandidatePartyname.Margin = new System.Windows.Forms.Padding(4);
            this.txtCandidatePartyname.Name = "txtCandidatePartyname";
            this.txtCandidatePartyname.Size = new System.Drawing.Size(420, 22);
            this.txtCandidatePartyname.TabIndex = 10;
            // 
            // lblCandidatePartyname
            // 
            this.lblCandidatePartyname.AutoSize = true;
            this.lblCandidatePartyname.Location = new System.Drawing.Point(40, 522);
            this.lblCandidatePartyname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCandidatePartyname.Name = "lblCandidatePartyname";
            this.lblCandidatePartyname.Size = new System.Drawing.Size(81, 16);
            this.lblCandidatePartyname.TabIndex = 9;
            this.lblCandidatePartyname.Text = "Party Name:";
            // 
            // btnDeleteCandidate
            // 
            this.btnDeleteCandidate.Location = new System.Drawing.Point(349, 562);
            this.btnDeleteCandidate.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCandidate.Name = "btnDeleteCandidate";
            this.btnDeleteCandidate.Size = new System.Drawing.Size(160, 28);
            this.btnDeleteCandidate.TabIndex = 11;
            this.btnDeleteCandidate.Text = "Delete Candidate";
            this.btnDeleteCandidate.UseVisualStyleBackColor = true;
            this.btnDeleteCandidate.Click += new System.EventHandler(this.btnDeleteCandidate_Click);
            // 
            // cmbCandidates
            // 
            this.cmbCandidates.FormattingEnabled = true;
            this.cmbCandidates.Location = new System.Drawing.Point(114, 78);
            this.cmbCandidates.Name = "cmbCandidates";
            this.cmbCandidates.Size = new System.Drawing.Size(395, 24);
            this.cmbCandidates.TabIndex = 12;
            this.cmbCandidates.SelectedIndexChanged += new System.EventHandler(this.cmbCandidates_SelectedIndexChanged);
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.Location = new System.Drawing.Point(278, 608);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(75, 23);
            this.btnNewEntry.TabIndex = 13;
            this.btnNewEntry.Text = "New";
            this.btnNewEntry.UseVisualStyleBackColor = true;
            this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
            // 
            // lblSelectCandidate
            // 
            this.lblSelectCandidate.AutoSize = true;
            this.lblSelectCandidate.Location = new System.Drawing.Point(73, 59);
            this.lblSelectCandidate.Name = "lblSelectCandidate";
            this.lblSelectCandidate.Size = new System.Drawing.Size(113, 16);
            this.lblSelectCandidate.TabIndex = 14;
            this.lblSelectCandidate.Text = "Select Candidate:";
            // 
            // lblCandidateDetails
            // 
            this.lblCandidateDetails.AutoSize = true;
            this.lblCandidateDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateDetails.Location = new System.Drawing.Point(128, 330);
            this.lblCandidateDetails.Name = "lblCandidateDetails";
            this.lblCandidateDetails.Size = new System.Drawing.Size(351, 46);
            this.lblCandidateDetails.TabIndex = 15;
            this.lblCandidateDetails.Text = "Candidate Details";
            // 
            // frmCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 667);
            this.Controls.Add(this.lblCandidateDetails);
            this.Controls.Add(this.lblSelectCandidate);
            this.Controls.Add(this.btnNewEntry);
            this.Controls.Add(this.cmbCandidates);
            this.Controls.Add(this.btnDeleteCandidate);
            this.Controls.Add(this.txtCandidatePartyname);
            this.Controls.Add(this.lblCandidatePartyname);
            this.Controls.Add(this.txtCandidateDescription);
            this.Controls.Add(this.lblCandidateDescription);
            this.Controls.Add(this.txtCandidateEmail);
            this.Controls.Add(this.lblCandidateEmail);
            this.Controls.Add(this.txtCandidateSurname);
            this.Controls.Add(this.lblCandidateSurname);
            this.Controls.Add(this.txtCandidateForename);
            this.Controls.Add(this.lblCandidateForename);
            this.Controls.Add(this.btnAddCandidate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCandidates";
            this.Text = "Candidates";
            this.Load += new System.EventHandler(this.frmCandidates_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCandidate;
        private System.Windows.Forms.Label lblCandidateForename;
        private System.Windows.Forms.TextBox txtCandidateForename;
        private System.Windows.Forms.Label lblCandidateSurname;
        private System.Windows.Forms.TextBox txtCandidateSurname;
        private System.Windows.Forms.TextBox txtCandidateEmail;
        private System.Windows.Forms.Label lblCandidateEmail;
        private System.Windows.Forms.TextBox txtCandidateDescription;
        private System.Windows.Forms.Label lblCandidateDescription;
        private System.Windows.Forms.TextBox txtCandidatePartyname;
        private System.Windows.Forms.Label lblCandidatePartyname;
        private System.Windows.Forms.Button btnDeleteCandidate;
        private System.Windows.Forms.ComboBox cmbCandidates;
        private System.Windows.Forms.Button btnNewEntry;
        private System.Windows.Forms.Label lblSelectCandidate;
        private System.Windows.Forms.Label lblCandidateDetails;
    }
}