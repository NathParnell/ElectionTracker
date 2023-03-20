using ElectionTracker.Models;
using System.Collections.Generic;

namespace ElectionTracker.Services
{
    public interface IElectionService
    {
        ElectionGroup SelectedElectionGroup { get; set; }
        void SetSelectedElectionGroup(ElectionGroup selectedElectionGroup);
        bool CreateElectionGroup(string name, string description);
        bool CheckElectionGroupNameIsUnique(string electionGroupName);
        void CreateElectionGroupMembership(ElectionGroup electionGroup, string userRole, User user = null);
        List<ElectionGroup> GetAllElectionGroups();
        List<ElectionGroup> GetElectionGroupsUserIsNotAPartOf(User user = null);
        List<ElectionGroupMembership> GetUserElectionGroupMemberships(User user = null);

        /// <summary>
        /// Gets the user role of a user relative to the Election group they are in, and it converts the value into the correct type.
        /// </summary>
        /// <returns></returns>
        ElectionGroupUserRole GetUserRole();
        bool JoinElectionGroupRequest(string name, string userRole);
        bool AcceptElectionGroupMembershipRequest(ElectionGroupMembership electionGroupMembership);
        List<ElectionGroupMembership> GetUnacceptedElectionGroupMembershipRequests(ElectionGroup electionGroup);

        /// <summary>
        /// method takes in the new election object and runs checks on it
        /// Checks that the start date is before the end date
        /// </summary>
        /// <param name="election"></param>
        /// <returns>boolean confirming whether election passed validation</returns>
        bool ElectionDateValidator(Election election);

        /// <summary>
        /// Method which checks whether the election name has already been taken but I have added in a barrier for edited elections.
        /// </summary>
        /// <param name="election"></param>
        /// <returns></returns>
        bool ElectionNameValidator(Election election);
        bool CreateElection(Election newElection);
        bool UpdateElection(Election election);
        List<Election> GetElectionsbyElectionGroupID(string electionGroupID);
        Election GetElectionByElectionID(string electionID);
        bool DeleteElection(string electionID);
        bool CreateCandidate(Candidate candidate);
        List<Candidate> GetCandidatesByElection(Election election);

        /// <summary>
        /// We delete the candidates
        /// We also delete the votes for any candidates so nothing gets confised and also voters get their vote back
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns></returns>
        bool DeleteCandidate(Candidate candidate);
        bool CreateVote(Vote vote);

        /// <summary>
        /// returns an empty vote if the user hasnt voted already
        /// </summary>
        /// <param name="candidates"></param>
        /// <returns></returns>
        Vote CheckIfUserHasVoted(List<Candidate> candidates);
        List<Vote> GetVotesbyUser(User user);
        List<Vote> GetVotesbyCandidate(Candidate candidate);

        /// <summary>
        /// method which counts the votes of each candidate in an election and then returns the candidate with the most votes
        /// </summary>
        /// <param name="election"></param>
        /// <returns></returns>
        Candidate GetElectionWinner(Election election);
        bool DeleteVote(Vote vote);
    }
}
