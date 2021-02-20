using System;

namespace HW._05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle();
        }

        static void Triangle()
        {
            Console.WriteLine("Input value 1..100");
            var isCorrectInp = Int32.TryParse(Console.ReadLine(), out int value);
            if (isCorrectInp && value >= 1 && value <= 100)
            {
                for (int i = 1; i <= value; i++)
                {
                    for (int j = i; j <= value; j++)
                    {
                        Console.Write((i < 10) ? (" " + i) : (" " + i % 10));
                    }
                    Console.WriteLine();
                    Console.Write(new string(' ', i));
                }
            } else
            {
                Console.WriteLine("Your input isn't valid! Try again!");
                Triangle();
            }
        }
    }
}
