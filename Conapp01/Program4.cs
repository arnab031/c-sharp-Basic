using System;   
namespace ConApp01
{
    class Program4
    {
        static void Main(string[] args)
        {
            string name = "Disha Maini";
            Console.WriteLine($"{name}");
            Console.WriteLine($"Name is {name}");

            Console.WriteLine($"Length of {name} is { name.Length} letters");
            Console.WriteLine($"UPPER CASE IS {name.ToUpper()}");
            Console.WriteLine($"lower case is {name.ToLower()}");


        }
        
    }
}

/*
    Templating literals
        this feature is used to provide variable content within message
 */