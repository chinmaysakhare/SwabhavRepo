using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EmployeePolymorphismApp.Module
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Manager m = new Manager(101,"Sohel",25000);
            DisplaySalarySlip(m);
            Console.ReadLine();
            Developer d = new Developer(201, "Sanket", 20000);
            DisplaySalarySlip(d);
            Console.ReadLine();
            Accountant a = new Accountant(301,"Chinmay",15000);
            DisplaySalarySlip(a);
            Console.ReadLine();
        }
        public static void DisplaySalarySlip(Employee obj)
        {
            ArrayList currentData =obj.CalSal();
            int count = currentData.Count;
            if (count == 8)
            {
                Console.WriteLine("Account Number : " + currentData[0]);
                Console.WriteLine("Employee Designation : " + currentData[1]);
                Console.WriteLine("Name : " + currentData[2]);
                Console.WriteLine("Basic Salary : " + currentData[3]);
                Console.WriteLine("HRA : " + currentData[4]);
                Console.WriteLine("TA : " + currentData[5]);
                Console.WriteLine("DA : " + currentData[6]);
                Console.WriteLine("Total Salary : " + currentData[7]);
            }
            else if (count == 7)
            {
                Console.WriteLine("Account Number : " + currentData[0]);
                Console.WriteLine("Employee Designation : " + currentData[1]);
                Console.WriteLine("Name : " + currentData[2]);
                Console.WriteLine("Basic Salary : " + currentData[3]);
                Console.WriteLine("PA : " + currentData[4]);
                Console.WriteLine("OT : " + currentData[5]);
                Console.WriteLine("Total Salary : " + currentData[6]);
            }
            else if (count == 6)
            {
                Console.WriteLine("Account Number :  " + currentData[0]);
                Console.WriteLine("Employee Designation : " + currentData[1]);
                Console.WriteLine("Name :" + currentData[2]);
                Console.WriteLine("Basic Salary : " + currentData[3]);
                Console.WriteLine("Perks : " + currentData[4]);
                Console.WriteLine("Total Salary : " + currentData[5]);
            }
        }

    }
}
