using System;

namespace HW._06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = FillArr(InputLength());
            PrintArray(arr);
            int[] newArr = InsertElement(arr);
            PrintArray(newArr);
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int InputLength()
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
                    continue;
                }
            }
            return length;
        }
        static int[] FillArr( int length)
        {
            int[] array = new int[length];
            for (int i = 0; i < array.Length - 1; i++)
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

        static int[] InsertElement(int[] array)
        {
            int[] newArr = array;
            Console.WriteLine($"Input the position for inserting <{array.Length}!");
            int pos = 0;
            while (true)
            {
                var isCorrectInp = Int32.TryParse(Console.ReadLine(), out pos);
                if (isCorrectInp && pos < array.Length) break;
                else
                {
                    Console.WriteLine("Your input isn't correct! Please try again");
                    continue;
                }
            }

            Console.WriteLine($"Input the new element for inserting in position = {pos}!");
            int newElemOfArr = 0;
            while (true)
            {
                var isCorrectInp = Int32.TryParse(Console.ReadLine(), out  newElemOfArr);
                if (isCorrectInp) break;
                else
                {
                    Console.WriteLine("Your input isn't correct! Please try again");
                    continue;
                }
            }

            for (int i = array.Length - 1; i > pos; i--)
            {
                array[i] = array[i - 1];
            }
            array[pos] = newElemOfArr;

                return array;
        }
    }
}
