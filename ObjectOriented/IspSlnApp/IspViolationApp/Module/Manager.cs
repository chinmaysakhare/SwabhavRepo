using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspViolationApp.Module
{
    class Manager : IWorker
    {
        public void startEat()
        {
            Console.WriteLine("Manager is Eating");
        }
        public void stopEat()
        {
            Console.WriteLine("Manager stopped eating");
        }
        public void startWork()
        {
            Console.WriteLine("Manager is working");
        }
        public void stopWork()
        {
            Console.WriteLine("Manager stopped Working ");
        }
    }
}
