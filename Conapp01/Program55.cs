using System;
namespace Conapp01
{
    class Program55
    {
        static void Display(params string[] names)
        {
            Console.Write("Names are: ");
            for (int i = 0; i < names.Length; i++)
                Console.Write($"{names[i]} ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Display("Disha", "Kiran", "Raj");
            Display("ram", "rani");
            Display("Rajesh");
        }
    }
}


/*
params:     This is ised to different no. of arguments in method
*/