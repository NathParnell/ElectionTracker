using ElectionTracker.Forms;
using ElectionTracker.Models;
using ElectionTracker.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ElectionTracker.Controls.FLPControls
{
    public partial class ctrElectionSelect : UserControl
    {
        private Election _election;
        private ElectionGroupUserRole _userRole;
        private readonly IElectionService _electionService;
        private readonly IUserService _userService;
        public event Action ElectionEdited;

        public ctrElectionSelect(Election election, ElectionGroupUserRole userRole, IElectionService electionService, IUserService userService)
        {
            _electionService = electionService;
            _election = election;
            _userRole = userRole;
            _userService = userService;
            InitializeComponent();
        }

        private void ctrElectionSelect_Load(object sender, EventArgs e)
        {
            //make a method which disables all controls
            DisableControls();
            PopulateControls();
            setControlColor();
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

        /// <summary>
        /// method checks whether the election is still active and if not it disables the button.
        /// It also uses color to show the status of the election
        /// </summary>
        private void setControlColor()
        {
            if (_election.StartDate.Date > DateTime.Now.Date || _election.EndDate.Date < DateTime.Now.Value)
            {
                this.BackColor = Color.Red;
                btnVote.Hide();
                btnAddBallotStationVote.Hide();
                btnAddPostalVote.Hide();
            }
            else if (DateTime.Now.AddDays(1).Date == _election.EndDate.Date)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = Color.Green;
            }
        }

        private void btnCandidates_Click(object sender, EventArgs e)
        {
            frmCandidates frmCandidates = new frmCandidates(_election, _electionService, _userRole);
            frmCandidates.ShowDialog();
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            frmVote frmVote = new frmVote(_electionService, _userService, _election, "ElectionTracker");
            frmVote.ShowDialog();
        }

        private void btnAddPostalVote_Click(object sender, EventArgs e)
        {
            frmVote frmVote = new frmVote(_electionService, _userService, _election, "Postal");
            frmVote.ShowDialog();
        }

        private void btnAddBallotStationVote_Click(object sender, EventArgs e)
        {
            frmVote frmVote = new frmVote(_electionService, _userService, _election, "BallotBox");
            frmVote.ShowDialog();
        }

        private void btnCountVotes_Click(object sender, EventArgs e)
        {
            frmCountVotes frmCountVotes = new frmCountVotes(_electionService, _election);
            frmCountVotes.ShowDialog();
        }

        private void btnEditElection_Click(object sender, EventArgs e)
        {
            frmManageElection frmManageElection = new frmManageElection(_electionService, _election.ElectionID);
            frmManageElection.ShowDialog();

            if (ElectionEdited != null)
            {
                ElectionEdited();
            }
        }
    }
}
