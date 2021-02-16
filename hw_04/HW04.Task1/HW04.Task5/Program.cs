using System;

namespace HW04.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSymb = 'Z';
            byte lastSymbByte = Convert.ToByte(lastSymb);
            for (int i = 25; i >= 0 ; i--)
            {
                Console.WriteLine(lastSymb);
                lastSymbByte -= 1;
                lastSymb= Convert.ToChar(lastSymbByte);
            }
        }
    }
}
