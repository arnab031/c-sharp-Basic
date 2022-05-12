using System;
namespace Conapp01
{

    class Program45
    {
        static void Main(string[] args)
        {
            Numbers n1 = new Numbers();    //object instantation
            Numbers n2 = new Numbers(100,200);     //object instantation

            n1.GetNumbers(); 
            n2.GetNumbers();
        }
    }
}
/*
 Private : It is an access modifier, the content in this is accessible within the class only
 Public : It is an access modifier, the content in this accessible within inside and outside a class
 */