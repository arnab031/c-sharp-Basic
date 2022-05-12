using System;
namespace Conapp01
{
    class Program66
    {
        static void Main(string[] args)
        {
            EmpBO context = new EmpBO();
            //List<EmpModel> employees = context.Employees.Skip(2).ToList();
            //List<EmpModel> employees = context.Employees.Take(2).ToList();
            //List<EmpModel> employees = context.Employees.Skip(2).Take(2).ToList();
            //List<EmpModel> employees = context.Employees.Where(x => x.Job == "Trainer").ToList();
            //foreach (var e in employees)
            //    Console.WriteLine($"{e.Id} {e.EName} {e.Job} {e.Salary}");

            //Fetch first developer
            //EmpModel e = context.Employees.Where(x=>x.Job=="Developer").First();

            //Fetch first manager
            EmpModel e = context.Employees.Where(x => x.Job == "Manager").FirstOrDefault();
            if (e is not null)
                Console.WriteLine($"{e.Id} {e.EName} {e.Job} {e.Salary}");
            else
                Console.WriteLine("No managers at all");

        }
    }
}
