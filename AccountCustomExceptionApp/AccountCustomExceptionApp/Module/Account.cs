using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Module
{
    public class Account
    {
        private int _accNo;
        private string _name;
        private double _balance;
        private double _withdrawAmt;

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

        public void Withdraw(double amt)
        {
            if (_balance - amt < 500)

            {
                _withdrawAmt = amt;
                throw new InsufficientFundsException(this);
            }   
        }
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
        public double WithdrawBal
        { get { return _withdrawAmt; } }

    }
}

