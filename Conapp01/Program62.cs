using System;
namespace Conapp01
{
    class Program62
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Banana", "Grapes", "Apple", "Grapes", "Cherry" };
            //var query  = from fruit in fruits select fruit;
            //var query = from fruit in fruits orderby fruit select fruit;
            //var query = from fruit in fruits orderby fruit descending select fruit;
            var query = from fruit in fruits where fruit.Length == 5 select fruit;

            foreach( var x in query)
                Console.WriteLine( $"{x}");
        }
    }
}