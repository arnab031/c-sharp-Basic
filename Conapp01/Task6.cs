using System;

namespace Conapp01
{
    class Task6
    {
        static void Main(string[] args)
        {
            //Display count of event digits and odd digits
            Console.Write($"Enter any integer number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int even = 0;
            int odd = 0;
            while (n>0)
            {
                int rem = n % 10;
                if(rem%2==0)
                    even++;
                else
                    odd++;
                n = n / 10;
            }
            Console.WriteLine($"Count of even numbers: {even}");
            Console.WriteLine($"Count of odd numbers: {odd}");
        }
    }
}
