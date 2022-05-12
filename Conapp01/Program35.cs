using System;
using System.Collections;
namespace Conapp01
{
    class Program35
    {
        static void Main(string[] args)
        {
            Hashtable items = new Hashtable();
            items.Add("Biscuit", 25);
            items.Add("Apple", 30);
            items.Add("egg", 23);
            items.Add("chocolate", 50);
            items.Add("grapes", 2);
            items.Add("Donut", 5);

            Console.Write("Enter item: ");
            string item = Console.ReadLine();

            if (items.Contains(item))
                Console.WriteLine(items[item].ToString());
            else
                Console.WriteLine($"{item} not exist....");

            /*
            Hashtable employees = new Hashtable();
            employees.Add("hr1", "Hari");
            employees.Add("hr2", "Dev");

            employees.Add("trainer1", "Kiran");
            employees.Add("trainer2", "Rajesh");

            Console.WriteLine( employees["hr1"].ToString());
            */
        }
    }
}

/*
Hashtable:  The object of this type is used to have key and value paired collection
 */