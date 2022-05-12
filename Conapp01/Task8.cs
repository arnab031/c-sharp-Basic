using System;

namespace Conapp01
{
    class Task8
    {
        static void Main(string[] args)
        {
            //Display reverse of given no
            Console.Write($"Enter any integer number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;
            while (n > 0)
            {
                int rem = n % 10;
                
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine($"The reverse of the given no is: {reverse}");
        }
    }
}
