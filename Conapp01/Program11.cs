using System;

namespace Conapp01
{
    class Program11
    {
        enum Gender
        {
            Male, Female, NotDisclosed
        }
        static void Main(string[] args)
        {
                
            Gender Disha = Gender.Female;
            Gender Rajat = Gender.Male;

            Console.WriteLine(Disha);
            Console.WriteLine(Rajat);

        }
    }
}

//enum: used to create group of constant into a category