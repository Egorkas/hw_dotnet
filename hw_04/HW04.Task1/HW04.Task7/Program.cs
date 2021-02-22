using System;

namespace HW04.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstIntValue = int.Parse("12345");
            bool isCorrectInt32 = Int32.TryParse("12345", out int secondIntValue);

            char firstCharValue = char.Parse(Console.ReadLine());
            bool isCorrectChar = char.TryParse(Console.ReadLine(), out char secondCharValue);

            bool firstBoolValue = bool.Parse(Console.ReadLine());
            bool isCorrectBool = bool.TryParse(Console.ReadLine(), out bool secondBoolValue);

        }
    }
}
