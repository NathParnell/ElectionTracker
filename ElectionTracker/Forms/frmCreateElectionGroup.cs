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
            if (String.IsNullOrEmpty(txtElectionGroupName.Text) || String.IsNullOrEmpty(txtElectionGroupDescription.Text))
            {
                MessageBox.Show("Please ensure you have entered both a Name and Description for your Election Group!");
                return;
            }

            if (!_electionService.CheckElectionGroupNameIsUnique(txtElectionGroupName.Text))
            {
                MessageBox.Show("This Election Group name is already in use. Please Rename this Election Group");
                return;
            }

            bool success = _electionService.CreateElectionGroup(txtElectionGroupName.Text, txtElectionGroupDescription.Text);
            if (success)
            {
                MessageBox.Show("Election Group created");
                this.Dispose();
            }

        }
    }
}
