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
        private readonly ILog _log = LogFactory.CreateLogger("UserService", LoggerType.FileLogger);

        public UserService(IDataService dataService) 
        {
            _dataService = dataService;
        }


        public User CurrentUser { get; set; }

       
        public void SetCurrentUser(User user = null)
        {
            this.CurrentUser = user;
        }

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

        public string GenerateHashSalt()
        {
            const int saltSize = 128;
            RNGCryptoServiceProvider hashProvider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[saltSize];
            hashProvider.GetBytes(salt);
            return Encoding.Default.GetString(salt);
        }

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

        public bool CheckEmailIsUnique(string email)
        {
            email = email.ToLower();
            int emailDuplicates = _dataService.CheckEmailIsUnique(email);
            if (emailDuplicates == 0)
                return true;

            return false;
        }

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
