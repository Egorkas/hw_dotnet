using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Addition();
        }

        static void Addition()
        {
            Console.WriteLine("Input the first value!");
            int firstValue = 0;
            while (!Int32.TryParse(Console.ReadLine(), out firstValue))
            {
                Console.WriteLine("Your input is not valid, please repeate input!");
                continue;
            }

            Console.WriteLine("Input the second value!");
            int secondValue = 0;
            while (!Int32.TryParse(Console.ReadLine(), out secondValue))
            {
                Console.WriteLine("Your input is not valid, please repeate input!");
                continue;
            }

            int summ = firstValue + secondValue;
            Console.WriteLine($"The summary is {summ}");
        }
    }
}
