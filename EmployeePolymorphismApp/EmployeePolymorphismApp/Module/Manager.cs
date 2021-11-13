using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EmployeePolymorphismApp.Module
{
    class Manager : Employee
    {
        
        public Manager(int accNo, string name, double basicSal) : base(accNo, name, basicSal)
        {
        }

        public override ArrayList CalSal()
        {
            hra = (0.5 * _basicSal) + hra;
            ta = (0.4 * _basicSal) + ta;
            da = (0.3 * _basicSal) + da;
            _totalSal = _basicSal + hra + ta + da;
            data.Add(_accNo);
            data.Add(ToString());
            data.Add(_name);
            data.Add(_basicSal);
            data.Add(hra);
            data.Add(ta);
            data.Add(da);
            data.Add(_totalSal);
            return data;
        }
        public override string ToString()
        {
            return "Manager";
        }
    }
}

/*
 
 
 
 
 public string Name { get { return _name; } }
            public int AccountNumber { get { return _accNo; } }
            public double BasicSal { get { return _basicSal; } }
            public double HRA { get { return hra; } }
            public double TA { get { return ta; } }
            public double Da { get { return da; } }
            public double TotalSal { get { return _totalSal; } }
 */
