using System;

namespace Conapp01
{
    class Task7
    {
        static void Main(string[] args)
        {
            //Display sum of even digits
            Console.Write($"Enter any integer number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int even = 0;
            int sum = 0;

            while (n > 0)
            {
                int rem = n % 10;
                if (rem % 2 == 0)
                    sum += rem;
                    even++;
                n = n / 10;
            }
            Console.WriteLine($"Sum of even numbers: {sum}");
        }
    }
}
