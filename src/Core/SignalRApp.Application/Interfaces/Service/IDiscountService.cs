using SignalRApp.Application.Features.Discount.Commands.Create;
using SignalRApp.Application.Features.Discount.Commands.Delete;
using SignalRApp.Application.Features.Discount.Commands.Update;
using SignalRApp.Application.Helpers;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Interfaces.Service;

public interface IDiscountService
{
    Task<Discount> GetByIdAsync(int id);
    Task<List<Discount>> GetAllAsync();
    Task<ServiceResult> AddAsync(CreateDiscountCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateDiscountCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteDiscountCommandRequest request,CancellationToken cancellationToken);
}