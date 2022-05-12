using System;   //This is the base library
namespace ConApp01
{
    class Program2
    {
        static void Main(string[] args)
        {
            string name = "Disha Maini";
            Console.WriteLine(name);
            Console.WriteLine(name.Length);  //This property return the length of the given string
            
            //String class methods
            Console.WriteLine(name.ToLower());  //return upper case string
            Console.WriteLine(name.ToUpper());  //return lower case string

            Console.WriteLine(name.IndexOf("a"));   //return first occurence of letter a
            Console.WriteLine(name.LastIndexOf("a"));  //return last occurence of letter a

            Console.WriteLine(name.Substring(3,5));   //return 5 letters from 3rd position
            Console.WriteLine(name.Substring(4,6));   //return 6 letters from 4th position
            Console.WriteLine(name.Substring(4));     //return all letters from 4th position

        }
        
    }
}

/*
  code snippet:     this feature to generate syntax in visual studio IDE
  svm +tab +tab     :       dtatic void main()
  
  cw+tab+tab        :       console.writeline();
if, switch, while, etc...,
*/