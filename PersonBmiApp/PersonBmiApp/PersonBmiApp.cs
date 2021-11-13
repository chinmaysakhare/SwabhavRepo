using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonBmiApp.Module
{
    class PersonBmiApp
    {
        // public Person(string n, float h, float w, float a, string g)
        static void Main(string[] args)
        {
            Person[] human = new Person[5];
            human[0] = new Person("Sanket", 12f * 5.8f, 75.3f, 22, "Male");
            human[1] = new Person("Sohel", 12f * 5.9f, 68.3f, 22, "Male");
            human[2] = new Person("Chinmay", 12f * 5.7f, 100.0f, 22, "Male");
            human[3] = new Person("Gunjan", 12f * 5.5f, 34.3f, 21, "Female");
            human[4] = new Person("Ishita", 12f * 5.4f, 62.3f, 22, "Female");
            Console.WriteLine("Before Working out or eating\n\n");
            PrintDetail(human);
            Console.ReadLine();
            Console.WriteLine("\n\n\n\t\t\t After Working out\n\n");
            for (int i = 0; i < human.Length; i++)
            {
                human[i].Workout();
            }
            for (int i = 0; i < 4; i++)
            { human[2].Workout(); }
            PrintDetail(human);
            Console.ReadLine();
            Console.WriteLine("\n\n\n\t\t\t After eating\n\n");
            for (int i = 0; i < human.Length; i++)
            {
                human[i].Eat();
            }
            /*for (int i = 0; i < 20; i++)
            {
                human[3].Eat();
            }*/
            PrintDetail(human);
            Console.ReadLine();
        }
        public static void PrintDetail(Person[] obj)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i].PrintDetails(obj[i]);
                Console.WriteLine("\n\n================================================================================================");
            }
        }
    }
}
// for (int i = 0; i < human.Length; i++)