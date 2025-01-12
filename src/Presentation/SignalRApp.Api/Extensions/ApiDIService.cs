using SignalRApp.Api.Hubs;

namespace SignalRApp.Api.Extensions;

public static class ApiDIService
{
    public static IServiceCollection AddApiDıService(this IServiceCollection services)
    {
        services.AddCors(opt =>
        {
            opt.AddPolicy(SignalRConstant.PolicyName, builder =>
            {
                builder.AllowAnyHeader()
                    .AllowAnyMethod()
                    .SetIsOriginAllowed((host) => true)
                    .AllowCredentials();
            });
        });
        services.AddSignalR();

        return services;
    }
    
}