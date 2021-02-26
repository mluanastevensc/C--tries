using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var div = a / b;
            var mod = a % b;
            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");
            Console.WriteLine();

            Console.WriteLine("Enter a number: ");
            int r = int.Parse(Console.ReadLine());


            var pi = Math.PI;
            var areaofCircle = pi * (r * r);
            Console.WriteLine($"The area of a circle with radius {r} is {areaofCircle}");

            //var i = 3;
            //var j = 4;
            //var k = ++i * j++;
            //Console.WriteLine(k);
    




                Console.WriteLine("Hello World!");
        }
    }
}
