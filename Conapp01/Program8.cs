using System;

namespace Conapp01
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a letter: ");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Given letter is: {ch}");
            Console.WriteLine($"Next letter of {ch} is {(char)(ch + 1)}");
            Console.WriteLine($"Previous0 letter of {ch} is {(char)(ch - 1)}");
        
        }
    }

}

/* char type    :   refers to variable to store any type of single letter including alphabet, digit, spl letter, etc...
  
  ASCII:   American Standard Code for Information Interchange
           It is a standard code for all letters used in keyword
  A-Z :         65 to 90
  a-z :         97 to 122
  0-9 :         48 to 57
 
 */