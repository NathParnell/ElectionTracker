using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ElectionTracker.Classes
{

    public enum UserAccountType
    {
        Administrator = 0,
        Auditor = 1,
        Voter = 2
    }

    public class User : Person
    {
        public User (string Forename, string Surname, string Email, string Username, string Password)
            : base(Forename, Surname, Email)
        {
            this.UserName = Username;
            this.Password = Password;
        }

        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime EntryDate { get; set; }
        public UserAccountType AccountType { get; set; }

    }
}
