using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.OrderDetail.Queries.GetAllOrderDetails;

public record GetAllOrderDetailsQueryResponse(ServiceResult<List<GetAllOrderDetailDto>> Result);