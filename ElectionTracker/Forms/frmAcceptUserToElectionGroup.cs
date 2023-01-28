using ElectionTracker.Classes;
using ElectionTracker.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionTracker.Forms
{
    public partial class frmAcceptUserToElectionGroup : Form
    {
        private readonly IUserService _userService;
        private readonly IElectionService _electionService;

        private List<ElectionGroupMembership> unacceptedElectionGroupMemberships;

        public frmAcceptUserToElectionGroup(IUserService userService, IElectionService electionService)
        {
            _userService = userService;
            _electionService = electionService;
            InitializeComponent();
        }

        private void frmAcceptUserToElectionGroup_Load(object sender, EventArgs e)
        {
            unacceptedElectionGroupMemberships = _electionService.GetUnacceptedElectionGroupRequests(_electionService.SelectedElectionGroup);
            foreach(ElectionGroupMembership unacceptedElectionGroupMembership in unacceptedElectionGroupMemberships)
            {
                cmbSelectCustomer.Items.Add(unacceptedElectionGroupMembership.UserID) ;
            }
        }
    }
}
