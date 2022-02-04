using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthentication.API.Models
{
    public class UserBL
    {
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User()
            {
                Id = 1,
                UserName = "backend",
                Password = "Back@123"
            });
            users.Add(new User()
            {
                Id = 2,
                UserName = "frontend",
                Password = "Front@123"
            });
            users.Add(new User()
            {
                Id = 3,
                UserName = "hr",
                Password = "Hr@123"
            });
            return users;
        }
    }
}