using System.ComponentModel.DataAnnotations;

namespace Nojan.Data.Model
{
    public class PriceListModel : ModelBase<int>
    {
        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public virtual ICollection<PriceListItemModel> Items { get; set; }
    }
}
