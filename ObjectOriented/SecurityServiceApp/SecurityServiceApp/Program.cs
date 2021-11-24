using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityServiceApp.Module
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                SecurityService obj = new SecurityService();
                User u = obj.Login("ABC1", "password@1");
                PrintDetails(u);
                User u1 = obj.Login("ABC1", "password@2");
                PrintDetails(u1);
            }
            catch (PasswordDontMatchException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            try
            {
                SecurityService obj = new SecurityService();
                User u3 = obj.Login("WWW", "password@1");
            }
            catch (UserNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("\n\n\t\t\t\tThankyou for using this app");
                Console.ReadLine();
            }
        }
        public static void PrintDetails(User obj)
        {
            Console.WriteLine("User found \nLogin Succesful\n\n");
            Console.WriteLine("User Id : "+obj.Id);
            Console.WriteLine("First Name of the User : "+obj.FirstName);
            Console.WriteLine("Last Name of the User : "+obj.LastName);
            Console.WriteLine("Email of the User : "+obj.Email);
            Console.ReadLine();
        }
    }
}
