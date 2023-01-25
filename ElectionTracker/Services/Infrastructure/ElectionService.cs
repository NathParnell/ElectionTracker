using ElectionTracker.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
