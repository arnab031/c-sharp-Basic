using System;

namespace Conapp01
{
    class Task5
    {
        static void Main(string[] args)
        {
            //Display count of zero digits
            Console.WriteLine($"Enter any integer number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int d;
            while(n > 0)
            {
                d = n % 10;
                n /= 10;
                if (d == 0)
                    count++;

            }
            Console.WriteLine($"Number of zeroes are: {count}");

        }
    }
}
