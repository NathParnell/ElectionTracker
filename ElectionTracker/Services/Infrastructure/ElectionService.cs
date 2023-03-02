using ElectionTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectionTracker.Services.Infrastructure
{
    public class ElectionService: IElectionService
    {
        private readonly IUserService _userService;
        private readonly IDataService _dataService;

        public ElectionService(IUserService userService, IDataService dataService) 
        {
            _userService = userService;
            _dataService = dataService;
        }

        public ElectionGroup SelectedElectionGroup { get; set; }

        public void SetSelectedElectionGroup(ElectionGroup selectedElectionGroup)
        {
            this.SelectedElectionGroup = selectedElectionGroup;
        }

        public bool CreateElectionGroup(string name, string description)
        {
            ElectionGroup newElectiongroup = new ElectionGroup(name, description);
            _dataService.CreateElectionGroup(newElectiongroup);

            CreateElectionGroupMembership(newElectiongroup, "Administrator");
            return true;
        }

        public void CreateElectionGroupMembership(ElectionGroup electionGroup, string userRole, User user = null) 
        {
            if (user == null)
            {
                user = _userService.CurrentUser;
            }

            ElectionGroupMembership newMembership = new ElectionGroupMembership(electionGroup.ElectionGroupID, userRole, user.UserID);
            _dataService.CreateElectionGroupMembership(newMembership);
            return;

        }

        public List<ElectionGroup> GetAllElectionGroups()
        {
            List<ElectionGroup> electionGroups = _dataService.GetAllElectionGroups();
            return electionGroups;
        }

        public List<ElectionGroup> GetElectionGroupsUserIsNotAPartOf(User user = null)
        {
            if (user == null)
                user = _userService.CurrentUser;


            List<ElectionGroup> electionGroups = _dataService.GetAllElectionGroups();
            List<string> userElectionGroupIDs = _dataService.GetUserElectionGroupIDs(user.UserID);


            //I experienced an error when removing objects from this list and i found the solution using this link - https://www.tutorialspoint.com/why-the-error-collection-was-modified-enumeration-operation-may-not-execute-occurs-and-how-to-handle-it-in-chash
            foreach (string userElectionGroupID in userElectionGroupIDs)
            {
                foreach (ElectionGroup electionGroup in electionGroups.ToList())
                {
                    if (electionGroup.ElectionGroupID == userElectionGroupID)
                    {
                        electionGroups.Remove(electionGroup);
                    }
                }
            }
            return electionGroups;
        }

        public List<ElectionGroupMembership> GetUserElectionGroupMemberships(User user = null)
        {
            if (user == null)
                user = _userService.CurrentUser;
            List<ElectionGroupMembership> userElectionGroupMembership = _dataService.GetUserElectionGroupMemberships(user.UserID);

            return userElectionGroupMembership;
        }

        /// <summary>
        /// Gets the user role of a user relative to the Election group they are in, and it converts the value into the correct type.
        /// </summary>
        /// <returns></returns>
        public ElectionGroupUserRole GetUserRole()
        {
            ElectionGroupUserRole userRole = (ElectionGroupUserRole) int.Parse(_dataService.GetUserRole(_userService.CurrentUser.UserID, SelectedElectionGroup.ElectionGroupID)); ;

            return userRole;
        }

        public bool JoinElectionGroupRequest(string name, string userRole)
        {
            try
            {
                ElectionGroup electionGroup = _dataService.GetElectionGroupByName(name);
                ElectionGroupMembership electionGroupMembershipRequest = new ElectionGroupMembership(electionGroup.ElectionGroupID, userRole, _userService.CurrentUser.UserID);
                _dataService.CreateElectionGroupMembership(electionGroupMembershipRequest);
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public bool AcceptElectionGroupRequest(ElectionGroupMembership electionGroupMembership)
        {
            _dataService.AcceptElectionGroupRequest(electionGroupMembership.ElectionGroupMembershipID);
            return true;
        }

        public List<ElectionGroupMembership> GetUnacceptedElectionGroupRequests(ElectionGroup electionGroup)
        {
            List<ElectionGroupMembership> unacceptedElectionGroupRequests = _dataService.GetUnaccpetedElectionGroupMembershipsForGroup(electionGroup.ElectionGroupID);
            return unacceptedElectionGroupRequests;
        }

        /// <summary>
        /// method takes in the new election object and runs checks on it
        /// Checks that the start date is before the end date
        /// </summary>
        /// <param name="election"></param>
        /// <returns>boolean confirming whether election passed validation</returns>
        public bool NewElectionValidator(Election election)
        {
            if (election.StartDate > election.EndDate)
            {
                return false;
            }

            return true;
        }

        public bool CreateElection(Election newElection)
        {
            //I need to create a DataService method which will add in an election to the database 
            _dataService.CreateElection(newElection);
            return true;
        }

        public List<Election> GetElectionsbyElectionGroupID(string electionGroupID)
        {
            List<Election> elections = _dataService.GetElectionsByElectionGroupID(electionGroupID);
            return elections;
        }

        public bool CreateCandidate(Candidate candidate)
        {
            _dataService.CreateCandidate(candidate);
            return true;
        }

        public List<Candidate> GetCandidatesByElection(Election election)
        {
            List<Candidate> candidates = _dataService.GetCandidatesByElectionID(election.ElectionID);
            return candidates;
        }

        public bool DeleteCandidate(Candidate candidate)
        {
            _dataService.DeleteCandidate(candidate.CandidateID);
            return true;
        }

        public bool CreateVote(Vote vote)
        {
            _dataService.CreateVote(vote);
            return true;
        }

        public List<Vote> GetVotesbyUser(User User)
        {
            List<Vote> votes = _dataService.GetVotesByUserID(User.UserID);
            return votes;
        }

        public List<Vote> GetVotesbyCandidate(Candidate candidate)
        {
            List<Vote> votes = _dataService.GetVotesByCandidateID(candidate.CandidateID);
            return votes;
        }

        /// <summary>
        /// method which counts the votes of each candidate in an election and then returns the candidate with the most votes
        /// </summary>
        /// <param name="election"></param>
        /// <returns></returns>
        public Candidate GetElectionWinner(Election election)
        {
            List<Candidate> electionCandidates = GetCandidatesByElection(election);
            List<int> numOfVotes = new List<int>();

            foreach(Candidate candidate in electionCandidates)
            {
                numOfVotes.Add(GetVotesbyCandidate(candidate).Count());
            }

            return electionCandidates[numOfVotes.IndexOf(numOfVotes.Max())];

        }

        public bool DeleteVote(Vote vote)
        {
            _dataService.DeleteVote(vote.VoteID);
            return true;
        }

    }

   
}
