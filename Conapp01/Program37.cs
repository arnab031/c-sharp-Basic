using System;
namespace Conapp01
{
    class Program37
    {
        static void Main(string[] args)
        {
            object o1 = 100;    //boxing
            Console.WriteLine($"value is {o1}, datatype is {o1.GetType()}");


            int i1 = (int)o1;        //unboxing
            Console.WriteLine($"value is {i1}, datatype is {i1.GetType()}");

            o1 = 45.34;     //boxing
            Console.WriteLine($"value is {o1}, datatype is {o1.GetType()}");

            double d1 = (double)o1;     //unboxing
            Console.WriteLine($"value is {d1}, datatype is {d1.GetType()}");

        }
    }
}

/*
Boxing  :   Refers to assign anytype of data to object
Unboxing:   Refers to dereference the same

How to store anytype of data in object type?
Object is root type of all datatype in CTS
============

 */