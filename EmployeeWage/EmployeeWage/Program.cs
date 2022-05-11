﻿using System;
//Switch Case 
namespace EmpWage
{
    internal class Program
    {

        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int Emp_RATE_PER_TIME = 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        static void Main(string[] args)
        {
            //Variables
            int empHrs = 0;
            int empwage = 0;
            int totalEmpWage = 0;

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
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

                empwage = empHrs * Emp_RATE_PER_TIME;
                totalEmpWage = totalEmpWage + empwage;
                Console.WriteLine("EmpWage : " + empwage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }

    }
}