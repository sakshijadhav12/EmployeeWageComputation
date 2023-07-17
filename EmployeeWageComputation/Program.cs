
 namespace EmployeeWageComputation
    {
        class Program
        {

            //constants
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int NUM_OF_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            public
                 static int computeEmpWage()
            {
                //variables
                int empHrs = 0, empWage = 0, totalWage = 0, day = 1, totalWorkingHrs = 0;
                Console.WriteLine("welcome to EmployeeWageComputation");
                Random random = new Random();
                while (day <= NUM_OF_WORKING_DAYS && totalWorkingHrs <= MAX_WORKING_HRS)
                {
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

                    empWage = empHrs * EMP_RATE_PER_HOUR;
                    totalWage += empWage;
                    Console.WriteLine("Day{0} Employeewage is :{1}", day, empWage);
                    day++;
                    totalWorkingHrs += empHrs;
                    if (totalWorkingHrs > MAX_WORKING_HRS)
                    {
                        totalWorkingHrs = MAX_WORKING_HRS - empHrs;
                    }
                }
                Console.WriteLine(" Total Employee Wage  for {0} days and Hrs:{1} is :{2}", (day - 1), (totalWorkingHrs), (totalWage));
                return totalWage;
            }
            static void Main(string[] args)
            {
                computeEmpWage();
            }

        }
    }
