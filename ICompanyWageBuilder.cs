using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeWages
{
    interface ICompanyWageBuilder
    {
        abstract public void AddCompany(Company company);

        public void AddCompanies(List<Company> companies);

        public void PrintAllCompanyWages();

        public int RetrieveWageByCompany(string company);
    }
}
