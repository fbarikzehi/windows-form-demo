using Nojan.Data.Commands;
using Nojan.Data.Model;
using Nojan.Shared.Utilities;

namespace Nojan.Ui.Forms.PriceList;

public partial class PriceListCreateItemFrm : Form
{
    public PriceListItemModel? Item { get; set; }

    public PriceListCreateItemFrm()
    {
        InitializeComponent();
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
        var command = new PriceListCommand();
        Item.Name = txtName.Text;
        Item.Price = TypeUtility.ToFloatPrice(txtPrice.Text);
        Item.Code = string.IsNullOrEmpty(txtCode.Text) ? 0 : int.Parse(txtCode.Text);
        if (Item.PriceList?.Id > 0)
        {
            var response = command.CreateItem(Item);
            if (response.IsSuccess)
            {
                Item = response.Data;
                this.DialogResult = DialogResult.Continue;
                this.Close();
            }
            else
                MessageBox.Show(response.Message);
        }
        else
        {
            Item.PriceList.Items = new List<PriceListItemModel> { Item };
            var response = command.Create(Item.PriceList);
            if (response.IsSuccess)
            {
                Item = response.Data?.Items?.FirstOrDefault();
                this.DialogResult = DialogResult.Continue;
                this.Close();
            }
            else
                MessageBox.Show(response.Message);

        }

    }

    private void txtPrice_KeyUp(object sender, KeyEventArgs e)
    {
        if (!string.IsNullOrEmpty(txtPrice.Text) && float.TryParse(TypeUtility.ToFloatPrice(txtPrice.Text).ToString(), out float _))
        {
            txtPrice.Text = float.Parse(TypeUtility.ToFloatPrice(txtPrice.Text).ToString()).ToString(TypeUtility.CommaFormatted);
            txtPrice.SelectionStart = txtPrice.Text.Length;
        }
    }
}
