using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CustomerApp.Module
{
    class CustomerTest
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Chinmay", 10000);
            Console.WriteLine(c1);
            Console.WriteLine(c1.ToString());
            Customer c2 = new Customer("Sanket", 200000);
            Customer c3 = new Customer("Sohel", 300000);
            PrintDetails(c1);
            PrintDetails(c2);
            PrintDetails(c3);
            PrintDetails(c1);
            Console.ReadLine();

            Type t = c1.GetType();
            MethodInfo[] mi = t.GetMethods();
            PropertyInfo[] pi = t.GetProperties();
            Console.WriteLine("Methods are : \n\n");
            foreach (MethodInfo m in mi)
            {
                Console.WriteLine(m.Name);
            }
            Console.ReadLine();
            ConstructorInfo[] ci = t.GetConstructors();
            foreach (ConstructorInfo c in ci)
                Console.WriteLine(c.ToString());
            Console.ReadLine();
        }
       
            
        public static void PrintDetails(Customer obj)
        {
            Console.WriteLine("Name :- "+obj.Name);
            Console.WriteLine("Amount :- "+obj.Amount);
            Console.WriteLine("Id : " + obj.Id+"\n\n");
        }

    }
}



/*
string filePath = @"E:\Swabhav\23.10.21_\CustomerApp\CustomerDetails.txt";
            List<string> lines = new List<string>();
            List<Customer> customers = new List<Customer>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] item = line.Split(',');
                
            }
*/