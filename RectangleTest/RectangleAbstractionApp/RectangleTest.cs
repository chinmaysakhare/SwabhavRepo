using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAbstractionApp.Model
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle small=new Rectangle();
            small.height = 10;
            small.width = 5;
            int area = small.Area();
           // Console.WriteLine("Area is " + area);


            Rectangle big = new Rectangle();
            big.height = 80;
            big.width = 3;
            area = big.Area();
            //Console.WriteLine("Area is " + area);
            //Console.ReadLine();
            
            
            Rectangle temp = small;
            //Console.WriteLine(temp.width);
            //Console.WriteLine(small.width);
            temp.width = temp.width + 7;
            //Console.WriteLine(temp.width);
            //Console.WriteLine(small.width);
            //Console.WriteLine(temp.Area());
            Console.WriteLine(small.GetHashCode());
            Console.WriteLine(big.GetHashCode());
            Console.WriteLine(temp.GetHashCode());


            Console.ReadLine();

        }
    }
}
