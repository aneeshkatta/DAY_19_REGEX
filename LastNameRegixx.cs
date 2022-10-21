using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LastNameRegix
{
   
    
    internal class LastNameRegixx
    {
        
        public static string LastName = "^[A-Z]{1}[a-z]{2}$";
        public bool validate_lastName(string lastname)
        {
            return Regex.IsMatch(LastName,lastname);
        }
    }
}
