using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueApp.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<int> numbers = new MyQueue<int>();
            numbers.Enque(100);
            numbers.Enque(200);
            numbers.Enque(300);
            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Deque() );           
            Console.WriteLine(numbers.Count());
            Console.ReadKey();
        }
    }
}
