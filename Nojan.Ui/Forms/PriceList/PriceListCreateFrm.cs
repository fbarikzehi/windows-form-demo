using Nojan.Data.Model;
using System.Data;
using Nojan.Ui.Utilities;
using Nojan.Data.Commands;

namespace Nojan.Ui.Forms.PriceList;

public partial class PriceListCreateFrm : Form
{
    public PriceListModel PriceList { get; set; } = new PriceListModel { Items = new List<PriceListItemModel>() };

    public PriceListCreateFrm()
    {
        InitializeComponent();

    }

    private void ServicesGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        itemsGridView.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
    }

    private void DeleteRowBtn_Click(object sender, EventArgs e)
    {
        Delete();
    }

    private void btnInsertItem_Click(object sender, EventArgs e)
    {
        Insert();
    }

    private void Insert()
    {
        if (string.IsNullOrEmpty(txtTitle.Text))
        {
            MessageBox.Show("مقدار عنوان را وارد کنید");
            return;
        }

        var priceListCreateItemFrm = new PriceListCreateItemFrm();
        FormUtility.CloseIfExistForm(priceListCreateItemFrm.Name);
        PriceList.Title = txtTitle.Text;
        PriceList.Year = int.Parse(comboBoxYear.SelectedValue?.ToString());
        PriceList.Month = int.Parse(comboBoxMonth.SelectedValue?.ToString());
        priceListCreateItemFrm.Item = new PriceListItemModel { PriceList = PriceList };
        var result = priceListCreateItemFrm.ShowDialog();
        if (priceListCreateItemFrm.Item.Id > 0)
        {
            PriceList.Id = priceListCreateItemFrm.Item.PriceListId;
            AddRowToGrid(priceListCreateItemFrm.Item);
            if (result == DialogResult.Continue)
                Insert();
        }

    }

    private void AddRowToGrid(PriceListItemModel item)
    {
        itemsGridView.Rows.Add("", item.Id, item.Name, item.Price.ToString(TypeUtility.CommaFormatted), item.Code);
        itemsGridView.FirstDisplayedScrollingRowIndex = itemsGridView.RowCount - 1;
    }

    private void Delete()
    {
        if (itemsGridView.SelectedRows.Count > 0)
        {
            var selectedRows = itemsGridView.SelectedRows;
            var items = new List<PriceListItemModel>();
            foreach (DataGridViewRow row in selectedRows)
                items.Add(new PriceListItemModel { Id = (long)itemsGridView.Rows[row.Index].Cells[1].Value });

            var command = new PriceListCommand();
            var response = command.DeleteItems(items);
            if (response.IsSuccess)
                foreach (DataGridViewRow row in selectedRows)
                    itemsGridView.Rows.RemoveAt(row.Index);

        }
        else
        {
            MessageBox.Show("ردیفی برای حذف انتخاب نشده");
        }
    }

    private void LoadItemGridView()
    {
        var command = new PriceListCommand();
        var response = command.FindAllItemsByPriceList(PriceList.Id);
        if (response.Data is not null)
            foreach (var item in response.Data)
                AddRowToGrid(item);
    }

    private void LoadCombos(int selectedYear, int selectedMonth)
    {
        comboBoxYear.Items.Clear();
        comboBoxMonth.Items.Clear();

        var thisYear = DateTimeUtility.GetIntPersianYear(DateTime.Now);
        var years = new int[6] { thisYear - 4, thisYear - 3, thisYear - 2, thisYear - 1, thisYear, thisYear + 1 };

        comboBoxYear.DataSource = new BindingSource(years.Select(x => new { Key = x, Value = x }), null);
        comboBoxYear.SelectedItem = selectedYear == 0 ? thisYear : selectedYear;
        comboBoxYear.SelectedIndex = selectedYear == 0 ? 4 : years.Where(x => x == selectedYear);
        comboBoxYear.DisplayMember = "Value";
        comboBoxYear.ValueMember = "Key";

        var month = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        comboBoxMonth.DataSource = new BindingSource(month.Select(x => new { Key = x, Value = x }), null);
        comboBoxMonth.SelectedItem = selectedMonth == 0 ? 1 : selectedMonth;
        comboBoxMonth.SelectedIndex = selectedMonthIndex;
        comboBoxMonth.DisplayMember = "Value";
        comboBoxMonth.ValueMember = "Key";
    }

    private void PriceListCreateFrm_KeyDown(object sender, KeyEventArgs e)
    {
        if (!e.Control && e.KeyCode == Keys.Add)
        {
            Insert();
        }
        else if (!e.Control && e.KeyCode == Keys.Delete)
        {
            Delete();
        }
    }

    private void PriceListCreateFrm_Shown(object sender, EventArgs e)
    {
        if (PriceList != null && PriceList.Id != 0)
        {
            LoadItemGridView();
            LoadCombos(PriceList.Year, PriceList.Month);
        }
        else
            LoadCombos(0, 0);
    }
}
