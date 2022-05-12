using System;
namespace Conapp01
{
    class Program13
    {
        //Read marks into a variable and check the input entry is valid or not
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 0 && marks <= 100)
                Console.WriteLine($"input marks {marks} are valid");

            else
                Console.WriteLine($"invalid input marks{marks}");
        }
    }
}
