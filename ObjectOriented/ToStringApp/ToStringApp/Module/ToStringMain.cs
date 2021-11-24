using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringApp.Module
{
    class ToStringMain
    {
        int _id;
        string _name;
        double _amt;

        public ToStringMain(int id, string name, double amt)
        {
            _id = id;
            _name = name;
            _amt = amt;
        }

        public String ToString()
        {
            string s= "Parent -> Account holder name is " + _name + " . Balance is  " + _amt; ;
            return s;
        }
        public bool equals(ToStringMain a)
        {
            if (this._id == a._id)
            {
                return true;
            }
            else
                return false;
        }
    }
}
