using System;
namespace Conapp01
{
    class Program67
    {
        static void Display()
        {
            Console.WriteLine("Hello from display");
        }
        static void Wishes()
        {
            Console.WriteLine("Hello from wishes");
        }
        delegate void MyDelegate();
        static void Main(string[] args)
        {
            MyDelegate d;
            //d = new MyDelegate(Display);    //assign method reference to delegate object
            //d();    //invoke method using delegate object

            //d = new MyDelegate(Wishes);
            //d();   //delegate with instant implementation
            d = new MyDelegate(delegate ()
            {
                Console.WriteLine("Hello from delegate!");
            });
            d();
        }

    }
}

/*
Delegate:   A delegate is a typesafe function pointer
            A delegate object refers to a method
                              refers to multiple methods
                              refers to an anonymous method ( instant implementation )
                              refers to a lambda expression         
Inbuilt delegates
Lambda expression
Introduction to database

 */
