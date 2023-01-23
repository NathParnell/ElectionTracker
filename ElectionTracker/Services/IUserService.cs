using ElectionTracker.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTracker.Services
{
    public interface IUserService
    {
        bool CreateAccount(string Forename, string Surname, string Email, string Username, string Password, string AccountType);
        User HashPassword(User user);
    }
}
