using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;
using Store.Infra.Data.Mapping;


namespace Store.Infra.Data.Context
{
    public class StoreContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new PaymentMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
