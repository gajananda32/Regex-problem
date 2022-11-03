using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPhoneNumber
{
    public class Pattern
    {
        public static string Regex_PhoneNumber = "^(91)?[' ']{1}[6-9]{1}[0-9]{9}$";
        public bool validatePincode(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, Regex_PhoneNumber);
        }
    }
}
