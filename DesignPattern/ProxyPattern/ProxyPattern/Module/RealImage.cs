using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Module
{
    class RealImage:IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
           _fileName = fileName;
            Console.WriteLine("Loading the Image "+_fileName);
        }
        public void display()
        {
            Console.WriteLine("Displaying the Image "+_fileName);
        }
    }
}
