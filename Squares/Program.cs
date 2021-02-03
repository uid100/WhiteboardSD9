using System;

namespace Squares
{
    public class Program
    {
        public static int AreaOfASquare(int side) => side * side;

        static void Main(string[] args)
        {
            Console.WriteLine("Squares.Program.Main()");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"square({i}) area: {AreaOfASquare(i)}");
            }
        }
    }
}
