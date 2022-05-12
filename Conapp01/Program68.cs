using System;
namespace Conapp01
{
    class Program68
    {
        static void Display(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        static void Wishes(string name)
        {
            Console.WriteLine($"Hi {name} Good Morning!");
        }
        delegate void MyDelegate(string name);      //Delegate with paramterized method
        static void Main(string[] args)
        {
            MyDelegate d;
            d = new MyDelegate(Display);
            d("Disha");

            d = new MyDelegate(Wishes);
            d("Rajat");

            d = new MyDelegate(delegate(string name)
            {
                Console.WriteLine($"Hello {name} delegate instant implementation");
            });
            d("Disha");
        }
    }
}
