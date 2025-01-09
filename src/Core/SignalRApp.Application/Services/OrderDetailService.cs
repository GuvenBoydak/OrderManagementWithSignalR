using System.Net;
using AutoMapper;
using SignalRApp.Application.Constants;
using SignalRApp.Application.Features.OrderDetail.Commands.Create;
using SignalRApp.Application.Features.OrderDetail.Commands.Update;
using SignalRApp.Application.Features.OrderDetail.Queries.GetAllOrderDetails;
using SignalRApp.Application.Features.OrderDetail.Queries.GetOrderDetailById;
using SignalRApp.Application.Helpers;
using SignalRApp.Application.Interfaces.Repository;
using SignalRApp.Application.Interfaces.Service;
using SignalRApp.Application.Interfaces.UnitOfWork;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Services;

public class OrderDetailService(IOrderDetailRepository orderDetailRepository, IUnitOfWork unitOfWork, IMapper mapper)
    : IOrderDetailService
{
    public async Task<ServiceResult<List<GetAllOrderDetailDto>>> GetAllAsync()
    {
        var orderDetails = await orderDetailRepository.GetAllAsync(x => x.Order, x => x.Product);

        return ServiceResult<List<GetAllOrderDetailDto>>.Success(mapper.Map<List<GetAllOrderDetailDto>>(orderDetails));
    }

    public async Task<ServiceResult<GetOrderDetailByIdDto>> GetByIdAsync(int id)
    {
        var orderDetail = await orderDetailRepository.GetByIdAsync(id);
        if (orderDetail is null)
        {
            return ServiceResult<GetOrderDetailByIdDto>.Failure(OrderDetailConstant.NotFound);
        }

        var orderDetailDto = mapper.Map<GetOrderDetailByIdDto>(orderDetail);
        return ServiceResult<GetOrderDetailByIdDto>.Success(orderDetailDto);
    }

    public async Task<ServiceResult> AddAsync(CreateOrderDetailCommandRequest request,
        CancellationToken cancellationToken)
    {
        var orderDetail = mapper.Map<OrderDetail>(request);

        await orderDetailRepository.AddAsync(orderDetail);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> UpdateAsync(UpdateOrderDetailCommandRequest request,
        CancellationToken cancellationToken)
    {
        var orderDetail = await orderDetailRepository.GetByIdAsync(request.Id);
        if (orderDetail is null)
        {
            return ServiceResult.Failure(OrderDetailConstant.NotFound);
        }

        var updatedOrderDetail = mapper.Map(request, orderDetail);

        orderDetailRepository.Update(updatedOrderDetail);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }

    public async Task<ServiceResult> DeleteAsync(int id, CancellationToken cancellationToken)
    {
        var orderDetail = await orderDetailRepository.GetByIdAsync(id);
        if (orderDetail is null)
        {
            return ServiceResult.Failure(OrderDetailConstant.NotFound);
        }

        orderDetailRepository.Delete(orderDetail);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ServiceResult.Success(HttpStatusCode.NoContent);
    }
}