using System.ComponentModel.DataAnnotations.Schema;

namespace Nojan.Data.Model
{
    public class CustomerProjectModel : ModelBase<int>
    {
        public string Title { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual CustomerModel Customer { get; set; }
    }
}
