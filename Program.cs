using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LastNameRegix
{

    internal class Program

    {
        public static void Main(string[] args)
        {
            LastNameRegixx pattern = new LastNameRegixx();
            Console.WriteLine(pattern.validate_lastName("Kat"));
           
        }
    }
}