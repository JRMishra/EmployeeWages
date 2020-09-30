using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EmployeeWages
{
    class Employee
    {
        bool _isPresent;
        bool _isFullTime;
        string _company;

        public Employee()
        {
            this._isPresent = true;
            this._isFullTime = true;
            this._company = "";
        }
        
        public Employee(string company)
        {
            this._isPresent = true;
            this._isFullTime = true;
            this._company = company;
        }

        public bool IsPresent {
            get
            {
                Random randomNum = new Random();
                int num = randomNum.Next(0, 2);

                this._isPresent = (num == 1);
                return _isPresent;
            }
        }
        public bool IsFullTime {
            get
            {
                Random randomNum = new Random();
                int num = randomNum.Next(1, 3);

                this._isFullTime = (num == 2);
                return _isFullTime;
            }
        }

        public string Company { get => _company; set => _company = value; }
    }
}
