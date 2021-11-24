using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation.HighLevelModule
{
    class TaxCalculator:LogPolicyType
    {
        LogType policy;
        public enum LogType { DB, FILE }
        public TaxCalculator(LogType policy)
        {
           
        }
        public int Calculate(int value1, int value2)
        {
            int result=0;
            try
            {
                result = value1 / value2;
            }
            catch (Exception e)
            {
                if (policy == LogType.DB)
                {
                    var a = new LowLevelModule.DBLogger();
                    Console.WriteLine(a.WriteLine());
                }
                else if (policy == LogType.FILE)
                {
                    var a = new LowLevelModule.FileLogger();
                    Console.WriteLine(a.WriteLine());
                }
            }
            return result;
        }
    }
}
