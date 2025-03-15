using Microsoft.Extensions.DependencyInjection;

namespace Hobbyshop.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(ApplicationAssemblyReference.Assembly);
        });

        return services;
    }
}
