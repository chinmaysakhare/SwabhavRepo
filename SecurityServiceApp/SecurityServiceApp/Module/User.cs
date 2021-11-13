using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityServiceApp.Module
{
    class User
    {
        private string _id;
        private string _fName;
        private string _lName;
        private string _email;
        private string _pw;

        public User()
        {
        }

        public User(string id, string fName, string lName, string email, string pw)
        {
            _id = id;
            _fName = fName;
            _lName = lName;
            _email = email;
            _pw = pw;
        }

        public string Id { get { return _id; } }
        public string FirstName { get {return _fName; } }
        public string LastName { get {return _lName; } }
        public string Email { get { return _email; } }
        public String PassWord { get { return _pw; }  }
    }
}
