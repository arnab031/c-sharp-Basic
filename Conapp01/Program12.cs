using System;

namespace Conapp01
{
    class Program12
    {
        //check the given no. is zero or not

        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                Console.WriteLine("Input is zero");
            else
                Console.WriteLine($"{n} is not zero");
        }
        

    }
}

/*
Control structures: Used to control the flow of statement execution
                        Default execution is top to bottom approach

Available control structures:
    conditional control structures:         if,     switch case
    iteration control structures: while, do ..while for loops

Operators used in C# programming
Arithmetic operator:        +, -, *,  /,  %
Assignment operators:       =,      +=,     -=,     *=,     /= ,    %=
Relational operators:        >,      >=,     <,      <=,     ==,         !=
logical operators:          && (and) || (or)!(not)
increment and decrement:        ++, --
ternary operator:           ?:

*/
