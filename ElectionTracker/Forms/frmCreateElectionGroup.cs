using ElectionTracker.Services;
using System;
using System.Windows.Forms;

namespace ElectionTracker
{
    public partial class frmCreateElectionGroup : Form
    {

        private readonly IUserService _userService;
        private readonly IElectionService _electionService;


        public frmCreateElectionGroup(IUserService userService, IElectionService electionService)
        {
            InitializeComponent();
            _userService = userService;
            _electionService = electionService;
        }



        private void btnCreateElectionGroup_Click(object sender, EventArgs e)
        {
            bool success = _electionService.CreateElectionGroup(txtElectionGroupName.Text, txtElectionGroupDescription.Text);
            if (success)
            {
                MessageBox.Show("Election group created");
                this.Dispose();
            }

        }
    }
}
