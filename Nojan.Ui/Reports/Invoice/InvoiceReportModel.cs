namespace Nojan.Ui.Reports.Invoice
{
    public class InvoiceReportModel
    {
        public string RowNumber { get; set; } = "";
        public string Description { get; set; } = "";
        public string Qty { get; set; } = "";
        public string Unit { get; set; } = "";
        public string UnitPrice { get; set; } = "";
        public string TotalPrice { get; set; } = "";
    }
}
