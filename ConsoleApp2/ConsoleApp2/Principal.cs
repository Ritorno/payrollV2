using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Principal
    {
       public static void Main (string[]args)
        {
            Pay invoice = new Pay();

            Console.WriteLine("Welcome to the payroll program");
            Console.WriteLine("1. if you want add an employed");
            Console.WriteLine("2. if you want to exit from this program");
            string opt = Console.ReadLine();


            int opt1 = 1;

            switch (opt)
            {

                case "1":
                    do
                    {

                       invoice.Payrollcalc();
                       invoice.PrintData();

                        Console.WriteLine("1. if you want add any more employed");
                        Console.WriteLine("2. if you want to exit from this program");

                        opt1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Invalid data");

                        Console.Clear();
                    } while (opt1 != 2);
                    break;
                    
                    case "2":

                    Console.WriteLine("Leaving the program");
                    break;

                default:
                    Console.WriteLine("Invalid option please choose another ");
                    break;

            }


        }


    }
}
