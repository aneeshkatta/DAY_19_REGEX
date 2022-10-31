using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regix_Validate_Email
{
    class uc6uppercase
    {

        public static string reg = "^[A-Z]{1}.{7,}$";
            
        public static bool validate_password(string word)
        {
            return Regex.IsMatch(word, reg);
        }
        static void Checkcase()
        {
            Console.Write("Enter The Password:");
            string pass = Console.ReadLine();

            if (validate_password(pass))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        static void Main()
        {
            uc6uppercase.Checkcase();
        }

    }
}