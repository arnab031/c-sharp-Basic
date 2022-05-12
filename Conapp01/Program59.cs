using System;
namespace Conapp01
{
    static class StringManipulations
    {
        public static string FirstName(this string fullName)
        {
            return fullName.Substring(0, fullName.IndexOf(" "));
        }
        public static string LastName(this string fullName)
        {
            return fullName.Substring(fullName.LastIndexOf(" ") + 1);
        }
    }
    class Program59
    {
        static void Main(string[] args)
        {
            string fullName = "Disha Maini";
            Console.WriteLine(fullName);
            Console.WriteLine(fullName.FirstName());
            Console.WriteLine(fullName.LastName());
        }
    }
}
