using System;

namespace HW._05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            CountOfLetter();
        }

        public static void CountOfLetter()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Input your string");
            string usInp = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < usInp.Length; i++)
            {
                switch (usInp[i])
                {
                    case 'a':
                    case 'A':
                    case 'а': //Russian
                    case 'А': //Russian
                        ++count;
                        break;
                    default: break;
                };
            }
            Console.WriteLine($"The count of 'a' in input string is {count}");
        }
    }
}
