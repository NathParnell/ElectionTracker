using ElectionTracker.Services;
using ElectionTracker.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionTracker.Controls
{
    public partial class ctrMainMenu : UserControl
    {
        private readonly IUserService _userService;
        private readonly IElectionService _electionService;
        public ctrMainMenu(IUserService userService, IElectionService electionService)
        {
            InitializeComponent();
            _userService = userService;
            _electionService = electionService;
        }

        public void DisplayUserDetails()
        {
            try
            {
                lblCurrentUserName.Text = _userService.CurrentUser.Forename + " " + _userService.CurrentUser.Surname;
            }
            catch(Exception ex)
            {

            }
        }

        private void ctrMainMenu_Load(object sender, EventArgs e)
        {
            DisplayUserDetails();
        }


        private void btnCreateElectionGroup_Click(object sender, EventArgs e)
        {
            frmCreateElectionGroup frmCreateElectionGroup = new frmCreateElectionGroup(_userService, _electionService);
            frmCreateElectionGroup.ShowDialog();
        }

        private void btnElectionGroupRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
