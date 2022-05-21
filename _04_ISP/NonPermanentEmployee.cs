using static System.Console;

namespace _04_ISP
{
    public class NonPermanentEmployee
    {
        /// <summary>
        /// Non-permanent employees should implement only adding data to DB!!!
        /// according to out client's request
        /// </summary>


        ///<summary>
        ///this method adds employee's details to DB
        /// <returns>true if success else false</returns>
        /// </summary>
        public bool AddEmployeeDetails()
        {
            WriteLine("In NonPermanentEmployee::AddEmployeeDetails method... Adding non permanent employee to DB...");
            return true;
        }
    }
}