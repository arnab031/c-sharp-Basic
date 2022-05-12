using System;
namespace Conapp01
{
    class Program20
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            Console.WriteLine($"{a} {b}");

            int c;

            int i = 2;
            while(i<10)
            {

                c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
                i++;
            }


        }
    }
    
}


/*
Fibanocii series: 0  1  1  2  3  5  8  13  21   34  55
*/