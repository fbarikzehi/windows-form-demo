using Nojan.Data.Model;
using Nojan.Data;

namespace Nojan.Ui.Forms.Invoice;

public partial class InvoiceSettingFrm : Form
{
    public InvoiceSettingFrm()
    {
        InitializeComponent();
        try
        {
            using var dbContext = new MainDbContext();
            var setting = dbContext.SettingInvoice.FirstOrDefault();
            if (setting is not null)
            {
                txtInitNumber.Text = setting.InitNumber;
                txtAddress.Text = setting.Address;
                txtJobTitle.Text = setting.JobTitle;
                txtPhone.Text = setting.Phone;
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }

    private void UpdateBtn_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(txtInitNumber.Text))
            {
                MessageBox.Show("فیلد شماره شروع فاکتور را وارد کنید");
                txtInitNumber.Focus();
                return;
            }

            using var dbContext = new MainDbContext();
            var model = new SettingInvoiceModel();
            if (dbContext.SettingInvoice.Count() == 0)
            {
                model.InitNumber = txtInitNumber.Text;
                model.Address = txtAddress.Text;
                model.JobTitle = txtJobTitle.Text;
                model.Phone = txtPhone.Text;
                dbContext.SettingInvoice.Add(model);
            }
            else
            {
                model = dbContext.SettingInvoice.FirstOrDefault();
                if (dbContext.Invoices.Count() == 0)
                    model.InitNumber = txtInitNumber.Text;
                model.Address = txtAddress.Text;
                model.JobTitle = txtJobTitle.Text;
                model.Phone = txtPhone.Text;

            }
            dbContext.SaveChanges();
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
