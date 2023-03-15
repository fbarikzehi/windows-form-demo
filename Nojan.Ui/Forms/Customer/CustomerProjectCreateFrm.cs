using Nojan.Data.Commands;
using Nojan.Data.Model;

namespace Nojan.Ui.Forms.Customer;

public partial class CustomerProjectCreateFrm : Form
{
    public CustomerProjectModel CustomerProject { get; set; } = new CustomerProjectModel { Customer = new CustomerModel() };
    public CustomerProjectCreateFrm()
    {
        InitializeComponent();
    }

    private void CustomerProjectCreateFrm_Shown(object sender, EventArgs e)
    {
        lblCustomerFullName.Text = CustomerProject.Customer.FullName;
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        var command = new CustomerCommand();
        var commandResponse = command.AddProject(new CustomerProjectModel
        {
            Title = TxtTitle.Text,
            CustomerId = CustomerProject.CustomerId,
        });
        if (commandResponse.IsSuccess)
        {
            CustomerProject = commandResponse.Data;
            this.Close();
        }
        else
            MessageBox.Show(commandResponse.Message);
    }
}
