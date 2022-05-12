using System;
namespace Conapp01
{
    class Program19
    {
        static void Main(string[] args)
        {
            int i;

            i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{i} {11-i}");
                i++;
            }
        }
    }
}

/* 
 Debug      : refers to run statement one by one
 Fn + F5    : debug
 shift + F5 : stop debug
 ctrl + F5  : run the project
 Fn + F1    : step into
 F9         : Toggle breakpoint
*/