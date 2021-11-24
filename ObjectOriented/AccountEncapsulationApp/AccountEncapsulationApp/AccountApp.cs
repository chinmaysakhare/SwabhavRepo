using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEncapsulationApp.Module
{
    class AccountApp
    {
        static void Main(string[] args)
        {
            Account[] users = new Account[5];
            users[0]=new Account(101,"Tommy Shelby",5000.25);
            users[1]=new Account(102, "Michael Gray",3000.5);
            users[2]=new Account (103, "Aurthur Shelby", 3500.75);
            users[3]=new Account (104, "Jhon Shelby", 670.6);
            users[4] = new Account(105, "Ada Shelby", 3569.6);
            for (int i = 0; i < users.Length; i++)
            {
                PrintDetails(users[i]);
            }
            double wealthy = RichestAccount(users);
            Console.WriteLine("Highest account Balance: " + wealthy);
            Console.ReadLine();
            DistributeAmt(wealthy,users);
            for (int i = 0; i < users.Length; i++)
            {
                PrintDetails(users[i]);
            }
            Console.ReadLine();
        }

        public static void PrintDetails(Account obj)
        {
            Console.WriteLine(obj.GetAccountNumber());
            Console.WriteLine(obj.GetName());
            Console.WriteLine(obj.GetBalance());
            Console.ReadLine();
        }
        public static double RichestAccount(Account[] obj)
        {
            double highest=obj[0].GetBalance();
            for(int i=0;i<obj.Length;i++)
            {
                for (int j=i+1;j<obj.Length;j++)
                {
                    if (obj[j].GetBalance() > highest)
                    {
                        highest = obj[j].GetBalance();
                    }
                }
            }
            return highest;
        }
        public static void  DistributeAmt(double amt,Account []obj)
        {
            double temp = amt;
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].GetBalance() == amt)
                {
                    obj[i].UpdateBalance(500-temp);
                }
            }
            amt = (amt-500)/ 4;
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].GetBalance() != 500)
                    obj[i].UpdateBalance(amt);
                else
                    continue;
            }

        }
    }
}

/*
  Account userOne = new Account(100, "Tommy Shelby", 1500);
            PrintDetails(userOne);
            userOne.Deposit(1000.50);
            userOne.Withdraw(2000);
            PrintDetails(userOne); */