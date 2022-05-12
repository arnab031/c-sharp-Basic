using System;
namespace Conapp01
{
    class Test1
    {
        public Test1()      //constructor method
        {
            Console.WriteLine("Object creation process......");
        }
        public Test1(string name)         //parametrized constructor method
        {
            Console.WriteLine($"{name}  Object creation process.......");
        }
    }
    class Program49
    {
        static void Main(string[] args)
        {
            Test1 o1 = new Test1(); 
            Test1 o2 = new Test1("raj");
        }
    }
}
/*
Constructor method:
------------------
    This is a special method, which will be invoked while object creation
	a) Constructor method name should be same as class name

    b) Constructor will be invoked implicitly

	This method used to initialize the class members, the default values into data members are provided using constructor method

    Ex: While opening your bank balance set to zero using contructor
            While opening email account you will get welcome mail, send by constructor

Scenario:
Admission in a college, process completed by constructor method
Admission in a hospital, process completed by constructor method
Reporting in an office, process completed by constructor method
Opening bank account, process completed by constructor method
=============
*/