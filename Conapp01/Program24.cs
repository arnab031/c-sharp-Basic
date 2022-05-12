using System;
namespace Conapp01
{
    class Program24
    {
        static void Main(string[] args)
        {
            //program to display count of digits in a given no.
            int n = 1234;

            int count=0;
            while(n>0)
            {
                count++;
                n /= 10;
            }
            Console.WriteLine($"Count of digits: {count}");
            
        }
    }
}

/*
    remove last digit in a given integer, if number is more than 0, meaning a digit is there and increase count
    n       count
    2345    0+1
    234     1+1
    23      2+1
    2       3+1
    0

 To remove last digit
     n = n / 10; (or)
     n /= 10;

 To get last digit
    int d = n % 10;

To add a digit:
    n = n * 10 + d;
 */
