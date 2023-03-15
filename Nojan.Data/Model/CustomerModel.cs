using System.ComponentModel.DataAnnotations;

namespace Nojan.Data.Model
{
    public class CustomerModel : ModelBase<int>
    {
        [Required]
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? Address { get; set; }
        public int Code { get; set; }

        public virtual ICollection<InvoiceModel> Invoices { get; set; }
        public virtual ICollection<CustomerProjectModel> Projects { get; set; }

    }
}
