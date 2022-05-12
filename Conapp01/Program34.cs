using System;
using System.Collections;
namespace Conapp01
{
    class Program34
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList();
            items.Add("Disha");
            items.Add(45);
            items.Add('a');
            items.Add(true);
            items.Add(34.456);

            foreach (object item in items)
                Console.WriteLine($"Value is {items}, datatype is {item.GetType()}");
        }
    }
}

/*
for each loop:  This loop is used to iterate on any collection including array
    for each(datatype items in items)
    {
        statements;
    }
 */
