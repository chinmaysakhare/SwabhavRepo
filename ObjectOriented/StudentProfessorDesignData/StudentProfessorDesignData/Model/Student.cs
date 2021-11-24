using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorDesignData.Model
{
    class Student:Person
    {
        private int _id;
        private string _address;
        private string _dateOfBirth;
        private string _branch;

        public Student(int id,string address,string dateofbirth,string branch) : base(id, address, dateofbirth)
        {
            this._id = id;
            this._address = address;
            this._dateOfBirth = dateofbirth;
            this._branch = branch;
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
        public string Branch
        {
            get
            {
                return _branch;
            }
        }
        public override string ExtraThings()
        {
            Console.WriteLine($"Branch:{ _branch}");
            return string.Empty;
        }
    }
}
