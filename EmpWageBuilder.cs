using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmpWageBuilder
    {
        Employee emp ;
        int _fullDayWorkHour;
        int _ratePerHour;
        int _monthlyWorkDay;
        int _maxHourPerMonth;
        int _monthlyWage;

        public EmpWageBuilder()
        {
            emp = new Employee();
            this.FullDayWorkHour = 8;
            this.WagePerHour = 20;
            this.MonthlyWorkDay = 20;
            this.MaxHourPerMonth = 100;
        }

        public EmpWageBuilder(string company, int FullDayWorkHour, int WagePerHour, int MonthlyWorkDay, int MaxMonthlyWorkHour)
        {
            emp = new Employee(company);
            this.FullDayWorkHour = FullDayWorkHour;
            this.WagePerHour = WagePerHour;
            this.MonthlyWorkDay = MonthlyWorkDay;
            this.MaxHourPerMonth = MaxMonthlyWorkHour;
        }

        public EmpWageBuilder(Company company)
        {
            emp = new Employee(company.Name);
            this.FullDayWorkHour = company.FullDayWorkHour;
            this.WagePerHour = company.WagePerHour;
            this.MonthlyWorkDay = company.MonthlyWorkingDay;
            this.MaxHourPerMonth = company.MonthlyMaxWorkHour;
        }

        public int FullDayWorkHour { get => _fullDayWorkHour; set => _fullDayWorkHour = value; }
        public int WagePerHour { get => _ratePerHour; set => _ratePerHour = value; }
        public int MonthlyWorkDay { get => _monthlyWorkDay; set => _monthlyWorkDay = value; }
        public int MaxHourPerMonth { get => _maxHourPerMonth; set => _maxHourPerMonth = value; }
        public int TotalMonthlyWage {
            get
            {
                return MonthlyWage();
            }
        }

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
            wageAtMonthEnd = WagePerHour * workHour;
            return wageAtMonthEnd;
        }
    }
}
