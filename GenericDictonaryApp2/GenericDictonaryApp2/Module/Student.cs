using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictonaryApp2
{
    class Student
    {
        private int _rollnumber;
        private int _std;
        private string _name;
        private string _loc;

        public Student(int rollnumber, int std, string name, string loc)
        {
            _rollnumber = rollnumber;
            _std = std;
            _name = name;
            _loc = loc;
        }

        public override int GetHashCode()
        {
            string hashcode = Convert.ToString(_rollnumber) + Convert.ToString(_std);
            return int.Parse(hashcode);

        }
        public override bool Equals(object obj)
        {
            Student studentobj = (Student)obj;
            if (this._rollnumber == studentobj._rollnumber && this._std == studentobj._std)
            {
                return true;
            }
            else
                return false;
        }
        public int RollNo { get { return _rollnumber; } }  
        public int Class { get { return _std; } }  
        public string Name { get { return _name; } }  
        public string loc { get { return _loc; } }  
        /*public bool CheckSame(Student obj)
        {

        }*/
    }
}
