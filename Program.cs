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

            // Console.WriteLine("Enter your birthday: ");
            // string birthday = Console.ReadLine();

            // Console.WriteLine("Your birtday is in "+birthday);

            Random random = new Random();
            int[] numbers = new int[50];

            for(int c = 0; c < numbers.Length; c++)
            {
                numbers[c] = random.Next(1, 101);
            }

            Console.WriteLine("Unsorted array");
            Console.WriteLine("int[] numbers = {");
            for(int a = 0; a<numbers.Length; a++)
            {
                Console.Write(numbers[a]+", ");
            }
            Console.WriteLine("};");
            Console.WriteLine("Sorted Array");
            int i = 0;
            int temp = 0;
            while(i < numbers.Length)
            {
                int j = i+1;
                while (j < numbers.Length)
                {
                    if (numbers[i] >= numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }//if (numbers[i] >= numbers[j])
                    j++;
                }//while (j < numbers.Length)
                i++;
            }//while(i < numbers.Length)

            Console.WriteLine("int[] numbers = {");
            for(int a = 0; a<numbers.Length; a++)
            {
                Console.Write(numbers[a]+", ");
            }
            Console.WriteLine("};");
            Console.WriteLine("Sorted Array");

            //birthday feature added
            Console.WriteLine("Enter your birthday: ");
            string birthday = Console.ReadLine();

            Console.WriteLine("Your birtday is in "+birthday);
        }//static void Main(string[] args)
    }
}