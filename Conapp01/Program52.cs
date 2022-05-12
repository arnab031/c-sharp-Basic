using System;
namespace Conapp01
{
    class Program52
    {
        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void Main(string[] args)
        {
            int a = 5, b = 7;
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After swap: a = {a}, b = {b}");
        }
    }
}
/*
Note: The default method arguments are value type
changes made at target will not effect source
*
ref parameter: This is used to create a reference an argument without creating copy
    This paramter refers to original argument, changes made in the definition will effect the source
 */