using System;
namespace EmployeeWages
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem on Master Branch");

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            Random random = new Random();
            for (int i = 0; i < NUM_OF_WORKING_DAYS; i++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 2:
                        empHrs = 4;
                        break;
                    case 1:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage :" + empWage);
                Console.ReadKey();
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}