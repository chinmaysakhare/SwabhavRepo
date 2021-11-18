using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublisherLib.Publisher;
using SubscriberClient.Subscriber;

namespace ObserverPatternSoln
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "Chinmay", 5000,"chinmaysakhare.1234@gmail.com");
            acc1.AddNotifier(new SmsNotifier());
            acc1.AddNotifier(new EmailNotifier());
            acc1.WithDraw(4900);
            acc1.Deposit(6000);
            acc1.WithDraw(4900);
            Console.ReadLine();
        }
    }
}
