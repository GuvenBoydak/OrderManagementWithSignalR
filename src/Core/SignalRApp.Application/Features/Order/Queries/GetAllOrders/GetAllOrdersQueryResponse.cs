using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Order.Queries.GetAllOrders;

public record GetAllOrdersQueryResponse(ServiceResult<List<GetAllOrdersDto>> Result);