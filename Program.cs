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
