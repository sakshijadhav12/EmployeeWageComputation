namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT = 1;
            Console.WriteLine("welcome to EmployeeWageComputation");
            Random random = new Random();
            int emplyeeInput = random.Next(0, 2);// 0  or 1
            if (emplyeeInput == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}