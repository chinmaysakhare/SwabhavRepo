using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EmployeePolymorphismApp.Module
{
    class Developer : Employee
    {

        public Developer(int accNo, string name, double basicSal) : base(accNo, name, basicSal)
        {

        }

        public override ArrayList CalSal()
        {
            pa = (0.4 * _basicSal) + pa;
            ot = (0.3 * _basicSal) + ot;
            _totalSal = _basicSal + ot + pa;
            data.Add(_accNo);
            data.Add(ToString());
            data.Add(_name);
            data.Add(_basicSal);
            data.Add(pa);
            data.Add(ot);
            data.Add(_totalSal);
            return data;
        }

        public override string ToString()
        {
            return "Developer";
        }
    }
}


/*
 * 
 * 
 *   public override void DisplaySalSlip()
        {
            Console.WriteLine("Name : " + _name);
            Console.WriteLine("Employee Id : " + _accNo);
            Console.WriteLine("Employee Type : " + ToString() + " Employee");
            Console.WriteLine("Basic Salary : " + _basicSal);
            Console.WriteLine("PA : " + pa);
            Console.WriteLine("OT : " + ot);
            Console.WriteLine("__________________________________________________________/n");
            Console.WriteLine("Total Salary :" + _totalSal);
        }

*/