using static System.Console;
using System.Collections.Generic;

namespace _03_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEmployee> employeeList = new List<IEmployee>();
            // following line if uncomment gives an error
            // employeeList.Add(new ContractualEmployee());
            employeeList.Add(new CasualEmployee());
            foreach (IEmployee e in employeeList)
            {
                WriteLine(e.GetEmployeeDetails(1245));
            }
        }
    }
}