using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Module
{
    class Customer
    {
        private string _name;
        private double _amount;
        private string _id;
        private static int temp=0;

        public Customer(string name, double amount)
        {
            temp++;
            this._id = string.Concat("C00", temp);
            this._name = name;
            this._amount = amount;
        }
        public string Name
        {
            get { return _name; }
        }
        public double Amount
        {
            get { return _amount; }
        }
        public string Id { get { return _id; } }
    }
}
