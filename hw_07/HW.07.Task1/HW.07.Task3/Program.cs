using System;

namespace HW._07.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string which consist digit and one arithmetic sign(+, -, *, /)!");
            string str = Console.ReadLine();
            int result = CodeWars(str);
            Console.WriteLine($"The result is {result}");
        }

        static int CodeWars(string str)
        {
            int result = 0;
            string firstValue = string.Empty;
            string secondValue = string.Empty;
            string  sign= string.Empty;
            string temp = string.Empty;
            char[] charArr = str.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (Char.IsDigit(charArr[i])) temp += charArr[i];
                else if(Char.Equals(charArr[i], '+')|| Char.Equals(charArr[i], '-') || Char.Equals(charArr[i], '*') || Char.Equals(charArr[i], '/'))
                {
                    sign = charArr[i].ToString();
                    firstValue = temp;
                    temp = string.Empty;
                }
            }
            secondValue = temp;
            switch (sign)
            {
                case "+":
                    result = Int32.Parse(firstValue) + Int32.Parse(secondValue);
                    break;
                case "-":
                    result = Int32.Parse(firstValue) - Int32.Parse(secondValue);
                    break;
                case "*":
                    result = Int32.Parse(firstValue) * Int32.Parse(secondValue);
                    break;
                case "/":
                    result = Int32.Parse(firstValue) / Int32.Parse(secondValue);
                    break;
            }
            return result;
        }
    }
}
