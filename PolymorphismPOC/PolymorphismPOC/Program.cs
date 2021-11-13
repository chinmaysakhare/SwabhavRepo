using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPOC.Module
{
    
    class main
    {
        public static void Main(String[] args)
        {
            Polymorphisim p = new Polymorphisim();                                      //Superclass object is created
            Console.WriteLine("Variable with the same name : "+p.varWithSameName);
            PolymorphisimSubClass p1 = new PolymorphisimSubClass();                     // subclass object created
            Console.WriteLine("Variable with same name : "+p1.varWithSameName);
            Polymorphisim p2 = new PolymorphisimSubClass();                             //Upcasted the subClass to super class.
            Console.WriteLine("Variable with same name : " + p2.varWithSameName);
            Console.WriteLine("\n\nVariable Shadowing Achieved. Type of Compile Time Polymorphism \n\n");
            p.Method();
            p1.Method();
            p2.Method();
            Console.ReadLine();
        }
    }
}
