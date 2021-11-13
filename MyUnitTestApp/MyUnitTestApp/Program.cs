using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MyUnitTestApp.Module
{
    class Program

    {
        static void Main(string[] args)
        {
            int mCount1 = 0;
            int mCount2 = 0;
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyUnitTestClass>().Count() > 0);
            foreach (var type in types)
            {
                Console.WriteLine(type.Name);
                var methods = type.GetMethods().Where(t => t.GetCustomAttributes<MyUnitTestMethod>().Count() > 0);
                object obj = Activator.CreateInstance(type);
                foreach (var method in methods)
                {
                    var currentMethod = method.Invoke(obj, null);
                    if (currentMethod.Equals(true))
                    {
                        Console.WriteLine(method.Name + " : Passed");
                    }
                    else
                    {
                        Console.WriteLine(method.Name + " : Failed");
                    }
                    
                    

                }
            }
            Console.ReadLine();
        }
    }
}
/*Type mtype = method.GetType();
ConstructorInfo cInfo = mtype.GetConstructor(Type.EmptyTypes);
object mObj = cInfo.Invoke(new object[] { });
MethodInfo mMethod = mtype.GetMethod(string.Empty);
if (mMethod(method) == true)
{

}*/
