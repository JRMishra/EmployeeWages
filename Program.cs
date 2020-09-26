using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("=============================================");

            bool attendance;
            attendance = CheckPresentOrAbsent();
            if (attendance)
                Console.WriteLine("Employee is Present");
            return; 
        }

        static bool CheckPresentOrAbsent()
        {
            Random random = new Random();
            int IS_PRESENT = 1;
            int eCheck = random.Next(0, 2);
            if (eCheck == IS_PRESENT)
                return true;
            else
                return false;
        }
    }
}
