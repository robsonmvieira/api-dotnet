namespace Stock.Supplier.Application.Configurations;

public static class ControllerConfigurations
{
    public static IServiceCollection AddControllersConfiguration(this IServiceCollection services)
    {
        services.AddControllers();
        return services;
    }
}