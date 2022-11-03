using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUC3
{
    public class Pattern
    {
        //creating regex
        public static string Regex_Email = "^[a-z]{4,}[0-9]{2,4}['@']{1}[a-z]{2,6}['.'][a-z]{2,6}$";
        public bool validatePincode(string Email)
        {
            return Regex.IsMatch(Email, Regex_Email);
        }
    }
}
