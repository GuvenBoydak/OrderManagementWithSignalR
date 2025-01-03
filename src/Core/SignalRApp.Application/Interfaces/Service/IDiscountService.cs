using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IDiscountService
{
    Task<Discount> GetByIdAsync(int id);
    Task<List<Discount>> GetAllAsync();
    ValueTask AddAsync(Discount discount,CancellationToken cancellationToken);
    ValueTask UpdateAsync(Discount discount,CancellationToken cancellationToken);
    ValueTask DeleteAsync(Discount discount,CancellationToken cancellationToken);
}