using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SingletonPatternApp.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() =>
                {
                    DataService.GetInstance().DoSomething();
                });
            Thread t2 = new Thread(() =>
            {
                DataService.GetInstance().DoSomething();
            });
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
        public static void CaseStudy()
        {
            var sv1 = DataService.GetInstance();
            var sv2 = DataService.GetInstance();
            Console.WriteLine(sv1.GetHashCode());
            Console.WriteLine(sv2.GetHashCode());
            sv1.DoSomething();
            sv2.DoSomething();
        }
    }
}
