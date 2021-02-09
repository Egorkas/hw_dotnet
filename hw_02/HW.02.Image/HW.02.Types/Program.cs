using System;

namespace HW._02.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int code_a = 1;
            System.Int32 clr_a = 2;
            Console.WriteLine(code_a.GetType() + " = " + clr_a.GetType());

            byte code_b = 3;
            System.Byte clr_b = 4;
            Console.WriteLine(code_b.GetType() + " = " + clr_b.GetType());

            char code_c = 'a';
            System.Char clr_c = 'b';
            Console.WriteLine(code_c.GetType() + " = " + clr_c.GetType());

            double code_d = 1.8374;
            System.Double clr_d = 3.14;
            Console.WriteLine(code_d.GetType() + " = " + clr_d.GetType());

            float code_f = 1.22f;
            System.Single clr_f = 1.2245f;
            Console.WriteLine(code_f.GetType() + " = " + clr_f.GetType());

            object code_o1 = new object();
            System.Object clr_o1 = new System.Object();
            Console.WriteLine(code_o1.GetType() + " = " + clr_o1.GetType());

            string code_string = "djfjhhfdf";
            System.String clr_string = "dffdgkopkpog";
            Console.WriteLine(code_string.GetType() + " = " + clr_string.GetType());

            Console.ReadKey();
        }
    }
}
