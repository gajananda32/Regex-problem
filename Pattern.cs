using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUC7
{
    public class Pattern
    {
        public string Rergex_PosswordRule3 = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z]).{8,15}$";
        public bool validiate(string password)
        {
            return Regex.IsMatch(password, Rergex_PosswordRule3);
        }
    }
}
