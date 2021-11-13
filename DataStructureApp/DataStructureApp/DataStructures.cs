using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp.Module
{
    class DataStructures
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please Select a item \n\n");
            int opt;
            Console.WriteLine(" 1. ArrayList");
            Console.WriteLine(" 2. HashSet");
            Console.WriteLine(" 3. Dictionary");
            Console.WriteLine(" 4. Exit");
            opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1: ArrayList();
                    break;
                case 2: HashSet();
                    break;
                case 3: Dictionary();
                    break;
            }
        }
        public static void ArrayList()
        {
            int opt;
            char opt1;
            string element;
            ListClass obj = new ListClass();
            Console.WriteLine(" ArrayList ");
            Console.WriteLine(" 1. Create ");
            Console.WriteLine(" 2. Display");
            Console.WriteLine(" 3. Delete");
            Console.WriteLine(" 4. Update");
            Console.WriteLine(" 5. Main Menu");
            Console.WriteLine(" Please select a option");
            opt = Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1:
                    lbl:
                    Console.WriteLine("Enter Elements :");
                    element = Convert.ToString(Console.ReadLine());
                    obj.CreateaList(element);
                    Console.WriteLine("Press 'y' to enter more elements or 'n' to goto Main Menu");
                    opt1=Convert.ToChar(Console.ReadLine());
                    if (opt1 == 'y' || opt1 == 'Y')
                    {
                        goto lbl;
                    }
                    else
                        ArrayList();
                    break;
                case 2:
                    Console.WriteLine("Displaying a ArrayList ");
                    for (int i = 0; i <= obj.aList.Count; i++)
                    {
                        Console.WriteLine(obj.aList[i]);
                    }
                    break;
                case 3:
                    Console.WriteLine(" Delete a Element \n\n");
                    int index;
                    Console.WriteLine(" Enter the index that needs to be delete ");
                    index = Convert.ToInt32(Console.ReadLine());
                    obj.RemoveFromList(index);
                    break;
                case 4:
                    Console.WriteLine(" Update the list \n\n");
                    string el;
                    int index2;
                    Console.WriteLine("Please enter the element to be updated and the index");
                    el = Convert.ToString(Console.ReadLine());
                    index2 = Convert.ToInt32(Console.ReadLine());
                    obj.UpdateaList(el,index2);
                    break;
                case 5:
                    string[] args= new string[5];
                    Main(args);
                    break;

            }
            
        }
        public static void HashSet()
        {

        }
        public static void Dictionary()
        {
            
        }
    }
}
