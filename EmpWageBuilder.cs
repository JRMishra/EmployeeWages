using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmpWageBuilder
    {
        Employee emp = new Employee();
        int _fullDayWorkHour;
        int _ratePerHour;
        int _monthlyWorkDay;
        int _maxHourPerMonth;
        int _monthlyWage;

        public EmpWageBuilder()
        {
            this.FullDayWorkHour = 8;
            this.WagePerHour = 20;
            this.MonthlyWorkDay = 20;
            this.MaxHourPerMonth = 100;
        }

        public EmpWageBuilder(int FullDayWorkHour, int WagePerHour, int MonthlyWorkDay, int MaxMonthlyWorkHour)
        {
            this.FullDayWorkHour = FullDayWorkHour;
            this.WagePerHour = WagePerHour;
            this.MonthlyWorkDay = MonthlyWorkDay;
            this.MaxHourPerMonth = MaxMonthlyWorkHour;
        }

        public int FullDayWorkHour { get => _fullDayWorkHour; set => _fullDayWorkHour = value; }
        public int WagePerHour { get => _ratePerHour; set => _ratePerHour = value; }
        public int MonthlyWorkDay { get => _monthlyWorkDay; set => _monthlyWorkDay = value; }
        public int MaxHourPerMonth { get => _maxHourPerMonth; set => _maxHourPerMonth = value; }

        public int MonthlyWage()
        {
            this._monthlyWage = MonthlyWage(emp, this.FullDayWorkHour, this.WagePerHour, this.MonthlyWorkDay, this.MaxHourPerMonth);
            return this._monthlyWage;
        }

        private int MonthlyWage(Employee emp , int FullDayWorkHour, int WagePerHour, int MaxMonthlyWorkDay, int MaxMonthlyWorkHours)
        {
            int workDay = 0, workHour = 0, wageAtMonthEnd=0;
            while(workDay<MaxMonthlyWorkDay && workHour<MaxMonthlyWorkHours)
            {
                if(emp.IsPresent)
                {
                    if (emp.IsFullTime)
                        workHour += FullDayWorkHour;
                    else
                        workHour += FullDayWorkHour / 2;  
                }
                workDay++;
            }
            Console.WriteLine("Day: " + workDay + " Hours: " + workHour);
            wageAtMonthEnd = WagePerHour * workHour;
            return wageAtMonthEnd;
        }
    }
}
