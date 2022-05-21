using System.Collections.Generic;
using static System.Console;

namespace _04_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PermanentEmployee> permanentEmployees= new List<PermanentEmployee> {(new PermanentEmployee()), (new PermanentEmployee())};
            List<NonPermanentEmployee> nonPermanentEmployees= new List<NonPermanentEmployee> {new NonPermanentEmployee(), new NonPermanentEmployee()};
            foreach (var employee in permanentEmployees)
            {
                employee.AddEmployeeDetails();
                employee.ShowEmployeeDetails(1);
            }

            foreach (var employee in nonPermanentEmployees)
            {
                employee.AddEmployeeDetails();

                //non permanent employees dont implement ShowEmployeeDetails!!!
                //employee.ShowEmployeeDetails(1);
            }
        }
    }
}