using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternApp.Module
{
    class DataService
    {
        static DataService bucket;
        private static object locker = new object();
        private DataService()
        {
            Console.WriteLine("Data service Created");
        }
        public void DoSomething() 
        {
            Console.WriteLine("Work Done by : "+this.GetHashCode());
        }
        public static DataService GetInstance()
        {
            if (bucket == null)
            {
                lock (locker)
                {
                    if (bucket == null)
                        bucket = new DataService();
                }
            }  
            return bucket;
        }
    }
}