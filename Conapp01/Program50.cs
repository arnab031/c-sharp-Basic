using System;
namespace Conapp01
{
    class Program50
    {
        static void Drawline()
        {
            string msg = "";
            for (int i = 0; i < 100; i++)
                msg += '-';
            Console.WriteLine( msg );
            
        }
        static void Display()
        {
            Console.WriteLine("Hello from display");
        }

        static void Main(string[] args)
        {
            Drawline();
            Display();
            Drawline();
        }
    }
}


/*
Static method: This is a method which will be called using class name
    In the same class you can call using method name
 */