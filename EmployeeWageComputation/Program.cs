namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT = 1;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Console.WriteLine("welcome to EmployeeWageComputation");
            Random random = new Random();
            int emplyeeInput = random.Next(0, 2);// 0  or 1
            if (emplyeeInput == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Daily Employeewage is :{0}", empWage);
        }
    }
}