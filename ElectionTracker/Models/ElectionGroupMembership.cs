namespace ElectionTracker.Models
{
    public enum ElectionGroupUserRole
    {
        Administrator = 0,
        Auditor = 1,
        Voter = 2
    }


    public class ElectionGroupMembership
    {
        public ElectionGroupMembership() 
        {
        }

        public ElectionGroupMembership(string electionGroupID, string userRole, string userID) 
        {
            this.ElectionGroupMembershipID = Taikandi.SequentialGuid.NewGuid().ToString();
            this.ElectionGroupID = electionGroupID;
            this.UserID = userID;
            SetUserRole(userRole);
            if (UserRole == ElectionGroupUserRole.Administrator)
                this.Accepted = true;
            else
                this.Accepted = false;
        }

        public string ElectionGroupMembershipID { get; set; }
        public string ElectionGroupID { get; set; }
        public string UserID { get; set; }
        public ElectionGroupUserRole UserRole { get; set; }
        public bool Accepted { get; set; }



        public void SetUserRole(string userRole)
        {
            if (userRole == "Administrator")
                this.UserRole = ElectionGroupUserRole.Administrator;

            else if (userRole == "Auditor")
                this.UserRole = ElectionGroupUserRole.Auditor;

            else
                this.UserRole = ElectionGroupUserRole.Voter;
        }
    }
    
}
