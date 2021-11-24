using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictonaryApp2.Module
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
            var s1 = new Student(12,10,"Vinay","Mumbai");
            var s2 = new Student(10,12,"Chinmay","Mumbai");
            var s3 = new Student(12,10,"VINAY","MUMBAI");
            Console.WriteLine("HashCode Student 1 :"+s1.GetHashCode());
            Console.WriteLine("HashCode Student 2 :" + s2.GetHashCode());
            Console.WriteLine("HashCode Student 3 :" + s3.GetHashCode());
            var Students = new Dictionary<Student,Student>();
            Students.Add(s1,s1);
            Students.Add(s2,s2);
            if(!Students.ContainsKey(s3))
            { Students.Add(s3, s3); }
              Console.WriteLine("Total Students : "+Students.Count);
        }
        public static void CaseStudy1()
        {
            var map = new Dictionary<int, string>();
            map.Add(101, "One");
            //map.Add(103, "ONE");
            map.Add(102, "Two");
            Console.WriteLine("Total No. of Elements in the map " + map.Count);
            foreach (var item in map)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
        }
    }
}

