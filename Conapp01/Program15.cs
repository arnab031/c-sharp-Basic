using System;

namespace Conapp01
{
    class Program15
    {
        //Read a letter and check the given letter is capital or small or digit or spl letter
        //And display its opposite case letter
        static void Main(string[] args)
        {
            Console.Write("Enter a letter: ");
            char ch = Convert.ToChar(Console.ReadLine());

            //if (ch >= 65 && ch <= 90)
            if( ch>='A' && ch<='z')
            {
                Console.WriteLine($"{ch} is CAPTIAL LETTER alphabet");
                Console.WriteLine($"{ch} is opposite case(lowercase) is: {(char)(ch + 32)}");
            }
            else if (ch >= 97 && ch <= 122)
            {

                Console.WriteLine($"{ch} is small letter alphabet");
                Console.WriteLine($"{ch} is opposite case(UPPERCASE) is: {(char)(ch - 32)}");

            }
            else if (ch >= 48 && ch <= 57)
            {
                Console.WriteLine($"{ch} is digit");
            }
            else
            {
                Console.WriteLine($"{ch} is spl letter");
            }
        }
    }
}
