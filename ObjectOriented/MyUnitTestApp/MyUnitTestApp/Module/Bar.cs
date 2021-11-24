using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnitTestApp.Module
{
    [MyUnitTestClass]
    class Bar
    {
        [MyUnitTestMethod]
        public bool B1()
        {
            return false;
        }
        public bool B2()
        {
            return true;
        }
        public bool B3()
        {
            return true;
        }
    }
}
