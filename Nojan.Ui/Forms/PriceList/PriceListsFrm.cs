using Nojan.Data;
using Nojan.Data.Commands;
using Nojan.Data.Model;
using Nojan.Ui.Forms.Invoice;

namespace Nojan.Ui.Forms.PriceList;

public partial class PriceListsFrm : Form
{
    public PriceListsFrm()
    {
        InitializeComponent();
    }

    private void PriceListsFrm_Shown(object sender, EventArgs e)
    {
        var command = new PriceListCommand();
        var response = command.FindAllWithoutItems();
        if (response.Data != null)
        {
            PriceListGridView.Rows.Clear();
            foreach (var pricelist in response.Data)
                PriceListGridView.Rows.Add("", pricelist.Id, pricelist.Title, pricelist.Year, pricelist.Month);
        }

    }

    private void CreateBtn_Click(object sender, EventArgs e)
    {
        var priceListCreateFrm = new PriceListCreateFrm();
        FormUtility.CloseIfExistForm(priceListCreateFrm.Name);
        priceListCreateFrm.ShowDialog();
    }

    private void PriceListGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        PriceListGridView.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
        var confirmResult = MessageBox.Show("آیا لیست قیمت انتخاب شده حذف شود؟", "تایید حذف", MessageBoxButtons.YesNo);
        if (confirmResult == DialogResult.Yes)
        {

            if (PriceListGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in PriceListGridView.SelectedRows)
                {
                    var priceListId = (int)PriceListGridView.Rows[row.Index].Cells[1].Value;

                    PriceListGridView.Rows.RemoveAt(row.Index);
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
        if (PriceListGridView.SelectedRows.Count > 0)
        {
            var selectedRow = PriceListGridView.Rows[PriceListGridView.SelectedRows[0].Index];
            var priceListId = (int)selectedRow.Cells[1].Value;
            var priceListCreateFrm = new PriceListCreateFrm();
            FormUtility.CloseIfExistForm(priceListCreateFrm.Name);
            priceListCreateFrm.PriceList.Id = priceListId;
            priceListCreateFrm.ShowDialog();
        }
        else
        {
            MessageBox.Show("ردیفی برای ویرایش انتخاب نشده");
        }
    }
}
