using static System.Console;

namespace _01_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating employee...
            Employee employee = new Employee {Employee_Id = 1, Employee_Name = "Johny"};

            //creating reporter...
            ReportGeneration reporter = new ReportGeneration();

            //insertion status code
            var statusCode = employee.InsertIntoEmployeeTable(employee);
            WriteLine();
            reporter.GenerateReport(employee, statusCode);
        }
    }
}