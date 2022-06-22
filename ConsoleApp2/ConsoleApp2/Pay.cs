using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pay
    {   
        Employment newEmployed = new Employment();

        public void Payrollcalc()
        {
            try
            {

                Console.WriteLine("Digit the documentation Id");
                newEmployed.Documentation_ID1 = Console.ReadLine();
                Console.WriteLine("Digit the First Name of employed");
                newEmployed.First_Name1 = Console.ReadLine();
                Console.WriteLine("Digit the Last name of employed");
                newEmployed.Last_Name1 = Console.ReadLine();
                Console.WriteLine("digit the salary of employed");
                newEmployed.Salary1 = double.Parse(Console.ReadLine());
                Console.WriteLine("digit the days worked of employed");
                newEmployed.Days_Worked1 = double.Parse(Console.ReadLine());
                  
            }
            catch (FormatException e)
            {

                Console.WriteLine("Invalid data .\n entry an digit numeric", e);
                Console.ReadKey();

            }

            newEmployed.Income1 = newEmployed.Salary1 / 30;
            newEmployed.Income1 = newEmployed.Income1 * newEmployed.Days_Worked1;

            newEmployed.Transport_assistant1 = 117172 / 30;
            newEmployed.Transport_assistant1 = newEmployed.Transport_assistant1 * newEmployed.Days_Worked1;

            newEmployed.Health1 = newEmployed.Income1 * 0.04;
            newEmployed.Pension1 = newEmployed.Pension1 * 0.04;

            if (newEmployed.Salary1 <= 2000000)
            {

                newEmployed.Income1 = newEmployed.Income1 + newEmployed.Transport_assistant1;

            }

            else
            {

                newEmployed.Income1 = newEmployed.Income1;

            }


        }

        public void PrintData()
        {

            Console.WriteLine($"documentation id: {newEmployed.Documentation_ID1} ");
            Console.WriteLine($"First Name: {newEmployed.First_Name1 } ");
            Console.WriteLine($"Last name: {newEmployed.Last_Name1 } ");
            Console.WriteLine($"salary: {newEmployed.Salary1 } ");
            Console.WriteLine($"Days Worked: {newEmployed.Days_Worked1 } ");
            Console.WriteLine($"Income: {newEmployed.Income1 } ");
            Console.WriteLine($"Health: {newEmployed.Health1 } ");
            Console.WriteLine($"Pension: {newEmployed.Pension1 } ");

        }
           


    }
}
