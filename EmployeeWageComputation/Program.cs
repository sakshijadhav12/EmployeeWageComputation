using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject tcs = new EmpWageBuilderObject("TCS", 20, 3, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 5, 20);
            tcs.computeEmpWage();
            Console.WriteLine(tcs.ToString());
            reliance.computeEmpWage(); 
            Console.WriteLine(reliance.ToString());
        }
    }

    public class EmpWageBuilderObject
    {
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHrs;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHrs, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHrs = empRatePerHrs;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void computeEmpWage()
        {
            int empHrs = 0, totalHrs = 0, totalWorkingDays = 0;
            Console.WriteLine("Welcome to EmployeeWageComputation");
            while (totalHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int employeeInput = random.Next(0, 3);
                switch (employeeInput)
                {
                    case IS_PART_TIME:
                        Console.WriteLine("Part-time employee is present.");
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        Console.WriteLine("Full-time employee is present.");
                        empHrs = 8;
                        break;
                    default:
                        Console.WriteLine("Employee is absent.");
                        empHrs = 0;
                        break;
                }

                totalHrs += empHrs;
                Console.WriteLine("Day: " + totalWorkingDays + " Emp Hrs: " + empHrs);
            }
            totalEmpWage = totalHrs * this.empRatePerHrs;
            Console.WriteLine("Total emp wage for company " + company + " is: " + totalEmpWage);
        }

        public string ToString()
        {
            return "Total Emp Wage for company: " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
