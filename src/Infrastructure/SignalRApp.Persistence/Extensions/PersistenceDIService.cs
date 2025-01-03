using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Extensions;

public static class PersistenceDIService
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("SqlServer");
        
        services.AddDbContext<OrderManagementDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
        
        return services;
    }
}