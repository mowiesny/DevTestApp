using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevTestApp.Models
{
    public class TestAppUtility
    {
        public string webFormat(string StringToBeFormatted)
        {
            StringToBeFormatted = StringToBeFormatted.Trim();
            return StringToBeFormatted;
        }
    }
}