using System;

namespace HW._05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input positive value!");
            int value = Int32.Parse(Console.ReadLine());
            int sum = SumOfValues(value);
            Console.WriteLine($"The Sum of all values 1..{value} is {sum}");
        }

        static int SumOfValues(int value)
        {
            if (value > 1)
            {
                return value + SumOfValues(value - 1);
            }else if(value == 1)
            {
                return 1;
            }
            else
            {
                Console.WriteLine($"{value} is non-positive!!! Please enter value another time.");
                return SumOfValues(Convert.ToInt32(Console.ReadLine()));
            }
        }
    }
}
