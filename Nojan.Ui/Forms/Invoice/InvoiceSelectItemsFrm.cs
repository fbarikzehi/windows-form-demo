using Nojan.Data.Commands;
using Nojan.Data.Model;
using Nojan.Shared.Enum;
using Nojan.Shared.Extensions;
using Nojan.Shared.Utilities;

namespace Nojan.Ui.Forms.Invoice;

public partial class InvoiceSelectItemsFrm : Form
{
    private string item_identifier = "item_";
    public InvoiceModel Invoice { get; set; } = new InvoiceModel { Customer = new CustomerModel(), Items = new List<InvoiceItemModel>(), Project = new CustomerProjectModel() };

    public InvoiceSelectItemsFrm()
    {
        InitializeComponent();
    }

    private void LoadPriceLists()
    {
        var command = new PriceListCommand();
        var response = command.FindAll();
        if (response.Data is not null)
        {
            var parentListNode = new TreeNode();
            var childNode = new TreeNode();
            foreach (var list in response.Data)
            {
                parentListNode = treeViewPriceLists.Nodes.Add($"list_{list.Id}", $"{list.Title}({list.Year}/{list.Month})");
                foreach (var item in list.Items)
                {
                    childNode = parentListNode.Nodes.Add($"{item_identifier}{item.Id}", $"--{item.Name} کد ({item.Code}) [قیمت {item.Price.ToString(TypeUtility.CommaFormatted)}]");
                    childNode.Checked = Invoice.Items != null && Invoice.Items.Any(x => x.PriceListItemId == item.Id);
                    if (childNode.Checked)
                    {
                        childNode.ForeColor = Color.RoyalBlue;
                    }
                }
            }
        }

    }

    private void treeViewPriceLists_AfterCheck(object sender, TreeViewEventArgs e)
    {
        if (e.Node.Name.Contains(item_identifier))
        {
            e.Node.ForeColor = Color.RoyalBlue;
            var command = new InvoiceCommand();
            var thisItemId = long.Parse(e.Node.Name.Trim(item_identifier.ToCharArray()));
            if (e.Node.Checked)
            {
                var item = new InvoiceItemModel { InvoiceId = Invoice.Id, PriceListItemId = thisItemId, Qty = 0, Unit = EnumExtensions<UnitEnum>.GetPersianName(UnitEnum.Number) };
                if (Invoice.Id == 0)
                {
                    Invoice.Items.Add(item);
                    var response = command.Create(Invoice);
                    if (response.IsSuccess)
                    {
                        Invoice.Id = response.Data.Id;
                    }
                }
                else
                {
                    var response = command.CreateItem(item);
                    if (response.IsSuccess)
                    {
                        Invoice.Items.Add(item);
                    }
                }
            }
            else
            {
                var response = command.DeleteItem(thisItemId);
                if (response.IsSuccess)
                    Invoice.Items.Remove(Invoice.Items.FirstOrDefault(x => x.PriceListItemId == thisItemId));
            }
        }
    }

    private void treeViewPriceLists_DrawNode(object sender, DrawTreeNodeEventArgs e)
    {
        if (e.Node.Level == 0)
            e.Node.HideCheckBox();
        e.DrawDefault = true;
    }

    private void InvoiceSelectItemsFrm_Load(object sender, EventArgs e)
    {
        treeViewPriceLists.DrawMode = TreeViewDrawMode.OwnerDrawText;
        treeViewPriceLists.DrawNode += new DrawTreeNodeEventHandler(treeViewPriceLists_DrawNode);
    }

    private void InvoiceSelectItemsFrm_Shown(object sender, EventArgs e)
    {
        LoadPriceLists();
    }
}

