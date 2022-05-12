using System;
namespace Conapp01
{
    class Program70
    {
        static void Main(string[] args)
        {
            Action wishes = () => Console.WriteLine("Hello");
            wishes();

            Action<string> display = x => Console.WriteLine($"Hello {x}");
            display("Disha");
        }
    }
}
/*
=========
.NET provided inbuilt delegates

Action  :   Refers to any method without returning value
Func:   Refers to a method returning value
Predicate:  Refers to method returning boolean


lamda expression :   It is a small/short definition
                        This lambda expression can also be called as arrow function in javascript/node technologies
 */