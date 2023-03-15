using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Nojan.Data;
using Nojan.Data.Commands;
using Nojan.Data.Model;
using Nojan.Ui.Forms.Customer;
using Nojan.Ui.Reports.Invoice;
using Nojan.Shared.Enum;
using Nojan.Shared.Extensions;
using Nojan.Ui.Utilities;
using System.Data;

namespace Nojan.Ui.Forms.Invoice;

public partial class InvoiceCreateFrm : Form
{
    public InvoiceModel Invoice { get; set; } = new InvoiceModel { Items = new List<InvoiceItemModel>(), Customer = new CustomerModel() };


    public InvoiceCreateFrm()
    {
        InitializeComponent();
    }


    private void CreateInvoiceFrm_Shown(object sender, EventArgs e)
    {
        //On Update
        if (Invoice.Id is not 0)
        {
            LoadGridView();
            LoadProjectCombo(Invoice.ProjectId);
        }
        //On Create
        else
        {
            LoadProjectCombo();
        }
        lblFullName.Text = Invoice.Customer.FullName;
        lblCode.Text = Invoice.Customer.Code.ToString();
    }


    private void InvoicePrintBtn_Click(object sender, EventArgs e)
    {
        var command = new SettingInvoiceCommand();
        var commandResponse = command.Find();
        if (commandResponse.IsSuccess && commandResponse.Data is not null)
        {
            var invoiceCommand = new InvoiceCommand();
            var invoiceCommandResponse = invoiceCommand.FindById(Invoice.Id);
            if (invoiceCommandResponse.Data is not null)
            {
                Invoice = invoiceCommandResponse.Data;
                var invoiceSetting = commandResponse.Data;
                var reportModel = new InvoiceReportData
                {
                    Items = new List<InvoiceReportModel>(),
                    JobTitle = invoiceSetting?.JobTitle,
                    JobAddress = invoiceSetting?.Address,
                    JobPhone = invoiceSetting?.Phone,
                    CustomerCode = Invoice?.Customer.Code.ToString(),
                    CustomerFullName = Invoice?.Customer.FullName,
                    Project = Invoice?.Project?.Title,
                    Date = Invoice?.Date.ToPersianDate(),
                    Number = Invoice?.Number?.ToString()
                };
                int rowNumber = 1;
                float invoiceTotalPrice = 0;
                foreach (var item in Invoice.Items)
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
        {
            var invoiceSettingFrm = new InvoiceSettingFrm();
            FormUtility.CloseIfExistForm(invoiceSettingFrm.Name);
            invoiceSettingFrm.ShowDialog();
        }
    }

    private void DeleteItemBtn_Click(object sender, EventArgs e)
    {
        try
        {
            if (invoiceItemsGridView.SelectedRows.Count > 0)
            {
                var command = new InvoiceCommand();
                foreach (DataGridViewRow row in invoiceItemsGridView.SelectedRows)
                {
                    var response = command.DeleteItem((long)invoiceItemsGridView.Rows[row.Index].Cells[1].Value);
                    if (response.IsSuccess)
                        invoiceItemsGridView.Rows.RemoveAt(row.Index);
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

    private void BtnAddProject_Click(object sender, EventArgs e)
    {
        var customerProjectCreateFrm = new CustomerProjectCreateFrm();
        FormUtility.CloseIfExistForm(customerProjectCreateFrm.Name);
        customerProjectCreateFrm.CustomerProject.CustomerId = Invoice.CustomerId;
        customerProjectCreateFrm.CustomerProject.Customer.FullName = lblFullName.Text;
        customerProjectCreateFrm.ShowDialog();

        var newPeject = customerProjectCreateFrm.CustomerProject;
        if (newPeject is not null)
            LoadProjectCombo();
    }

    private void LoadProjectCombo(int? selectedItemId = null)
    {
        var customerCommand = new CustomerCommand();
        var customerProjects = customerCommand.GetProjects(Invoice.CustomerId);
        if (customerProjects.Data?.Count > 0)
        {
            customerProjects.Data.Add(0, "انتخاب نشده");
            ComboCustomerProject.DataSource = new BindingSource(customerProjects.Data.OrderBy(x => x.Key), null);
            if (selectedItemId is not null)
                ComboCustomerProject.SelectedItem = customerProjects.Data.FirstOrDefault(x => x.Key == selectedItemId);
            ComboCustomerProject.DisplayMember = "Value";
            ComboCustomerProject.ValueMember = "Key";
        }
    }

    private void InvoiceCreateFrm_KeyDown(object sender, KeyEventArgs e)
    {
        if (!e.Control && e.KeyCode == Keys.Add)
        {
            SelectItems();
        }
        else if (e.Control && e.KeyCode == Keys.P)
        {
            InvoiceReport.Load(new InvoiceReportData { Items = new List<InvoiceReportModel>() });
        }
    }

    private void invoiceItemsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        invoiceItemsGridView.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
    }

    private void SelectItemsBtn_Click(object sender, EventArgs e)
    {
        SelectItems();
    }

    private void SelectItems()
    {
        var invoiceSelectItemsFrm = new InvoiceSelectItemsFrm();
        FormUtility.CloseIfExistForm(invoiceSelectItemsFrm.Name);
        var projectIdSelected = int.TryParse(ComboCustomerProject.SelectedValue?.ToString(), out int _);
        Invoice.ProjectId = projectIdSelected && ComboCustomerProject.SelectedValue?.ToString() != "0" ? int.Parse(ComboCustomerProject.SelectedValue.ToString()) : null;
        invoiceSelectItemsFrm.Invoice = Invoice;
        invoiceSelectItemsFrm.ShowDialog();
        Invoice = invoiceSelectItemsFrm.Invoice;
        LoadGridView();
    }

    private void invoiceItemsGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
    {
        if (invoiceItemsGridView.CurrentCell.ColumnIndex == 3 || invoiceItemsGridView.CurrentCell.ColumnIndex == 4)
        {
            invoiceItemsGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }

    private void invoiceItemsGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (invoiceItemsGridView.Rows.Count > 0)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            var itemId = long.Parse(invoiceItemsGridView.Rows[row].Cells[1].Value.ToString());

            //Qty
            if (column == 3 && row >= 0)
            {
                var qtyCellValue = invoiceItemsGridView.Rows[row].Cells[column].Value?.ToString();
                if (!string.IsNullOrEmpty(qtyCellValue) && float.TryParse(qtyCellValue, out float _))
                {
                    var command = new InvoiceCommand();
                    var updateResponse = command.UpdateItem(new InvoiceItemModel { Id = itemId, Qty = float.Parse(qtyCellValue), Unit = string.Empty });
                    if (updateResponse.IsSuccess)
                    {
                        var itemTotal = TypeUtility.ToFloatPrice(invoiceItemsGridView.Rows[row].Cells[5].Value.ToString()) * float.Parse(qtyCellValue);
                        invoiceItemsGridView.Rows[row].Cells[6].Value = itemTotal.ToString(TypeUtility.CommaFormatted);
                        RefreshTotalPriceLable();
                    }
                }
                else
                {
                    invoiceItemsGridView.Rows[row].Cells[column].Value = 0;
                    invoiceItemsGridView.Rows[row].Cells[6].Value = 0;
                }
            }
            //Unit
            if (column == 4 && row >= 0)
            {
                var qtyCellValue = float.TryParse(invoiceItemsGridView.Rows[row].Cells[3].Value?.ToString(), out float _) ? float.Parse(invoiceItemsGridView.Rows[row].Cells[3].Value?.ToString()) : 0;
                var UnitCellValue = invoiceItemsGridView.Rows[row].Cells[column].Value?.ToString();
                if (!string.IsNullOrEmpty(UnitCellValue))
                {
                    var command = new InvoiceCommand();
                    var updateResponse = command.UpdateItem(new InvoiceItemModel { Id = itemId, Qty = qtyCellValue, Unit = UnitCellValue });
                }
            }
        }
    }

    private void ComboCustomerProject_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (!Invoice.Id.Equals(0))
        {
            var selectedProject = ComboCustomerProject.SelectedValue.ToString();
            Invoice.ProjectId = (!string.IsNullOrEmpty(selectedProject) &&
                                 !selectedProject.ToString().Equals("0") &&
                                 int.TryParse(selectedProject, out int _)) ? int.Parse(ComboCustomerProject.SelectedValue.ToString()) : null;
            var command = new InvoiceCommand();
            command.UpdateProject(Invoice);

        }

    }

    private void RefreshTotalPriceLable()
    {
        float itemTotal = 0;
        foreach (DataGridViewRow row in invoiceItemsGridView.Rows)
        {
            itemTotal += TypeUtility.ToFloatPrice(invoiceItemsGridView.Rows[row.Index].Cells[5].Value.ToString()) * float.Parse(invoiceItemsGridView.Rows[row.Index].Cells[3].Value?.ToString());
        }
        lblTotalPrice.Text = itemTotal.ToString(TypeUtility.CommaFormatted);
    }

    private void LoadGridView()
    {
        var command = new InvoiceCommand();
        var response = command.FindById(Invoice.Id);
        if (response != null && response.Data?.Items is not null)
        {
            invoiceItemsGridView.Rows.Clear();
            Invoice = response.Data;
            float invoiceTotalPrice = 0;
            foreach (var item in Invoice.Items)
            {
                float totalPrice = item.PriceListItem.Price * item.Qty;
                var units = Enum.GetValues(typeof(UnitEnum)).Cast<UnitEnum>().Select(x => EnumExtensions<UnitEnum>.GetPersianName(x)).ToList();

                var row = new DataGridViewRow();

                var cellRowNumber = new DataGridViewTextBoxCell();
                cellRowNumber.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                row.Cells.Add(cellRowNumber);
                cellRowNumber.ReadOnly = true;

                var cellId = new DataGridViewTextBoxCell();
                row.Cells.Add(cellId);

                var cellPriceListItemName = new DataGridViewTextBoxCell();
                cellPriceListItemName.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                row.Cells.Add(cellPriceListItemName);
                cellPriceListItemName.ReadOnly = true;

                var cellQty = new DataGridViewTextBoxCell();
                cellQty.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                row.Cells.Add(cellQty);

                var cellUnit = new DataGridViewComboBoxCell();
                cellUnit.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                cellUnit.Value = item.Unit;
                row.Cells.Add(cellUnit);

                var cellPriceListItemPrice = new DataGridViewTextBoxCell();
                cellPriceListItemPrice.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                row.Cells.Add(cellPriceListItemPrice);
                cellPriceListItemPrice.ReadOnly = true;

                var cellPriceListItemTotalPrice = new DataGridViewTextBoxCell();
                cellPriceListItemTotalPrice.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                row.Cells.Add(cellPriceListItemTotalPrice);
                cellPriceListItemTotalPrice.ReadOnly = true;

                row.Cells[0].Value = "";
                row.Cells[1].Value = item.Id;
                row.Cells[2].Value = item.PriceListItem.Name;
                row.Cells[3].Value = item.Qty;
                ((DataGridViewComboBoxCell)row.Cells[4]).DataSource = units;
                row.Cells[5].Value = item.PriceListItem.Price.ToString(TypeUtility.CommaFormatted);
                row.Cells[6].Value = totalPrice.ToString(TypeUtility.CommaFormatted);

                invoiceTotalPrice += totalPrice;

                invoiceItemsGridView.Rows.Add(row);
            }
            invoiceItemsGridView.FirstDisplayedScrollingRowIndex = invoiceItemsGridView.RowCount - 1;
            lblTotalPrice.Text = invoiceTotalPrice.ToString(TypeUtility.CommaFormatted);
            lblInvoiceNumber.Text = Invoice?.Number;
        }
    }

}
