using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class CompanyEmpWage
    {
        Employee _emp = new Employee();
        Company _company;

        int _totalMonthlyWage = 0;
        List<int> _dailyWages = new List<int>();

        public CompanyEmpWage()
        {
            _emp = new Employee();
            _company = new Company();
        }

        public CompanyEmpWage(Company company)
        {
            this._company = company;
        }

        public int TotalMonthlyWage
        {
            get
            {
                if (this._totalMonthlyWage == 0)
                    MonthlyWage();
                return this._totalMonthlyWage;
            }
        }

        public List<int> DailyWages
        {
            get
            {
                if(this._dailyWages.Count==0)
                    MonthlyWage();
                return _dailyWages;
            }
        }

        internal string Company { get => _company.Name;}

        private void MonthlyWage()
        {
            int workDay = 0, workHour = 0;
            while (workDay < _company.MonthlyWorkingDay && workHour < _company.MonthlyMaxWorkHour)
            {
                if (_emp.IsPresent)
                {
                    if (_emp.IsFullTime)
                    { 
                        _dailyWages.Add(_company.FullDayWorkHour * _company.WagePerHour);
                        workHour += _company.FullDayWorkHour;
                    }   
                    else
                    {
                        _dailyWages.Add((_company.FullDayWorkHour/2) * _company.WagePerHour);
                        workHour += _company.FullDayWorkHour/2;
                    }
                }
                workDay++;
            }
            this._totalMonthlyWage = _company.WagePerHour * workHour;

            return;
        }
    }
}