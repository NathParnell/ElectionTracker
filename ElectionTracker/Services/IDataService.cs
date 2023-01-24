using ElectionTracker.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTracker.Services
{
    public interface IDataService
    {
        List<User> GetAllUsers();
        User GetUserByUserID(string userID);
        User GetUserByEmail(string email);
        void CreateUser(User user);
        string LoadConnectionString(string id = "Default");
        string GetPasswordSalt(string email);
        string GetPassword(string email);
    }
}
