using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regix_Validate_Email
{
    class uc5_PASSWORD
    {

        public static string reg = "[A-Za-z1-9]{8}";
        public static bool validate_password(string word)
        {
            return Regex.IsMatch(word, reg);
        }
        static void CheckPswd()
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
            uc5_PASSWORD.CheckPswd();
        }

    }
}