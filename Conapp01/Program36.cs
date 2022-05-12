using System;
using System.Collections;
namespace Conapp01
{
    class Program36
    {
        static void Main(string[] args)
        {

            SortedList items = new SortedList();
            //Hashtable items = new Hashtable();
            items.Add("Biscuit", 25);
            items.Add("Apple", 30);
            items.Add("egg", 23);
            items.Add("chocolate", 50);
            items.Add("grapes", 2);
            items.Add("Donut", 5);

            foreach (DictionaryEntry item in items)
                Console.WriteLine($"Key = {item.Key}, Value = {item.Value}");
        }
    }
}

/*
SortedList: The objec of this type is used to store key value paired items in ascending order 

DictionaryEntry:It is a type contains both Key and Value as propeties
The object of DictionaryEntry can access  the items of Hashtable
=========

 */