using ElectionTracker.Logger;
using ElectionTracker.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace ElectionTracker.Services.Infrastructure
{
    public class UserService : IUserService
    {
        private readonly IDataService _dataService;
        private readonly ILog _log = LogFactory.SetFileLogger("UserService");

        public UserService(IDataService dataService) 
        {
            _dataService = dataService;
        }


        public User CurrentUser { get; set; }

        /// <summary>
        /// sets the current user variable to be the user passed through
        /// can also be used to reset the current user value to be null
        /// </summary>
        /// <param name="user"></param>
        public void SetCurrentUser(User user = null)
        {
            this.CurrentUser = user;
        }

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
        public bool CreateAccount(string forename, string surname, string address, string postcode, DateTime dateOfBirth, string email, string password)
        {
            try
            {
                email = email.ToLower();
                User newUser = new User(forename, surname, address, postcode, dateOfBirth, email);
                newUser.PasswordSalt = GenerateHashSalt();
                newUser.Password = Hasher(newUser.PasswordSalt, password);
                _dataService.CreateUser(newUser);
                SetCurrentUser(_dataService.GetUserByUserID(newUser.UserID));
                _log.Info($"User {newUser.UserID} Created");
                return true;
            }
            catch(Exception ex)
            {
                _log.Info(ex.Message.ToString());
                return false;
            }  
        }

        /// <summary>
        /// compares attempted password to the one stored in the database
        /// if the password is not the same or if the email address does not exist, then method returns false
        /// </summary>
        /// <param name="email"></param>
        /// <param name="passwordAttempt"></param>
        /// <returns></returns>
        public bool AttemptLogin(string email, string passwordAttempt)
        {
            try
            {
                email = email.ToLower();
                string passwordSalt = _dataService.GetPasswordSalt(email);
                string hashedPassword = _dataService.GetPassword(email);
                string hashedPasswordAttempt = Hasher(passwordSalt, passwordAttempt);
                if (hashedPasswordAttempt == hashedPassword)
                {
                    SetCurrentUser(_dataService.GetUserByEmail(email));
                    _log.Info($"User {this.CurrentUser.UserID} Logged in");
                    return true;
                }
                _log.Info("Login Attempt Failed");
                return false;
            }
            catch (ArgumentNullException ex)
            {
                _log.Error($"Email {email} does not exist in the database {ex.Message.ToString()}");
                return false;
            } 
            catch(Exception ex)
            {
                _log.Error(ex.Message.ToString());
                return false;
            }
        }

        /// <summary>
        /// method which generates a new has salt
        /// I used this along with previous work i have done using password encyption here 
        /// https://stackoverflow.com/questions/11412882/hash-password-in-c-bcrypt-pbkdf2
        /// </summary>
        /// <returns></returns>
        public string GenerateHashSalt()
        {
            const int saltSize = 128;
            RNGCryptoServiceProvider hashProvider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[saltSize];
            hashProvider.GetBytes(salt);
            return Encoding.Default.GetString(salt);
        }

        /// <summary>
        /// Takes in a string and hash salt as parameters and hashes the string accordingly
        /// </summary>
        /// <param name="saltString"></param>
        /// <param name="stringToHash"></param>
        /// <returns> The hashed string </returns>
         public string Hasher(string saltString, string stringToHash)
         {
            const int HashSize = 128;
            const int Iterations = 100000;

            byte[] salt = Encoding.Default.GetBytes(saltString);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(stringToHash, salt, Iterations);
            string hashedString = Encoding.Default.GetString(pbkdf2.GetBytes(HashSize));

            return hashedString;
         }

        public List<User> GetAllUsers()
        {
            return _dataService.GetAllUsers();
        }

        public User GetUserByUserID(string userID)
        { 
            return _dataService.GetUserByUserID(userID);
        }

        /// <summary>
        /// Passes in email and checks whether the email has already been entered into the database
        /// if it has return false, otherwise return true
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool CheckEmailIsUnique(string email)
        {
            email = email.ToLower();
            int emailDuplicates = _dataService.CheckEmailIsUnique(email);
            if (emailDuplicates == 0)
                return true;

            return false;
        }

        /// <summary>
        /// passes in a user input and a validation string to compare the input against
        /// </summary>
        /// <param name="UserInput"></param>
        /// <param name="ValidationString"></param>
        /// <returns></returns>
        public bool ExpressionValidator(string UserInput, string ValidationString)
        {
            // I used this regex validator to ensure that user inputs are valid for the system - https://uibakery.io/regex-library/password-regex-csharp
            Regex RegexValidator = new Regex(ValidationString);
            if (RegexValidator.IsMatch(UserInput))
                return true;

            return false;
        }
    }
}
