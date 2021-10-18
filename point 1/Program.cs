using System;

namespace point_1
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Введите значение радиуса основания - r = ");
            decimal r = decimal.Parse(Console.ReadLine());
            Console.Write("Введите значение образующей - l = ");
            decimal l = decimal.Parse(Console.ReadLine());

            const decimal pi = 3.141592653M;
            Console.WriteLine($"Значение констаты   pi={pi}");

            decimal S = pi * r * (r + l);


            Console.WriteLine($"Площадь поверхности круглогоконуса составляет {S}");





           
        }
    }
}
