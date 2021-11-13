using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SRPSolutionApp.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(1, "New Invoice For Chinmay", 100, 0.1f, 0.05f);
            var a = new InvoiceHTMLPrinter();
            inv.CalculateTax();
            inv.CalculateDiscount();
            inv.CalculateFinalAmount();
            //var ip = new InvoiceConsolePrinter(inv);
            StringBuilder sb1 = new StringBuilder();
            sb1 = a.PrintDetails(inv);
            //Table start.
            string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";

            //Adding HeaderRow.
            html += "<tr>";
            html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>Invoice Details</th>";
            html += "</tr>";

            //Adding DataRow.
            html += "<tr>";
            html += "<td style='width:300px;border: 2px solid #ccc'>" + sb1.ToString() + "</td>"; 
            html += "</tr>";

            //Table end.
            html += "</table>";

            //Create the HTML file.
            File.WriteAllText(@"E:\Swabhav\C#\OOP\SRPsolution\HtmlPrinter.htm", html);

            Console.WriteLine("HTML File created.");
            Console.ReadLine();



        }
    }
}
/*

    //Table start.
    string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";
 
    //Adding HeaderRow.
    html += "<tr>";
    html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>Name</th>";
    html += "</tr>";
 
    //Adding DataRow.
    html += "<tr>";
    html += "<td style='width:120px;border: 1px solid #ccc'>" + name + "</td>";
    html += "</tr>";
 
    //Table end.
    html += "</table>";
 
    //Create the HTML file.
    File.WriteAllText(@"E:\Files\Console.htm", html);
 
    Console.WriteLine("HTML File created.");
    Console.ReadLine();
 * 
 */