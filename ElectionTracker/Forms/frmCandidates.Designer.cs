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
            this.btnAddCandidate.Location = new System.Drawing.Point(39, 349);
            this.btnAddCandidate.Name = "btnAddCandidate";
            this.btnAddCandidate.Size = new System.Drawing.Size(120, 23);
            this.btnAddCandidate.TabIndex = 0;
            this.btnAddCandidate.Text = "Add Candidate";
            this.btnAddCandidate.UseVisualStyleBackColor = true;
            this.btnAddCandidate.Click += new System.EventHandler(this.btnAddCandidate_Click);
            // 
            // lblCandidateForename
            // 
            this.lblCandidateForename.AutoSize = true;
            this.lblCandidateForename.Location = new System.Drawing.Point(37, 215);
            this.lblCandidateForename.Name = "lblCandidateForename";
            this.lblCandidateForename.Size = new System.Drawing.Size(57, 13);
            this.lblCandidateForename.TabIndex = 1;
            this.lblCandidateForename.Text = "Forename:";
            // 
            // txtCandidateForename
            // 
            this.txtCandidateForename.Location = new System.Drawing.Point(100, 213);
            this.txtCandidateForename.Name = "txtCandidateForename";
            this.txtCandidateForename.Size = new System.Drawing.Size(122, 20);
            this.txtCandidateForename.TabIndex = 2;
            // 
            // lblCandidateSurname
            // 
            this.lblCandidateSurname.AutoSize = true;
            this.lblCandidateSurname.Location = new System.Drawing.Point(231, 215);
            this.lblCandidateSurname.Name = "lblCandidateSurname";
            this.lblCandidateSurname.Size = new System.Drawing.Size(52, 13);
            this.lblCandidateSurname.TabIndex = 3;
            this.lblCandidateSurname.Text = "Surname:";
            // 
            // txtCandidateSurname
            // 
            this.txtCandidateSurname.Location = new System.Drawing.Point(294, 213);
            this.txtCandidateSurname.Name = "txtCandidateSurname";
            this.txtCandidateSurname.Size = new System.Drawing.Size(122, 20);
            this.txtCandidateSurname.TabIndex = 4;
            // 
            // txtCandidateEmail
            // 
            this.txtCandidateEmail.Location = new System.Drawing.Point(100, 245);
            this.txtCandidateEmail.Name = "txtCandidateEmail";
            this.txtCandidateEmail.Size = new System.Drawing.Size(316, 20);
            this.txtCandidateEmail.TabIndex = 6;
            // 
            // lblCandidateEmail
            // 
            this.lblCandidateEmail.AutoSize = true;
            this.lblCandidateEmail.Location = new System.Drawing.Point(37, 248);
            this.lblCandidateEmail.Name = "lblCandidateEmail";
            this.lblCandidateEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCandidateEmail.TabIndex = 5;
            this.lblCandidateEmail.Text = "Email:";
            // 
            // txtCandidateDescription
            // 
            this.txtCandidateDescription.Location = new System.Drawing.Point(100, 278);
            this.txtCandidateDescription.Name = "txtCandidateDescription";
            this.txtCandidateDescription.Size = new System.Drawing.Size(316, 20);
            this.txtCandidateDescription.TabIndex = 8;
            // 
            // lblCandidateDescription
            // 
            this.lblCandidateDescription.AutoSize = true;
            this.lblCandidateDescription.Location = new System.Drawing.Point(37, 281);
            this.lblCandidateDescription.Name = "lblCandidateDescription";
            this.lblCandidateDescription.Size = new System.Drawing.Size(63, 13);
            this.lblCandidateDescription.TabIndex = 7;
            this.lblCandidateDescription.Text = "Description:";
            // 
            // txtCandidatePartyname
            // 
            this.txtCandidatePartyname.Location = new System.Drawing.Point(100, 313);
            this.txtCandidatePartyname.Name = "txtCandidatePartyname";
            this.txtCandidatePartyname.Size = new System.Drawing.Size(316, 20);
            this.txtCandidatePartyname.TabIndex = 10;
            // 
            // lblCandidatePartyname
            // 
            this.lblCandidatePartyname.AutoSize = true;
            this.lblCandidatePartyname.Location = new System.Drawing.Point(37, 316);
            this.lblCandidatePartyname.Name = "lblCandidatePartyname";
            this.lblCandidatePartyname.Size = new System.Drawing.Size(65, 13);
            this.lblCandidatePartyname.TabIndex = 9;
            this.lblCandidatePartyname.Text = "Party Name:";
            // 
            // btnDeleteCandidate
            // 
            this.btnDeleteCandidate.Location = new System.Drawing.Point(295, 349);
            this.btnDeleteCandidate.Name = "btnDeleteCandidate";
            this.btnDeleteCandidate.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteCandidate.TabIndex = 11;
            this.btnDeleteCandidate.Text = "Delete Candidate";
            this.btnDeleteCandidate.UseVisualStyleBackColor = true;
            this.btnDeleteCandidate.Click += new System.EventHandler(this.btnDeleteCandidate_Click);
            // 
            // cmbCandidates
            // 
            this.cmbCandidates.FormattingEnabled = true;
            this.cmbCandidates.Location = new System.Drawing.Point(86, 63);
            this.cmbCandidates.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCandidates.Name = "cmbCandidates";
            this.cmbCandidates.Size = new System.Drawing.Size(297, 21);
            this.cmbCandidates.TabIndex = 12;
            this.cmbCandidates.SelectedIndexChanged += new System.EventHandler(this.cmbCandidates_SelectedIndexChanged);
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.Location = new System.Drawing.Point(202, 351);
            this.btnNewEntry.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(56, 19);
            this.btnNewEntry.TabIndex = 13;
            this.btnNewEntry.Text = "New";
            this.btnNewEntry.UseVisualStyleBackColor = true;
            this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
            // 
            // lblSelectCandidate
            // 
            this.lblSelectCandidate.AutoSize = true;
            this.lblSelectCandidate.Location = new System.Drawing.Point(55, 48);
            this.lblSelectCandidate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectCandidate.Name = "lblSelectCandidate";
            this.lblSelectCandidate.Size = new System.Drawing.Size(91, 13);
            this.lblSelectCandidate.TabIndex = 14;
            this.lblSelectCandidate.Text = "Select Candidate:";
            // 
            // lblCandidateDetails
            // 
            this.lblCandidateDetails.AutoSize = true;
            this.lblCandidateDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateDetails.Location = new System.Drawing.Point(103, 160);
            this.lblCandidateDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCandidateDetails.Name = "lblCandidateDetails";
            this.lblCandidateDetails.Size = new System.Drawing.Size(286, 37);
            this.lblCandidateDetails.TabIndex = 15;
            this.lblCandidateDetails.Text = "Candidate Details";
            // 
            // frmCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 392);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCandidates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Election Tracker - Candidates";
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