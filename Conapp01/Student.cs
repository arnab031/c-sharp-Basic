namespace Conapp01
{
    class Student
    {
        private int id;
        private string sname;
        private string course;
        private double fee;

        public void SetStudent(string sname, int id, string course, double fee)
        {
            this.sname = sname; this.id = id; this.course = course; this.fee = fee;
        }

        public void GetStudent()
        {
            Console.WriteLine($"Name of the student is: {this.sname}, Id of the student is: {this.id}, Course enrolled: {this.course}, and fee for the course is: {this.fee}");
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