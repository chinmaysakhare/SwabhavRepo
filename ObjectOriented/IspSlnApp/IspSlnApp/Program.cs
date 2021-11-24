using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspSlnApp.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Manager();
            var r = new Robot();
            AtTheCafeteria(m);
            AtTheCafeteria(r);
            AtTheWorkStation(m);
            AtTheWorkStation(r);
        }
        public static void AtTheCafeteria(IWorkableEatable worker)
        {
            worker.startEat();
            worker.stopEat();
        }
        public static void AtTheWorkStation(IWorkable worker)
        {
            worker.startWork();
            worker.stopWork();
        }
    }
}
