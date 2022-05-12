using System;
namespace Conapp01
{
    class Program43
    {
        static void Main(string[] args)
        {
            int[] items = { 10, 20, 30, 40, 50 };

            try
            {
                for (int i = 0; i <= items.Length; i++)
                    Console.WriteLine($"{items[i]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("No more array elements "+ ex.Message);
            }
            finally
            {
                Console.WriteLine("Statement executed even error is raised or not");
            }
        }
    }
}