using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class Company
    {
        string _name;
        int _fullDayWorkHour;
        int _monthlyWorkingDay;
        int _wagePerHour;
        int _monthlyMaxWorkHour;

        public Company()
        {
            this._name = "";
            this._fullDayWorkHour = 8;
            this._monthlyWorkingDay = 30;
            this._wagePerHour = 20;
            this._monthlyMaxWorkHour = 100;
        }

        public Company(string Name, int FullDayWorkHour, int WagePerHour, int MonthlyWorkingDay, int MaxWorkHourPerMonth)
        {
            this._name = Name;
            this._fullDayWorkHour = FullDayWorkHour;
            this._monthlyWorkingDay = MonthlyWorkingDay;
            this._wagePerHour = WagePerHour;
            this._monthlyMaxWorkHour = MaxWorkHourPerMonth;
        }

        public string Name { get => _name; set => _name = value; }
        public int FullDayWorkHour { get => _fullDayWorkHour; set => _fullDayWorkHour = value; }
        public int WagePerHour { get => _wagePerHour; set => _wagePerHour = value; }
        public int MonthlyMaxWorkHour { get => _monthlyMaxWorkHour; set => _monthlyMaxWorkHour = value; }
        public int MonthlyWorkingDay { get => _monthlyWorkingDay; set => _monthlyWorkingDay = value; }

        public void EnterCompanyDetails()
        {
            Console.Write("Company Name : ");
            Name = Console.ReadLine();

            Console.Write("Full Day Work Hour : ");
            FullDayWorkHour = Int32.Parse(Console.ReadLine());

            Console.Write("Wage per Work Hour : ");
            WagePerHour = Int32.Parse(Console.ReadLine());

            Console.Write("Monthly Work Day : ");
            MonthlyWorkingDay = Int32.Parse(Console.ReadLine());

            Console.Write("Max Monthly Work Hour : ");
            MonthlyMaxWorkHour = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            return;
        }
    }
}
