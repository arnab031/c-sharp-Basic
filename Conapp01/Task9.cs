using System;

namespace Conapp01
{
    class Task9
    {
        static void Main(string[] args)
        {
            //Check the given no is prime or not
            Console.Write($"Enter any integer number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;
         
            for (int i = 1; i <= n; i++)
            {
                if ( n % i == 0)
                {
                    count++;
                }
            }
                
            {
                if(count == 2)
                {
                    Console.WriteLine($" It is a prime number ");
                }
                else
                    Console.WriteLine($" It is not a prime number ");

            }
            
            
        }
    }
}
