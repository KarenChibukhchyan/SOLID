using static System.Console;

namespace _04_ISP
{
    public class PermanentEmployee : IAddOperation, IGetOperation
    {
        /// <summary>
        /// Permanent employees should implement both logic of adding and extracting data from DB
        /// according to out client's request
        /// </summary>

        ///<summary>
        ///this method adds employee's details to DB
        /// <returns>true if success else false</returns>
        /// </summary>
        public bool AddEmployeeDetails()
        {
            WriteLine("In PermanentEmployee::AddEmployeeDetails method... Adding permanent employee to DB...");
            return true;
        }

        ///<summary>
        ///this method shows employee's details from DB
        /// <returns>true if success else false</returns>
        /// </summary>
        public bool ShowEmployeeDetails(int employeeId)
        {
            WriteLine("In PermanentEmployee::ShowEmployeeDetails method... Printing out permanent employee from DB...");
            return true;
        }
    }
}