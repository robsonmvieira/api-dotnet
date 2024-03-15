using MediatR;
using Microsoft.EntityFrameworkCore;
using Stock.Supplier.Application.UseCases.Supplier.CreateSupplierUseCase;
using Stock.Supplier.Infra.Context;

namespace Stock.Supplier.Application.Configurations;

public static class ConnectionConfiguration
{
    public static IServiceCollection AddCustomConnections(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext(configuration)
            .AddMediatR(typeof(CreateSupplierUseCase));
        return services;
    }
    
    private static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("supplierDb");
        
        services.AddDbContext<SupplierContext.SupplierDbContext>(options =>
        {
            // force run migrations
            options.UseNpgsql(connectionString)
                .LogTo(Console.WriteLine, LogLevel.Information);
        });
        
        return services;
    }
}