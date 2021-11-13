using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorDesignData.Model
{
    abstract class Person
    {
        private int _id;
        private string _address;
        private string _dateOfBirth;

        public Person(int id,string address,string dateofbirth)
        {
            this._id = id;
            this._address = address;
            this._dateOfBirth = dateofbirth;

        }
        public Person(int id,string address,string dateofbirth,double basicsalary1) : this(id, address, dateofbirth)
        {
            Basicsalary = basicsalary1;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
        }
        public string DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
        }
        public double Basicsalary { get; }

        public abstract string ExtraThings();
    }
}
