using Stock.Core.Application.UOW;
using Stock.Core.Entities;
using Stock.Supplier.Domain.Repositories;
using Stock.Supplier.Infra.Repositories;
using Stock.Supplier.Infra.UOW;

namespace Stock.Supplier.Application.Configurations;

public static class ResolveDependencies
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.ResolveDomainDependencies();
        return services;
    }
    private static IServiceCollection ResolveDomainDependencies(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<INotificatorService, NotificationService>();
        services.AddScoped<ISupplierRepository, SupplierRepository>();
        return services;
    }

}