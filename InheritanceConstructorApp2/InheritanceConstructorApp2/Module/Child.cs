using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp2.Module
{
    class Child:Parent
    {
        public Child(): base(100)
        {
            Console.WriteLine("Child is Created");
        }
        public Child(int a):base(100)
        {
            Console.WriteLine("Child is Created");
            Console.WriteLine(a);
        }
    }
}
