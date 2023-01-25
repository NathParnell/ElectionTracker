using ElectionTracker.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTracker.Services
{
    public interface IElectionService
    {
        bool CreateElectionGroup(string name, string description);
        void CreateElectionGroupMembership(ElectionGroup electionGroup, string userRole, User user = null);
    }
}
