using System;

namespace Conapp01
{
    class Task1
    {
        static void Main(string[] args)
        {
            //check the given no. is even or not
            Console.Write("Enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());


            if (n == 0)
                Console.WriteLine("Input number is zero");

            else if (n % 2 == 0)
                Console.WriteLine("Input number is even");
            
            else
                Console.WriteLine("Input number is odd");
        }
    }
}
