using Microsoft.EntityFrameworkCore;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Domain.Entities;
using SignalRApp.Persistence.Context;

namespace SignalRApp.Persistence.Repositories;

public class ProductRepository(OrderManagementDbContext context)
    : GenericRepository<Product>(context), IProductRepository
{
    public async Task<Decimal> GetProductsAveragePriceAsync()
    {
        return await context.Set<Product>().AverageAsync(x => x.Price);
    }

    public async Task<string> GetProductNameByMaxPriceAsync()
    {
        return await context.Set<Product>()
            .Where(x => x.Price == (context.Set<Product>().Max(x => x.Price)))
            .Select(x => x.Name)
            .FirstOrDefaultAsync();
    }

    public async Task<string> ProductNameByMinPriceAsync()
    {
        return await context.Set<Product>()
            .Where(x => x.Price == (context.Set<Product>().Min(x => x.Price)))
            .Select(x => x.Name)
            .FirstOrDefaultAsync();
    }
}