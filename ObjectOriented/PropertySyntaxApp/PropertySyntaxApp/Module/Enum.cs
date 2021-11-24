using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySyntaxApp.Module
{
    class Enum
    {
        private int _bar;
        private int _baz;
        public Enum()
        {
            Random r = new Random();
           _baz = r.Next(0, 1);
         }
        public int Baz
        {
            get 
            {
                return _baz;
            }
        }
        public int Bar
        {
            get
            {
                return _bar;
            }
            set
            {
                if (value > 0)
                {
                    _bar = value;
                }
            }
        }
    }
}
