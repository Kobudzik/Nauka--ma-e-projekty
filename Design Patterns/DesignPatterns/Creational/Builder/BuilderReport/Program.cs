using System;

namespace BuilderReport;

static class Program
{
    static void Main()
    {
        Report currentMonthTaxReport = ReportBuilder.CreateMonthTaxReport(4, 2017);

        Console.WriteLine(currentMonthTaxReport);

        Report currentYearTaxReport = ReportBuilder.CreateYearTaxReport(2017);
        Report currentMonthCommissionReport = ReportBuilder.CreateMonthCommissionReport(4, 2017);
        Report currentYearCommissionReport = ReportBuilder.CreateYearCommissionReport(2017);

        Console.Read();
    }
}
