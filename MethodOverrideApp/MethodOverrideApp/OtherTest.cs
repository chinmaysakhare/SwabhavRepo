using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrideApp.Module
{
    class OtherTest
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            Console.WriteLine("======================================================");
            
            CaseStudy2();
            Console.WriteLine("======================================================");
            CaseStudy3();
            Console.WriteLine("======================================================");
            CaseStudy4();
            Console.WriteLine("======================================================");
            CaseStudy5();
            Console.ReadLine();

        }
        public static void CaseStudy5()
        {
            Object x;
            x = 10;
            Console.WriteLine(x.GetType());
            x = "Hello";
            Console.WriteLine(x.GetType());
            x = 10.5f;
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());
        }
        public static void CaseStudy1()
        {
            Man x;
            x = new Man();
            x.walk();
            x.Play();
            x.Read();
           
        }
        public static void CaseStudy2()
        {
            Boy y;
            y = new Boy();
            y.Play();
            y.walk();
            y.Read();
            y.Jump();
        }
        public static void CaseStudy3()
        {
            Man z;
            z = new Boy();
            z.walk();
            z.Play();
            z.Read();

        }
        public static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Infant());
        }
        public static void AtThePark(Man a)
        {
            Console.Write("At the Park ");
            a.Play();
        }
    }
    
}
