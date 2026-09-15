using System;
namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("Hi World");
            // Console.WriteLine("I love you");

            Console.WriteLine("Enter your birthday: ");
            string birthday = Console.ReadLine();

            Console.WriteLine("Your birtday is in "+birthday);
        }
    }
}