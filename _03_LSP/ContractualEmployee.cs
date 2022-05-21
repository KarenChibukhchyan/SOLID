using static System.Console;

namespace _03_LSP
{
    public class ContractualEmployee : IProject
    {
        public string GetProjectDetails(int employeeId)
        {
            WriteLine("In ContractualEmployee::GetEmployeeDetails method");
            return $"Details for contractual employee with Id: {employeeId}";
        }
    }
}