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
                    this._totalMonthlyWage = MonthlyWage();
                return this._totalMonthlyWage;
            }
        }

        internal string Company { get => _company.Name;}

        private int MonthlyWage()
        {
            int workDay = 0, workHour = 0, wageAtMonthEnd = 0;
            while (workDay < _company.MonthlyWorkingDay && workHour < _company.MonthlyMaxWorkHour)
            {
                if (_emp.IsPresent)
                {
                    if (_emp.IsFullTime)
                        workHour += _company.FullDayWorkHour;
                    else
                        workHour += _company.FullDayWorkHour / 2;
                }
                workDay++;
            }
            wageAtMonthEnd = _company.WagePerHour * workHour;
            return wageAtMonthEnd;
        }
    }
}

