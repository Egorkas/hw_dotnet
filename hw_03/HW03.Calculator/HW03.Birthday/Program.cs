using System;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input the year of your birth: ");
            int yearOfBirth = int.Parse(Console.ReadLine());

            Console.Write("Input the month of your birth: ");
            int monthOfBirth = int.Parse(Console.ReadLine());

            Console.Write("Input this year: ");
            int todayYear = int.Parse(Console.ReadLine());

            Console.Write("Input this month : ");
            int todayMonth = int.Parse(Console.ReadLine());

            int userYear = todayYear - yearOfBirth;
            if (todayMonth > monthOfBirth)
            {
                Console.WriteLine($"You are { userYear} years old.");
            }
            else
            {
                userYear = userYear - 1;
                Console.WriteLine($"You are {userYear} years old.");
            }

        }
    }
}
