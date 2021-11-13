using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EmployeePolymorphismApp.Module
{
    abstract class Employee
    {
        protected int _accNo;
        protected string _name;
        protected double _basicSal;
        protected double _totalSal;
        protected double hra = 0;
        protected double ta = 0;
        protected double da = 0;
        protected double pa = 0;
        protected double ot = 0;
        protected double perks = 0;
        protected ArrayList data = new ArrayList();
        public Employee(int accNo, string name, double basicSal)
        {
            _accNo = accNo;
            _name = name;
            _basicSal = basicSal;
        }
        public abstract ArrayList CalSal();
        //public abstract void DisplaySalSlip();
    }
}
