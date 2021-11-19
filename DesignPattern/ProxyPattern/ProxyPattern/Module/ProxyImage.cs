using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Module
{
    class ProxyImage:IImage
    {
        private string _fileName;
        private RealImage _realImage;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }
        public void display() 
        {
           if(_realImage==null)
            {
                _realImage = new RealImage(_fileName);
            }
            _realImage.display();
        }
    }
}
