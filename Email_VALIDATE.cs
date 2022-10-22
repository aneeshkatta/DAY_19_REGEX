using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regix_Validate_Email
{
    class Email_VALIDATE
      //abc.xyz @bl.co.in - Email has 3 mandatory
    {


        public static void validate_Mail()
        {
        Console.WriteLine("Enter your mail ID");
        string Email = Console.ReadLine();
            string Mail = "^[0-9a-z]{1,}([.+-_]*)[0-9a-z]{1,}(@)(gmail|bl)(.)(com|co)([.]*)([in]*)$";
               
        if (Regex.IsMatch(Email, Mail))
        {
            Console.WriteLine("Entered Email is valid");

        }
        else
        {
            Console.WriteLine("Entered Email is invalid");
        }

         } 
}
    
}
