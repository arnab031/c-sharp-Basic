using System;
namespace Conapp01
{
    class Program29
    {
        static void Main(string[] args)
        {
            //display sum, count, avg, biggest and smallest element in an array
            int[] items = new int[5];

            int sum = 0;
            int max=0;
            int min=0;
            Console.WriteLine("Input: ");
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"Enter value for items[{i}]: ");
                items[i] = Convert.ToInt32(Console.ReadLine());
                sum += items[i];
                if (i == 0) max = min = items[0];
                if(items[i] > max)
                    max = items[i];
                else if(items[i] < min)
                    min = items[i];
            }

            Console.WriteLine($"Given elements are: ");
            for (int i = 0; i < items.Length; i++) 
            {
                Console.WriteLine($"items[{i}] = {items[i]}");
            }
            int count = items.Length;
            double avg = (double)sum / count;
            Console.WriteLine($"Count of elements: {count}");
            Console.WriteLine($"Sum of elements: {sum}");
            Console.WriteLine($"Average of elements: {avg}");
            Console.WriteLine($"Biggest elements: {max}");
            Console.WriteLine($"Smallest elements: {min}");
        }
    }
}
