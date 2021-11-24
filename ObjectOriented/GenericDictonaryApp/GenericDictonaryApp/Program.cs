using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictonaryApp.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy2();
            Console.ReadLine();
        }
        public static void CaseStudy2()
        {
            
            var map = new Dictionary<int, string>();
            var s1=new 
        }
        public static void CaseStudy1()
        {
            var map = new Dictionary<int, string>();
            map.Add(101, "One");
            //map.Add(103, "ONE");
            map.Add(102, "Two");
            Console.WriteLine("Total No. of Elements in the map "+map.Count);
            foreach (var item in map)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }
        }
    }
}
