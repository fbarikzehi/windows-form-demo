using Nojan.Ui.Forms.Customer;
using Nojan.Ui.Forms.Invoice;
using Nojan.Ui.Forms.PriceList;
using Nojan.Ui.Utilities;

namespace Nojan.Ui.Forms;

public partial class MainFrm : Form
{
    public MainFrm()
    {
        InitializeComponent();
    }

    private void CreateCustomerMenuItem_Click(object sender, EventArgs e)
    {
        var customerCreateFrm = new CustomerCreateFrm();
        FormUtility.CloseIfExistForm(customerCreateFrm.Name);
        customerCreateFrm.ShowDialog();
    }

    private void CustomerMenuItem_Click(object sender, EventArgs e)
    {
        var customersFrm = new CustomersFrm();
        FormUtility.CloseIfExistForm(customersFrm.Name);
        customersFrm.ShowDialog();
    }

    private void PriceListMenuItem_Click(object sender, EventArgs e)
    {
        var priceListsFrm = new PriceListsFrm();
        FormUtility.CloseIfExistForm(priceListsFrm.Name);
        priceListsFrm.ShowDialog();
    }

    private void InvoiceSettingMenuItem_Click(object sender, EventArgs e)
    {
        var invoiceSettingFrm = new InvoiceSettingFrm();
        FormUtility.CloseIfExistForm(invoiceSettingFrm.Name);
        invoiceSettingFrm.ShowDialog();
    }

    private void CreatePriceListMenuItem_Click(object sender, EventArgs e)
    {
        var priceListCreateFrm = new PriceListCreateFrm();
        FormUtility.CloseIfExistForm(priceListCreateFrm.Name);
        priceListCreateFrm.ShowDialog();
    }
}