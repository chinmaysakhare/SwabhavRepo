using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityServiceApp.Module
{
    class PasswordDontMatchException: Exception
    {
        private string _message;
        public PasswordDontMatchException()
        {
            _message = "User ID and Password Dont match";
        }
        public override string Message
        {
            get { return _message; }
        }
    }
}
