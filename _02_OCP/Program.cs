using _01_SRP;
using static System.Console;

namespace _02_OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating employee...
            Employee employee = new Employee {Employee_Id = 1, Employee_Name = "Johny"};

            //creating reporter...
            IReportGeneration reporter = new CrystalReportGeneraion();

            //inserting employee to DB...
            employee.InsertIntoEmployeeTable(employee);
            WriteLine();

            //reporting...
            reporter.GenerateReport(employee);
        }
    }
}