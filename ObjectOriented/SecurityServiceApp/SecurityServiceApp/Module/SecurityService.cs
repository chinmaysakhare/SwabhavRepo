using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SecurityServiceApp.Module
{
    class SecurityService
    {
        Dictionary<string, User> Users = new Dictionary<string, User>();

        public SecurityService()
        {
            User u1 = new User("ABC1", "Chinmay", "Sakhare", "chinmay@gmail.com", "password@1");
            User u2 = new User("ABC2", "Vinay", "Govekar", "vinay@gmail.com", "password@2");
            User u3 = new User("ABC3", "Sanket", "Dhote", "sanket@gmail.com", "password@3");
            User u4 = new User("ABC4", "Sohel", "Maneri", "sohel@gmail.com", "password@4");
            User u5 = new User("ABC5", "Vallabh", "Ghundla", "vallabh@gmail.com", "password@5");
            Users.Add(u1.Id, u1);
            Users.Add(u2.Id, u2);
            Users.Add(u3.Id, u3);
            Users.Add(u4.Id, u4);
            Users.Add(u5.Id, u5);
        }
        public User Login(string id, string pw)
        {
            if (Users.ContainsKey(id))
            {
                User u = Users[id];
                if (u.PassWord == pw)
                    return u;
                else
                    throw new PasswordDontMatchException();
            }
            else
                throw new UserNotFoundException(id);
        }
    }
}
/*
 *  
 * 
 * 
 * 
 * 
 * public User Login1(string id, string pw)
{
    try
    {
        if (Users.ContainsKey(id))
        {
            User u = Users[id];
            try
            {
                if (u.PassWord == pw)
                    return u;
                else 
                    return null;
            }
            catch (PasswordDontMatchException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        else 
            return null;
    }
    catch (UserNotFoundException e)
    {
        Console.WriteLine(e.Message);
    }
}
}
}
/*if (Users.ContainsKey(id))
{
User u = Users[id];
if (u.PassWord == pw)
return u;
else
throw new PasswordDontMatchException();
}*/