using ElectionTracker.Models;
using System.Collections.Generic;

namespace ElectionTracker.Services
{
    public interface IDataService
    {
        /// <summary>
        /// DataService method which adds a User to the User Table in the database
        /// </summary>
        /// <param name="user"></param>
        void CreateUser(User user);

        /// <summary>
        /// DataService method which adds an Election Group to the Election Group Table in the database
        /// </summary>
        /// <param name="electionGroup"></param>
        void CreateElectionGroup(ElectionGroup electiongroup);

        /// <summary>
        /// DataService method which adds an Election Group Membership to the Election Group Membership Table in the database
        /// </summary>
        /// <param name="electionGroupMembership"></param>
        void CreateElectionGroupMembership(ElectionGroupMembership electionGroupMembership);

        /// <summary>
        /// DataService method which adds an Election To the Election Table in the database
        /// </summary>
        /// <param name="election"></param>
        void CreateElection(Election election);

        /// <summary>
        /// DataService method which adds a Candidate To the Candidate Table in the database
        /// </summary>
        /// <param name="candidate"></param>
        void CreateCandidate(Candidate candidate);

        /// <summary>
        /// DataService method which adds a Vote To the Vote Table in the database
        /// </summary>
        /// <param name="vote"></param>
        void CreateVote (Vote vote);

        /// <summary>
        /// DataService method which updates the "Accepted" column for a record in the Election Group
        /// Membership Table where the electionGroupMembership value is equal to the <paramref name="electionGroupMembershipID"/>
        /// </summary>
        /// <param name="electionGroupMembershipID"></param>
        void AcceptElectionGroupMembershipRequest(string electionGroupMembershipID);

        /// <summary>
        /// DataService method which updates the Name, Description, StartDate and EndDate with the values in <paramref name="election"/> 
        /// where the ElectionID is equal to the election's ElectionID in the Election Table
        /// </summary>
        /// <param name="election"></param>
        void UpdateElection(Election election);

        /// <summary>
        /// DataService method which selects all of the user from the User Table where the Email value is equal to <paramref name="email"/>
        /// The method then returns the count of these accounts with duplicated emails
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        int CheckEmailIsUnique(string email);

        /// <summary>
        /// DataService method which selects all of the Election Groups from the Election Group Table where the Name value is equal to <paramref name="electionGroupName"/>
        /// The method then returns the count of these accounts with duplicated emails
        /// </summary>
        /// <param name="electionGroupName"></param>
        /// <returns></returns>
        int CheckElectionGroupNameIsUnique(string electionGroupName);

        /// <summary>
        /// DataService method which selects and returns all Users in the User Table
        /// </summary>
        /// <returns></returns>
        List<User> GetAllUsers();

        /// <summary>
        /// DataService method which selects the User from the User Table where the UserID value is equal to <paramref name="userID"/>
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        User GetUserByUserID(string userID);

        /// <summary>
        /// DataService method which selects and returns the User from the User Table where the Email value is equal to <paramref name="email"/>
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        User GetUserByEmail(string email);

        /// <summary>
        /// DataService method which selects and returns all Election Groups in the ElectionGroup Table
        /// </summary>
        /// <returns></returns>
        List<ElectionGroup> GetAllElectionGroups();

        /// <summary>
        /// DataService method which selects and returns the Election Group from the ElectionGroup Table where the Name value is equal to <paramref name="electionName"/>
        /// </summary>
        /// <param name="electionName"></param>
        /// <returns></returns>
        ElectionGroup GetElectionGroupByName(string electionName);

        /// <summary>
        /// DataService method which selects and returns the ElectionGroupIDs from the ElectionGroupMembership Table where the UserID value is equal to <paramref name="userID"/>
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        List<string> GetUserElectionGroupIDs(string userID);

        /// <summary>
        /// DataService method which selects and returns a list of ElectionGroupMemberships from the ElectionGroupMembership Table where the UserID value is equal to <paramref name="userID"/>
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        List<ElectionGroupMembership> GetUserElectionGroupMemberships(string userID);

