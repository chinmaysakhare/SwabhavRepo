using DogDoorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp
{
    class DogDoorConsole
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine(" Fido is barking to go outside");
            remote.pressButton();
            Console.WriteLine(" Fido has gone outside");
            remote.pressButton();
            Console.WriteLine(" Fido is done outside");
            remote.pressButton();
            Console.WriteLine(" Fido is back inside");
            remote.pressButton();
            Console.ReadLine();
        }
    }
}
