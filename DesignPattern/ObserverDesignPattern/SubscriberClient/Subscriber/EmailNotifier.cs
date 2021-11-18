using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublisherLib.Publisher;

namespace SubscriberClient.Subscriber
{
    public class EmailNotifier:INotifier
    {
        public void Notify(Account obj)
        {
            Console.WriteLine();
            Console.WriteLine("Email send to " + obj.Email);
            Console.WriteLine("Updated Balance :-" + obj.Balance);
            Console.WriteLine("Name  : "+obj.Name+"\t Account No: "+obj.accNo);
            Console.WriteLine("================================================================================================");

        }
    }
}
