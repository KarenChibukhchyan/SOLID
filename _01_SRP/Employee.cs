using static System.Console;

namespace _01_SRP
{
    public class Employee
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }

        /// <summary>
        /// This method used to insert into employee table
        /// </summary>
        /// <param name="em">Employee object</param>
        /// <returns>Status of insertion</returns>
        public int InsertIntoEmployeeTable(Employee em)
        {
            WriteLine("In Employee::InsertIntoEmployeeTable method...");
            WriteLine($"Inserting employee with Id {Employee_Id} name {Employee_Name} into database...");
            return 1;
        }

        public override string ToString()
        {
            return $"employee with Id: {Employee_Id} and name: {Employee_Name}";
        }
    }
}