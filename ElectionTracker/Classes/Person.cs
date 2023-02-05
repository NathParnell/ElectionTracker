using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTracker.Classes
{
    public class Person
    {
        public Person()
        { }

        public Person(string forename, string Surname, string Email)
        {
            this.Forename = forename;
            this.Surname = Surname;
            this.Email = Email;
        }

        public string Forename { get; set; }
        public string Surname { get; set; }

        public string Email { get; set; }

        
    }
}
