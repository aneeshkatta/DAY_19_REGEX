using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateUsingREGEX
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Uc1_Regexfirstname pattern = new Uc1_Regexfirstname();
            Console.WriteLine(pattern.validate_FirstName("Ani"));
        }
    }
}
