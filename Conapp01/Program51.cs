 using System;
namespace Conapp01
{
    class Program51
    {
        static void Addition(int a, int b)
        {
            Console.WriteLine($"Addition is: {a+b}");
        }
        static void Addition(int a, int b, int c)
        {
            Console.WriteLine($"Addition is: {a + b + c}");
        }
        static void Main(string[] args)
        {
            Addition(10, 20);
            Addition(100, 200, 300);
        }
    }
}

/*
 method overloading:    Refers to define morethan one method with same name
=========
*/