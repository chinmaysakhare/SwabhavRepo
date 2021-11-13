using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp2.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            Child C1 = new Child();
            Child C2 = new Child(200);
            Console.ReadLine();
        }
    }
}
