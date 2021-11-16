using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspSlnApp.Module
{
    class Robot:IWorkable
    {
        public  void startWork()
        {
            Console.WriteLine("Robot Started working");
        }public  void stopWork()
        {
            Console.WriteLine("Robot Stopped working");
        }
    }
}
