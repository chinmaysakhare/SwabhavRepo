using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Module
{
    public class InsufficientFundsException : Exception

    {
        private string _message;
        public InsufficientFundsException(Account obj)
        {
            _message = "Tranasaction Declined for Account holder. \n" +
                "Minimun Balance Excedded\n " + obj.Name + " " + obj.AccNo 
                + "\n Withdrawl failed becase withdrawl amt was : " + obj.WithdrawBal;

        }
        public override string Message
        {
            get { return _message; }
        }
    }
}
/*
 *public InsufficientFundsException(string message) : base(string.Format("Tranasaction Declined for Account holder. Minimun Balance Excedded"))
        {

        } 
 * 
 */