using System;

namespace Conapp01
{
    class Program18
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Numbers generate using while loop: ");
            i = 1;                //initialization
            while (i <= 10)       //condition
            {
                Console.Write($"{i}");
                i++;              //update statement
            }

            Console.WriteLine("\n=========================");

            Console.WriteLine("Numbers generate using do..while loop: ");
            i = 1;
            do
            {
                Console.Write($"{i}");
                i++;

            } while (i <= 10);
            Console.WriteLine("\n==========================");

            Console.WriteLine("Numbers generate using for loop: ");
            for (i = 1; i <= 10; i++)
            {
                Console.Write($"{i}");
            }
        }
    }
}
