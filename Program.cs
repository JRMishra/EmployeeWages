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
                    "2 : Retrieve all Wage Details\n" +
                    "3 : Retrieve Wage of one company\n" +
                    "0 : Exit");
                option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 0:
                        cont = false;
                        break;
                    case 1:
                        allCompanyWages.AddCompanies();
                        break;
                    case 2:
                        allCompanyWages.PrintAllCompanyWages();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Enter Company Name :");
                        allCompanyWages.PrintCompanyWage(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Wrong Option choosed");
                        break;
                }
            }
            return;
        }
    }
}
