using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            caseStudy1();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
            caseStudy2();
            Console.ReadKey();
        }
        public static void caseStudy1()
        {
            IImage img1 = new RealImage("One.jpg");
            IImage img2 = new RealImage("Twojpg");
            IImage img3 = new RealImage("Three.jpg");
            img3.display();
        }
        public static void caseStudy2()
        {
            IImage img4 = new ProxyImage("Four.jpg");
            IImage img5 = new ProxyImage("Five.jpg");
            IImage img6 = new ProxyImage("Six.jpg");
            img6.display();
        }
    }
}
