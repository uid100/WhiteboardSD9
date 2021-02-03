using System;

namespace Circle
{
    class Program
    {
        static double AreaOfACircle(int radius) => Math.PI * radius * radius;

        static void Main(string[] args)
        {
            Console.WriteLine("Circle.Program.Main()");

            Console.WriteLine(AreaOfACircle(10));
        }
    }
}
