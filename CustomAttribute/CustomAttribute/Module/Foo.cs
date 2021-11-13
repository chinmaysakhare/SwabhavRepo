using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute.Module
{
    public class Foo
    {
        [NeedToRefactor]
        public void m1()
        { }
        public void m2()
        { }
        public void m3()
        { }
        [NeedToRefactor]
        public void m4()
        { }

    }
}
