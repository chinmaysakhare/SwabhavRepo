using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace AccountAppSerialisationDeserialisation.Module
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account obj = new Account(1, "Chinmay");
            PrintDetails(obj);
            obj.UpdateBal(2000);
            PrintDetails(obj);
            Console.ReadLine();
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(obj);
            Console.WriteLine("Data Serialised");
            Console.ReadLine();
            // Deserializing json data to object
            JavaScriptSerializer js1 = new JavaScriptSerializer();
            Account obj = js1.Deserialize<Account>(jsonData);
            

        }
        public static void PrintDetails(Account o)
        {
            Console.WriteLine(o.AccNo);
            Console.WriteLine(o.Name);
            Console.WriteLine(o.Balance+"\n\n");
        }
    }
}
