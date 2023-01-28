using ElectionTracker.Classes;
using ElectionTracker.Forms;
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
    public partial class ctrElectionGroupManager : UserControl
    {
        private readonly IUserService _userService;
        private readonly IElectionService _electionService;
        private ElectionGroup _electionGroup;

        public ctrElectionGroupManager(IElectionService electionService, IUserService userService)
        {
            _electionService = electionService;
            _userService = userService;
            InitializeComponent();
        }

        private void ctrElectionGroupManager_Load(object sender, EventArgs e)
        {
            _electionGroup = _electionService.SelectedElectionGroup;

            lblElectionGroupName.Text = _electionGroup.Name;
        }

        private void btnCreateElection_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAcceptElectionGroupMembers_Click(object sender, EventArgs e)
        {
            frmAcceptUserToElectionGroup frmAcceptUserToElectionGroup = new frmAcceptUserToElectionGroup(_userService, _electionService);
            frmAcceptUserToElectionGroup.ShowDialog();
        }
    }
}
