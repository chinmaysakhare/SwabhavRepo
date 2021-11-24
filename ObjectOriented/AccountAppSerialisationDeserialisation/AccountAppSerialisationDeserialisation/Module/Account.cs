using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAppSerialisationDeserialisation.Module
{
    class Account
    {
        private double _balance;
        private string _name;
        private int _accNo;
        public void UpdateBal(double balance)
        {
            _balance = balance;
        }
        public Account(int _accNo, string _name) 
        {
           _balance = 1000;
            this._name = _name;
            this._accNo = _accNo;
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
        public string Name
        {
            get 
            {
                return _name;
            }
        }
        public int AccNo
        {
            get 
            {
                return _accNo;
            }
        }
        
    }

}
