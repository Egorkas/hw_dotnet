using System;

namespace HW03.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            //Call Addition            
            Console.Write("Input first value: ");
            double firstValue1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second value: ");
            double secondValue1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Value = {calc.Addition(firstValue1, secondValue1)}");            

            //Call Substraction           
            Console.Write("Input first value: ");
            double firstValue2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second value: ");
            double secondValue2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Value = {calc.Subtraction(firstValue2, secondValue2)}");            

            //Call Multiplication           
            Console.Write("Input first value: ");
            double firstValue3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second value: ");
            double secondValue3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Value = {calc.Multiplication(firstValue3, secondValue3)}");            

            //Call Division           
            Console.Write("Input first value: ");
            double firstValue4 = double.Parse(Console.ReadLine());
            Console.Write("Input second value: ");
            double secondValue4 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Value = {calc.Division(firstValue4, secondValue4)}");            

            //Call Remainder            
            Console.Write("Input first value: ");
            double firstValue5 = double.Parse(Console.ReadLine());
            Console.Write("Input second value: ");
            double secondValue5 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Remainder = {calc.Remainder(firstValue5, secondValue5)}");           

            //Call AreaOfCircle            
            Console.Write("Input radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area of circle = {calc.AreaOfCircle(radius)}");          
        }
    }
}
