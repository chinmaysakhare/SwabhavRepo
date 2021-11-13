using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount acc1 = new SavingAccount(101, "Sohel", 5000);
            PrintDetails(acc1);
            CurrentAccount acc2 = new CurrentAccount(102, "Sanket", 5000);
            PrintDetails(acc2);
            acc1.Withdraw(4501);
            PrintDetails(acc1);
            acc2.Withdraw(6000);
            PrintDetails(acc2);

            
        }
        public static void PrintDetails(Account obj)
        {
            Console.WriteLine("Name : "+obj.Name);
            Console.WriteLine("Account Number : " + obj.AccNo);
            Console.WriteLine("Total Balance : "+obj.Balance);
            Console.WriteLine(obj.ToString());
            Console.ReadLine();
        }
    }
}
