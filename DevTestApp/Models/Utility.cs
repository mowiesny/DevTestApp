using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevTestApp.Models
{
    public class Utility
    {
        public string WebFormat(string message)
        {
            return $"<h1>{message}</h1>";
        }
    }
}