using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace EmployeeWages
{
    class Program
    {
        
        static List<Company> allCompanies = new List<Company>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("=============================================");

            bool cont = true;
            int option;

            while (cont)
            {
                Console.WriteLine("Enter\n" +
                    "1 : Enter Company Details\n" +
                    "2 : Retrieve Wage Details\n" +
                    "0 : Exit");
                option = Int32.Parse(Console.ReadLine());
                switch(option)
                {
                    case 0:
                        cont = false;
                        break;
                    case 1:
                        allCompanies.Add(EnterCompanyDetails());
                        break;
                    case 2:
                        foreach(Company company in allCompanies)
                        {
                            EmpWageBuilder empWage = new EmpWageBuilder(company);
                            Console.Write("Company : " + company.Name+" , ");
                            Console.WriteLine("Monthly Wage :" + empWage.TotalMonthlyWage);
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Wrong Option choosed");
                        break;

                }
            }
            return;
        }

        static Company EnterCompanyDetails()
        {
            Company company = new Company();

            Console.Write("Company Name : ");
            company.Name = Console.ReadLine();

            Console.Write("Full Day Work Hour : ");
            company.FullDayWorkHour = Int32.Parse(Console.ReadLine());

            Console.Write("Wage per Work Hour : ");
            company.WagePerHour = Int32.Parse(Console.ReadLine());

            Console.Write("Monthly Work Day : ");
            company.MonthlyWorkingDay = Int32.Parse(Console.ReadLine());

            Console.Write("Max Monthly Work Hour : ");
            company.MonthlyMaxWorkHour = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            return company;
        }
    }
}
