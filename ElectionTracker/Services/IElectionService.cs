﻿using ElectionTracker.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        bool JoinElectionGroupRequest(string name, string userRole);
        bool AcceptElectionGroupRequest(ElectionGroupMembership electionGroupMembership);
        List<ElectionGroupMembership> GetUnacceptedElectionGroupRequests(ElectionGroup electionGroup);
        bool CreateElection(Election newElection);
    }
}
