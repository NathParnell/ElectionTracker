using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTracker.Classes
{
    public class Candidate : Person
    {

        public Candidate() { }

        public Candidate(string Forename, string Surname, string Email, string ElectionID, string Description, string Partyname)
            : base(Forename, Surname, Email)
        {
            this.CandidateID = Taikandi.SequentialGuid.NewGuid().ToString();
            this.ElectionID = ElectionID;
            this.Description = Description;
            this.Partyname = Partyname;
        }

        public string CandidateID { get; set; }
        public string ElectionID { get; set;}
        public string Description { get; set; }
        public string Partyname { get; set; }
    }
}
