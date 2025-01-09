using SignalRApp.Application.Features.Order.Commands.Create;
using SignalRApp.Application.Features.Order.Commands.Update;
using SignalRApp.Application.Features.Order.Queries.GetAllOrders;
using SignalRApp.Application.Features.Order.Queries.GetOrderById;
using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Interfaces.Service;

public interface IOrderService
{
    Task<ServiceResult<List<GetAllOrdersDto>>> GetAllAsync();
    Task<ServiceResult<GetOrderByIdDto>> GetByIdAsync(int id);
    Task<ServiceResult> AddAsync(CreateOrderCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateOrderCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(int id,CancellationToken cancellationToken);
}