using Nojan.Ui.Utilities;
using Stimulsoft.Report;

namespace Nojan.Ui.Reports.Invoice
{
    public class InvoiceReport
    {
        public static void Load(InvoiceReportData data)
        {
            data.TotalByAlphabet = $"{Utilities.Persian.Numbers.Convert.NumberToText(TypeUtility.ToFloatPrice(data.Total).ToString())} ریال";

            var report = new StiReport();
            report.Load(@"Reports\InvoiceReport.mrt");
            report.Dictionary.Databases.Clear();
            report.RegData("Data", data);
            report.Show();
        }
    }
}
