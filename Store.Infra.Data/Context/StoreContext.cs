using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;
using Store.Infra.Data.Mapping;

namespace Store.Infra.Data.Context
{
    public class StoreContext : DbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Payment> Payments { get; set; }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("ControleStore");

            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new PaymentMap());
        }
    }
}
