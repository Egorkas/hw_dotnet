using System;

namespace HW._02.Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Явные преобразования
            int a = 2;
            int b = 3;
            byte c = (byte)(a + b);

            short s = 45;
            byte b1 = (byte)s; 
            
            double d= 123;
            int dint = (int)d;


            //Неявное преобразование
            byte n = 5;
            short s1 = n;
            long l = 12232423;
            float f3 = l;
            double d1 = f3;

            //boxing
            object o1 = new object();
            object o2 = new object();
            object o3 = new object();
            o1 = a;
            o2 = b;
            o3 = d;

            //unboxing
            int a_new, b_new; double d_new;
            a_new = (int)o1;
            b_new = (int)o2;
            d_new = (double)o3;


        }
    }
}
