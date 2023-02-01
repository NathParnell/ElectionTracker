using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Taikandi;
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
        /// <summary>
        /// empty constructor which is called when 
        /// </summary>
        public User() { }


        /// <summary>
        /// Constructor for a new user
        /// </summary>
        /// <param name="Forename"></param>
        /// <param name="Surname"></param>
        /// <param name="Email"></param>
        /// <param name="Password"></param>
        public User (string Forename, string Surname, string Email)
            : base(Forename, Surname, Email)
        {
            this.UserID = Taikandi.SequentialGuid.NewGuid().ToString();
            this.EntryDate = DateTime.Now;
        }


        public string UserID { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime EntryDate { get; set; }





    }
}
