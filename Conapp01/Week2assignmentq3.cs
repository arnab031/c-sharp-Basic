using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conapp01
{
    static class Today
    {
        public static bool IsWeekend()
        {
            string day = DateTime.Now.DayOfWeek.ToString().Substring(0,3).ToLower();
            return day == "sat" || day == "sun";
        }
        public static bool IsWorkingHours ()
        {
            int hour = DateTime.Now.Hour;
            return (hour >= 10 && hour <= 19);
        }
    }
    class BankAccount
    {
        private string cname;
        private int accountBalance;
        public BankAccount(string cname = "Not Provided", int accountBalance = 0)
        {
            this.cname = cname;
            this.accountBalance = accountBalance;
        }
        public void Deposit(int amount)
        {
            Console.WriteLine($"Attempt: {cname} Deposit requested for an amount of Rs. {amount}");
            if(Today.IsWeekend())
            {
                Console.WriteLine($"Status: {cname} Failed due to deposit requested on weekend");
            }
            else if(!Today.IsWorkingHours())
            {
                Console.WriteLine($"Status: {cname} Failed as deposit requested out of office hours");
            }
            else
            {
                accountBalance += amount;
                Console.WriteLine($"Status Success: {cname} Amount Rs.{amount}/- deposited successfully...");
            }
        Console.WriteLine("==================================================================================");
        Thread.Sleep(1000);
        }
        public void Withdraw(int amount)
        {
            Console.WriteLine($"Attempt: {cname}Withdraw requested for an amount of Rs.{amount}");
            if(Today.IsWeekend())
            {
                Console.WriteLine($"Status: {cname} Failed due to withdraw requested on weekend");
            }
            else if(!Today.IsWorkingHours())
            {
                Console.WriteLine($"Status: {cname} Failed due to withdraw requested out of office hours");
            }
            else
            {
                if(accountBalance == 0)
                {
                    Console.WriteLine($"Status: {cname} Failed as balance is NIL");
                }
                else if(accountBalance < amount)
                {
                    Console.WriteLine($"Status: {cname} Failed as an insufficient balance");
                }
                accountBalance -= amount;
                    Console.WriteLine($"Status Success: {cname} Amount Rs.{amount}/- withdraw successfully...");
                }
            Console.WriteLine("==================================================================================");
            Thread.Sleep(1000);
            }
        public void GetDetails()
        {
            Console.WriteLine($"Name: {cname}, Account Balance: {accountBalance}");
        }
    }
    class Week2assignmentq3
    {
        static void Main(string[] args)
        {
            BankAccount c1 = new BankAccount("Kiran", 1500);
            BankAccount c2 = new BankAccount();
            BankAccount c3 = new BankAccount("Rajesh");

            c1.Deposit(1200);
            c2.Deposit(100000);
            c3.Deposit(250000);
            c1.GetDetails();
            c2.GetDetails();
            c3.GetDetails();
            c1.Withdraw(1000);
            c2.Withdraw(2000000);
            c3.Withdraw(290000);
        }
    }
}
