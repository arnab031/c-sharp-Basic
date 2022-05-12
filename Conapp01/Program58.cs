using System;
namespace Conapp01
{
    static class MyExtensions
    {
        public static int Next(this int n)
        {
            return n + 1;
        }
        public static int Square(this int n)
        {
            return n * n;
        }
        public static int Factorial(this int n)
        {
            int f = 1;
            for (int i = n; i >= 1; i--)
                f *= i;
            return f;
        }
    }
    class Program58
    {
        static void Main(string[] args)
        {
            int n = 6;
            Console.WriteLine(n);
            Console.WriteLine(n.Square());
            Console.WriteLine(n.Square().Square());
            Console.WriteLine(n.Next());
            Console.WriteLine(n.Next().Next());

            Console.WriteLine(n.Next().Square());
            Console.WriteLine(n.Square().Next());

            Console.WriteLine(n.Factorial());
        }
    }
}
/*
Extension Methods: These are used to add a funcitonality to an existing data type
How to create extension method?
Define a static class and implement a static method with datatype as argument by prefix this keyword
 */