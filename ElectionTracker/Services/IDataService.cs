using ElectionTracker.Models;
using System.Collections.Generic;

namespace ElectionTracker.Services
{
    public interface IDataService
    {
        void CreateUser(User user);
        void CreateElectionGroup(ElectionGroup electiongroup);
        void CreateElectionGroupMembership(ElectionGroupMembership electionGroupMembership);
        void CreateElection(Election election);
        void CreateCandidate(Candidate candidate);
        void CreateVote (Vote vote);
        void AcceptElectionGroupMembershipRequest(string electionGroupMembershipID);
        void UpdateElection(Election election);
        int CheckEmailIsUnique(string email);
        List<User> GetAllUsers();
        User GetUserByUserID(string userID);
        User GetUserByEmail(string email);
        List<ElectionGroup> GetAllElectionGroups();
        ElectionGroup GetElectionGroupByName(string electionName);
        List<string> GetUserElectionGroupIDs(string userID);
        List<ElectionGroupMembership> GetUserElectionGroupMemberships(string userID);
        List<ElectionGroupMembership> GetUnaccpetedElectionGroupMembershipsForGroup(string electionID);
        string GetUserRole(string userID, string electionGroupID);
        List<Election> GetAllElections();
        List<Election> GetElectionsByElectionGroupID(string electionGroupID);
        Election GetElectionByElectionID(string electionID);
        List<Candidate> GetCandidatesByElectionID(string electionID);
        List<Vote> GetVotesByUserID(string userID);
        List<Vote> GetVotesByCandidateID(string candidateID);
        string GetPassword(string email);
        string GetPasswordSalt(string email);
        void DeleteCandidate(string candidateID);
        void DeleteElection(string electionId);
        void DeleteVote(string voteID);
        void DeleteVotesByCandidateID(string candidateID);
        void DeleteVotesByElectionID(string electionID);

        string LoadConnectionString(string id = "Default");
    }
}
