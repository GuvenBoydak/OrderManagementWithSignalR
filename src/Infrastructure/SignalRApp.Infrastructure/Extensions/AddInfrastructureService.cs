using Microsoft.Extensions.DependencyInjection;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Infrastructure.Services;

namespace SignalRApp.Infrastructure.Extensions;

public static class AddInfrastructureService
{
    public static IServiceCollection AddInfrastructureServiceDI(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        return services;
    }
}