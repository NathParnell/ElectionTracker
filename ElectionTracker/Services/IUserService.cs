using ElectionTracker.Models;
using System;
using System.Collections.Generic;

namespace ElectionTracker.Services
{
    public interface IUserService
    {
        User CurrentUser { get; set; }

        /// <summary>
        /// sets the current user variable to be the user passed through
        /// can also be used to reset the current user value to be null
        /// </summary>
        /// <param name="user"></param>
        void SetCurrentUser(User user = null);

        /// <summary>
        /// Takes in account parameters and creates a user in the database
        /// Then sets the current user variable to be the new user
        /// </summary>
        /// <param name="forename"></param>
        /// <param name="surname"></param>
        /// <param name="address"></param>
        /// <param name="postcode"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns> confirmation account has been created </returns>
        bool CreateAccount(string forename, string surname, string address, string postcode, DateTime dateOfBirth, string email, string password);

        /// <summary>
        /// compares attempted password to the one stored in the database
        /// if the password is not the same or if the email address does not exist, then method returns false
        /// </summary>
        /// <param name="email"></param>
        /// <param name="passwordAttempt"></param>
        /// <returns></returns>
        bool AttemptLogin(string email, string passwordAttempt);

        /// <summary>
        /// method which generates a new has salt
        /// I used this along with previous work i have done using password encyption here 
        /// https://stackoverflow.com/questions/11412882/hash-password-in-c-bcrypt-pbkdf2
        /// </summary>
        /// <returns></returns>
        string GenerateHashSalt();

        /// <summary>
        /// Takes in a string and hash salt as parameters and hashes the string accordingly
        /// </summary>
        /// <param name="saltString"></param>
        /// <param name="stringToHash"></param>
        /// <returns> The hashed string </returns>
        string Hasher(string saltString, string stringToHash);

        List<User> GetAllUsers();
        User GetUserByUserID(string userID);

        /// <summary>
        /// Passes in email and checks whether the email has already been entered into the database
        /// if it has return false, otherwise return true
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        bool CheckEmailIsUnique(string email);

        /// <summary>
        /// passes in a user input and a validation string to compare the input against
        /// </summary>
        /// <param name="UserInput"></param>
        /// <param name="ValidationString"></param>
        /// <returns></returns>
        bool ExpressionValidator(string UserInput, string ValidationString);
    }
}
