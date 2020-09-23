using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Report_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Report currentMonthTaxReport =
               ReportBuilder.CreateMonthTaxReport(4, 2017);

            Console.WriteLine(currentMonthTaxReport);

            Report currentYearTaxReport =
                ReportBuilder.CreateYearTaxReport(2017);

            Report currentMonthCommissionReport =
                ReportBuilder.CreateMonthCommissionReport(4, 2017);

            Report currentYearCommissionReport =
                ReportBuilder.CreateYearCommissionReport(2017);

            Console.Read();
        }
    }
}
