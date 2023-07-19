
namespace EmployeeWageComputation
{
    class Program
    {  //constants
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        public  static int computeEmpWage(string company,int empRatePerHrs,int numOfWorkingDays ,int maxHrsPerMonth)
            {
            //variables
            int empHrs = 0, totalHrs = 0, totalWorkingDays = 0;
                Console.WriteLine("welcome to EmployeeWageComputation");
            while (totalHrs <= maxHrsPerMonth && totalWorkingDays < numOfWorkingDays) 
                {
                    totalWorkingDays++;
                   Random random= new Random();
                    int emplyeeInput = random.Next(0, 3);
                    switch (emplyeeInput)
                    {
                        case IS_PART_TIME:
                            Console.WriteLine("part time employee is present ");
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            Console.WriteLine("full time employee is present ");
                            empHrs = 8;
                            break;
                        default:
                            Console.WriteLine(" employee is absent ");
                            empHrs = 0;
                            break;
                    }

                totalHrs += empHrs;
                Console.WriteLine("day: "+ totalWorkingDays +" Emp Hrs:"+ empHrs);
                }
            int totalEmpWage = totalHrs * empRatePerHrs;
            Console.WriteLine("total emp wage for company "+ company + "is:" + totalEmpWage);
            return totalEmpWage;
        }
            static void Main(string[] args)
            {
                computeEmpWage("TCS",20,3,10);
               computeEmpWage("Reliance", 10, 5, 20);

        }

        }
    }
