using SignalRApp.Application.Features.OrderDetail.Commands.Create;
using SignalRApp.Application.Features.OrderDetail.Commands.Update;
using SignalRApp.Application.Features.OrderDetail.Queries.GetAllOrderDetails;
using SignalRApp.Application.Features.OrderDetail.Queries.GetOrderDetailById;
using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Interfaces.Service;

public interface IOrderDetailService
{
    Task<ServiceResult<List<GetAllOrderDetailDto>>> GetAllAsync();
    Task<ServiceResult<GetOrderDetailByIdDto>> GetByIdAsync(int id);
    Task<ServiceResult> AddAsync(CreateOrderDetailCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> UpdateAsync(UpdateOrderDetailCommandRequest request,CancellationToken cancellationToken);
    Task<ServiceResult> DeleteAsync(int id,CancellationToken cancellationToken);
}