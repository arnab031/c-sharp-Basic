using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conapp01
{
    interface DAL
    {
        void ConnectToDB();
        void GetCustomers();
    }
    class OracleDAL : DAL
    {
        public void ConnectToDB()
        {
            Console.WriteLine("Code to connect to oracle");
        }
        public void GetCustomers()
        {
            Console.WriteLine("Customers data from oracle");
        }
    }
    class SqlServerDal : DAL
    {
        public void ConnectToDB()
        {
            Console.WriteLine("Code to connect to sql server");
        }
        public void GetCustomers()
        {
            Console.WriteLine("Customers data from sql server");
        }
    }
    class MySqlDal : DAL
    {
        public void ConnectToDB()
        {
            Console.WriteLine("Code to connect to my sql ");
        }
        public void GetCustomers()
        {
            Console.WriteLine("Customers data from MySql");
        }
    }
    class CustomerClass
    {
        DAL c1;
        public CustomerClass(DAL c1)
        {
            this.c1 = c1;
        }
        public void GetData()
        {
            c1.ConnectToDB();
            c1.GetCustomers();
        }
    }
    class DIEx02
    {
        static void Main(string[] args)
        {
            CustomerClass source1 = new CustomerClass(new OracleDAL());
            CustomerClass source2 = new CustomerClass(new MySqlDal());
            CustomerClass source3 = new CustomerClass(new SqlServerDal());

            source1.GetData(); source2.GetData(); source3.GetData();

        }
    }

}
