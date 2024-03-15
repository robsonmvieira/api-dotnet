using Microsoft.EntityFrameworkCore;
using Stock.Supplier.Domain.Entities;

namespace Stock.Supplier.Infra.Context;

public class SupplierContext
{
    public class SupplierDbContext : DbContext
    {
        public SupplierDbContext() {}
        public SupplierDbContext(DbContextOptions<SupplierDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories {get; set; } 
            

        public DbSet<Product> Products {get; set; } 

        public DbSet<Domain.Entities.Supplier> Suppliers {get; set; } 

        public DbSet<Address> Addresses {get; set; } 


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                         .SelectMany(e => e.GetProperties()
                             .Where(p => p.ClrType == typeof(string)))) 
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SupplierDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Added && entry.Properties.Any(p => p.Metadata.Name == "CreatedAt"))
                {
                    entry.Property("CreatedAt").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("UpdatedAt").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}