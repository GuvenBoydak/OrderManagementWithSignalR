using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IProductService
{
    Task<Product> GetByIdAsync(int id);
    Task<List<Product>> GetAllAsync();
    ValueTask AddAsync(Product product,CancellationToken cancellationToken);
    ValueTask UpdateAsync(Product product,CancellationToken cancellationToken);
    ValueTask DeleteAsync(Product product,CancellationToken cancellationToken);
}