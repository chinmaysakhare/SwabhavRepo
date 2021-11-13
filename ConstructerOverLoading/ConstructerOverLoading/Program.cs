using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructerOverLoading.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            Player sachin = new Player("Sachin Tendulkar", 45, GenderType.male);
            //PrintDetails(sachin);
            //Console.ReadLine();
            //Console.WriteLine("\n\n");
            Player virat = new Player("Virat Kohli");
            //PrintDetails(virat);
            //Console.ReadLine();
            Player elder = sachin.WhoIsElder(virat);
            PrintDetails(elder);
            Console.ReadLine();
        }
        public static void PrintDetails(Player obj)
        {
            Console.WriteLine(obj.GetName());
            Console.WriteLine(obj.GetAge());
            Console.WriteLine(obj.GetGenderr());
        }
    }
}
