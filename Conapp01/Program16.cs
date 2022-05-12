using System;

namespace Conapp01
{
    class Program16
    {   
        //wishes based on time and day
        static void Main(string[] args)
        {
            Console.WriteLine($"Time: {DateTime.Now.ToLongTimeString()}");
            Console.WriteLine($"Today is: {DateTime.Now.DayOfWeek.ToString()}");

            int hour = DateTime.Now.Hour;
            string today = DateTime.Now.ToString().Substring(0,3).ToLower();

            if (hour < 12) Console.WriteLine("Good Morning!");
            else if (hour < 16) Console.WriteLine("Good Afternoon!");
            else Console.WriteLine("Good Evening!");

            if( today =="sat" || today == "sun")
                Console.WriteLine("Today is weekend and busy with family..." );
            else
                Console.WriteLine("Today is weekday and enjoy office works...");
        }
    }
}
