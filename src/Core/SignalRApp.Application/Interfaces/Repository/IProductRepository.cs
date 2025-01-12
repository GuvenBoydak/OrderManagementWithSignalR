using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Repository;

public interface IProductRepository : IRepository<Product>
{
    Task<decimal> GetProductsAveragePriceAsync();
    Task<string> GetProductNameByMaxPriceAsync();
    Task<string> ProductNameByMinPriceAsync();
}