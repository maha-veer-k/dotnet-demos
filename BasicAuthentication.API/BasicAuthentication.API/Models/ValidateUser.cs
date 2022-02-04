using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthentication.API.Models
{
    public class ValidateUser
    {
        public static bool Login(string username, string password)
        {
            UserBL userBL = new UserBL();
            var UserList = userBL.GetUsers();
            return  UserList.Any(user => 
               user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) &&
               user.Password == password);
        }
    }
}