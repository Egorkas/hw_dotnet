using System;
using System.Collections.Generic;
using System.Text;

namespace HW._05.Task3
{
    class Greeting
    {
        public Greeting()
        {
            int thisHour = DateTime.Now.Hour;
             switch(thisHour)
            {
                case int n when n >= 9 && n < 12 :
                    Console.WriteLine( "Good morning, guys");
                    break;
                case int n when n >= 12 && n < 15:
                    Console.WriteLine("Good day, guys");
                    break;
                case int n when n >= 15 && n < 22:
                    Console.WriteLine("Good evening, guys");
                    break;
                default:
                    Console.WriteLine("Good night!");
                    break;
            };
        }
    }
}
