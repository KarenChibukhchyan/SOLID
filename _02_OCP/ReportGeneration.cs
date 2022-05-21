using _01_SRP;
using static System.Console;

namespace _02_OCP
{
    public class IReportGeneration
    {
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public virtual void GenerateReport(Employee em)
        {
            // From base
        }
    }

    /// <summary>
    /// Class to generate Crystal report
    /// </summary>
    public class CrystalReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Employee em)
        {
            WriteLine("In CrystalReportGeneration::GenerateReport method... Generating crystal report...");
        }
    }

    /// <summary>
    /// Class to generate PDF report
    /// </summary>
    public class PDFReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Employee em)
        {
            WriteLine("In PDFReportGeneration::GenerateReport method... Generating PDF report...");
        }
    }
}