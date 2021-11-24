using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEncapsulationApp.Module
{
    class Account
    {
        private int _accountNo;
        private string _name;
        private double _balance;
        public Account(int n,string name,double bal)
        {
            _accountNo = n;
            _name = name;
            _balance = bal;
        }
        public void UpdateBalance(double amt)
        {
            _balance = _balance + amt;
        }

        public void Deposit(double amt)
        {
            if (amt < 0)
            {
                _balance = (-1 * amt) + _balance;
            }
            else
             _balance = amt + _balance;
        }
        public void Withdraw(double amt)
        {
            if (_balance - amt >= 500)
            {
                _balance = _balance - amt;

            }
            else
            {
                Console.WriteLine("Minimum balance amt exceeded. Withdraw Failed");
            }
        }
        public int GetAccountNumber()
        {
            return _accountNo;
        }
        public string GetName()
        {
            return _name;
        }
        public double GetBalance()
        {
            return _balance;

        }
    }
}

