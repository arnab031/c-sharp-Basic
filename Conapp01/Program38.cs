using System;
using System.Collections.Generic;
namespace Conapp01
{
    class Program38
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>() {  "banana", "apple"};
            fruits.Add("grapes");
            fruits.Add("mango");
            fruits.Add("pineapple");

            fruits.Sort();
            fruits.Reverse();

            foreach (string fruit in fruits)
                Console.WriteLine(fruit);

        }
    }
}

/*
Generic:    used to provide strict type, which make the collection of typesafe
 */