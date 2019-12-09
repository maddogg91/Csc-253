using System;
using EmployeeLibrary;

namespace ConsoleUI
{
    /**
    * Nov 2, 2019
    * CSC 253
    * Robert Charity
    * Team Leader
    * This program allows input from a user for an Employee and creates a Team Leader out of Production worker.
*/
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            do
            {
                Console.Write("This program displays employee information, would you like to run this program?\n>");
                switch (Console.ReadLine().ToLower())
                {
                    case "yes":
                        DisplayMenu();
                        break;

                    case "no":
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            while (run == true);
            

           
            
            //Create Employee object using the ProductionWorker class and Employee Class
          
        }

        private static void DisplayMenu()
        {
            Console.Write("Would you like to create a production worker, team leader or supervisor?\n>");

            switch (Console.ReadLine().ToLower())
            {
                case "production worker":
                    CreateProductionEmployee();
                    break;

                case "supervisor":
                    CreateSupervisor();
                    break;

                case "team leader":
                    CreateTeamLeader();
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        private static void CreateTeamLeader()
        {
         
            TeamLeader employee = new TeamLeader(GetEmployeeName(), GetEmployeeNumber(), GetShift(), GetPayRate(), GetHours());
            string check= " ";
            string shift = " ";
            check = CheckEmployeeHours(employee.AttendedHours, employee.RequiredTrainingHours);

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
            Console.Write($"\nEmployee name: {employee.Name}\nEmployee#: {employee.Number}\nShift: {shift}\nPay Rate: {employee.PayRate.ToString("C2")}\n{check}\nTraining Hours Remaining: " +
                $"{employee.RequiredTrainingHours-employee.AttendedHours}");
            

            
            if (!check.Contains("not"))
            {
                Console.WriteLine($"\nBonus Earned: {employee.MonthlyBonus.ToString("C2")}");
            }
            Console.ReadLine();

        }

        private static string CheckEmployeeHours(double hours, double requiredHours)
        {
            if (hours >= requiredHours)
            {
                return "Employee has met required hours";
            }
            else
            {
                return "Employee has not met required hours";
            }
        }

        private static double GetHours()
        {
            double hours= 0;
            Console.WriteLine("\nHow many hours of training did the employee attend?");
            string input = Console.ReadLine();
            bool run = true;
            do
            {
                try
                {
                    hours= double.Parse(input);
                    run = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid entry");

                }


            }
            while (run == true);
            return hours;
           
        }

        static void CreateProductionEmployee()
        {
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

        static void CreateSupervisor()
        {
            
            ShiftSupervisor employee = new ShiftSupervisor(GetEmployeeName(), GetEmployeeNumber(), GetSalary());
            decimal bonus= GetBonus(employee);
            string check = $"Salary w/Bonus: {(employee.Bonus + employee.Salary).ToString("C2")}";
            if (bonus == 0)
            {
                check = "Did not meet Bonus Requirements";
            }
            //Displays Employee information
            Console.WriteLine($"\nEmployee name: {employee.Name}\nEmployee#: {employee.Number}\nAnnual Salary: {employee.Salary.ToString("C2")}\n{check}");
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


        static decimal GetSalary()
        {
            decimal pay = 0;
            Console.WriteLine("\nEnter the base annual salary of the worker");
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

        private static decimal GetBonus(ShiftSupervisor employee)
        {
          
            Console.Write("\nDid the shift meet production goals?\n\nEnter yes or no\n>");
            switch(Console.ReadLine().ToLower())
            {
                case "yes":
                    return employee.Bonus;
                   

                case "no":
                    return 0;
                  

                default:
                    Console.WriteLine("Invalid entry");
                    return GetBonus(employee);
                    
            }
        }

    }
}
