using ElectionTracker.Classes;
using ElectionTracker.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
