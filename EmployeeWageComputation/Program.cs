namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {   //constants
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Console.WriteLine("welcome to EmployeeWageComputation");
            Random random = new Random();
            //Computation
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
            Console.WriteLine("Daily Employeewage is :{0}", empWage);
        }
    }
}
