using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp2.Module
{
    class Parent
    {
        public Parent(int foo)
        {
            Console.WriteLine("Parent is Created");
            Console.WriteLine(foo);
        }
    }
}
