using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevTestApp.Models
{
    public class Utility
    {
        public static string WebFormat(string message)
        {
            return $"<h1>{message}</h1>";
        }
        public static string FormatDate(DateTime date)
        {
            return date.ToString("MMMM dd, yyyy");
        }
        public static string FormatCurrency(decimal amount)
        {
            return amount.ToString("C2");
        }   
    }
}