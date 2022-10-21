using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ValidateUsingREGEX
{
    internal class Uc1_Regexfirstname
    {
        public static string FirstName = "^[A-Z]{1}[a-z]{2}$";
        public bool validate_FirstName(string firstname)
        {
            return Regex.IsMatch(firstname, FirstName);
        }
    }
}
