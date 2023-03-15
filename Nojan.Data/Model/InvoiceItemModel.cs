

using System.ComponentModel.DataAnnotations.Schema;

namespace Nojan.Data.Model;

public class InvoiceItemModel : ModelBase<long>
{
    public float Qty { get; set; }

    public string Unit { get; set; }

    public long PriceListItemId { get; set; }

    [ForeignKey(nameof(PriceListItemId))]
    public virtual PriceListItemModel PriceListItem { get; set; }

    public long InvoiceId { get; set; }
    [ForeignKey(nameof(InvoiceId))]
    public virtual InvoiceModel Invoice { get; set; }
}
