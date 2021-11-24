using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeApp
{
    public class Node<T>
    {
        private T _data;
        private Node<T> _next;

        public T Data
        {
            set { _data = value; }
            get { return _data; }
        }
        public Node<T> Next
        {
            set { _next = value; }
            get { return _next; }
        }
    }
}

        
       