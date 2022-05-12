using System;
namespace Conapp01
{
    class Program32
    {
        static void Main(string[] args)
        {
            string[][] batches = new string[5][];
            batches[0] = new string[] { "Anil", "Arvind" };
            batches[1] = new string[] { "Bobby", "Bhaskar","Bhuvan" };
            batches[2] = new string[] { "Chandu", "Charan", "Chiru","Cathe" };
            batches[3] = new string[] { "Dev", "Duke","Disha" };
            batches[4] = new string[] { "Eman" };

            for (int i = 0; i < batches.Length; i++)
            {
                for (int j = 0; j < batches[i].Length; j++)
                    Console.Write($"{batches[i][j]} ");
                Console.WriteLine();  
            }
        }
    }
}
