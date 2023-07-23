using System;

namespace EmployeeWageComputation
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHrs;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHrs, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHrs = empRatePerHrs;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public override string ToString()
        {
            return "Total Emp Wage for company: " + this.company + " is: " + this.totalEmpWage;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empwageBuilderarray = new EmpWageBuilderArray();
            empwageBuilderarray.addCompanyEmpWage("TCS", 20, 3, 10);
            empwageBuilderarray.addCompanyEmpWage("Reliance", 10, 5, 20);
            empwageBuilderarray.computeEmpWage();
        }
    }

    public class EmpWageBuilderArray
    {
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] CompanyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int empRatePerHrs, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHrs, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                CompanyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(CompanyEmpWageArray[i]));
                Console.WriteLine(CompanyEmpWageArray[i].ToString());
            }
        }

        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalHrs = 0, totalWorkingDays = 0;
            Console.WriteLine("Welcome to EmployeeWageComputation");
            while (totalHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
            return totalHrs * companyEmpWage.empRatePerHrs;
        }
    }
}
