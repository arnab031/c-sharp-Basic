using System;

namespace Conapp01
{
    class Task10
    {
        static void Main(string[] args)
        {
            //Check the given no is palindrome or not
            Console.Write($"Enter any integer number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            int palindrome = 0;
            while (n > 0)
            {
                int rem = n % 10;
                palindrome = (palindrome * 10) + rem;
                n = n / 10;
            }
            if (temp == palindrome)
            {
                Console.WriteLine($"The given no is Palindrome ");
            }
            else
            {

                Console.WriteLine($"The given no is not a Palindrome ");
            }
        }
    }
}
