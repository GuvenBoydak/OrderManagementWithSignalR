using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface ICategoryService
{
    Task<Category> GetByIdAsync(int id);
    Task<List<Category>> GetAllAsync();
    ValueTask AddAsync(Category category,CancellationToken cancellationToken);
    ValueTask UpdateAsync(Category category,CancellationToken cancellationToken);
    ValueTask DeleteAsync(Category category,CancellationToken cancellationToken);
}