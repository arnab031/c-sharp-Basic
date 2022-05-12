using System;   //This is the base library
namespace ConApp01
{
    class Program3
    {
        static void Main(string[] args)
        {
            string v1 = "Disha";
            Console.WriteLine("v1 = "+v1+", dataype is "+v1.GetType());

            int v2 = 1400;
            Console.WriteLine("v2 = " + v2 +", datatype is " + v2.GetType());

            double v3 = 34.45;
            Console.WriteLine("v3 = " + v3 + ", datatype is " + v3.GetType());

            char v4 = 'a';
            Console.WriteLine("v4 = " + v4 + ", datatype is " + v4.GetType());

            bool v5 = true;
            Console.WriteLine("v5 = " + v5 + ", datatype is " + v5.GetType());

        }
        
    }
}

/*
  CTS : Common Type System

        This is component inside CLR(Common Language Runtime)
        This has the hierarchy of datatypes available in .NET

     System.Int16       2 byte integer      short
     System.Int32       4 byte integer      int
     System.Int64       8 byte integer      long
 */