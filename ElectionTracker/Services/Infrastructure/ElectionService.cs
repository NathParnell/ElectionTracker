using ElectionTracker.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

            ElectionGroupMembership newMember = new ElectionGroupMembership(electionGroup.ElectionGroupID, userRole, user.UserID);
            _dataService.CreateElectionGroupMembership(newMember);
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



    }

   
}
