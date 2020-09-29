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

            int empID;
            empID = GenerateEmpId();

            bool attendance;
            attendance = CheckPresentOrAbsent();

            int dailyWorkHours;
            bool isFullTime;

            isFullTime = IsFullTimeEmployee();
            if (isFullTime)
                dailyWorkHours = FULL_DAY_HOUR;
            else
                dailyWorkHours = HALF_DAY_HOUR;

            int dailyWage;
            dailyWage = DailyWage(attendance, dailyWorkHours);

            if (attendance)
            {
                Console.WriteLine("Employee is Present"); 
                Console.WriteLine("today's wage is Rs. {0}.00", dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("So, his/her today's wage is Rs. 0.00");
            }

            int monthlyWage;
            monthlyWage = CalculateMonthlyWage(isFullTime);
            Console.WriteLine("The monthly wage of that employee is " + monthlyWage);

            Console.WriteLine("Enter\n" +
                "1. To Calculate Employee Wage for Certain Days\n" +
                "2. To Calculate Employee Wage for Certain Hours\n" +
                "3. Exit");
            int userChoice = Int32.Parse(Console.ReadLine());
            int totalWage;

            switch (userChoice)
            {
                
                case 1:
                    Console.WriteLine("Enter Number of days: ");
                    int days = Int32.Parse(Console.ReadLine());
                    totalWage = DailyWage(true, days * dailyWorkHours);
                    Console.WriteLine("Total wage of " + days + " days is " + totalWage);
                    break;
                case 2:
                    Console.WriteLine("Enter Number of hourss: ");
                    int hours = Int32.Parse(Console.ReadLine());
                    totalWage = DailyWage(true, hours);
                    Console.WriteLine("Total wage of " + hours + " hours is " + totalWage);
                    break;
                default:
                    break;
            }
            Console.WriteLine("\nThank you for using Employee Wage Computation Program");
            Console.ReadLine();
            return; 
        }

        static int GenerateEmpId()
        {
            Random random = new Random();
            int eId = random.Next(1, 100);
            return eId;
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

        static bool IsFullTimeEmployee()
        {
            Random random = new Random();
            int num = random.Next(1, 3);
            if (num == 2)
                return true;
            else
                return false;
        }
        static int CalculateMonthlyWage(bool typeOfEmployee)
        {
            int idx;
            int monthlyPresence = 0, monthlyWage = 0, dailyHours = 4; ;

            if (typeOfEmployee)
                dailyHours = 8;

            for(idx=0; idx<20; idx++)
            {
                if (CheckPresentOrAbsent())
                    monthlyPresence++;
            }
            monthlyWage = monthlyPresence * dailyHours * 20;

            Console.WriteLine("The employee was present {0} days in the month",monthlyPresence);
            return monthlyWage;
        }
    }
}
