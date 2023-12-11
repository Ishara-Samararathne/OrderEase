using OrderEase.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEase.service
{
    public class UserService
    {
        private DatabaseHelper _dbHelper;

        public UserService()
        {
            _dbHelper = new DatabaseHelper();
        }

        public void addUser(User user)
        {
            if (user == null)
            {
                throw new Exception("invalid user details");
            }

            _dbHelper.SaveUser(user);

        }

        public User loginUser(string username, string password)
        {
            User loggedUser = _dbHelper.CheckLogin(username, password);
            if (loggedUser == null)
            {
                throw new Exception("Incorrect username or password");
            }

            return loggedUser;
        }
    }
}
