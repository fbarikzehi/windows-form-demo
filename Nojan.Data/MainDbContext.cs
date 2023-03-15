using Microsoft.EntityFrameworkCore;
using Nojan.Data.Model;

namespace Nojan.Data
{
    public class MainDbContext : DbContext
    {
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<CustomerProjectModel> CustomerProjects { get; set; }
        public DbSet<PriceListModel> PriceLists { get; set; }
        public DbSet<PriceListItemModel> PriceListItems { get; set; }
        public DbSet<InvoiceModel> Invoices { get; set; }
        public DbSet<InvoiceItemModel> InvoiceItems { get; set; }
        public DbSet<SettingInvoiceModel> SettingInvoice { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=nojan;Persist Security Info=True;User ID=sa;Password=Dev_1234@4321;TrustServerCertificate=True");
        }

    }
}
