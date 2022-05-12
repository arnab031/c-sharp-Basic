using System;
namespace Conapp01
{
    class Program63
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Mahesh", "Kiran", "Gani", "Sri", "Suresh", "Om", "Ramesh", "Ferandez", "Disha" };
            //var query = from name in names orderby name.length select name;
            //var query = from name in names orderby name.length descending select name;

            var query = from name in names where name.Substring(name.Length - 2) == "sh" select name;
            foreach(var x in query)
                Console.WriteLine(x);

        }
    }
}
