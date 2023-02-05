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

        public Candidate(string forename, string surname, string email, string electionID, string description, string partyname)
            : base(forename, surname, email)
        {
            this.CandidateID = Taikandi.SequentialGuid.NewGuid().ToString();
            this.ElectionID = electionID;
            this.Description = description;
            this.Partyname = partyname;
        }

        public string CandidateID { get; set; }
        public string ElectionID { get; set;}
        public string Description { get; set; }
        public string Partyname { get; set; }
    }
}
