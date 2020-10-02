using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmpWageBuilder : ICompanyWageBuilder
    {
        LinkedList<CompanyEmpWage> allCompanyWages = new LinkedList<CompanyEmpWage>(); 

        public void AddCompanies()
        {
            Company company = new Company();
            company.CompanyWageProfile();
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company);

            allCompanyWages.AddLast(companyEmpWage);
        }

        public void AddCompanies(Company company)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company);
            allCompanyWages.AddLast(companyEmpWage);
        }

        public void PrintAllCompanyWages()
        {
            foreach(CompanyEmpWage cpw in allCompanyWages)
            {
                Console.WriteLine("Company : " + cpw.Company + ", Total Monthly Wage :" + cpw.TotalMonthlyWage);
            }
        }
        
        public void PrintCompanyWage(string company)
        {
            foreach (CompanyEmpWage cpw in allCompanyWages)
            {
                if(cpw.Company == company)
                    Console.WriteLine("Company : " + cpw.Company + ", Total Monthly Wage :" + cpw.TotalMonthlyWage);
            }
        }
    }
}
