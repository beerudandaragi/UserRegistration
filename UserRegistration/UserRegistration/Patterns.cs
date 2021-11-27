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
        public static void Email(string name)
        {
            string Email = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)*[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
            Regex regex = new Regex(Email);
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid Email");
            }
            else
            {
                Console.WriteLine(name + " is invalid Email.");
                Console.ReadKey();
        }
    }
}