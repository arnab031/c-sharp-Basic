using System.Collections.Generic;
using System.Linq;
namespace Conapp01
{
    class EmpBO
    {
        public List<EmpModel> Employees { get; set; }
        public EmpBO()
        {
            Employees = new List<EmpModel> {
            new EmpModel{Id=1001,EName="Bhanu",Job="Trainer",Salary=5000},
            new EmpModel{Id=1002,EName="Anil",Job="Developer",Salary=5300},
            new EmpModel{Id=1003,EName="Charan",Job="Programmer",Salary=5200},
            new EmpModel{Id=1004,EName="David",Job="Trainer",Salary=5100}
            };
        }
        public List<EmpModel> GetAllEmployees()
        {
            return Employees;
        }
        public EmpModel GetEmployeeById(int Id)
        {
            EmpModel e1 = null;
            for (int i = 0; i < Employees.Count; i++)
            {
                if(Employees[i].Id == Id)
                {
                    e1 = Employees[i];
                    break;
                }
            }return e1;
        }
        public void AddEmployees(EmpModel e1)
        {
            Employees.Add(e1);
        }
        public void EditEmployees(int Id, EmpModel e1)
        {
            int pos = -1;

            for (int i = 0; i < Employees.Count; i++)
            {
                if(Employees[i].Id==Id)
                {
                    pos = 1;
                    break;
                }
            }

            if (pos != -1)
                Employees[pos] = e1;
        }
        public void DeleteEmployees(int Id)
        {
            int pos = -1;
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].Id == Id)
                {
                    pos = 1;
                    break;
                }
            }
            Employees.RemoveAt(pos);
            
        }

    }

}
/*
 BO(Business Objects):  The BO consists of methods to perform CRUD operations on data source
 Expression body method:    This feature is used to make method simple
 When a method contains single definition it can assign using lambda operations
 */