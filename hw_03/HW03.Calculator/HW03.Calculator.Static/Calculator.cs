using System;
using System.Collections.Generic;
using System.Text;

namespace HW03.Calculator.Static
{
    class Calculator
    {
        public static double Addition(double firstValue, double secondValue) => firstValue + secondValue;
        public static double Subtraction(double firstValue, double secondValue) => firstValue - secondValue;
        public static double Multiplication(double firstValue, double secondValue) => firstValue * secondValue;
        public static int Division(int firstValue, int secondValue)
        {
            try
            {
                return firstValue / secondValue;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Enter the secondValue another time");
                int secondValue2 = Int32.Parse(Console.ReadLine());
                return Division(firstValue, secondValue2);
            }
        }
        public static double Remainder(double firstValue, double secondValue) => firstValue % secondValue;
        public static double AreaOfCircle(double radius) => radius * radius * Math.PI;
    }
}
