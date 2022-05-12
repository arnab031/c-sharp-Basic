using System;
namespace Conapp01
{
    class Program64
    {
        static void Main(string[] args)
        {
            EmpBO context = new EmpBO();
            //var query = from e in context.Employees select e;
            //var query = from e in context.Employees orderby e.EName select e;
            //var query = from e in context.Employees orderby e.Id descending select e;
            var query = from e in context.Employees where e.Job == "Trainer" select e;
            foreach (var e in query)
                Console.WriteLine($"{e.Id} {e.EName} {e.Job} {e.Salary}");
        }
    }
}
