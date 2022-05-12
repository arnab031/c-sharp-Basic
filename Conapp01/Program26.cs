using System;
namespace Conapp01
{
    class Program26
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Numbers generate using while loop: ");
            i = 100;
            while (i<=10)  //entry control loop, statement in the loop are execute only when condition pass
            {
                Console.WriteLine($"{i} ");
                i++;     //update statement
            }
            Console.WriteLine("\n===================================");

            Console.WriteLine("Numbers generate using do while loop: ");
            i = 100;
            do
            {
                Console.Write($"{i} ");
                i++;

            } while (i<=10);  //exit control loop, statement is executed once even condition failed
            Console.WriteLine("\n====================================");
            {

            }
        }
    }
}
