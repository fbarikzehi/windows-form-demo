using System.ComponentModel.DataAnnotations.Schema;

namespace Nojan.Data.Model
{
    public class PriceListItemModel : ModelBase<long>
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Code { get; set; }

        public int PriceListId { get; set; }
        [ForeignKey(nameof(PriceListId))]
        public virtual PriceListModel PriceList { get; set; }
    }
}
