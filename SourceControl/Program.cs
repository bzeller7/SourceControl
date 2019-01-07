using System;

namespace SourceControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name :");
            string FirstName = Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine("Hi", FirstName, "!");
            Console.ReadKey();
        }
    }
}
