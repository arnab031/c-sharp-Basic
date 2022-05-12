using System;
using System.Collections.Generic;
namespace Conapp01
{
    class Program39
    {
        static void Main(string[] args)
        {
            List<int> payments = new List<int>() { 100,200,300};
            payments.Add(250);
            payments.Add(500);

            Console.WriteLine(payments.Count);

            foreach (int payment in payments)
                Console.WriteLine(payment);
        }
    }
}
