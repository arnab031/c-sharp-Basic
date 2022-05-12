using System;
namespace Conapp01
{
    partial class MyClass1
    {
        public void Display1()
        {
            Console.WriteLine("Hello from myclass display1");
        }
    }

    partial class MyClass1
    {
        public void Display2()
        {
            Console.WriteLine("Hello from myclass display2");
        }
    }
    class Program57
    {
        static void Main(string[] args)
        {
            MyClass1 o1 = new MyClass1();
            o1.Display1();
            o1.Display2();
        }
    }
}

/*
Partial class: It is a class defined in different places
 */