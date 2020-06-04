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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite("Data Source=local.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("ControleStore");

            modelBuilder.Entity<Category>(new CategoryMap().Configure);
            modelBuilder.Entity<Product>(new ProductMap().Configure);
            modelBuilder.Entity<Payment>(new PaymentMap().Configure);
        }
    }
}
