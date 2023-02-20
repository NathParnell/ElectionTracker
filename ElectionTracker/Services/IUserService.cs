using ElectionTracker.Models;
using System;
using System.Collections.Generic;

namespace ElectionTracker.Services
{
    public interface IUserService
    {
        User CurrentUser { get; set; }
        void SetCurrentUser(User user = null);
        bool CreateAccount(string forename, string surname, string address, string postcode, DateTime dateOfBirth, string email, string password);
        bool AttemptLogin(string email, string passwordAttempt);
        string GenerateHashSalt();
        string Hasher(string saltString, string stringToHash);
        List<User> GetAllUsers();
        User GetUserByUserID(string userID);
        bool CheckEmailIsUnique(string email);
        bool ExpressionValidator(string UserInput, string ValidationString);
    }
}
