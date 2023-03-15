using Nojan.Data.Commands;
using Nojan.Data.Model;

namespace Nojan.Ui.Forms.Customer;

public partial class CustomerCreateFrm : Form
{
    public bool ReloadGrid { get; set; }
    public DataGridView CustomersGridView { get; set; }

    public CustomerCreateFrm()
    {
        InitializeComponent();
    }

    private void createBtn_Click(object sender, EventArgs e)
    {
        var command = new CustomerCommand();
        var commandResponse = command.Create(new CustomerModel
        {
            FullName = customerNameTxt.Text,
            Phone = customerPhoneTxt.Text,
            Mobile = customerMobileTxt.Text,
            Address = customerAddressTxt.Text,
        });
        if (commandResponse.IsSuccess)
        {
            if (ReloadGrid)
                CustomersGridView.Rows.Add("", commandResponse.Data?.Id, commandResponse.Data?.Code, commandResponse.Data?.FullName, commandResponse.Data?.Mobile);
            MessageBox.Show(commandResponse.Message);
            Controls.Clear();
            InitializeComponent();

            customerNameTxt.Focus();
        }
        else
            MessageBox.Show(commandResponse.Message);
    }
}
