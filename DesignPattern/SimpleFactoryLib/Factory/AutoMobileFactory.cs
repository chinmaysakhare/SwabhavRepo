using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactoryLib.Product;

namespace SimpleFactoryLib.Factory
{
    public class AutoMobileFactory
    {
        static AutoMobileFactory bucket;
        private static object locker = new object();
        public static AutoMobileFactory GetInstance()
        {
            if (bucket == null)
            {
                lock (locker)
                {
                    if (bucket == null)
                        bucket = new AutoMobileFactory();
                }
            }
            return bucket;
            
        }
        public IAuto make(AutoType type)
        {
            if (type == AutoType.TESLA)
                return new TESLA();
            else if (type == AutoType.AUDI)
                return new AUDI();
                return new BMW();
        }
    }
}
