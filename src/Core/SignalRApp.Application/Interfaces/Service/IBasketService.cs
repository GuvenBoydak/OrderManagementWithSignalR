using SignalRApp.Application.Features.Basket.Commands.Create;
using SignalRApp.Application.Features.Basket.Commands.Delete;
using SignalRApp.Application.Features.Basket.Commands.Update;
using SignalRApp.Application.Features.Basket.Queries.GetAllBaskets;
using SignalRApp.Application.Features.Basket.Queries.GetBasketById;
using SignalRApp.Application.Features.Basket.Queries.GetBasketByMenuTableId;
using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Interfaces.Service;

public interface IBasketService
{
    Task<ServiceResult<GetBasketByIdDto>> GetByIdAsync(int id);
    Task<ServiceResult<List<GetAllBasketDto>>> GetAllAsync();
    Task<ServiceResult<List<GetBasketByMenuTableIdDto>>> GetBasketByMenuTableIdAsync(int id);
    Task<ServiceResult> AddAsync(CreateBasketCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateBasketCommandRequest request, CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(DeleteBasketCommandRequest request, CancellationToken cancellationToken);
}