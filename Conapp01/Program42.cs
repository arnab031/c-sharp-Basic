using System;
namespace Conapp01
{
    class Program42
    {
        static void Main(string[] args)
        {
            int? a = null;
            int? b = null;
            int? c = null;

            try
            {
                Console.Write($"Enter no.1: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter no.2: ");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine($"Division of {a} and {b} is {c}");
            }
            catch (DivideByZeroException ex)
            {
                Console.Write($"You cannot divide by zero,  error {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
                b = 1;
            }
        }
    }
}
