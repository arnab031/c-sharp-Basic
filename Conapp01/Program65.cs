using System;
using System.Linq;
namespace Conapp01
{
    class Program65
    {
        static void Main(string[] args)
        {
            int[] feePayments = new int[] { 100, 200, 300, 400, 500, 600, 700, 800 };

            Console.WriteLine(feePayments.First());
            Console.WriteLine(feePayments.Last());
            Console.WriteLine(feePayments.ElementAt(2));

            //foreach (int payment in feePayments.Take(5))
            //foreach (int payment in feePayments.Last(5))
            //foreach (int payment in feePayments.Skip(3))

            foreach(int payment in feePayments.Skip(3).Take(3))
                Console.WriteLine(payment);

        }
    }
}
/*
 Linq like queries are implemented using in built extension methods
 */