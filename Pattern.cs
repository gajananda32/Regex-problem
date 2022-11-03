using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUC6
{
    public class Pattern
    {
        public string Regex_PasswordRule2 = "^([A-Z]+)[a-z]{8,15}$";
        public bool Validiate(string password)
        {
            return Regex.IsMatch(password, Regex_PasswordRule2);
        }
    }
}
