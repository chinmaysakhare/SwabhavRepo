using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgram.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            Man x = new Man();
            Boy y = new Boy();
            AtThePartyHall(x);
            AtThePartyHall(y);
            //AtTheCinemaHall(x);
            AtTheCinemaHall(y);
            Console.ReadLine();

        }
        public static void AtThePartyHall(Imanner obj)
        {
            Console.WriteLine(  "At the party.");
            obj.Wish();
            obj.Depart();
        }
        public static void AtTheCinemaHall(IEmotion obj)
        {
            Console.WriteLine("At the Cinema");
            obj.Cry();
            obj.Laugh();
        }
    }
}
