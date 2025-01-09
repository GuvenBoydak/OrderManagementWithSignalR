using SignalRApp.Application.Features.OrderDetail.Queries;

namespace SignalRApp.Application.Features.Order.Queries.GetAllOrders;

public record GetAllOrdersDto(int Id,
    string TableNumber,
    string Description,
    DateTime Date,
    decimal TotalPrice,
    OrderDetailDto OrderDetail);