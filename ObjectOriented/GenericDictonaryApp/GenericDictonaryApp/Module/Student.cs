using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGenericApp.Module
{
    class Student
    {
        private int _rollnumber;
        private int _std;
        private string _name;
        private string _loc;

        public Student(int rollnumber, string name, string loc)
        {
            _rollnumber = rollnumber;
            _name = name;
            _loc = loc;
        }
        public override int GetHashCode()
        {
            return _rollnumber;
        }
        public override bool Equals(object obj)
        {
          
        }
        public bool CheckSame(Student obj)
        {
            
        }
    }
}
