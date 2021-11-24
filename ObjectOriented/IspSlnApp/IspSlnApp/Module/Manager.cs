using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspSlnApp.Module
{
    class Manager:IWorkableEatable
    {
        public  void startEat()
        {
            Console.WriteLine("Manager StartedEating");
        }
        public  void stopWork()
        {
            Console.WriteLine("Manager Stopped Working");
        }
        public  void stopEat()
        {
            Console.WriteLine("Manager Stopped Eating");
        }
        public  void startWork()
        {
            Console.WriteLine("Manager Started working");
        }
    }
}
