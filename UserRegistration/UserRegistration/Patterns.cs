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
        public static void MobileNumber(string name)
        {
            string MobileNumber = "(0|91)?[ ][6-9][0-9]{9}";
            Regex regex = new Regex(MobileNumber);
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid Mobile Number");
            }
            else
            {
                Console.WriteLine(name + " is invalid Mobile Number.");
            }
            Console.ReadKey();
        }
    }
}