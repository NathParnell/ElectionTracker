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
using static System.Collections.Specialized.BitVector32;
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

        public void CreateElection(Election election)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string createElectionQuery = "Insert into Election (ElectionID, Name, Description, ElectionGroupID, StartDate, EndDate)" +
                                        "values (@ElectionID, @Name, @Description, @ElectionGroupID, @StartDate, @EndDate) ";
                conn.Execute(createElectionQuery, election);
            }
        }

        public void CreateCandidate(Candidate candidate)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string createCandidateQuery = "Insert into Candidate (CandidateID, Forename, Surname, Email, ElectionID, Description, Partyname)" +
                                        "values (@CandidateID, @Forename, @Surname, @Email, @ElectionID, @Description, @Partyname) ";
                conn.Execute(createCandidateQuery, candidate);
            }
        }

        public void CreateVote(Vote vote)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string createVoteQuery = "Insert into Vote (VoteID, CandidateID, UserID, VoteMethod)" +
                                        "values (@VoteID, @CandidateID, @UserID, @VoteMethod) ";
                conn.Execute(createVoteQuery, vote);
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

        public string GetUserRole(string userID, string electionGroupID)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getUserRoleInElectionGroupQuery = "Select UserRole from ElectionGroupMembership Where ElectionGroupID = @ElectionGroupID and UserID = @UserID";
                var userElectionGroupMemberships = (conn.QuerySingle<string>(getUserRoleInElectionGroupQuery, new { ElectionGroupID = electionGroupID, UserID = userID }));
                return userElectionGroupMemberships;
            }
        }

        public List<Election> GetAllElections()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getAllUsersQuery = "Select * from Election";
                var output = conn.Query<Election>(getAllUsersQuery, new DynamicParameters());
                return output.ToList();
            }
        }

        public List<Election> GetElectionsByElectionGroupID(string electionGroupID)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getElectionsByElectionGroupIDQuery = "Select * from Election Where ElectionGroupID = @ElectionGroupID";
                var elections = (conn.Query<Election>(getElectionsByElectionGroupIDQuery, new { ElectionGroupID = electionGroupID }));
                return elections.ToList();
            }
        }

        public List<Candidate> GetCandidatesByElectionID(string electionID)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getCandidatesByElectionIDQuery = "Select * from Candidate Where ElectionID = @ElectionID";
                var candidates = (conn.Query<Candidate>(getCandidatesByElectionIDQuery, new { ElectionID = electionID }));
                return candidates.ToList();
            }
        }

        public List<Vote> GetVotesByUserID(string userID)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getVotesByUserIDQuery = "Select * from Vote Where UserID = @UserID";
                var votes = (conn.Query<Vote>(getVotesByUserIDQuery, new { UserID = userID }));
                return votes.ToList();
            }
        }

        public List<Vote> GetVotesByCandidateID(string candidateID)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getVotesByCandidateIDQuery = "Select * from Vote Where CandidateID = @CandidateID";
                var votes = (conn.Query<Vote>(getVotesByCandidateIDQuery, new { CandidateID = candidateID }));
                return votes.ToList();
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

        public void DeleteCandidate(string candidateID)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string DeleteCandidateQuery = "Delete from Candidate Where CandidateID = @CandidateID";
                conn.Query(DeleteCandidateQuery, new { CandidateID = candidateID });
                return;
            }
        }

        public void DeleteVote(string voteID)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string DeleteVoteQuery = "Delete from Vote Where VoteID = @VoteID";
                conn.Query(DeleteVoteQuery, new { VoteID = voteID });
                return;
            }
        }

        public string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
