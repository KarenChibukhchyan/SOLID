using static System.Console;

namespace _03_LSP
{
    public class CasualEmployee : IEmployee
    {
        public string GetEmployeeDetails(int employeeId)
        {
            WriteLine("In CasualEmployee::GetEmployeeDetails method");
            return $"Details for casual employee with Id: {employeeId}";
        }
    }
}