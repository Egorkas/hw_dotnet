using System;

namespace HW04.Task3
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
            Console.WriteLine("Input the summary of the first and second values");
            int userSumm = 0;
            while (!Int32.TryParse(Console.ReadLine(), out userSumm))
            {
                Console.WriteLine("Your input is not valid, please repeate input!");
                continue;
            }

            if (userSumm == summ)
            {
                Console.WriteLine($"True, {userSumm} = {summ} ");
            }
            else if(userSumm > summ)
            {
                Console.WriteLine($"False, your summ is bigger then true summary! ");
            }
            else
            {
                Console.WriteLine($"False, your summ is smaller then true summary! ");
            }
        }
    }
}
