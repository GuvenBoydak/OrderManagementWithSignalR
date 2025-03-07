using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Persistence.Context;

public class OrderManagementDbContext:IdentityDbContext<AppUser,AppRole,int>
{
    public OrderManagementDbContext(DbContextOptions options):base(options)   
    {
    }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<MenuTable> MenuTables { get; set; }
    public DbSet<Notification> Notifications { get; set; }
}