using System;
namespace Conapp01
{
    class Program23
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter a value to generate factorial: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = n; i >=1; i--)
            
                f *= i;
            Console.WriteLine($"Factorial of {n} is {f}");
            

        }
    }
}

/* 
Generate factorial value:
5 =>   5*4*3*2*1    =120
*/
