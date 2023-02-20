using ElectionTracker.Models;
using System;
using System.Windows.Forms;

namespace ElectionTracker.Controls.FLPControls
{
    public partial class ctrElectionGroup : UserControl
    {
        private ElectionGroupMembership _userElectionGroupMembership;
        private ElectionGroup _userElectionGroup;

        public event Action<ElectionGroup> ElectionGroupClicked;

        public ctrElectionGroup(ElectionGroupMembership userElectionGroupMembership, ElectionGroup userElectionGroup)
        {
            _userElectionGroupMembership = userElectionGroupMembership;
            _userElectionGroup = userElectionGroup;

            InitializeComponent();


        }

        private void ctrElectionGroup_Load(object sender, EventArgs e)
        {
            lblRole.Text = _userElectionGroupMembership.UserRole.ToString();
            lblElectionGroupName.Text = _userElectionGroup.Name.ToString();
        }

        private void electionGroupClicked(object sender, EventArgs e)
        {
            if (ElectionGroupClicked != null)
            {
                ElectionGroupClicked(_userElectionGroup);
            }
        }
    }
}
