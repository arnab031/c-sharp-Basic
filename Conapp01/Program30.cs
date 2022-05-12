using System;
namespace Conapp01
{
    class Program30
    {
        static void Main(string[] args)
        {
            int[,] items;
            items = new int[2, 2] { {  10, 20}, { 20, 30 } };

            //items[0, 0] = 100;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{items[i,j]} ");
                }
                Console.WriteLine();
            }
            //Console.Write($"{items[0,0]} ");
        
            

        }
    }
}
