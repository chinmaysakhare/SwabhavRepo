using StudentProfessorDesignData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorDesignData
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p = new Professor(1, "Vashi", "17/07/2021", 30000);
            Professor p1 = new Professor(2, "Panvel", "19/06/2021", 20000);

            Student s = new Student(100, "CBD-Belapur", "11/2/2021", "Electronics Engineering");
            Student s1 = new Student(101, "Nerul", "11/064/2017", "Electronics and Communication Engineering");

            PrintDetails(p);
            PrintDetails(p1);
            PrintDetails(s);
            PrintDetails(s1);
            Console.ReadKey();
        }

        public static void PrintDetails(Professor p)
        {
            Console.WriteLine("\n Id :" + p.Id);
            Console.WriteLine(" Name :" + p.Address);
            Console.WriteLine(" DOB :" + p.DateOfBirth);
            Console.WriteLine(" Basic Salary :" + p.Basicsalary);
        }
        public static void PrintDetails(Student s)
        {
            Console.WriteLine("\n Id :" + s.Id);
            Console.WriteLine(" Name :" + s.Address);
            Console.WriteLine(" Date Of Birth :" + s.DateOfBirth);
            Console.WriteLine(" Branch Details :" + s.Branch);
        }
    }
}
