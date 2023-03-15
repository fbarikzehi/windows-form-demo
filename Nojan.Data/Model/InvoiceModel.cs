using System.ComponentModel.DataAnnotations.Schema;

namespace Nojan.Data.Model;

public class InvoiceModel : ModelBase<long>
{
    public string Number { get; set; }
    public DateTime Date { get; set; }

    public int CustomerId { get; set; }
    [ForeignKey(nameof(CustomerId))]
    public virtual CustomerModel Customer { get; set; }

    public int? ProjectId { get; set; }
    [ForeignKey(nameof(ProjectId))]
    public virtual CustomerProjectModel? Project { get; set; }

    public virtual ICollection<InvoiceItemModel> Items { get; set; }
}
