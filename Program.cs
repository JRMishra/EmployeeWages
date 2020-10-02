using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("=============================================");

            EmpWageBuilder allCompanyWages = new EmpWageBuilder();
            bool cont = true;
            int option;

            while (cont)
            {
                Console.WriteLine("Enter\n" +
                    "1 : Enter Company Details\n" +
                    "2 : Retrieve all Monthly Wage Details\n" +
                    "3 : Retrieve Monthly Wage of one company\n" +
                    "4 : Print daily Wages of a company\n" +
                    "0 : Exit");
                option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 0:
                        cont = false;
                        break;
                    case 1:
                        Console.Write("Number of Company details you want to enter : ");
                        int numDetail = Int32.Parse(Console.ReadLine());

                        List<Company> companyList = new List<Company>();
                        Company company = new Company();
                        for(int i=0; i<numDetail; i++)
                        {
                            company.CompanyWageProfile();
                            companyList.Add(company);
                        }

                        allCompanyWages.AddCompanies(companyList);
                        break;
                    case 2:
                        allCompanyWages.PrintAllCompanyWages();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Enter Company Name :");
                        allCompanyWages.PrintCompanyWage(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("Enter Company Name :");
                        allCompanyWages.PrintDailyWage(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Wrong Option choosed");
                        break;
                }
            }
            
            Console.WriteLine("Thanks for use Employee Wage Computation Program");
            return;
        }
    }
}
