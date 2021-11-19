using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternSoln
{
    public class File:IStorageItem
    {
        private string _name;
        private string _size;

        public File(string name, string size)
        {
            _name = name;
            _size = size;
        }
        public void Display(int indentation)
        {
            Console.WriteLine(string.Format("{0}    Name : {1},Size : {2}",new string(' ',indentation),_name,_size));
        }
    }
}
    