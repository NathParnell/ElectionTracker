using ElectionTracker.Classes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ElectionTracker.Services.Infrastructure
{
    public class UserService : IUserService
    {
        //IDataService dataService = new DataService();
        private readonly IDataService _dataService;
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
            User NewUser = new User(forename, surname, address, postcode, dateOfBirth, email);
            NewUser.PasswordSalt = GenerateHashSalt();
            NewUser.Password = Hasher(NewUser.PasswordSalt, password);
            _dataService.CreateUser(NewUser);
            SetCurrentUser(_dataService.GetUserByUserID(NewUser.UserID)); 
            //should this include a check to see if the db command has worked
            return true;
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
                string passwordSalt = _dataService.GetPasswordSalt(email);
                string hashedPassword = _dataService.GetPassword(email);
                string hashedPasswordAttempt = Hasher(passwordSalt, passwordAttempt);
                if (hashedPasswordAttempt == hashedPassword)
                {
                    SetCurrentUser(_dataService.GetUserByEmail(email));
                    
                    return true;

                }
                return false;
            }
            catch(Exception ex)
            {
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


    }
}
