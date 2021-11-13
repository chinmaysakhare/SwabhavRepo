using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"E:\Swabhav\C#\OOP\ReadFile\Records.txt";
            FileStream stream  ;
            stream = new FileStream(fileName, FileMode.Append);
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                Console.WriteLine(" Enter your name :");
                string data = Convert.ToString(Console.ReadLine());
                writer.WriteLine(data);
            }
            string readText = File.ReadAllText(fileName);
            Console.WriteLine("\n\n Contents of the file are :- ");
            Console.WriteLine(readText);
            Console.ReadLine();
        }

    }
}
// E:\Swabhav\C#\OOP\ReadFile\Records.txt

/*
 *      
/*/
