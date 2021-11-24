using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Module
{
    abstract class Account
    {
        private int _accNo;
        protected string _name;
        protected double _balance;

        public Account(int accNo, string name, double balance)
        {
            _accNo = accNo;
            _name = name;
            _balance = balance;
        }

        public void Deposit(double amt)
        {
            _balance += amt;
        }
        
        public abstract void Withdraw(double amt);
        
        public int AccNo
        {
            get 
            {
                return _accNo;
            }
        }
        public string Name
        {
            get { return _name; }
        }
        public double Balance
        { get { return _balance; } }
        
    }
}
