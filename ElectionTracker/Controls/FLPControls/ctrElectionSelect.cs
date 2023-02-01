using ElectionTracker.Classes;
using ElectionTracker.Forms;
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

namespace ElectionTracker.Controls.FLPControls
{
    public partial class ctrElectionSelect : UserControl
    {
        private Election _election;
        private ElectionGroupUserRole _userRole;
        private IElectionService _electionService;

        public ctrElectionSelect(Election election, ElectionGroupUserRole userRole, IElectionService electionService)
        {
            _electionService = electionService;
            _election = election;
            _userRole = userRole;
            InitializeComponent();
        }

        private void ctrElectionSelect_Load(object sender, EventArgs e)
        {
            //make a method which disables all controls
            DisableControls();
            PopulateControls();
        }

        private void DisableControls()
        {
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.Hide();
            }
        }

        private void PopulateControls()
        {
            lblElectionName.Text = _election.Name;

            btnVote.Show();
            btnCandidates.Show();

            //check if auditor
            if ((int)_userRole <= 1)
            {
               btnAddPostalVote.Show();
               btnAddBallotStationVote.Show();
               btnCountVotes.Show();
            }

            if ((int)_userRole == 0)
            {
                btnEditElection.Show();
            }

        }

        private void btnCandidates_Click(object sender, EventArgs e)
        {
            frmCandidates frmCandidates = new frmCandidates(_election, _electionService, _userRole);
            frmCandidates.ShowDialog();
        }
    }
}
