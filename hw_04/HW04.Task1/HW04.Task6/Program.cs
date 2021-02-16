using System;

namespace HW04.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Need4Speed toretto = new Need4Speed();
            toretto.Move();
        }

        class Need4Speed
        {
            public void Move()
            {
                Console.WriteLine("Run Dominic! For moving put on WASD! For exit put on E!");
                var inputUser = Console.ReadKey();
                switch (inputUser.Key)
                {
                    case ConsoleKey.W:
                        Console.WriteLine(" MOVE UP!!!");
                        Move();
                        break;
                    case ConsoleKey.A:
                        Console.Write(" MOVE LEFT!!!");
                        Move();
                        break;
                    case ConsoleKey.S:
                        Console.Write(" MOVE DOWN");
                        Move();
                        break;
                    case ConsoleKey.D:
                        Console.Write(" MOVE RIGHT!!!");
                        Move();
                        break;
                    case ConsoleKey.E:
                        Console.Write(" EXIT!!!");
                        break;
                    default:
                        Console.Write(" key is not valid, use WASD keys!!!");
                        Move();
                        break;
                }
            }
        }
    }
}
