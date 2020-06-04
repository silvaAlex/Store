using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities;

namespace Store.Infra.Data.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(c => c.CategoryId);

            builder.Property(c => c.Name)
                .IsRequired();

            builder.Property(c => c.Description)
               .IsRequired();

            builder.Property(c => c.CreatedAt)
                .IsRequired();
                
        }
    }
}

