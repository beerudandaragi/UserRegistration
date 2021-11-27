using System;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program \n");

            Console.WriteLine("Write your name using 1st character should be Capital ");
            Console.Write("\n Enter First Name : ");
            string name1 = Console.ReadLine();
            Patterns.FirstName(name1);

            Console.WriteLine("\n Write your name using 1st character should be Capital ");
            Console.Write("\n Enter Last Name : ");
            string name2 = Console.ReadLine();
            Patterns.LastName(name2);

            Console.WriteLine("\n Write your Email ex : beerappadandaragi@gmail.com your can write yahoo and any other mail ID.");
            Console.Write("\n Enter Email : ");
            string name3 = Console.ReadLine();
            Patterns.Email(name3);

            Console.WriteLine("\n Write your Mobile Number ex : +91 7411416743 .");
            Console.Write("\n Enter Mobile Number : ");
            string name4 = Console.ReadLine();
            Patterns.MobileNumber(name4);

            Console.WriteLine("\n Write your Password ex : Aa9@ length atleast 8 .");
            Console.Write("\n Enter Password : ");
            string name5 = Console.ReadLine();
            Patterns.Password(name5);
        }
    }
}