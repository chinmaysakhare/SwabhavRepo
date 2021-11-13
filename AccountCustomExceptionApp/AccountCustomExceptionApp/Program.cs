using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Module
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Account acc1 = new Account(101, "Chinmay", 5000);
                acc1.Withdraw(4501);
            }
           
            catch (InsufficientFundsException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("yy");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }



        }
        public static void PrintDetails(Account obj)
        {
            Console.WriteLine(obj.AccNo);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Balance);
        }
    }
}
