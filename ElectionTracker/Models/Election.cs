using System;

namespace ElectionTracker.Models

{
    public class Election
    {
        public Election() { }

        public Election(string name, string description, string electionGroupID, DateTime startDate, DateTime endDate) 
        {
            this.ElectionID = Taikandi.SequentialGuid.NewGuid().ToString();
            this.Name = name;
            this.Description = description;
            this.ElectionGroupID = electionGroupID;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public string ElectionID { get; set; }        
        public string Name { get; set; }
        public string Description { get; set; }
        public string ElectionGroupID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
