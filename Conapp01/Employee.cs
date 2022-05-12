namespace Conapp01
{
    class Employee
    {
        private string ename;
        private string job;
        private int id;
        private double salary;

        public Employee(string ename, string job, int id, double salary)
        {
            this.ename = ename; this.job = job; this.id = id; this.salary = salary;
        }

        public void GetEmployee()
        {
            Console.WriteLine($"Name of employee is: {ename}, Job type: {job}, Job id: {id}, Salary: {salary}");
        }

    }
}

