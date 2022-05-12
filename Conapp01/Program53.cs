using System;
namespace Conapp01
{
    class Program53
    {
        static void Initialize(out int a)
        {
            a = 0;
        }
        static void Main(string[] args)
        {
            int a;
            Initialize(out a);
            Console.WriteLine($"a ={a}");
        }
    }
}

/*
out parameter: Used to have variable value receive empty and fill with given value
used to intialize values, set default values into variables
 */
