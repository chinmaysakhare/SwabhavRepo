using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionApp.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy2();
            Console.ReadLine();
        }
        public static void CaseStudy2()
        {
            List<LineItem> basket = new List<LineItem>();
            basket.Add(new LineItem("EarPhone", 150, 2));
            basket.Add(new LineItem("Kids toy", 500, 3));
            //basket.Add("Hello");
            foreach (LineItem obj in basket)
            {
                Console.WriteLine("Product Name : " + obj.Name + " Price : " + obj.Price+" Quantity : "+obj.Quantity);
                Console.WriteLine(obj.Total());
            }
            
            
            
        }
        public static void CaseStudy1()
        {
            ArrayList basket = new ArrayList();
            basket.Add(new LineItem("EarPhone", 150, 2));
            basket.Add(new LineItem("Kids toy", 500, 3));
            basket.Add("Hello Aurion Pro");
            foreach (object obj in basket)
            {
                Console.WriteLine(((LineItem)(object)obj).Price);
            }
        }
    }
}
