using System;
using DishaLibrary01;
namespace Conapp01
{
    class Program74
    {
        static void Main(string[] args)
        {
            int n = 6;
            Console.WriteLine(Calculations.Factorial(n));

            n = 23456;
            Console.WriteLine(Calculations.Reverse(n));
        }
    }
}
/*
 * Class library: It is a project which contains class files without Main() method
 *              This file genrate .dll when it is build
 *              dll stands for dynamic link library, this file can be consumed by any
 */