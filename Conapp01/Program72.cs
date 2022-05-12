using System;
namespace Conapp01
{
    class Program72
    {
        static void Main(string[] args)
        {
            EmpBO context = new EmpBO();
            List<EmpModel> employees = null;
            int ch = 0;
            do
            {
                Console.Write("Menu\n1.GetAll Employees\n2.Search an Employee by Id\n3.Add Employee\n4.Edit employee\n.Delete Employee\n6.Exit\nEnter Choice: ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            employees = context.GetAllEmployees();
                            foreach (EmpModel e in employees)
                                Console.WriteLine($"{e.Id} {e.EName} {e.Job} {e.Salary}");
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Enter value for Empid: ");
                            int id1 = Convert.ToInt32(Console.ReadLine());
                            EmpModel e1 = context.GetEmployeeById(id1);
                            if (e1 is null)
                                Console.WriteLine($"{id1} not exist..");
                            else
                                Console.WriteLine($"{e1.Id} {e1.EName} {e1.Job} {e1.Salary}");
                        }
                            break;
                    case 3:
                        {
                            Console.WriteLine("Input new Employee details: ");
                            Console.Write("Enter value for Empid: ");
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter value for Ename: ");
                            string EName = Console.ReadLine();
                            Console.Write("Enter value for Job: ");
                            string Job = Console.ReadLine();
                            Console.Write("Enter value for Salary: ");
                            int Salary = Convert.ToInt32(Console.ReadLine());
                            EmpModel c1 = new EmpModel { Id = id2, EName = EName, Job = Job, Salary = Salary };
                            context.AddEmployees(c1);
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Input new employees details for editing: ");
                            Console.Write("Enter value for Empid: ");
                            int id3 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter value for Ename: ");
                            string ename = Console.ReadLine();
                            Console.Write("Enter value for Job: ");
                            string Job = Console.ReadLine();
                            Console.Write("Enter value for Salary: ");
                            int Salary = Convert.ToInt32(Console.ReadLine());
                            EmpModel c1 = new EmpModel { Id = id3, EName = ename, Job = Job, Salary = Salary };
                            context.EditEmployees(id3, c1);
                        }
                        break;
                    case 5:
                        Console.Write("Enter value for courseid: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        context.DeleteEmployees(id);
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Invalid input choice...");
                        break;
                }
            } while (ch != 6);

        }
    }
}
