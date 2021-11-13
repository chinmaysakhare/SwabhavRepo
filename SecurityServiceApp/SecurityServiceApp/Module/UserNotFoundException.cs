using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityServiceApp.Module
{
    class UserNotFoundException : Exception
    {
        private string _message;
        public UserNotFoundException(string id)
        {
            _message = "User with '"+id +"' Id not found";  
        }
        public override string Message
        {
            get { return _message; }
        }
    }
}
