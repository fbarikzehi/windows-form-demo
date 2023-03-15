using Microsoft.EntityFrameworkCore;
using Nojan.Data;
using Nojan.Data.Commands;
using Nojan.Data.Model;
using Nojan.Ui.Reports.Invoice;
using Nojan.Ui.Utilities;
using System.Data;

namespace Nojan.Ui.Forms.Invoice;

public partial class InvoicesFrm : Form
{
    public CustomerModel Customer { get; set; } = new CustomerModel();

    public InvoicesFrm()
    {
        InitializeComponent();
    }

    private void LoadGridView()
    {

        if (Customer is not null)
        {
            lblName.Text = Customer.FullName;
            lblPhone.Text = Customer.Phone;
            lblCode.Text = Customer.Code.ToString();
        }
        List<InvoiceModel> invoices = new List<InvoiceModel>();
        var command = new InvoiceCommand();
        if (Customer.Id == 0)
        {
            var response = command.FindAll();
            if (response.Data is not null)
                invoices = response.Data;
        }
        else
        {
            var response = command.FindAllByCustomer(Customer.Id);
            if (response.Data is not null)
                invoices = response.Data;
        }
        lblInvoiceTotal.Text = invoices.Sum(x => x.Items.Sum(x => x.PriceListItem.Price * x.Qty)).ToString(TypeUtility.CommaFormatted);
        InvoiceGridView.Rows.Clear();
        foreach (var invoice in invoices)
            InvoiceGridView.Rows.Add("", invoice.Id, invoice.Number, (invoice.Project is null ? "---" : invoice.Project?.Title), DateTimeUtility.ToPersianDate(invoice.Date), invoice.Items.Sum(x => x.PriceListItem.Price * x.Qty).ToString(TypeUtility.CommaFormatted));
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {

        var confirmResult = MessageBox.Show("آیا فاکتور انتخاب شده حذف شود؟", "تایید حذف", MessageBoxButtons.YesNo);
        if (confirmResult == DialogResult.Yes)
        {
            if (InvoiceGridView.SelectedRows.Count > 0)
            {
                var command = new InvoiceCommand();
                foreach (DataGridViewRow row in InvoiceGridView.SelectedRows)
                {
                    var invoiceId = (long)InvoiceGridView.Rows[row.Index].Cells[1].Value;
                    var response = command.Delete(invoiceId);
                    if (response.IsSuccess)
                    {
                        InvoiceGridView.Rows.RemoveAt(row.Index);
                    }
                }
            }
            else
            {
                MessageBox.Show("ردیفی برای حذف انتخاب نشده");
            }
        }

    }

    private void UpdateBtn_Click(object sender, EventArgs e)
    {
        if (InvoiceGridView.SelectedRows.Count > 0)
        {
            var selectedRow = InvoiceGridView.Rows[InvoiceGridView.SelectedRows[0].Index];
            var invoiceId = (long)selectedRow.Cells[1].Value;
            var invoiceCreateFrm = new InvoiceCreateFrm();
            FormUtility.CloseIfExistForm(invoiceCreateFrm.Name);
            invoiceCreateFrm.Invoice.Id = invoiceId;
            invoiceCreateFrm.Invoice.CustomerId = Customer.Id;
            invoiceCreateFrm.ShowDialog();

            //after InvoiceCreateFrm closed update selected row cells
            var command = new InvoiceCommand();
            var response = command.FindById(invoiceId);
            var invoiceTotalPrice = response.Data.Items.Sum(x => (x.PriceListItem.Price * x.Qty));
            if (invoiceTotalPrice > 0)
                selectedRow.Cells[5].Value = invoiceTotalPrice.ToString(TypeUtility.CommaFormatted);
            var invoiceProjectTitle = response.Data?.Project?.Title;
            if (invoiceProjectTitle is null or "")
                selectedRow.Cells[3].Value = "---";
            else if (!invoiceProjectTitle.Equals(selectedRow.Cells[3].Value))
                selectedRow.Cells[3].Value = invoiceProjectTitle;
        }
        else
        {
            MessageBox.Show("ردیفی برای صدور فاکتور انتخاب نشده");
        }
    }

    private void InvoicesFrm_Shown(object sender, EventArgs e)
    {
        LoadGridView();
    }

    private void PrintBtn_Click(object sender, EventArgs e)
    {
        if (InvoiceGridView.SelectedRows.Count > 0)
        {
            var invoiceId = (long)InvoiceGridView.Rows[InvoiceGridView.SelectedRows[0].Index].Cells[1].Value;
            var command = new SettingInvoiceCommand();
            var commandResponse = command.Find();
            if (commandResponse.IsSuccess && commandResponse.Data is not null)
            {
                var invoiceCommand = new InvoiceCommand();
                var invoiceCommandResponse = invoiceCommand.FindById(invoiceId);
                if (invoiceCommandResponse.Data is not null)
                {
                    var invoice = invoiceCommandResponse.Data;
                    var invoiceSetting = commandResponse.Data;
                    var reportModel = new InvoiceReportData
                    {
                        Items = new List<InvoiceReportModel>(),
                        JobTitle = invoiceSetting?.JobTitle,
                        JobAddress = invoiceSetting?.Address,
                        JobPhone = invoiceSetting?.Phone,
                        CustomerCode = invoice?.Customer.Code.ToString(),
                        CustomerFullName = invoice?.Customer.FullName,
                        Project = invoice?.Project?.Title,
                        Date = invoice?.Date.ToPersianDate(),
                        Number = invoice?.Number?.ToString()
                    };
                    int rowNumber = 1;
                    float invoiceTotalPrice = 0;
                    foreach (var item in invoice.Items)
                    {
                        float totalPrice = item.PriceListItem.Price * item.Qty;
                        reportModel.Items.Add(new InvoiceReportModel
                        {
                            RowNumber = rowNumber.ToString(),
                            Description = item.PriceListItem.Name,
                            Qty = item.Qty.ToString(),
                            Unit = item.Unit,
                            UnitPrice = item.PriceListItem.Price.ToString(TypeUtility.CommaFormatted),
                            TotalPrice = totalPrice.ToString(TypeUtility.CommaFormatted),
                        });
                        invoiceTotalPrice += totalPrice;
                        rowNumber++;
                    }
                    reportModel.Total = invoiceTotalPrice.ToString(TypeUtility.CommaFormatted);

                    InvoiceReport.Load(reportModel);
                }
            }
            else
                MessageBox.Show("فاکتور انتخابی یافت نشد");
        }
        else
        {
            MessageBox.Show("ردیفی برای پرینت فاکتور انتخاب نشده");
        }

    }

    private void InvoiceGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        InvoiceGridView.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
    }
}
