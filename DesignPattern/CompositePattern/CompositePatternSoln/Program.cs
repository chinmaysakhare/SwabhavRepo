using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternSoln
{
    class Program
    {
        static void Main(string[] args)

        {
            Folder movies = new Folder("Movies");
            movies.addItem(new File("titanic", "700MB"));
            
            Folder comedy = new Folder("Comedy");
            comedy.addItem(new File("3 Idiots", "800MB"));
            movies.addItem(comedy);
            movies.Display(2);
            Console.ReadLine();
        }
    }
}
