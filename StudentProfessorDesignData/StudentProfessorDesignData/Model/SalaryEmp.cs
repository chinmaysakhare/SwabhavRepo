using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorDesignData.Model
{
    abstract class SalaryEmp:Person
    {
        private double _basicSalary;

        public SalaryEmp(int id,string address,string dateofbirth,double basicsalary) : base(id, address, dateofbirth, basicsalary)
        {
            _basicSalary = basicsalary;
        }
        public abstract double CalcSalary();
    }
}
