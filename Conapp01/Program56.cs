using System;
namespace Conapp01
{
    class Program56
    {
        static void Addition(params int[] items)
        {
            int sum = 0;
            for (int i = 0; i < items.Length; i++)
                sum += items[i];
            Console.WriteLine($"Addition is : {sum}");
        }
        static void Main(string[] args)
        {
            Addition(10, 20, 30);
            Addition(100, 200);
            Addition(2, 3, 4, 5, 6, 7, 8);

        }
    }
}
