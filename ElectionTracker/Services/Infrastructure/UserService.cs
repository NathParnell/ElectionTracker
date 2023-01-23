using ElectionTracker.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTracker.Services.Infrastructure
{
    public class UserService : IUserService
    {

        public bool CreateAccount(string Forename, string Surname, string Email, string Username, string Password, string AccountType)
        {
            User NewUser = new User(Forename, Surname, Email, Username, Password);
            NewUser = HashPassword(NewUser);
            //pass this through to the database
            return true;
        }


         public User HashPassword(User user)
        {
            const int saltSize = 128;
            const int HashSize = 128;
            const int Iterations = 100000;

            RNGCryptoServiceProvider hashProvider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[saltSize];
            hashProvider.GetBytes(salt);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(user.Password, salt, Iterations);
            user.Password = Encoding.Default.GetString(pbkdf2.GetBytes(HashSize));
            user.PasswordSalt = Encoding.Default.GetString(salt);

            return user;
        }


    }
}
