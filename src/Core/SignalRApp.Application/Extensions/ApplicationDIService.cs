using Microsoft.Extensions.DependencyInjection;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Services;

namespace SignalRApp.Application.Extensions;

public static class ApplicationDIService
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services)
    {       
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationAssembly).Assembly));
        services.AddAutoMapper(typeof(ApplicationAssembly).Assembly);
        
        services.AddScoped<IAboutService, AboutService>();
        services.AddScoped<IBookingService, BookingService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IContactService, ContactService>();
        services.AddScoped<IDiscountService, DiscountService>();
        services.AddScoped<IFeatureService, FeatureService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<ISocialMediaService, SocialMediaService>();
        services.AddScoped<ITestimonialService, TestimonialService>();
        
        return services;
    }
}