using System;

namespace Conapp01
{
    //implementing student model
    class StudentModel
    {
        public int Rollno { get; set; }
        public string Class { get; set; }
        public string Name { get; set; }
        public int Fee { get; set; }
    }
    class Task12
    {
        static void Main(string[] args)
        {
            StudentModel c1 = new StudentModel { Name = "Rajat", Class = "5th", Rollno = 23, Fee = 25000 };
            StudentModel c2 = new StudentModel { Name = "Vanshi", Class = "7th", Rollno = 423, Fee = 44000 };
            StudentModel c3 = new StudentModel { Name = "Jiya", Class = "2nd", Rollno = 253, Fee = 56000 };

            List<StudentModel> courses = new List<StudentModel>();
            courses.Add(c1);
            courses.Add(c2);
            courses.Add(c3);

            foreach ( StudentModel c in courses)
                Console.WriteLine($"{c.Name} {c.Class} {c.Rollno} {c.Fee}");
        }
    
    }
}
