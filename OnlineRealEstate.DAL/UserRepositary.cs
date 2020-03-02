using OnlineRealEstate.Entity;
using System.Collections.Generic;
using System.Linq;

namespace OnlineRealEstate.DAL
{
    public class UserRepositary
    {
        List<User> userList = new List<User>();
        public int SignUp(User user)
        {
            PropertyContext propertyContext = new PropertyContext();
            propertyContext.User.Add(user);
            return propertyContext.SaveChanges();
        }
        public string Login(User user)
        {
            bool flag = false;
            string role="";
            PropertyContext propertyContext = new PropertyContext();
            userList = propertyContext.User.ToList();
            foreach(var userInformation in userList)
            {
                if (userInformation.Email == user.Email && userInformation.Password == user.Password)
                {
                   propertyContext.SaveChanges();
                    role = userInformation.Role;
                    flag = true;
                }  
            }
            if(flag)
            {
                return role;
            }
            else
            {
                return role;

            }
        }
    }
}
