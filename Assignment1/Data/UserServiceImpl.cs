using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Assignment1.Data
{
    public class UserServiceImpl : IUserService
    {
        private List<User> users;

        public UserServiceImpl()
        {
            users = new[]
            {
                new User
                {
                    Password = "malpa",
                    Username = "admin",
                }
            }.ToList();
        }
        
        public User ValidateUser(string Username, string Password)
        {
            User first = users.FirstOrDefault(user => user.Username.Equals(Username));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(Password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}