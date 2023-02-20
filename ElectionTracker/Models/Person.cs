namespace ElectionTracker.Models
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
