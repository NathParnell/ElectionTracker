using ElectionTracker.Models;
using ElectionTracker.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ElectionTracker.Forms
{
    public partial class frmVote : Form
    {
        private readonly IUserService _userService;
        private readonly IElectionService _electionService;
        private List<Candidate> _candidates;
        private Election _election;
        private string _voteMethod;

        public frmVote(IElectionService electionService, IUserService userService, Election election, string voteMethod)
        {
            InitializeComponent();
            _electionService = electionService;
            _userService = userService;
            _election = election;
            _voteMethod = voteMethod;
        }

        private void frmVote_Load(object sender, EventArgs e)
        {
            _candidates = _electionService.GetCandidatesByElection(_election);

            Vote existingUserVote = _electionService.CheckIfUserHasVoted(_candidates);

            if (existingUserVote.VoteID != null && _voteMethod == "ElectionTracker")
            {
                //I used this to learn how to create a message box with buttons - https://stackoverflow.com/questions/5414270/messagebox-buttons
                if (MessageBox.Show("You have already voted in this Election. Would you like to delete your existing vote so you can vote again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _electionService.DeleteVote(existingUserVote);
                }
                else
                {
                    this.Dispose();
                }
            }

            foreach (Candidate candidate in _candidates)
            {
                cmbCandidate.Items.Add(candidate.Forename + " " + candidate.Surname);
            }
        }


        private void btnVote_Click(object sender, EventArgs e)
        {
            string selectedCandidateID = _candidates[cmbCandidate.SelectedIndex].CandidateID;

            Vote newVote = new Vote(selectedCandidateID, _userService.CurrentUser.UserID, _voteMethod);

            bool voteCreated = _electionService.CreateVote(newVote);

            if (voteCreated)
            {
                this.Dispose();
            }

        }
    }
}
