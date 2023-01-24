using ElectionTracker.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTracker.Services
{
    public interface IUserService
    {
        bool CreateAccount(string Forename, string Surname, string Email, string Password, string AccountType);
        bool AttemptLogin(string email, string passwordAttempt);
        string GenerateHashSalt();
        string Hasher(string saltString, string stringToHash);
    }
}
