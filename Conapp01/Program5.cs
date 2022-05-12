using System;

namespace ConApp01
{
    class Program5
    {
        static void Main(string[] args)
        {
            int a = 125;
            int b = 25;

            Console.WriteLine($"a = {a} , b = {b}");
            Console.WriteLine($"Add of {a} and {b} is {a + b}");
            Console.WriteLine($"Sub of {a} and {b} is {a - b}");
            Console.WriteLine($"Mul of {a} and {b} is {a * b}");
            Console.WriteLine($"Div of {a} and {b} is {a / b}");

            int c = a > b ? a  : b;
            Console.WriteLine($"Biggest of {a} and {b} is {c}");

            c = a < b ? a : b;
            Console.WriteLine($"Smallest of {a} and {b} is {c}");

        }
        
    }
}

