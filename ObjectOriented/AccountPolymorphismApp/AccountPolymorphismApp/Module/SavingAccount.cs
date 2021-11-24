using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Module
{
    class SavingAccount : Account
    {
        public SavingAccount(int accNo, string name, double balance) : base(accNo, name, balance)
        {

        }

        public override void Withdraw(double amt)
        {
            if (CheckMinBal(amt))
            {
                _balance = _balance - amt;
            }
        }
        public bool CheckMinBal (double amt)
        {
            double temp = _balance - amt;
            if (temp >= 500)
            {
                return true;
            }
            else
                return false;
        }
        public override string ToString()
        {
            string s = "Account type :- Savings";
            return s;
        }

    }
}
