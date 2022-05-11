using System;
//Switch Case 
namespace EmpWage
{
    internal class Program
    {

        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int Emp_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public const int days_in_month = 20;
        static void Main(string[] args)
        {
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;


            //Computation
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                //It is using to generate random numbers
                Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_PART_TIME:
                    Console.WriteLine("Employee is present");
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    Console.WriteLine("Employee is also present");
                    empHrs = 8;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;

            }
               

                    totalEmpHrs += empHrs;
                Console.WriteLine("Days : " + totalWorkingDays + " Emp Hrs : " + empHrs);
              
            }

            
                Console.WriteLine("Total Employee Hrs is " + totalEmpHrs);

                int totalEmpWage = totalEmpHrs * Emp_RATE_PER_HOUR;
                Console.WriteLine("Total Employee Wage : " + totalEmpWage);
            
        }

    }
}