using ElectionTracker.Classes;
using ElectionTracker.Controls.FLPControls;
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
    public partial class frmCountVotes : Form
    {
        private readonly IUserService _userService;
        private readonly IElectionService _electionService;
        private Election _election;

        public frmCountVotes(IElectionService electionService, IUserService userService, Election election)
        {
            InitializeComponent();
            _electionService = electionService;
            _userService = userService;
            _election = election;
        }

        private void frmCountVotes_Load(object sender, EventArgs e)
        {
            checkWinner();
            displayCandidateVotes();
        }

        private void checkWinner()
        {
            if (_election.EndDate < DateTime.Now)
            {
                Candidate winningCandidate = _electionService.GetElectionWinner(_election);
                MessageBox.Show("The winner of this election is " + winningCandidate.Forename + " " + winningCandidate.Surname);
            }
        }


        private void displayCandidateVotes()
        {
            List<Candidate> candidates = _electionService.GetCandidatesByElection(_election);

            foreach (Candidate candidate in candidates)
            {
                List<Vote> candidateVotes = _electionService.GetVotesbyCandidate(candidate);

                var candidateVoteControl = new ctrCandidateVote(candidate.Forename + " " + candidate.Surname, candidateVotes.Count);
            }
        }

    }
}
