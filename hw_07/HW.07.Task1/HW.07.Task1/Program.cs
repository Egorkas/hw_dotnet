using System;

namespace HW._07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Input the poem where strings split by \";\"");
            PrintArr(Console.ReadLine());
        }

        static void PrintArr(string str)
        {
            string[] array = str.Split(';');

            for(int i = 0; i < array.Length; i++)
            {
                char[] charArr = array[i].ToCharArray();
                for (int j = 0; j < charArr.Length; j++)
                {
                    switch (charArr[j])
                    {
                        case 'O': charArr[j] = 'A';
                            break;
                        case 'o':
                            charArr[j] = 'a';
                            break;
                        case 'О':
                            charArr[j] = 'А';
                            break;
                        case 'о':
                            charArr[j] = 'а';
                            break;
                        default:
                            continue;
                    }
                }
                array[i] = new string(charArr);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
