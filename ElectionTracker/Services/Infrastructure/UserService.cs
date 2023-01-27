using ElectionTracker.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        

        public bool CreateAccount(string Forename, string Surname, string Email, string Password)
        {
            User NewUser = new User(Forename, Surname, Email);
            NewUser.PasswordSalt = GenerateHashSalt();
            NewUser.Password = Hasher(NewUser.PasswordSalt, Password);
            _dataService.CreateUser(NewUser);
            CurrentUser = _dataService.GetUserByUserID(NewUser.UserID); 
            //should this include a check to see if the db command has worked
            return true;
        }

        
        public bool AttemptLogin(string email, string passwordAttempt)
        {
            try
            {
                string passwordSalt = _dataService.GetPasswordSalt(email);
                string hashedPassword = _dataService.GetPassword(email);
                string hashedPasswordAttempt = Hasher(passwordSalt, passwordAttempt);
                if (hashedPasswordAttempt == hashedPassword)
                {
                    CurrentUser = _dataService.GetUserByEmail(email);
                    
                    return true;

                }
                return false;
            }
            catch(Exception ex)
            {
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

        /// <summary>
        /// Takes in a string and salt as parameters and hashes the string accordingly
        /// </summary>
        /// <param name="saltString"></param>
        /// <param name="stringToHash"></param>
        /// <returns></returns>
         public string Hasher(string saltString, string stringToHash)
         {
            const int HashSize = 128;
            const int Iterations = 100000;

            byte[] salt = Encoding.Default.GetBytes(saltString);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(stringToHash, salt, Iterations);
            string hashedString = Encoding.Default.GetString(pbkdf2.GetBytes(HashSize));

            return hashedString;
         }

        


    }
}
