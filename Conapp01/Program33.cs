using System;
using System.Collections;
namespace Conapp01
{
    class Program33
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList();
            Console.WriteLine($"Capacity is {items.Capacity}, Count is: {items.Count}");

            Thread.Sleep(1000);   //used to suspend specified no. of milli seconds
            items.Add(100);
            Console.WriteLine($"Capacity is {items.Capacity}, Count is: {items.Count}");

            Thread.Sleep(1000);
            items.Add(200);
            Console.WriteLine($"Capacity is {items.Capacity}, Count is: {items.Count}");

            Thread.Sleep(1000);
            items.Add(300);
            Console.WriteLine($"Capacity is {items.Capacity}, Count is: {items.Count}");

            Thread.Sleep(1000);
            items.Add(400);
            Console.WriteLine($"Capacity is {items.Capacity}, Count is: {items.Count}");

            Thread.Sleep(1000);
            items.Add(500);
            Console.WriteLine($"Capacity is {items.Capacity}, Count is: {items.Count}");

        }
    }
}


/*

Array:	Used to store group of elements within single identification
Limitations:
	Array will store limited number of elements, size cannot be enhanced
	Array will store only one type of items

To overcome limiations of array will use collections


Collection:
	The types in collection object is used to store unlimited elements of any datatype
	It is a readymade datastructure feature in languages like java, C#, etc.,

How a collection type store unlimited elements?
The default size of collection type is zero
While adding 1st element, the size increases to 4
While adding 5th element, the size increases to 8
While adding 9th element, the size increases to 16
While adding 17th element, the size increases to 32

How collection type store anytype of data?
The collection allow to store object as datatype, where object refers to anytype of data


Collection type consist of Capacity and Count attribute
Capacity refers to how many element can be stored?
Count refers to no.of elements already stored


Collection:     System.Collection

Collection types:
    ArrayList
    Hashtble
    Stack   
    Queue, etc.,

Add(),      Remove(),       RemoveAt(),     Sort(),     Reverse(),      TrimToSize()

=============

 */