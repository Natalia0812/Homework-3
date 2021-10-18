using System;

namespace point_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14, y = 1, z = 5;   // sample#1
            x += y - x++ * z;
            Console.WriteLine($"x={x}  y={y}  z={z}   ");
            Console.WriteLine();

            x = 14; y = 1; z = 5;   // sample#2
            z = --x - y * 5;
            Console.WriteLine($"x={x}  y={y}  z={z}");
            Console.WriteLine();

            x = 14; y = 1; z = 5;   // sample#3

            y /= x + 5 % z;
            Console.WriteLine($"x={x}  y={y}  z={z}");
            Console.WriteLine();

            x = 14; y = 1; z = 5;   // sample#4
            z = x++ + y * 5;
            Console.WriteLine($"x={x}  y={y}  z={z}");
            Console.WriteLine();
           

            x = 14; y = 1; z = 5;   // sample#5
            x = y - x++ * z;
            Console.WriteLine($"x={x}  y={y}  z={z}");

            Console.WriteLine("Hello World!");
        }
    }
}
