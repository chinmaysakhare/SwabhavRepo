using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueApp.Module
{
    public class MyQueue<T> : IQueue<T>
    {
        LinkedList<T> items = new LinkedList<T>();
        public void Enque(T data)
        {
            items.AddLast(data);
        }
        public T Deque()
        {
            var value =items.First();
            items.RemoveFirst();
            return value;
        }
        public int Count()
        {
            return items.Count();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
