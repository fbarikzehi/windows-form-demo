namespace Nojan.Ui.Reports.Invoice
{
    public class InvoiceReportData
    {
        public List<InvoiceReportModel> Items { get; set; }
        public string? JobTitle { get; set; }
        public string? Date { get; internal set; }
        public string? Number { get; internal set; }
        public string? JobAddress { get; internal set; }
        public string? JobPhone { get; internal set; }
        public string? CustomerFullName { get; internal set; }
        public string? CustomerCode { get; internal set; }
        public string? Total { get; internal set; }
        public string? TotalByAlphabet { get; internal set; }
        public string? Project { get; internal set; }
    }
}
