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
            int MONTHLY_ATTENDANCE = 30;
            int WAGE_PER_HOUR = 20;
            int MAX_MONTHLY_WORK_HOUR = 100;

            EmpWageBuilder empWage = new EmpWageBuilder(FULL_DAY_HOUR, WAGE_PER_HOUR, MONTHLY_ATTENDANCE, MAX_MONTHLY_WORK_HOUR);
            Console.WriteLine("Monthly Wage is " + empWage.MonthlyWage());
            return;
        }
    }
}
