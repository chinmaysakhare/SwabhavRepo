using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Module
{
    class CurrentAccount : Account
    {
        public CurrentAccount(int accNo, string name, double balance) : base(accNo, name, balance)
        {
        }

        public override void Withdraw(double amt)
        {
            if (DoOverDraftCheck(amt))
            {
                _balance = _balance - amt;
            }

        }
        public bool DoOverDraftCheck(double amt)
        {
            double temp = _balance - amt;
            if (temp > -5000)
            {
                return true;
            }
            else
                return false;
        }
        public override string ToString()
        {
            string s = "Account type :- Current";
            return s;
        }

    }
}
