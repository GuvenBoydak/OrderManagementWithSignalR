using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.Order.Commands.Create;
using SignalRApp.Application.Features.Order.Commands.Update;
using SignalRApp.Application.Features.Order.Queries.GetAllOrders;
using SignalRApp.Application.Features.Order.Queries.GetOrderById;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class OrderService(IOrderRepository orderRepository, IUnitOfWork unitOfWork, IMapper mapper) : IOrderService
{
    public async Task<ServiceResult<List<GetAllOrdersDto>>> GetAllAsync()
    {
        var orders = await orderRepository.GetAllAsync();
        return ServiceResult<List<GetAllOrdersDto>>
            .Success(mapper.Map<List<GetAllOrdersDto>>(orders));
    }

    public async Task<ServiceResult<GetOrderByIdDto>> GetByIdAsync(int id)
    {
        var order = await orderRepository.GetByIdAsync(id);
        if (order is null)
        {
            return ServiceResult<GetOrderByIdDto>.Failure(OrderConstant.NotFound);
        }

        var orderDto = mapper.Map<GetOrderByIdDto>(order);
        return ServiceResult<GetOrderByIdDto>.Success(orderDto);
    }

    public async Task<ServiceResult<int>> GetTotalOrder()
    {
        return ServiceResult<int>.Success(await orderRepository.GetCountAsync());
    }

    public async Task<ServiceResult<decimal>> GetTotalPrice()
    {
        return ServiceResult<decimal>.Success(await orderRepository.GetTotalPrice());
    }

    public async Task<ServiceResult<decimal>> GetTodayTotalPrice()
    {
        return ServiceResult<decimal>.Success(await orderRepository.GetTodayTotalPrice());
    }

    public async Task<ServiceResult> AddAsync(CreateOrderCommandRequest request, CancellationToken cancellationToken)
    {
        var order = mapper.Map<Order>(request);

        await orderRepository.AddAsync(order);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
    {
        var order = await orderRepository.GetByIdAsync(request.Id);
        if (order is null)
        {
            return ServiceResult.Failure(OrderConstant.NotFound);
        }

        var updatedOrder = mapper.Map(request, order);

        orderRepository.Update(updatedOrder);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> DeleteAsync(int id, CancellationToken cancellationToken)
    {
        var order = await orderRepository.GetByIdAsync(id);
        if (order is null)
        {
            return ServiceResult.Failure(OrderConstant.NotFound);
        }

        orderRepository.Delete(order);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}