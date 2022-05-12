using System;
namespace Conapp01
{
    class Program71
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            Func<int, int> cube = x => x * x * x;
            Console.WriteLine(cube(4));

            Func<string, int> Length = x => x.Length;
            Console.WriteLine(Length("Disha Maini "));

            Func<string, string> FirstName = x => x.Substring(0, x.IndexOf(" "));
            Console.WriteLine(FirstName("Kiran Kumar"));

            Func<string, string> LastName = x => x.Substring(x.LastIndexOf(" ") + 1);
            Console.WriteLine(LastName("Disha Maini"));

            Func<int, int, int> Add = (a,b) => a + b;
            Console.WriteLine(Add(4,5));

            Func<int, int, int> Big = (a, b) => a > b ? a : b;
            Console.WriteLine(Big(6,7));

            Func<int, int, int> Small = (a, b) => a < b ? a : b;
            Console.WriteLine(Small(6, 7));
        }
    }
}

/*
.NET provided inbuilt delegates

Func: Refers to a method returning value
 */
