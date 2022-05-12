using System;

namespace Conapp01
{
    class Task11
    {
        static void Main(string[] args)
        {
            //create an integer array, read 5 elements into array and display the elements and their sum
            int[] items = new int[5];
            int sum = 0;
            Console.Write($"Input : ");
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($" Enter value of [{i}] : ");
                items[i] = Convert.ToInt32(Console.ReadLine());
                sum += items[i];
            }
            Console.WriteLine($"Given elements are: ");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"items[{i}] = {items[i]}");
            }
            Console.WriteLine($"Sum of elements: {sum}");


        }
    }
}
