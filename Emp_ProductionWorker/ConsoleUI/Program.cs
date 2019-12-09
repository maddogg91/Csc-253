using System;
using EmployeeLibrary;

namespace ConsoleUI
{
/**
* October 27, 2019
* CSC 253
* Robert Charity
* Production Worker 
* This program allows input from a user for an Employee and creates a Production worker.
*/
    class Program
    {
        static void Main(string[] args)
        {
            //Create Employee object using the ProductionWorker class and Employee Class
            ProductionWorker employee = new ProductionWorker(GetEmployeeName(), GetEmployeeNumber(), GetShift(), GetPayRate());
            string shift = " ";

            //Depending on the number entered for shift, determines Day or Night shift.
            switch (employee.ShiftNumber)
            {
                case 1:
                    shift = "Day Shift";
                    break;

                case 2:
                    shift = "Night Shift";
                    break;

            }
            //Displays Employee information
            Console.WriteLine($"\nEmployee name: {employee.Name}\nEmployee#: {employee.Number}\nShift: {shift}\nPay Rate: {employee.PayRate.ToString("C2")}");
            Console.ReadLine();
        }

        //Get employee's name
        static string GetEmployeeName()
        {
            Console.WriteLine("\nEnter Employee's Name");
            return Console.ReadLine();

        }

        //Get employee's number
        static int GetEmployeeNumber()
        {
            Console.WriteLine("\nEnter Employee's Number");
            int number = 0;
            bool run = true;
            do
            {


                try
                {
                    number = int.Parse(Console.ReadLine());
                    run = false;

                }

                catch (FormatException)
                {
                    Console.WriteLine("Invalid entry");
                }
            }
            while (run == true);

            return number;
        }

        //Get employee's shift
        static int GetShift()
        {
            int number = 0;
            Console.WriteLine("\nDoes the worker work during the day shift or night?\nEnter 1 for day, Enter 2 for night");
            switch (Console.ReadLine())
            {
                case "1":
                    number = 1;
                    break;

                case "2":
                    number = 2;
                    break;

                default:
                    Console.WriteLine("\nInvalid entry");
                    number = GetShift();
                    break;


            }
            return number;
        }

        //Get employee's pay rate
        static decimal GetPayRate()
        {
            decimal pay = 0;
            Console.WriteLine("\nEnter the pay rate of the worker");
            bool run = true;
            do
            {


                try
                {
                    pay = decimal.Parse(Console.ReadLine());
                    run = false;

                }

                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid entry");
                }
            }
            while (run == true);

            return pay;
        }
    }
}
