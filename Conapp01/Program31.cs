using System;
namespace Conapp01
{
    class Program31
    {
        static void Main(string[] args)
        {
            int[][] items = new int[5][];      //jagged array initialization
            items[0] = new int[] { 12, 23, 567, 68, 98 };
            items[1] = new int[] { 1345,54,65};
            items[2] = new int[] { 34,45,2,34 };
            items[3] = new int[] { 12 };
            items[4] = new int[] { 1,5 };

            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items[i].Length; j++)
                {
                    Console.Write($"{items[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}


/*
Jagged array: Array of array
                used to have different no. of columns in each row
*/