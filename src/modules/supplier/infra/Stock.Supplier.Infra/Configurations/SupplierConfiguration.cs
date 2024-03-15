using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Stock.Supplier.Infra.Configurations;

public class SupplierConfiguration: IEntityTypeConfiguration<Domain.Entities.Supplier>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Supplier> builder)
    {
        builder.ToTable("Suppliers");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.SupplierType).HasConversion<int>();
        builder.ComplexProperty(x => x.Email);
        builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Document).HasMaxLength(14).IsRequired();
        builder.Property(x => x.Phone).HasMaxLength(14).IsRequired();
        builder.HasOne(x => x.Address)
            .WithOne().HasForeignKey<Domain.Entities.Supplier>(x => x.Id);
        builder.HasMany(x => x.Products)
            .WithOne(p => p.Supplier).HasForeignKey(p => p.SupplierId);
    }
}

