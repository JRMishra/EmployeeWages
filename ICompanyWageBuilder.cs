using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeWages
{
    interface ICompanyWageBuilder
    {
        public void AddCompanies(Company company);

        public void PrintAllCompanyWages();

        public void PrintCompanyWage(string company);
    }
}
