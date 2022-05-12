using System;

namespace Conapp01
{
    class Program14
    {
        //read the subject marks into m,p,c variables and display tot, avg, result and grade
        static void Main(string[] args)
        {
            Console.Write("Enter sub1(maths) marks: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter sub2(physics) marks: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter sub3(chemistry) marks: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Marks: m = {m}, p = {p}, c = {c}");
            int tot = m + p + c;
            double avg = tot / 3.0;
            Console.WriteLine($"Total marks: {tot}\n Avg marks: {avg}");

            string result = string.Empty;
            string grade = string.Empty;

            if(m>=35 && p>=35 && c>=35)
            {
                result = "PASS";
                if (avg >= 75) grade = "A1";
                else if (avg >= 60) grade = "A";
                else if (avg >= 50) grade = "B";
                else grade = "C";

            }
            else
            {
                result = "FAIL";
                grade = "NA";
            }
            Console.WriteLine($"Result is: {result}, Grade is : {grade}");
        }
        
    }
}

/*
 
Task2: Electricity bill generation program
Read present month and last month meter reading and calculate billed units
Calculate ur based on bu and amount

INPUT pmr, lmr
CALCULATE bu=pmr-lmr
Note: Make sure pmr>lmr
IF BU<150   THEN    UR=1.75
ELSEIF BU<300 THEN   UR=2.9
ELSE IF BU<500 THEN UR=3.75
ELSE UR=5
AMOUNT=BU*UR

*/