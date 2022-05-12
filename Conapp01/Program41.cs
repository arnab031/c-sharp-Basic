using System;
namespace Conapp01
{
    class Program41
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter an integer: ");
            int? n = null;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Input range is failed "+ex.Message+", we are setting up with 1");
                n = 1;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Different datatype error " + ex.Message + ", we are setting up with 0");
                n = 0;
            }
            finally
            {
                Console.WriteLine($"Square of {n} is {n * n}");
            }
        }
    }
}

/*
Exception Handling
    An exception refers to a runtime error
    Ex:     Input value out of range
            Arrayoutofbounds
            formatexception
            dividebyzeroexception

    What will happen when an exception raised?
    A: The program gets terminated due to its default mechanism

    How to handle exceptions?
    using try, catch and finally blocks

    try:    This block is used to provide statements which may provide error
    catch:  This block will catch error and execute specified statement at exception
    finally:    This block is used to execute statements even error raised or not
==============

 */