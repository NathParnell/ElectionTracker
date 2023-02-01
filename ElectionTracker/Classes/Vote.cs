using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTracker.Classes
{
    public class Vote
    {
        public Vote() { }
        public Vote(string candidateID, string userID, string voteMethod = "ElectionTracker") 
        {
            this.VoteID = Taikandi.SequentialGuid.NewGuid().ToString();
            this.CandidateID = candidateID;
            this.UserID = userID;
            this.EntryDate = DateTime.Now;
            SetVoteMethod(voteMethod);
        }


        public string VoteID { get; set; }
        public string CandidateID { get; set; }
        public string UserID { get; set; }
        public VoteMethod VoteMethod { get; set; }
        public DateTime EntryDate { get; set; }


        private void SetVoteMethod(string voteMethod)
        {
            if (voteMethod == "ElectionTracker")
                this.VoteMethod = VoteMethod.ElectionTracker;

            else if (voteMethod == "Postal")
                this.VoteMethod = VoteMethod.Postal;

            else
                this.VoteMethod = VoteMethod.BallotBox;
        }

    }


    

    public enum VoteMethod
    {
        ElectionTracker = 0,
        Postal = 1,
        BallotBox = 2
    }

}
