using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUC5
{
    public class Pattern
    {
        public string Regex_Password = "^[a-z]{8,13}$";
        public bool ValidateRegex(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}
