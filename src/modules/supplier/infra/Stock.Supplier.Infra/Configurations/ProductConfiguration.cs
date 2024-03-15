using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.Supplier.Domain.Entities;

namespace Stock.Supplier.Infra.Configurations;

public class ProductConfiguration: IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Description).HasMaxLength(2000);
        builder.Property(x => x.Price).HasColumnType("decimal(10,2)").IsRequired();
        builder.Property(x => x.IsActive).IsRequired();
        builder.Property(x => x.StockQuantity).IsRequired();
        builder.Property(x => x.StockMaximum).IsRequired();
        builder.Property(x => x.StockMinimum).IsRequired();
        builder.HasOne(x => x.Category)
            .WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
        builder.HasOne(x => x.Supplier)
            .WithMany(x => x.Products).HasForeignKey(x => x.SupplierId);
    }
}

