using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorDesignData.Model
{
    class Professor:SalaryEmp
    {
        private double _bonus;
        private double _totalsalary;
        private double _basicSalary;

        public Professor(int id,string address,string dateofbirth,double basicsalary) : base(id, address, dateofbirth, basicsalary)
        {
            _bonus = 50;
            _basicSalary = basicsalary;
        }
        public double TotalSalary
        {
            get
            {
                return _totalsalary;
            }
        }
        public override double  CalcSalary()
        {
            double initialSalary = (_bonus/100)*_basicSalary;
            _totalsalary = initialSalary + _basicSalary;
            return _totalsalary;
        }
        public override string ExtraThings()
        {
            Console.WriteLine($"Total salary: {CalcSalary()}");
            return string.Empty;
        }
    }
}
