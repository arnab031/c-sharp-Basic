using System;
namespace Conapp01
{
    class Program27
    {
        static void Main(string[] args)
        {
            int[] items = new int[5] {10, 20, 30, 40, 50};      //Array declaration
            //items = new int[5];   //Array instantiation
            //items[0] = 100;         //Assigning value in array
            for (int i = 0; i < items.Length; i++)     //iterating an array
                Console.WriteLine($"{items[i]}");
            //Console.WriteLine($"{items[1]}");
            
        }
        
    }
}

/*
 Array:  An array is used to store group of items in a single identification
        
        Seats in bus are array elements
        Days in a month/year are array elements
        
    syntax:
        datatype []items;
        items = new datatype[size];

    Array an index based collection
        Array can be single dimension:  Refers to store items in one direction
    Array can two dimension :       Refers to store items in two direcitons ( rows and columns )
    Array can jagged array  :       Refers to store different no.of elements in each row
*/ 