using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("=============================================");

            int FULL_DAY_HOUR = 8;
            int HALF_DAY_HOUR = 4;

            bool attendance;
            attendance = CheckPresentOrAbsent();
            if (attendance)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");

            int dailyWage;
            dailyWage = DailyWage(attendance, FULL_DAY_HOUR);
            Console.WriteLine("So, if full time employee, today's wage is Rs. {0}.00", dailyWage);

            dailyWage = DailyWage(attendance, HALF_DAY_HOUR);
            Console.WriteLine("else part time wage is Rs. {0}.00", dailyWage);

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

        static int DailyWage(bool presence, int workHour)
        {
            int WAGE_PER_HOUR = 20;
            int dailyWage = 0;
            if (presence)
                dailyWage = WAGE_PER_HOUR * workHour;
            return dailyWage;
        }
    }
}
