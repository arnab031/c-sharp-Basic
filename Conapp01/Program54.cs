using System;
namespace Conapp01
{
    class Program54
    {
        static void SetRole(string qly, out string jobrole)
        {
            switch (qly)
            {
                case "B.Tech":
                    jobrole = "Developer";
                    break;
                case "M.Tech":
                    jobrole = "Programmer";
                    break;
                case "MBA":
                    jobrole = "Hr";
                    break ;
                default:
                    jobrole = "Assistant";
                    break;
            }
        }
        static void Main(string[] args)
        {
            string qly = "B.Tech";
            string jobrole;
            SetRole(qly, out jobrole);
            Console.WriteLine($"Qualification {qly} is eligible for {jobrole}");
        }
    }
}
