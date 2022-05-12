using System;
namespace Conapp01
{
    class Program25
    {
        static void Main(string[] args)
        {
            //program to get sum of digits in a given no
            int n = 5643;
            int sum = 0;
            int d = 0;
            while(n>0)
            {
                d = n % 10;
                sum = sum + d;
                n /= 10;
            }
            Console.WriteLine($"Sum of digits: {sum}");
        }
    }
}
/*
Task5:   Display count of zero digits
Task6:   Display count of event digits and odd digits
Task7:   Display sum of even digits
Task8:   Display reverse of given no
Task9:   Check the given no is prime or not
Task10:  Check the given no is palindrome or not
============
*/