using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTracker.Classes
{
    public class Candidate : Person
    {
        public Candidate(string Forename, string Surname, String Email)
            : base(Forename, Surname, Email)
        {
            
        }
        public string CandidateID { get; set; }
        public string ElectionID { get; set;}
        public int NumberOfVotes { get; set; }
        public string PartyName { get; set; }
    }
}
