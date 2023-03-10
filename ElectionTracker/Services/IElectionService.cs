using ElectionTracker.Models;
using System.Collections.Generic;

namespace ElectionTracker.Services
{
    public interface IElectionService
    {
        ElectionGroup SelectedElectionGroup { get; set; }
        void SetSelectedElectionGroup(ElectionGroup selectedElectionGroup);
        bool CreateElectionGroup(string name, string description);
        void CreateElectionGroupMembership(ElectionGroup electionGroup, string userRole, User user = null);
        List<ElectionGroup> GetAllElectionGroups();
        List<ElectionGroup> GetElectionGroupsUserIsNotAPartOf(User user = null);
        List<ElectionGroupMembership> GetUserElectionGroupMemberships(User user = null);
        ElectionGroupUserRole GetUserRole();
        bool JoinElectionGroupRequest(string name, string userRole);
        bool AcceptElectionGroupMembershipRequest(ElectionGroupMembership electionGroupMembership);
        List<ElectionGroupMembership> GetUnacceptedElectionGroupMembershipRequests(ElectionGroup electionGroup);
        bool NewElectionValidator(Election election);
        bool CreateElection(Election newElection);
        List<Election> GetElectionsbyElectionGroupID(string electionGroupID);
        bool CreateCandidate(Candidate candidate);
        List<Candidate> GetCandidatesByElection(Election election);
        bool DeleteCandidate(Candidate candidate);
        bool CreateVote(Vote vote);
        Vote CheckIfUserHasVoted(List<Candidate> candidates);
        List<Vote> GetVotesbyUser(User user);
        List<Vote> GetVotesbyCandidate(Candidate candidate);
        Candidate GetElectionWinner(Election election);
        bool DeleteVote(Vote vote);
    }
}
