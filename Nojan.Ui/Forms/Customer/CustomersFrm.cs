using Nojan.Data;
using Nojan.Data.Model;
using Nojan.Ui.Forms.Invoice;
using Nojan.Ui.Utilities;

namespace Nojan.Ui.Forms.Customer;

public partial class CustomersFrm : Form
{
    public CustomersFrm()
    {
        InitializeComponent();
    }

    private void createCustomerBtn_Click(object sender, EventArgs e)
    {
        var customerCreateFrm = new CustomerCreateFrm();
        FormUtility.CloseIfExistForm(customerCreateFrm.Name);
        customerCreateFrm.ReloadGrid = true;
        customerCreateFrm.CustomersGridView = cutomersGridView;
        customerCreateFrm.ShowDialog();
    }

    private void cutomersGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        cutomersGridView.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
    }

    private void DeleteRowBtn_Click(object sender, EventArgs e)
    {
        var confirmResult = MessageBox.Show("آیا مشتری انتخاب شده حذف شود؟", "تایید حذف", MessageBoxButtons.YesNo);
        if (confirmResult == DialogResult.Yes)
        {
            try
            {
                using var dbContext = new MainDbContext();
                CustomerModel customer;

                if (cutomersGridView.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in cutomersGridView.SelectedRows)
                    {
                        var customerId = (int)cutomersGridView.Rows[row.Index].Cells[1].Value;
                        if (dbContext.Customers.Any(x => x.Id == customerId))
                        {
                            customer = dbContext.Customers.Find(customerId);
                            dbContext.Customers.Remove(customer);
                            dbContext.SaveChanges();
                            cutomersGridView.Rows.RemoveAt(row.Index);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ردیفی برای حذف انتخاب نشده");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

    private void CreateInvoiceBtn_Click(object sender, EventArgs e)
    {
        if (cutomersGridView.SelectedRows.Count > 0)
        {
            var customerId = (int)cutomersGridView.Rows[cutomersGridView.SelectedRows[0].Index].Cells[1].Value;
            var CustomerCode = (int)cutomersGridView.Rows[cutomersGridView.SelectedRows[0].Index].Cells[2].Value;
            var customerFullName = cutomersGridView.Rows[cutomersGridView.SelectedRows[0].Index].Cells[3].Value.ToString();
            var invoiceCreateFrm = new InvoiceCreateFrm();
            FormUtility.CloseIfExistForm(invoiceCreateFrm.Name);
            invoiceCreateFrm.Invoice.CustomerId = customerId;
            invoiceCreateFrm.Invoice.Customer.FullName = customerFullName;
            invoiceCreateFrm.Invoice.Customer.Code = CustomerCode;
            invoiceCreateFrm.ShowDialog();
        }
        else
        {
            MessageBox.Show("ردیفی برای صدور فاکتور انتخاب نشده");
        }


    }

    private void ShowCustomerInvoiceListBtn_Click(object sender, EventArgs e)
    {
        if (cutomersGridView.SelectedRows.Count > 0)
        {
            var customerId = (int)cutomersGridView.Rows[cutomersGridView.SelectedRows[0].Index].Cells[1].Value;
            var invoicesFrm = new InvoicesFrm();
            FormUtility.CloseIfExistForm(invoicesFrm.Name);
            invoicesFrm.Customer.Id = customerId;
            invoicesFrm.Customer.Code = (int)cutomersGridView.Rows[cutomersGridView.SelectedRows[0].Index].Cells[2].Value;
            invoicesFrm.Customer.FullName = cutomersGridView.Rows[cutomersGridView.SelectedRows[0].Index].Cells[3].Value.ToString();
            invoicesFrm.Customer.Phone = cutomersGridView.Rows[cutomersGridView.SelectedRows[0].Index].Cells[4].Value?.ToString();
            invoicesFrm.ShowDialog();
        }
        else
        {
            MessageBox.Show("مشتری برای لیست کردن فاکتورها انتخاب نشده");
        }
    }

    private void CustomersFrm_Shown(object sender, EventArgs e)
    {
        new Thread(new ThreadStart(LoadGridView)).Start();
    }

    private void LoadGridView()
    {
        using var dbContext = new MainDbContext();
        var customers = dbContext.Customers.ToList();
        foreach (var customer in customers)
        {
            Invoke(new EventHandler(delegate (object sender, EventArgs e)
            {
                cutomersGridView.Rows.Add("", customer.Id, customer.Code, customer.FullName, customer.Mobile);
            }), new object[2] { this, null });
            Thread.Sleep(1);
        }

    }
}
