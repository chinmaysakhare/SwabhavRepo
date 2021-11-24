using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGenericApp.Module
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
            HashSet<Student> students = new HashSet<Student>();
            Student s1 = new Student(101, "Chinmay", "Mumbai");
            Student s2 = new Student(101, "Chinmay", "Mumbai");
            students.Add(s1);
            students.Add(s2);
            Console.WriteLine("Hashcode S1: "+s1.GetHashCode());
            Console.WriteLine("Hashcode S2: " + s2.GetHashCode());
            Console.WriteLine("Are the elements same? :"+s1.CheckSame(s2));
            Console.WriteLine("No of elements : "+students.Count);
        }
        public static void CaseStudy1()
        {
            HashSet<int> nos = new HashSet<int>();
            nos.Add(10);
            nos.Add(200);
            nos.Add(5);
            nos.Add(5);
            nos.Add(300);
            
            foreach (var el in nos)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine("Size of Hashset " + nos.Count);
        }
    }
}
