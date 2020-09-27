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
            {
                string isFullTime;

                Console.WriteLine("Employee is Present");
                Console.WriteLine("Is the above one a full time employee ? ( yes / no )");
                isFullTime = Console.ReadLine().ToLower();

                int dailyWage;
                switch (isFullTime)
                {

                    case "yes":
                        dailyWage = DailyWage(attendance, FULL_DAY_HOUR);
                        Console.WriteLine("As a full time employee, his/her");
                        Console.WriteLine("today's wage is Rs. {0}.00", dailyWage);
                        break;
                    case "no":
                        dailyWage = DailyWage(attendance, HALF_DAY_HOUR);
                        Console.WriteLine("As a part time employee, his/her");
                        Console.WriteLine("today's wage is Rs. {0}.00", dailyWage);
                        break;
                    default:
                        Console.WriteLine("You choosed wrong option");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("So, his/her today's wage is Rs. 0.00");
            }

            int monthlyWage;
            monthlyWage = CalculateMonthlyWage();
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
                    totalWage = DailyWage(true, days * FULL_DAY_HOUR);
                    Console.WriteLine("Total wage of " + days + " days is " + totalWage);
                    break;
                case 2:
                    Console.WriteLine("Enter Number of hourss: ");
                    int hours = Int32.Parse(Console.ReadLine());
                    totalWage = DailyWage(true, hours);
                    Console.WriteLine("Total wage of " + hours + " hourss is " + totalWage);
                    break;
                default:
                    break;
            }
            Console.WriteLine("\nThank you for using Employee Wage Computation Program");

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

        static int CalculateMonthlyWage()
        {
            int idx;
            int monthlyPresence =0, monthlyWage = 0;

            for(idx=0; idx<20; idx++)
            {
                if (CheckPresentOrAbsent())
                    monthlyPresence++;
            }
            monthlyWage = monthlyPresence * 8 * 20;

            return monthlyWage;
        }
    }
}
