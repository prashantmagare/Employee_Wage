using System;
//Switch Case 
namespace EmpWage
{
    public class Program
    {

        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
      public static int CompanyName(string companyName, int empRatePerHr, int noOfWorkingDays, int maxHrPerMonth )
        {
            //Variables
            
            int totalEmpHrs = 0; 
            int totalWorkingDays = 0;
           
            while (totalEmpHrs < maxHrPerMonth && totalWorkingDays < noOfWorkingDays)
           {
                int empHrs = 0;
                totalWorkingDays++;

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

                int totalEmpWage = totalEmpHrs * empRatePerHr;
                Console.WriteLine("Total Employee Wage : " + totalEmpWage);
            return totalEmpWage;
        }
         static void Main(string[] args)
        {
            CompanyName("Dmart", 25, 20, 80);
            CompanyName("Reliance", 10, 4, 20);
        }

    }
}