using System;

namespace Conapp01
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter present month meter reading: ");
            int pmr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter last month meter reading: ");
            int lmr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"present month meter reading is : {pmr} and last month meter reading is : {lmr}");

            if (pmr >= lmr)
            {
                int bu = pmr - lmr;

                if(bu<150)
                {
                    Console.WriteLine($"Your UR is 1.75 ");
                    Console.WriteLine($"Your AMOUNT is {bu * 1.75}");
                }
                else if(bu<300)
                {
                    Console.WriteLine($"Your UR is 2.9 ");
                    Console.WriteLine($"Your AMOUNT is {bu * 2.9}");
                }
                else if(bu<500)
                {
                    Console.WriteLine($"Your UR is 3.75 ");
                    Console.WriteLine($"Your AMOUNT is {bu * 3.75}");
                }
                else
                {
                    Console.WriteLine($"Your UR is 5 ");
                    Console.WriteLine($"Your AMOUNT is {bu * 5}");
                }
            }

            else
            {
                Console.WriteLine($"Please enter the right values");
            }
          
            
        }
    }
}

/*
 
Task2:      Electricity bill generation program
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