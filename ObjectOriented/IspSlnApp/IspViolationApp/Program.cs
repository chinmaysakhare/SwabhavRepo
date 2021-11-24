using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspViolationApp.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Manager();
            var r = new Robot();

            AtTheCafeteria(m);
            try
            {
                AtTheCafeteria(r);
            }
            catch (Exception e)
            {
                Console.WriteLine("Isp Violation");
            }
            Console.ReadLine();

        }
        public static void AtTheCafeteria(IWorker worker)
        {
            worker.startWork();
            worker.stopWork();
            worker.startEat();
            worker.stopEat();
            Console.ReadLine();
        }
    }
}
