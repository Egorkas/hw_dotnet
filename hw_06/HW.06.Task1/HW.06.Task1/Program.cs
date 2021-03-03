using System;

namespace HW._06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of your arrays!");
            int length = 0;
            while (true)
            {
                var isCorrectInp = Int32.TryParse(Console.ReadLine(), out length);
                if (isCorrectInp && length > 0) break;
                else
                {
                    Console.WriteLine("Your input isn't correct! Please try again");
                }
            }

            int[] firstArr = FillArrRandom(length);
            int[] secondArr = FillArrByUser(length);
            int[] addArr = AddArrays(firstArr, secondArr);
            PrintArray(firstArr);
            PrintArray(secondArr);
            PrintArray(addArr);
            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] FillArrRandom(int n)
        {
            int[] array = new int[n];
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1,100);
            }
            return array;
        } 

        static int[] FillArrByUser(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Input the next value of array.");
                var isCorrectInp = Int32.TryParse(Console.ReadLine(), out int value);
                
                if (isCorrectInp) array[i] = value;
                else
                {
                    Console.WriteLine("Your input isn't correct! Please try again");
                    i--;
                    continue;
                }
            }
            return array;
        }

        static int[] AddArrays(int[] firstArr, int[] secondArr)
        {
            int[] array = new int[firstArr.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = firstArr[i] + secondArr[i];
            }
            return array;
        }
    }
}