        /// <summary>
        /// DataService method which selects and returns a list of ElectionGroupMemberships from the ElectionGroupMembership Table where the ElectionGroupId is equal to <paramref name="electionGroupID"/> 
        /// and the Accepted value is false 
        /// </summary>
        /// <param name="electionID"></param>
        /// <returns></returns>
        List<ElectionGroupMembership> GetUnaccpetedElectionGroupMembershipsForGroup(string electionGroupID);

        /// <summary>
        /// DataService method which selects and returns the user role of a user with in an election group.
        /// It selects the UserRole value from the ElectionGroupMembership table where the ElectionGroupID value is equal to <paramref name="electionGroupID"/> and where the UserID is equal to <paramref name="userID"/>
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="electionGroupID"></param>
        /// <returns></returns>
        string GetUserRole(string userID, string electionGroupID);

        /// <summary>
        /// DataService method which selects and returns all Elections in the Election Table
        /// </summary>
        /// <returns></returns>
        List<Election> GetAllElections();

        /// <summary>
        /// DataService method which selects and returns all Elections in the Election Table where the ElectionGroupID value is equal to <paramref name="electionGroupID"/>
        /// </summary>
        /// <param name="electionGroupID"></param>
        /// <returns></returns>
        List<Election> GetElectionsByElectionGroupID(string electionGroupID);

        /// <summary>
        /// DataService method which selects and returns all Elections in the Election Table where the Name value is equal to <paramref name="electionName"/>
        /// </summary>
        /// <param name="electionName"></param>
        /// <returns></returns>
        List<Election> GetElectionsByName(string electionName);

        /// <summary>
        /// DataService method which selects and returns the Election in the Election Table where the ElectionID value is equal to <paramref name="electionID"/>
        /// </summary>
        /// <param name="electionID"></param>
        /// <returns></returns>
        Election GetElectionByElectionID(string electionID);

        /// <summary>
        /// DataService method which selects and returns all Candidates in the Candidate Table where the ElectionID value is equal to <paramref name="electionID"/>
        /// </summary>
        /// <param name="electionID"></param>
        /// <returns></returns>
        List<Candidate> GetCandidatesByElectionID(string electionID);

        /// <summary>
        /// DataService method which selects and returns all Votes in the Vote Table where the UserID value is equal to <paramref name="userID"/>
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        List<Vote> GetVotesByUserID(string userID);

        /// <summary>
        /// DataService method which selects and returns all Votes in the Vote Table where the CandidateID value is equal to <paramref name="candidateID"/>
        /// </summary>
        /// <param name="candidateID"></param>
        /// <returns></returns>
        List<Vote> GetVotesByCandidateID(string candidateID);

        /// <summary>
        /// DataService method which selects and returns the Password in the User Table where the Email value is equal to <paramref name="email"/>
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        string GetPassword(string email);

        /// <summary>
        /// DataService method which selects and returns the PasswordSalt in the User Table where the Email value is equal to <paramref name="email"/>
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        string GetPasswordSalt(string email);

        /// <summary>
        /// DataService method which Deletes the database records in the Candidate table where the CandidateID is equal to <paramref name="candidateID"/>
        /// </summary>
        /// <param name="candidateID"></param>
        void DeleteCandidate(string candidateID);

        /// <summary>
        /// DataService method which Deletes the database records in the Election table where the ElectionId is equal to <paramref name="electionId"/>
        /// </summary>
        /// <param name="electionId"></param>
        void DeleteElection(string electionId);

        /// <summary>
        /// DataService method which Deletes the database records in the Vote table where the VoteID is equal to <paramref name="voteID"/>
        /// </summary>
        /// <param name="voteID"></param>
        void DeleteVote(string voteID);

        /// <summary>
        /// DataService method which Deletes the database records in the Vote table where the CandidateID is equal to <paramref name="candidateID"/>
        /// </summary>
        /// <param name="candidateID"></param>
        void DeleteVotesByCandidateID(string candidateID);

        /// <summary>
        /// DataService method which Deletes the database records in the Vote table where the ElectionID is equal to <paramref name="electionID"/>
        /// </summary>
        /// <param name="electionID"></param>
        void DeleteVotesByElectionID(string electionID);

        string LoadConnectionString(string id = "Default");
    }
}
