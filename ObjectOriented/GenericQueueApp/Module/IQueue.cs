using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueApp.Module
{
    interface IQueue<T> 
    {
        void Enque(T item);
        T Deque();
        int Count();
    }
    //: IEnumerable<T>
}
