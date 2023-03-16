namespace ElectionTracker
{
    partial class frmCreateElectionGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateElectionGroup));
            this.lblElectionGroupName = new System.Windows.Forms.Label();
            this.txtElectionGroupName = new System.Windows.Forms.TextBox();
            this.txtElectionGroupDescription = new System.Windows.Forms.TextBox();
            this.lblElectionGroupDescription = new System.Windows.Forms.Label();
            this.btnCreateElectionGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblElectionGroupName
            // 
            this.lblElectionGroupName.AutoSize = true;
            this.lblElectionGroupName.Location = new System.Drawing.Point(49, 54);
            this.lblElectionGroupName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElectionGroupName.Name = "lblElectionGroupName";
            this.lblElectionGroupName.Size = new System.Drawing.Size(38, 13);
            this.lblElectionGroupName.TabIndex = 0;
            this.lblElectionGroupName.Text = "Name:";
            // 
            // txtElectionGroupName
            // 
            this.txtElectionGroupName.Location = new System.Drawing.Point(68, 69);
            this.txtElectionGroupName.Margin = new System.Windows.Forms.Padding(2);
            this.txtElectionGroupName.Name = "txtElectionGroupName";
            this.txtElectionGroupName.Size = new System.Drawing.Size(302, 20);
            this.txtElectionGroupName.TabIndex = 1;
            // 
            // txtElectionGroupDescription
            // 
            this.txtElectionGroupDescription.Location = new System.Drawing.Point(68, 132);
            this.txtElectionGroupDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtElectionGroupDescription.Name = "txtElectionGroupDescription";
            this.txtElectionGroupDescription.Size = new System.Drawing.Size(302, 20);
            this.txtElectionGroupDescription.TabIndex = 3;
            // 
            // lblElectionGroupDescription
            // 
            this.lblElectionGroupDescription.AutoSize = true;
            this.lblElectionGroupDescription.Location = new System.Drawing.Point(49, 116);
            this.lblElectionGroupDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElectionGroupDescription.Name = "lblElectionGroupDescription";
            this.lblElectionGroupDescription.Size = new System.Drawing.Size(63, 13);
            this.lblElectionGroupDescription.TabIndex = 2;
            this.lblElectionGroupDescription.Text = "Description:";
            // 
            // btnCreateElectionGroup
            // 
            this.btnCreateElectionGroup.Location = new System.Drawing.Point(158, 170);
            this.btnCreateElectionGroup.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateElectionGroup.Name = "btnCreateElectionGroup";
            this.btnCreateElectionGroup.Size = new System.Drawing.Size(114, 19);
            this.btnCreateElectionGroup.TabIndex = 4;
            this.btnCreateElectionGroup.Text = "Create";
            this.btnCreateElectionGroup.UseVisualStyleBackColor = true;
            this.btnCreateElectionGroup.Click += new System.EventHandler(this.btnCreateElectionGroup_Click);
            // 
            // frmCreateElectionGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(437, 210);
            this.Controls.Add(this.btnCreateElectionGroup);
            this.Controls.Add(this.txtElectionGroupDescription);
            this.Controls.Add(this.lblElectionGroupDescription);
            this.Controls.Add(this.txtElectionGroupName);
            this.Controls.Add(this.lblElectionGroupName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(453, 249);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(453, 249);
            this.Name = "frmCreateElectionGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Election Tracker - Create Election Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElectionGroupName;
        private System.Windows.Forms.TextBox txtElectionGroupName;
        private System.Windows.Forms.TextBox txtElectionGroupDescription;
        private System.Windows.Forms.Label lblElectionGroupDescription;
        private System.Windows.Forms.Button btnCreateElectionGroup;
    }
}