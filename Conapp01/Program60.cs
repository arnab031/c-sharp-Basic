using System;
namespace Conapp01
{

    class Program60
    {
        static void Main(string[] args)
        {
            CourseBO context = new CourseBO();
            List<CourseModel> courses = null;
            int ch = 0;

            do
            {
                Console.Write("Menu\n1.GetAll \n2.Search Course\n3. Add Course\n4.Edit Course\n.Delete Course\n6.Exit\nEnter Choice:");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            courses = context.GetAllCourses();
                            foreach (CourseModel c in courses)
                                Console.WriteLine($"{c.Id} {c.Course} {c.Hod} {c.Fee}");
                        }
                        break;

                    case 2:
                        {
                            Console.Write("Enter value for courseid: ");
                            int id1 = Convert.ToInt32(Console.ReadLine());

                            CourseModel c = context.GetCourseByid(id1);
                            if (c is null)
                                Console.WriteLine($"{id1} not exist...");
                            else
                                Console.WriteLine($"{c.Id} {c.Course} {c.Hod} {c.Fee}");
                        }
                        break;


                    case 3:
                        {
                            Console.WriteLine("Input new course details: ");
                            Console.Write("Enter value for courseid: "); int id2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter value for Course: "); string course = Console.ReadLine();
                            Console.Write("Enter value for HOD: "); string hod = Console.ReadLine();
                            Console.Write("Enter value for Fee: "); int fee = Convert.ToInt32(Console.ReadLine());

                            CourseModel c1 = new CourseModel { Id = id2, Course = course, Hod = hod, Fee = fee };

                            context.AddCourse(c1);
                        }
                        break;


                    case 4:
                        {
                            Console.WriteLine("Input new course details for editing: ");
                            Console.Write("Enter value for courseid: "); int id3 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter value for Course: "); string course = Console.ReadLine();
                            Console.Write("Enter value for HOD: "); string hod = Console.ReadLine();
                            Console.Write("Enter value for Fee: "); int fee = Convert.ToInt32(Console.ReadLine());

                            CourseModel c1 = new CourseModel { Id = id3, Course = course, Hod = hod, Fee = fee };

                            context.EditCourse(id3, c1);
                        }
                        break;


                    case 5:
                        Console.Write("Enter value for courseid: "); int id = Convert.ToInt32(Console.ReadLine());
                        context.DeleteCourseById(id);
                        break;
                    case 6:
                        break;
                    default:
                        break;
                }
            } while (ch != 6);
        }
    }
}
