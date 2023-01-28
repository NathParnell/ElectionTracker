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
            this.cmbSelectCustomer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbSelectCustomer
            // 
            this.cmbSelectCustomer.FormattingEnabled = true;
            this.cmbSelectCustomer.Location = new System.Drawing.Point(60, 52);
            this.cmbSelectCustomer.Name = "cmbSelectCustomer";
            this.cmbSelectCustomer.Size = new System.Drawing.Size(344, 21);
            this.cmbSelectCustomer.TabIndex = 0;
            // 
            // frmAcceptUserToElectionGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(596, 620);
            this.Controls.Add(this.cmbSelectCustomer);
            this.Name = "frmAcceptUserToElectionGroup";
            this.Text = "frmAcceptUserToElectionGroup";
            this.Load += new System.EventHandler(this.frmAcceptUserToElectionGroup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectCustomer;
    }
}