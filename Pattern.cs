using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexxUC1
{
    public class Pattern
    {
        //creating regex
        public static string Regex_FirstName = "^[A-Z]{1}[a-z]{3,}$";
        public bool validatePincode(string FirstName)
        {
            return Regex.IsMatch(FirstName, Regex_FirstName);
        }
    }
}
