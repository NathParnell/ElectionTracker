using System;

namespace ElectionTracker.Models
{
    public class ElectionGroup
    {
        /// <summary>
        /// we need an empty constructor
        /// </summary>
        public ElectionGroup()
        {
        }

        /// <summary>
        /// constructor to be called upon creation
        /// </summary>
        public ElectionGroup(string name, string description)
        {
            this.ElectionGroupID = Taikandi.SequentialGuid.NewGuid().ToString();
            this.Name = name;
            this.Description = description;
            this.EntryDate = DateTime.Now;
        }

        public string ElectionGroupID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
