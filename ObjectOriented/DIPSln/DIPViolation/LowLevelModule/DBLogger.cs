using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation.LowLevelModule
{
    class DBLogger
    {
        public string WriteLine()
        {
            string message = "Recording from DB";
            return message;
        }
    }
}
