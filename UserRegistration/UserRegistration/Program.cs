using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)

        { 
        
            Console.WriteLine("Welcome to Regular Expression Program \n");
            Console.WriteLine("Write your Password ex : Aa9@ length atleast 8 .");
            Console.Write("\n Enter Password : ");
            string name = Console.ReadLine();
            Patterns.Password(name);
        }
    }
}