using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.Supplier.Domain.Entities;

namespace Stock.Supplier.Infra.Configurations;

public class AddressConfiguration: IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Addresses");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Street).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Number).HasMaxLength(10).IsRequired();
        builder.Property(x => x.Complement).HasMaxLength(100);
        builder.Property(x => x.District).HasMaxLength(100).IsRequired();
        builder.Property(x => x.City).HasMaxLength(100).IsRequired();
        builder.Property(x => x.State).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Country).HasMaxLength(100).IsRequired();
        builder.Property(x => x.ZipCode).HasMaxLength(8).IsRequired();
    }
}