using System;
//compute wage for multiple Company 
namespace EmpWage
{
    internal class EmployeeWageBuilderObject
    {

        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public string company;
        public int emp_Rate_Per_Hr;
        public int no_Of_Working_Days;
        public int max_Hours_Per_Month;
        public int total_Emp_Wage;

        public EmployeeWageBuilderObject(string company, int emp_Rate_Per_Hr, int no_Of_Working_DAys, int max_Hours_Per_Month)
        {
            this.company = company;
            this.emp_Rate_Per_Hr = emp_Rate_Per_Hr;
            this.no_Of_Working_Days = no_Of_Working_DAys;
            this.max_Hours_Per_Month = max_Hours_Per_Month;
        }
        public void ComputeWage()
        {
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;


            //Computation
            while (totalEmpHrs <= this.max_Hours_Per_Month && totalEmpHrs < this.no_Of_Working_Days)
            {
                totalWorkingDays++;
                Random random = new Random();
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


                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + " Emp Hrs : " + empHrs);

            }


            Console.WriteLine("Total Employee Hrs is " + totalEmpHrs);

            total_Emp_Wage = totalEmpHrs * this.emp_Rate_Per_Hr;
            Console.WriteLine("Total Employee Wage  For Comapny = " + company + " is : " + total_Emp_Wage);

        }
        
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeWageBuilderObject dmart = new EmployeeWageBuilderObject("Dmart", 20, 2, 10);
            EmployeeWageBuilderObject reliance = new EmployeeWageBuilderObject("Reliance", 10, 4, 20);
            dmart.ComputeWage();
            reliance.ComputeWage();
           
        }
    }
}