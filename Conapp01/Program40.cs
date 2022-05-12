using System;
namespace Conapp01
{
    class Program40
    {
        static void Main(string[] args)
        {
            string name = null;

            if(string.IsNullOrEmpty(name))
                Console.WriteLine("Is Empty");

            int? n = null;
            if(n is null)
                Console.WriteLine("no value in n");
            else
                Console.WriteLine(n);
        }
    }
}
/*

nullable types :    used to have null value as empty
which can be compared with null
 */
