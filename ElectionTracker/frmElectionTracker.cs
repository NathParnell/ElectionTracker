using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionTracker
{
    public partial class frmElectionTracker : Form
    {
        public frmElectionTracker()
        {
            InitializeComponent();
        }

        private void frmElectionTracker_Load(object sender, EventArgs e)
        {
            GenerateLoginControl();
        }

        /// <summary>
        /// Method to check if the panel is clear and if not it clears it
        /// </summary>
        private void ClearPanel()
        {
            if (pnlElectionTracker.Controls.Count != 0){
                pnlElectionTracker.Controls.Clear();
            }
        }

        private void GenerateLoginControl()
        {
            ClearPanel();
            var loginControl = new ElectionTracker.Controls.ctrLogin();
            loginControl.RegisterClicked += GenerateRegistrationControl;
            pnlElectionTracker.Controls.Add(loginControl);
        }

        private void GenerateRegistrationControl()
        {
            ClearPanel();
            var registrationControl = new ElectionTracker.Controls.ctrRegister();

            pnlElectionTracker.Controls.Add(registrationControl);
        }
    }
    
}
