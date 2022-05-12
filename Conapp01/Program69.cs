using System;
namespace Conapp01
{
    class Program69
    {
        static int Square(int n)
        {
            return n * n;
        }
        static int Next(int n)
        {
            return n + 1;
        }
        delegate int MyDelegate(int n);      
        static void Main(string[] args)
        {
            MyDelegate d;
            d = new MyDelegate(Square);
            Console.WriteLine(d(8));

            d = new MyDelegate(Next);
            Console.WriteLine(d(8));

            d = new MyDelegate(delegate (int n)
            {
                return n * n * n;
            });
            Console.WriteLine(d(4));
        }
    }
}
