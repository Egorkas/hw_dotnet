using System;
using System.Collections.Generic;
using System.Text;

namespace HW03.Calculator
{
    class Calculator
    {
        public double Addition(double firstValue, double secondValue) => firstValue + secondValue;
        public double Subtraction(double firstValue, double secondValue) => firstValue - secondValue;
        public double Multiplication(double firstValue, double secondValue) => firstValue * secondValue;
        public double Division(double firstValue, double secondValue) => firstValue / secondValue;
        //{
        //    try
        //    {
        //        return firstValue / secondValue;
        //    }
        //    catch(DivideByZeroException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine("Enter the secondValue another time");
        //        double secondValue2 = Int32.Parse(Console.ReadLine());
        //        return Division(firstValue, secondValue2);
        //    }
        //}
        public double Remainder(double firstValue, double secondValue) => firstValue % secondValue;
        public double AreaOfCircle(double radius) => radius * radius * Math.PI;
    }
}
