﻿using ElectionTracker.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTracker.Services
{
    public interface IDataService
    {
        void CreateUser(User user);
        void CreateElectionGroup(ElectionGroup electiongroup);
        void CreateElectionGroupMembership(ElectionGroupMembership electionGroupMembership);
        void CreateElection(Election election);
        void CreateCandidate(Candidate candidate);
        void AcceptElectionGroupRequest(string electionGroupMembershipID);
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
        List<Candidate> GetCandidatesByElectionID(string electionID);
        string GetPassword(string email);
        string GetPasswordSalt(string email);
        void DeleteCandidate(string candidateID);

        string LoadConnectionString(string id = "Default");
    }
}
