using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conapp01
{
    interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        double GetMinimumSalary();
    }

    interface IEmployeeBonus
    {
        double CalculateBonus(double salary);
    }
    public abstract class EmployeeClass : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public EmployeeClass()
        { }

        public EmployeeClass(int id, string name)
        {
            this.ID = id; this.Name = name;

        }
        public abstract double CalculateBonus(double salary);
        public override string ToString()
        {
            return string.Format($"ID : {this.ID} Name : {this.Name}");
        }

        public abstract double GetMinimumSalary();
    }

    public class PermanentEmployee : EmployeeClass
    {
        public PermanentEmployee()
        { }

        public PermanentEmployee(int id, string name) : base(id, name)
        { }

        public override double CalculateBonus(double salary)
        {
            return (salary * .1);
        }

        public override double GetMinimumSalary()
        {
            return 15000;
        }
    }

    public class TemporaryEmployee : EmployeeClass
    {
        public TemporaryEmployee()
        { }
        public TemporaryEmployee(int id, string name) : base(id, name)

        { }
        public override double CalculateBonus(double salary)
        {
            return (salary * .05);
        }
        public override double GetMinimumSalary()
        {
            return 5000;
        }
    }

    public class ContractEmployee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ContractEmployee()
        { }
        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public double GetMinimumSalary()
        {
            return 5000;
        }
        public override string ToString()
        {
            return string.Format($"ID : {this.ID} Name : {this.Name}");
        }
        class OpenClosedPrinciple
        {
            static void Main(string[] args)
            {
                List<EmployeeClass> employees = new List<EmployeeClass>();
                employees.Add(new PermanentEmployee(1001, "Pavan"));
                employees.Add(new TemporaryEmployee(1002, "Tarun"));
                foreach (var employee in employees)
                    Console.WriteLine($"Employee {employee.ToString()} Bonus: {employee.CalculateBonus(100000)} MinSalary: {employee.GetMinimumSalary()}");
                Console.WriteLine();
                List<IEmployee> employeesOnly = new List<IEmployee>();
                employeesOnly.Add(new PermanentEmployee(1001, "Pavan"));
                employeesOnly.Add(new TemporaryEmployee(1002, "Tarun"));
                employeesOnly.Add(new ContractEmployee(1003, "Charan"));
                foreach (var employee in employeesOnly)
                    Console.WriteLine($"Employee {employee.ToString()} MinSalary: {employee.GetMinimumSalary()}");
            }
        }
    }
}

