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
            if (emplyeeInput == IS_PART_TIME)
            {
                Console.WriteLine("Employee is part time");
                empHrs = 4;
            }
            else if (emplyeeInput == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is full time");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Daily Employeewage is :{0}", empWage);
        }
    }
}
