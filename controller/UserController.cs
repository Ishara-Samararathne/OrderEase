using OrderEase.model;
using OrderEase.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEase.controller
{
    public class UserController
    {
        private UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        public User login(string username, string password) {
            return _userService.loginUser(username, password);
        }

        public void saveUser(User user)
        {
            _userService.addUser(user);
        }
    }
}
