using Dapper;
using ElectionTracker.Logger;
using ElectionTracker.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace ElectionTracker.Services.Infrastructure
{
    /// <summary>
    /// I gained a lot of knowledge on how to use SQLite from this video https://www.youtube.com/watch?v=ayp3tHEkRc0
    /// </summary>
    public class DataService : IDataService
    {
        private readonly ILog _log = LogFactory.SetConsoleLogger("DataService");
        public void CreateUser(User user)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string createUserQuery = "Insert into User (UserID, Forename, Surname, Email, Password, PasswordSalt, Address, Postcode, DateofBirth, EntryDate)" +
                                            "values (@UserID, @Forename, @Surname, @Email, @Password, @PasswordSalt, @Address, @Postcode, @DateofBirth, @EntryDate) ";
                    conn.Execute(createUserQuery, user);
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
            }
        }

        public void CreateElectionGroup(ElectionGroup electionGroup)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string createElectionGroupQuery = "Insert into ElectionGroup (ElectionGroupID, Name, Description, EntryDate)" +
                                            "values (@ElectionGroupID, @Name, @Description, @EntryDate) ";
                    conn.Execute(createElectionGroupQuery, electionGroup);
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
            }
        }

        public void CreateElectionGroupMembership(ElectionGroupMembership electionGroupMembership)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string createElectionGroupMembershipQuery = "Insert into ElectionGroupMembership (ElectionGroupMembershipID, ElectionGroupID, UserID, UserRole, Accepted)" +
                                            "values (@ElectionGroupMembershipID, @ElectionGroupID, @UserID, @UserRole, @Accepted) ";
                    conn.Execute(createElectionGroupMembershipQuery, electionGroupMembership);
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
            }
        }

        public void CreateElection(Election election)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string createElectionQuery = "Insert into Election (ElectionID, Name, Description, ElectionGroupID, StartDate, EndDate)" +
                                            "values (@ElectionID, @Name, @Description, @ElectionGroupID, @StartDate, @EndDate) ";
                    conn.Execute(createElectionQuery, election);
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
            }
        }

        public void CreateCandidate(Candidate candidate)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string createCandidateQuery = "Insert into Candidate (CandidateID, Forename, Surname, Email, ElectionID, Description, Partyname)" +
                                            "values (@CandidateID, @Forename, @Surname, @Email, @ElectionID, @Description, @Partyname) ";
                    conn.Execute(createCandidateQuery, candidate);
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
            }
        }

        public void CreateVote(Vote vote)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string createVoteQuery = "Insert into Vote (VoteID, CandidateID, UserID, VoteMethod)" +
                                            "values (@VoteID, @CandidateID, @UserID, @VoteMethod) ";
                    conn.Execute(createVoteQuery, vote);
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
            }
        }

        public void AcceptElectionGroupMembershipRequest(string electionGroupMembershipID)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string createElectionGroupMembershipQuery = "Update ElectionGroupMembership Set Accepted = 1 Where ElectionGroupMembershipID = @ElectionGroupMembershipID";

                    conn.Execute(createElectionGroupMembershipQuery, new { ElectionGroupMembershipID = electionGroupMembershipID });
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
            }
        }
        
        public int CheckEmailIsUnique(string email)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getUserbyUserIDQuery = "Select * from User Where Email = @Email";
                    int emailDuplicateCount = conn.Query(getUserbyUserIDQuery, new { Email = email }).ToList().Count;
                    return emailDuplicateCount;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                throw;
            }
        }

        public List<User> GetAllUsers()
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getAllUsersQuery = "Select * from User";
                    var output = conn.Query<User>(getAllUsersQuery, new DynamicParameters()).ToList();
                    return output;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public User GetUserByUserID(string userID)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getUserbyUserIDQuery = "Select * from User Where UserID = @UserID";
                    User currentUser = conn.QuerySingle<User>(getUserbyUserIDQuery, new { UserID = userID });
                    return currentUser;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public User GetUserByEmail(string email)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getUserbyUserIDQuery = "Select * from User Where Email = @Email";
                    User currentUser = conn.QuerySingle<User>(getUserbyUserIDQuery, new { Email = email });
                    return currentUser;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public List<ElectionGroup> GetAllElectionGroups()
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getAllElectionGroups = "Select * from ElectionGroup";
                    var output = conn.Query<ElectionGroup>(getAllElectionGroups, new DynamicParameters()).ToList();
                    return output;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public ElectionGroup GetElectionGroupByName(string electionName)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getElectionGroupByName = "Select ElectionGroupID from ElectionGroup where Name = @Name";
                    ElectionGroup electionGroup = conn.QuerySingle<ElectionGroup>(getElectionGroupByName, new { Name = electionName });
                    return electionGroup;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public List<string> GetUserElectionGroupIDs(string userID)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string getUserElectionGroupIDs = "Select ElectionGroupID from ElectionGroupMembership where UserID = @UserID";
                var output = conn.Query<string>(getUserElectionGroupIDs, new {UserID = userID}).ToList();
                return output;
            }
        }

        public List<ElectionGroupMembership> GetUserElectionGroupMemberships(string userID)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getUserElectionGroupIDs = "Select * from ElectionGroupMembership Where UserID = @UserID";
                    var userElectionGroupMemberships = conn.Query<ElectionGroupMembership>(getUserElectionGroupIDs, new { UserID = userID }).ToList();
                    return userElectionGroupMemberships;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
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
                _log.Error(e.Message);
                var empty = new List<ElectionGroupMembership>();
                return empty;
            }
        }

        public string GetUserRole(string userID, string electionGroupID)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getUserRoleInElectionGroupQuery = "Select UserRole from ElectionGroupMembership Where ElectionGroupID = @ElectionGroupID and UserID = @UserID";
                    var userElectionGroupMemberships = (conn.QuerySingle<string>(getUserRoleInElectionGroupQuery, new { ElectionGroupID = electionGroupID, UserID = userID }));
                    return userElectionGroupMemberships;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public List<Election> GetAllElections()
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getAllUsersQuery = "Select * from Election";
                    var output = conn.Query<Election>(getAllUsersQuery, new DynamicParameters()).ToList();
                    return output;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public List<Election> GetElectionsByElectionGroupID(string electionGroupID)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getElectionsByElectionGroupIDQuery = "Select * from Election Where ElectionGroupID = @ElectionGroupID";
                    var elections = conn.Query<Election>(getElectionsByElectionGroupIDQuery, new { ElectionGroupID = electionGroupID }).ToList();
                    return elections;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public List<Candidate> GetCandidatesByElectionID(string electionID)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getCandidatesByElectionIDQuery = "Select * from Candidate Where ElectionID = @ElectionID";
                    var candidates = conn.Query<Candidate>(getCandidatesByElectionIDQuery, new { ElectionID = electionID }).ToList();
                    return candidates;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public List<Vote> GetVotesByUserID(string userID)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getVotesByUserIDQuery = "Select * from Vote Where UserID = @UserID";
                    var votes = conn.Query<Vote>(getVotesByUserIDQuery, new { UserID = userID }).ToList();
                    return votes;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public List<Vote> GetVotesByCandidateID(string candidateID)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getVotesByCandidateIDQuery = "Select * from Vote Where CandidateID = @CandidateID";
                    var votes = conn.Query<Vote>(getVotesByCandidateIDQuery, new { CandidateID = candidateID }).ToList();
                    return votes;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public string GetPassword(string email)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getPasswordQuery = "Select Password from User Where Email = @Email";
                    string password = conn.QuerySingle<string>(getPasswordQuery, new { Email = email });
                    return password;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public string GetPasswordSalt(string email)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string getPasswordSaltQuery = "Select PasswordSalt from User Where Email = @Email";
                    string passwordSalt = conn.QuerySingle<string>(getPasswordSaltQuery, new { Email = email });
                    return passwordSalt;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }

        }

        public void DeleteCandidate(string candidateID)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string DeleteCandidateQuery = "Delete from Candidate Where CandidateID = @CandidateID";
                    conn.Query(DeleteCandidateQuery, new { CandidateID = candidateID });
                    return;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
            }
        }

        public void DeleteVote(string voteID)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string DeleteVoteQuery = "Delete from Vote Where VoteID = @VoteID";
                    conn.Query(DeleteVoteQuery, new { VoteID = voteID });
                    return;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
            }
        }

        public void DeleteVotesByCandidateID(string candidateID)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    string DeleteVotesByCandidateIDQuery = "Delete from Vote Where CandidateID = @CandidateID";
                    conn.Query(DeleteVotesByCandidateIDQuery, new { CandidateID = candidateID });
                    return;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
            }
        }

        /// <summary>
        /// gets the default connection string from app.config
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
