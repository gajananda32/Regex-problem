using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUC2
{
    public  class Pattern
    {
        //creating regex
        public static string Regex_LastName = "^[A-Z]{1}[a-z]{2,}$";
        public bool validatePincode(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }
    }
}
