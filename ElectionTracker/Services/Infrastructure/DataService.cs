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
        public void CreateUser(User user)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string createUserQuery = "Insert into User (UserID, Forename, Surname, Email, Password, PasswordSalt, Address, Postcode, DateofBirth, EntryDate)" +
                                        "values (@UserID, @Forename, @Surname, @Email, @Password, @PasswordSalt, @Address, @Postcode, @DateofBirth, @EntryDate) ";
                conn.Execute(createUserQuery, user);
            }
        }

        public void CreateElectionGroup(ElectionGroup electionGroup)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string createElectionGroupQuery = "Insert into ElectionGroup (ElectionGroupID, Name, Description, EntryDate)" +
                                        "values (@ElectionGroupID, @Name, @Description, @EntryDate) ";
                conn.Execute(createElectionGroupQuery, electionGroup);
            }
        }

        public void CreateElectionGroupMembership(ElectionGroupMembership electionGroupMembership)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string createElectionGroupMembershipQuery = "Insert into ElectionGroupMembership (ElectionGroupMembershipID, ElectionGroupID, UserID, UserRole, Accepted)" +
                                        "values (@ElectionGroupMembershipID, @ElectionGroupID, @UserID, @UserRole, @Accepted) ";
                conn.Execute(createElectionGroupMembershipQuery, electionGroupMembership);
            }
        }

        public void AcceptElectionGroupRequest(string electionGroupMembershipID)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string createElectionGroupMembershipQuery = "Update ElectionGroupMembership Set Accepted = 1 Where ElectionGroupMembershipID = @ElectionGroupMembershipID";
                                        
                conn.Execute(createElectionGroupMembershipQuery, new { ElectionGroupMembershipID = electionGroupMembershipID});
            }
        }

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

        public List<ElectionGroup> GetAllElectionGroups()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getAllElectionGroups = "Select * from ElectionGroup";
                var output = conn.Query<ElectionGroup>(getAllElectionGroups, new DynamicParameters());
                return output.ToList();
            }
        }
        public ElectionGroup GetElectionGroupByName(string electionName)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getElectionGroupByName = "Select ElectionGroupID from ElectionGroup where Name = @Name";
                ElectionGroup electionGroup = conn.QuerySingle<ElectionGroup>(getElectionGroupByName, new { Name = electionName});
                return electionGroup;
            }
        }

        public List<string> GetUserElectionGroupIDs(string userID)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getUserElectionGroupIDs = "Select ElectionGroupID from ElectionGroupMembership where UserID = @UserID";
                var output = conn.Query<string>(getUserElectionGroupIDs, new {UserID = userID});
                return output.ToList();
            }
        }

        public List<ElectionGroupMembership> GetUserElectionGroupMemberships(string userID)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getUserElectionGroupIDs = "Select * from ElectionGroupMembership Where UserID = @UserID";
                    var userElectionGroupMemberships = (conn.Query<ElectionGroupMembership>(getUserElectionGroupIDs, new { UserID = userID }));
                    return userElectionGroupMemberships.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                var empty = new List<ElectionGroupMembership>();
                return empty;
            }
            
        }

        public List<ElectionGroupMembership> GetUnaccpetedElectionGroupMembershipsForGroup(string electionGroupID)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getUserElectionGroupIDs = "Select * from ElectionGroupMembership Where ElectionGroupID = @ElectionGroupID and Accepted = 0";
                    var userElectionGroupMemberships = (conn.Query<ElectionGroupMembership>(getUserElectionGroupIDs, new { ElectionGroupID = electionGroupID }));
                    return userElectionGroupMemberships.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                var empty = new List<ElectionGroupMembership>();
                return empty;
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
