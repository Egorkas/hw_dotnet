using System;
using System.Diagnostics;

namespace HW._06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comment PrintArr() before starting this Program
            Stopwatch firstTimer = new Stopwatch();
            Stopwatch secondTimer = new Stopwatch();

            Int64[] arr = CreateArr(100000000);
            PrintArr(arr);

            firstTimer.Start();
            MyReverse(arr);
            firstTimer.Stop();
            var ts = firstTimer.ElapsedMilliseconds;
            PrintArr(arr);

            secondTimer.Start();
            Array.Reverse(arr);
            secondTimer.Stop();
            var ts2 = secondTimer.ElapsedMilliseconds;

            Console.WriteLine($"Runtime of my Reverse is {ts}");
            Console.WriteLine($"Runtime of  System.Array.Reverse is {ts2}");
            PrintArr(arr);
        }

        static void PrintArr(Int64[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static Int64[] CreateArr(int length)
        {
            Int64[] array = new Int64[length];
            var rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next();
            }
            return array;
        }
        static Int64[] MyReverse(Int64[] array)
        {
            Int64 temp = 0;
            for (int i = 0, j = array.Length - 1; i < j ; i++, j--)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return array;
        }
    }
}
