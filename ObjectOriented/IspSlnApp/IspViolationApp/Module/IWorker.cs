using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspViolationApp.Module
{
    interface IWorker
    {
        void startWork();
        void stopWork();
        void stopEat();
        void startEat();
    }
}
