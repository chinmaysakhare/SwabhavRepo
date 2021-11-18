using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PublisherLib.Publisher
{
    public class Account
    {
        private int _accNo;
        private string _name;
        private double _balance;
        private string _email;
        private List<INotifier> notifiers = new List<INotifier>();
        public Account(int accNo, string name, double balance,string email)
        {
            _accNo = accNo;
            _name = name;
            _balance = balance;
            _email = email;
        }
        public void Deposit(double bal)
        {
            Console.WriteLine("Deposit Sucessful");
            _balance += bal;
            NotifySubs();
        }
        public void WithDraw(double bal)
        {
            double temp = _balance - bal;
            if (temp >= 500)
            {
                Console.WriteLine("Withdraw Successful");
                _balance -= bal;
                NotifySubs();
            }
            else
                Console.WriteLine("Transaction failed. Withdraw amt is higher. violating minimum balance");
        }
        public void AddNotifier(INotifier n)
        {
            notifiers.Add(n);
        }
        private void NotifySubs()
        {
            foreach (var notifier in notifiers)
                notifier.Notify(this);
        }
        public double Balance { get {return _balance; } }
        public string Email { get {return _email; } }
        public string Name { get {return _name; } }
        public int accNo { get { return _accNo; } }
    }
}
