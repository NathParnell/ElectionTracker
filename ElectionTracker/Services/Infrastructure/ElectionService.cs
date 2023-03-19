using ElectionTracker.Logger;
using ElectionTracker.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ElectionTracker.Services.Infrastructure
{
    public class ElectionService: IElectionService
    {
        private readonly ILog _log = LogFactory.SetFileLogger("ElectionService");
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
            try
            {
                ElectionGroup newElectiongroup = new ElectionGroup(name, description);
                _dataService.CreateElectionGroup(newElectiongroup);

                CreateElectionGroupMembership(newElectiongroup, "Administrator");

                _log.Info($"Election {newElectiongroup.ElectionGroupID} Created Successfully");
                return true;
            }
            catch(Exception ex)
            {
                _log.Error(ex.Message.ToString());
                return false;
            }
        }

        public bool CheckElectionGroupNameIsUnique(string electionGroupName)
        {
            int electionGroupNameDuplicates = _dataService.CheckElectionGroupNameIsUnique(electionGroupName);
            if (electionGroupNameDuplicates == 0)
                return true;

            return false;
        }

        public void CreateElectionGroupMembership(ElectionGroup electionGroup, string userRole, User user = null) 
        {
            try
            {
                if (user == null)
                {
                    user = _userService.CurrentUser;
                }

                ElectionGroupMembership newMembership = new ElectionGroupMembership(electionGroup.ElectionGroupID, userRole, user.UserID);
                _dataService.CreateElectionGroupMembership(newMembership);
                _log.Info($" Election Group Membership {electionGroup.ElectionGroupID} created for {user.UserID}");
            }
            catch(Exception ex)
            {
                _log.Error(ex.Message.ToString());
            }
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
                _log.Info($"Election Group Membership Request {electionGroup.ElectionGroupID} created for {_userService.CurrentUser.UserID}");
                return true;
            }
            catch (Exception ex) 
            {
                _log.Error(ex.Message.ToString());
                return false;
            }
        }

        public bool AcceptElectionGroupMembershipRequest(ElectionGroupMembership electionGroupMembership)
        {
            _dataService.AcceptElectionGroupMembershipRequest(electionGroupMembership.ElectionGroupMembershipID);
            _log.Info($"Election Group Membership Request {electionGroupMembership.ElectionGroupID} accecpted for {electionGroupMembership.UserID}");
            return true;
        }

        public List<ElectionGroupMembership> GetUnacceptedElectionGroupMembershipRequests(ElectionGroup electionGroup)
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
        public bool ElectionValidator(Election election)
        {
            if (election.StartDate > election.EndDate)
            {
                return false;
            }

            return true;
        }

        public bool CreateElection(Election newElection)
        {
            try
            {
                _dataService.CreateElection(newElection);
                _log.Info($"Election {newElection.ElectionID} created in Election Group {newElection.ElectionGroupID}");
                return true;
            }
            catch(Exception ex)
            {
                _log.Error(ex.Message.ToString());
                return false;
            }
        }

        public bool UpdateElection(Election election)
        {
            try
            {
                _dataService.UpdateElection(election);
                _log.Info($"Election {election.ElectionID} Updated in Election Group {election.ElectionGroupID}");
                return true;
            }
            catch (Exception ex)
            {
                _log.Error(ex.Message.ToString());
                return false;
            }
        }

        public List<Election> GetElectionsbyElectionGroupID(string electionGroupID)
        {
            List<Election> elections = _dataService.GetElectionsByElectionGroupID(electionGroupID);
            return elections;
        }

        public Election GetElectionByElectionID(string electionID)
        {
            Election election = _dataService.GetElectionByElectionID(electionID);
            return election;
        }

        public bool DeleteElection(string electionID)
        {
            try
            {
                _dataService.DeleteElection(electionID);
                _dataService.DeleteVotesByElectionID(electionID);
                _log.Info($"Election {electionID} Deleted");
                return true;
            }
            catch(Exception ex)
            {
                _log.Error(ex.Message.ToString());
                return false;
            }
        }

        public bool CreateCandidate(Candidate candidate)
        {
            try
            {
                _dataService.CreateCandidate(candidate);
                _log.Info($"Candidate {candidate.CandidateID} created in Election {candidate.ElectionID}");
                return true;
            }
            catch(Exception ex)
            {
                _log.Error(ex.Message.ToString());
                return false;
            }
            
        }

        public List<Candidate> GetCandidatesByElection(Election election)
        {
            List<Candidate> candidates = _dataService.GetCandidatesByElectionID(election.ElectionID);
            return candidates;
        }

        /// <summary>
        /// We delete the candidates
        /// We also delete the votes for any candidates so nothing gets confised and also voters get their vote back
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns></returns>
        public bool DeleteCandidate(Candidate candidate)
        {
            try
            {
                _dataService.DeleteCandidate(candidate.CandidateID);
                _dataService.DeleteVotesByCandidateID(candidate.CandidateID);
                _log.Info($"Candidate {candidate.CandidateID} in Election {candidate.ElectionID} Deleted");
                return true;
            }
            catch (Exception ex)
            {
                _log.Error(ex.Message.ToString());
                return false;
            }
            
        }

        public bool CreateVote(Vote vote)
        {
            try
            {
                _dataService.CreateVote(vote);
                _log.Info($"Vote {vote.VoteID} Created for Candidate {vote.CandidateID}");
                return true;
            }
            catch(Exception ex)
            {
                _log.Error (ex.Message.ToString());
                return false;
            }

        }

        /// <summary>
        /// returns an empty vote if the user hasnt voted already
        /// </summary>
        /// <param name="candidates"></param>
        /// <returns></returns>
        public Vote CheckIfUserHasVoted(List<Candidate> candidates)
        {
            //method below contains any vote put through by the user for any election ever
            List<Vote> userVotes = GetVotesbyUser(_userService.CurrentUser);

            Vote userVote = new Vote();

            //goes through every vote
            // I used this to help me do a "foreach where" statement - https://stackoverflow.com/questions/25412158/foreach-loop-with-a-where-clause
            foreach (Vote vote in userVotes.Where(vote => vote.VoteMethod == VoteMethod.ElectionTracker))
            {
                foreach (Candidate candidate in candidates)
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

        public List<Vote> GetVotesbyUser(User User)
        {
            List<Vote> votes = _dataService.GetVotesByUserID(User.UserID);
            return votes;
        }

        public List<Vote> GetVotesbyCandidate(Candidate candidate)
        {
            List<Vote> votes = _dataService.GetVotesByCandidateID(candidate.CandidateID);
            _log.Info($"Candidate {candidate.CandidateID} Votes Viewed by User {_userService.CurrentUser.UserID}");
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
            try
            {
                _dataService.DeleteVote(vote.VoteID);
                _log.Info($"Vote {vote.VoteID} Deleted");
                return true;
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());
                return false;
            }

        }

    }  
}
