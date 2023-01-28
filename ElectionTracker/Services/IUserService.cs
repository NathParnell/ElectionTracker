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
        User CurrentUser { get; set; }
        void SetCurrentUser(User user);
        bool CreateAccount(string Forename, string Surname, string Email, string Password);
        bool AttemptLogin(string email, string passwordAttempt);
        string GenerateHashSalt();
        string Hasher(string saltString, string stringToHash);
        List<User> GetAllUsers();
        User GetUserByUserID(string userID);
    }
}
