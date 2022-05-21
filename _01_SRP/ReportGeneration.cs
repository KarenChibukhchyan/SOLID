using static System.Console;

namespace _01_SRP
{
    public class ReportGeneration
    {
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em">employee</param>
        /// <param name="statusCode">
        ///     status codes:
        ///         1 - successfull insertion
        ///         -1 - failure
        /// </param>>
        public void GenerateReport(Employee em, int statusCode)
        {
            WriteLine("In ReportGeneration::GenerateReport method...");
            switch (statusCode)
            {
                case 1:
                    WriteLine($"Successfully added {em} into DB...");
                    break;
                case -1:
                    WriteLine($"Failed add {em} into DB!!!");
                    break;
            }
        }
    }
}