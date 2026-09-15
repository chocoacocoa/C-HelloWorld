using System;
namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("Hi World");
            Console.WriteLine("I love");

            Console.WriteLine("say your text: ");
            string UserText = Console.ReadLine();

            Console.WriteLine("How many time we should iterate your text?: ");
            int iterations = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= iterations; i++)
            {
                Console.WriteLine(UserText);
            }
        }
    }
}