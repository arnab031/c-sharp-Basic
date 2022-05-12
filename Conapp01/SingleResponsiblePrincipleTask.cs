using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Conapp01
{
    interface IUser
    {
        void SignUp();  //User Registration
        void SignIn();  //User Login
    }
    interface IEmail
    {
        void Compose();     //To send an email
        void Inbox();  //To receive an email
    }

    interface ILogger
    {
        void LogErrors();   //To log error
    }
    class GEmail : IUser, IEmail, ILogger
    {
        public void Inbox()
        {
            Console.WriteLine("Inbox: Code to view mails received");
        }

        public void Compose()
        {
            Console.WriteLine("Send Email : Code to send email");
        }

        public void LogErrors()
        {
            Console.WriteLine("Error Logging: Code to log errors");
        }

        public void SignIn()
        {
            Console.WriteLine("Login : Code to validate input and navigate to dashboard");
        }

        public void SignUp()
        {
            Console.WriteLine("RegisterUser : Code to take input and create user login");
        }
    }
    class SingleResponsiblePrincipleTask
    {
        static void Main(string[] args)
        {
            GEmail g1 = new GEmail();
            g1.SignUp();
            g1.SignIn();
            g1.Compose();
            g1.Inbox();
            g1.LogErrors();

        }
    }

}
/*
 Single Responsibility Principle (SRP)
A class should take one responsibility and there should be one reason to change that class.
Every class or a module should have responsibility over a single part of the functionality provided by the software that responsibility should entirely encapsulate by that class.
Motivations:
	Maintainability
	Testability
	Flexibility and extensibility
	Parallel Development
	Loosely Coupling
	SOLID principals and Design Pattern play key role in the above motivations

 */
