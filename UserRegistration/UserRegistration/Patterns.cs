using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Patterns
    {


        public static void Password(string name)
        {
            string Password = "^[A-Z][A-Za-z0-9]{7,}";
            Regex regex = new Regex(Password);
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid possword");
            }
            else
            {
                Console.WriteLine(name + " is invalid possword");
            }
            Console.ReadKey();
        }
    }
}