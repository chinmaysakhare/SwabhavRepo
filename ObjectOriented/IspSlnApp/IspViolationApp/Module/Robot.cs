using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspViolationApp.Module
{
    class Robot:IWorker
    {
        public void startWork()
        {
            Console.WriteLine("Robot is working");
        }
        public void stopWork()
        {
            Console.WriteLine("Robot stopped Working ");
        }
        public void startEat()
        {
            throw new Exception("Robots cant eat");
        }
        public void stopEat()
        {
            throw new Exception("Robots cant eat");
        }
    }
}
