using System;

namespace Methods_CSharp
{
    class Program
    {
        public static int Sum(int x, int y)
        {
            var answer = x + y;
            return answer;
        }
        public static int Multiply(int x, int y, int z)
        {
            var Mult_Answer = x * y * z;
            return Mult_Answer;
        }
        public static void GreetingUser( string[] args)
        {
            Console.WriteLine("Whats your name?");
            var Name = Console.ReadLine();

            Console.WriteLine("Whats your favorite color?");
            string Color = Console.ReadLine();

            Console.WriteLine("What your favorite animal?");
            string Animal = Console.ReadLine();

            Console.WriteLine($"Hi my name is {Name}, my favorite color is {Color}, and my favorite animal is {Animal}");


        }
        static void Main(string[] args)

        {

            var Amount = Sum(10, 45);
            var MultAmount = Multiply(10,45,100);
            GreetingUserUser()


            


        }
    }
}
