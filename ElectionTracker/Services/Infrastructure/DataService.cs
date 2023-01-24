using Dapper;
using ElectionTracker.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace ElectionTracker.Services.Infrastructure
{
    /// <summary>
    /// I gained a lot of knowledge on how to use SQLite from this video https://www.youtube.com/watch?v=ayp3tHEkRc0
    /// </summary>
    public class DataService : IDataService
    {
        public List<User> GetAllUsers()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getAllUsersQuery = "Select * from User";
                var output = conn.Query<User>(getAllUsersQuery, new DynamicParameters());
                return output.ToList();
            }
        }

        public User GetUserByUserID(string userID)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getUserbyUserIDQuery = "Select * from User Where UserID = @UserID";
                User currentUser = conn.QuerySingle<User>(getUserbyUserIDQuery, new { UserID = userID });
                return currentUser;
            }
        }

        public User GetUserByEmail(string email)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getUserbyUserIDQuery = "Select * from User Where Email = @Email";
                User currentUser = conn.QuerySingle<User>(getUserbyUserIDQuery, new { Email = email });
                return currentUser;
            }
        }

        public void CreateUser(User user)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string createUserQuery = "Insert into User (UserID, Password, Forename, Surname, Email, PasswordSalt, Address, DateofBirth, EntryDate, AccountType)" +
                                        "values (@UserID, @Password, @Forename, @Surname, @Email, @PasswordSalt, @Address, @DateofBirth, @EntryDate, @AccountType) ";
                conn.Execute(createUserQuery, user);
            }
        }

        public string GetPassword(string email)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getPasswordQuery = "Select Password from User Where Email = @Email";
                string password = conn.QuerySingle<string>(getPasswordQuery, new { Email = email });
                return password;
            }
        }

        public string GetPasswordSalt(string email)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getPasswordSaltQuery = "Select PasswordSalt from User Where Email = @Email";
                string passwordSalt = conn.QuerySingle<string>(getPasswordSaltQuery, new {Email = email});
                return passwordSalt;
            }

        }

        public string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
