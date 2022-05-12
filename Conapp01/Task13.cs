using System;

namespace Conapp01
{
    //implementing employee model
    class EmployeeModel
    {
        public int Empid { get; set; }
        public string Field { get; set; }
        public string ename { get; set; }
        public int salary { get; set; }
    }
    class Task13
    {
        static void Main(string[] args)
        {
            EmployeeModel c1 = new EmployeeModel { ename = "Rajat", Field = "Developer", Empid = 245463, salary = 25000 };
            EmployeeModel c2 = new EmployeeModel { ename = "Sumit", Field = "Programmer", Empid = 34533, salary = 330000 };
            EmployeeModel c3 = new EmployeeModel { ename = "Rajnesh", Field = "Trainer", Empid = 677853, salary = 465600 };

            List<EmployeeModel> courses = new List<EmployeeModel>();
            courses.Add(c1);
            courses.Add(c2);
            courses.Add(c3);

            foreach (EmployeeModel c in courses)
                Console.WriteLine($"{c.ename} {c.Field} {c.Empid} {c.salary}");
        }

    }
}