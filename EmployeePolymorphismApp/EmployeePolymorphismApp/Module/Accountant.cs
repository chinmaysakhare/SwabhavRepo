using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EmployeePolymorphismApp.Module
{
    class Accountant : Employee
    {
        
        public Accountant(int accNo, string name, double basicSal) : base(accNo, name, basicSal)
        {

        }

        public override ArrayList CalSal()
        {
            perks = (0.3 * _basicSal) + perks;
            _totalSal = _basicSal + perks;
            data.Add(_accNo);
            data.Add(ToString());
            data.Add(_name);
            data.Add(_basicSal);
            data.Add(perks);
            data.Add(_totalSal);
            return data;
        }

        public override string ToString()
        {
            return "Accountant";
        }
        
    }
}
/*
 * 
 * 
 * 
 * public override void DisplaySalSlip()
        {
            Console.WriteLine("Name : " + _name);
            Console.WriteLine("Employee Id : " + _accNo);
            Console.WriteLine("Employee Type : " + ToString() + " Employee");
            Console.WriteLine("Basic Salary : " + _basicSal);
            Console.WriteLine("Perks : " + perks);
            Console.WriteLine("__________________________________________________________/n");
            Console.WriteLine("Total Salary :" + _totalSal);
        }
*/