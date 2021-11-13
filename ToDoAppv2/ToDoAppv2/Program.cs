using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace TodoAppVersion1
{
    class ToDo
    {
        List<string> todoList = new List<string>();
        string filePath = @" E:\Swabhav\C#\OOP\ToDoAppv2\ToDo.txt";
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
            const int DISPLAY = 1; const int ADD = 2; const int REMOVE = 3; const int EXIT = 4;
            switch (opt)
            {
                case DISPLAY:
                    Display();
                    break;
                case ADD:
                    Add();
                    break;
                case REMOVE:
                    Remove();
                    break;
                case EXIT:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(" Invalid Input. Select Again");
                    WelcomePage();
                    break;
            }
        }
        public void Display()
        {
            Console.WriteLine("\t\t\t\t ToDo tasks ");
            string[] line=File.ReadAllLines(filePath);
            for (int i = 0;i< line.Length; i++)
            {
                Console.WriteLine("# "+(i+1)+"--- "+line[i]);
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
                WriteToFile();
                WelcomePage();
        }
        public void Remove()
        {
            int opt;
            Console.WriteLine(" Enter the Task Id which you want to remove?");
            opt = Convert.ToInt32(Console.ReadLine());
            opt--;
            todoList.RemoveAt(opt);
            Console.WriteLine(" Task removed ");
            WriteToFile();
            Display();
        }
        public void WriteToFile()
        {
            string[] tempList = new string[todoList.Count];
            for (int i = 0; i < todoList.Count; i++)
            {
                tempList[i] = todoList[i];
            }
           
            File.WriteAllLines(filePath,tempList);
        }
    }
}
