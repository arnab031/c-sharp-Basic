using System;
namespace Conapp01
{
    class Program22
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter no to generate multiplication table: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n*i}");
            }

        }
    }
}
