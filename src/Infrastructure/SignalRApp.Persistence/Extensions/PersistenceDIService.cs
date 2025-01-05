using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Persistence.Context;
using SignalRApp.Persistence.Repositories;

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
        
        services.AddScoped<IAboutRepository, AboutRepository>();
        services.AddScoped<IBookingRepository, BookingRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IContactRepository, ContactRepository>();
        services.AddScoped<IDiscountRepository, DiscountRepository>();
        services.AddScoped<IFeatureRepository, FeatureRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();
        services.AddScoped<ITestimonialRepository, TestimonialRepository>();
        
        services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
        return services;
    }
}