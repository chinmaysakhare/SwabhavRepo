using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TodoAppVersion1
{
    class ToDo
    {
        ArrayList todoList = new ArrayList();
        static void Main(string[] args)
        {
            ToDo obj = new ToDo();
            obj.WelcomePage();
        }
        public void WelcomePage()
        {
            Console.WriteLine("\n\t\t\t\t TODO Application");
            Console.WriteLine("\n\n 1. Display\n 2. Add\n 3. Remove\n 4. Exit");
            int opt = Convert.ToInt32(Console.ReadLine());
            const int DISPLAY = 1;const int ADD = 2;const int REMOVE = 3;const int EXIT = 4;
            switch (opt)
            {
                case DISPLAY: Display();
                    break;
                case ADD: Add();
                    break;
                case REMOVE: Remove();
                    break;
                case EXIT:
                    break;
                default:Console.WriteLine(" Invalid Input. Select Again");
                    WelcomePage();
                    break;
            }
        }
        public void Display()
        {
            for (int i = 0; i <todoList.Count; i++)
            {
                Console.WriteLine(" #"+(i+1)+" "+todoList[i]);
            }
            Console.WriteLine(" Press any key to go to Main Menu");
            Console.ReadLine();
            WelcomePage();
        }
        public void Add()
        {
            string item;
            char opt;
            Console.WriteLine(" Enter item :");
            item = Convert.ToString(Console.ReadLine());
            todoList.Add(item);
            Console.WriteLine(" Do you want to add more items? (y/n )");
            opt = Convert.ToChar(Console.ReadLine());
            if (opt == 'y')
                Add();
            else
                WelcomePage();
        }
        public void Remove()
        {
            Console.WriteLine(" Enter the Task Id which you want to remove?");
            int opt;
            char opt1;
            opt = Convert.ToInt32(Console.ReadLine());
            opt--;
            todoList.RemoveAt(opt);
            Console.WriteLine(" Task removed ");
            Console.WriteLine("Press Any key to goto main menu");
            Console.ReadLine();
            WelcomePage();
        }
    }
}
