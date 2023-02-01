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
            Vote existingUserVote = CheckIfUserHasVoted();

            if (existingUserVote != null && _voteMethod == "ElectionTracker")
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

            _candidates = _electionService.GetCandidatesByElection(_election);

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

        private Vote CheckIfUserHasVoted()
        {
            //method below contains any vote put through by the user for any election ever
            List<Vote> userVotes = _electionService.GetVotesbyUser(_userService.CurrentUser);


            Vote userVote = new Vote();

            //goes through every vote
            // I used this to help me do a "foreach where" statement - https://stackoverflow.com/questions/25412158/foreach-loop-with-a-where-clause
            foreach (Vote vote in userVotes.Where(vote => vote.VoteMethod == VoteMethod.ElectionTracker))
            {
                foreach(Candidate candidate in _candidates)
                {
                    if (candidate.CandidateID == vote.CandidateID)
                    {
                        userVote = vote;
                        return userVote;
                    }
                }
            }

            return userVote;
        }

    }
}
