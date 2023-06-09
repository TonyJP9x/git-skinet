using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get;  set; }
        public DbSet<ProductBrand> ProductBrand { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
    }
}