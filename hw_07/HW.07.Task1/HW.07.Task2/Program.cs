using System;
using System.Linq;

namespace HW._07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Our string for testing, please use it well!";
            RemoveFromStr(str);
            ChangeMinMax(str);
            CountLetter(str);
            StringSort(str);

        }

        static void RemoveFromStr(string str)
        {
            string[] strArr = str.Split(' ');
            int maxLength = 0;
            int index = 0;
            for (int i = 0; i < strArr.Length; i++)
            {
                if(strArr[i].Length > maxLength)
                {
                    maxLength = strArr[i].Length;
                    index = i;
                }
            }

            Array.Clear(strArr,index, 1);
            foreach (var item in strArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine($"Index of max value is {index}!");
        }

        static void ChangeMinMax(string str)
        {
            string[] strArr = str.Split(' ');
            int  maxValue =0, indexMin = 0, indexMax = 0;
            int minValue = Int32.MaxValue;
            for (int i = 0; i < strArr.Length; i++)
            {
                if(maxValue < strArr[i].Length)
                {
                    maxValue = strArr[i].Length;
                    indexMax = i;
                }

                if (minValue > strArr[i].Length)
                {
                    minValue = strArr[i].Length;
                    indexMin = i;
                }
            }

            string temp = string.Empty;
            temp = strArr[indexMin];
            strArr[indexMin] = strArr[indexMax];
            strArr[indexMax] = temp;

            foreach (var item in strArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void CountLetter(string str)
        {
            char[] chrArr = str.ToCharArray();
            int countLetter = 0, countPunct = 0;
            for (int i = 0; i < chrArr.Length; i++)
            {
                countLetter = Char.IsLetter(chrArr[i])? ++countLetter : countLetter;//Question: counter++ doesn't work!!!(postfix increment doesn't work) Why?
                countPunct = Char.IsPunctuation(chrArr[i])? ++countPunct : countPunct;
            }

            Console.WriteLine($"Count of letters is {countLetter}, the count of punctuation {countPunct}!");
        }

        static void StringSort(string str)
        {
            string[] strArr = str.Split(' ');
            Array.Sort(strArr, (x, y) => x.Length.CompareTo(y.Length));

            foreach (var item in strArr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
