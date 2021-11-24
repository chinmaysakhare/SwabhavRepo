using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<string> n1 = new Node<string>();
            n1.Data = "Mumbai";

            Node<string> n2 = new Node<string>();
            n2.Data = "Pune";

            Node<string> n3 = new Node<string>();
            n3.Data = "Nashik";

            n1.Next = n2;
            n2.Next = n3;
        }
        

    }
}
