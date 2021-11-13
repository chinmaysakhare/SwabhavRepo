using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp.Module
{
    class InvoiceHTMLPrinter
    {
        StringBuilder sb = new StringBuilder();
        public StringBuilder PrintDetails(Invoice obj)
        {
            sb.Append(Convert.ToString(obj.Id));
            sb.AppendLine();
            sb.Append(obj.Description);
            sb.AppendLine();
            sb.Append(Convert.ToString(obj.Amount));
            sb.AppendLine();
            sb.Append(Convert.ToString(obj.Tax * 100));
            sb.AppendLine();
            sb.Append(Convert.ToString(obj.CalculateTax()));
            sb.AppendLine();
            sb.Append(Convert.ToString(obj.Discount * 100)); 
            sb.AppendLine();
            sb.Append(Convert.ToString(obj.CalculateDiscount()));
            sb.AppendLine();
            sb.Append(Convert.ToString(obj.CalculateFinalAmount()));
            sb.AppendLine();
            return sb;
        }
        
    }
}
//E:\Swabhav\C#\OOP\SRPsolution
/*
 *  sb.Append(Convert.ToString(obj.Amount));
            sb.Append(Convert.ToString(obj.Tax * 100));
            sb.Append(Convert.ToString(obj.CalculateTax()));
            sb.Append(Convert.ToString(obj.Discount * 100));
            sb.Append(Convert.ToString(obj.CalculateDiscount()));
            sb.Append(Convert.ToString(obj.CalculateFinalAmount()));
 */