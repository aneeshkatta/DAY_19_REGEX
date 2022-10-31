using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CharRegexUC8
{
    class UC8_REGEX
    {

        public static string reg = "^[a-zA-Z0-9!@#$&()-`.+,/\"]{8}$";

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
            UC8_REGEX.Checkcase();
        }

    }
}
