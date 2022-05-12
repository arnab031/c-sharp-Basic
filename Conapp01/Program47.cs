using System;

namespace Conapp01
{
    class Program47
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.SetStudent("Riya", 2389, "Data Science", 25000.00);
            s1.GetStudent();

            Student s2 = new Student();
            s2.SetStudent("Vanshi", 8392, "Full Stack Development", 45000);
            s2.GetStudent();
        }
    }
}
/*
Naming conventions:
    ClassName (or) MethodName (or) any TypeName should be PascalCase

    keywords will be lowercase only ( blue color in visual studio IDE)

    Constants will be in UPPERCASE

    variableNames will be in camelCaseNotation

 */