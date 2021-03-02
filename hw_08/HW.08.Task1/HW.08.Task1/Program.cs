using System;
using System.Collections.Generic;
using System.Text;

namespace HW._08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1a!2.3!! .. 4.!.?6 7! ..?";
            Console.WriteLine(str);
            Console.WriteLine(ChangeString(str));
        }

        static string ChangeString(string str)
        {
            var sb = new StringBuilder(str);            
            int index = sb.ToString().IndexOf('?');
            List<int> indexes = new List<int>();

            Console.WriteLine("Enter ! or . for removing!");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "!": indexes = AllIndexesOf(sb.ToString(0, index), "!");
                    break;
                case ".": indexes = AllIndexesOf(sb.ToString(0, index), ".");
                    break;
                default:
                    Console.WriteLine("Yr input isn't correct!");
                    break;
            }
            for (int i = 0; i < indexes.Count; i++)
            {
                sb.Remove(indexes[i] - i, 1);
            }

            index = sb.ToString().IndexOf('?');
            Console.WriteLine(sb.Length);
            var indexesOfBackspace = AllIndexesOf(sb.ToString(index, sb.Length - index), " ");
            sb.Replace(' ', '_', index, sb.Length - index);

            return sb.ToString();
        }

        static List<int> AllIndexesOf(string str, string value)
        {
            List<int> indexes = new List<int>();
            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }

    }
}
