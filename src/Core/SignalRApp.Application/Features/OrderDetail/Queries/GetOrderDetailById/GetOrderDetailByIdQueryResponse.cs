using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.OrderDetail.Queries.GetOrderDetailById;

public record GetOrderDetailByIdQueryResponse(ServiceResult<GetOrderDetailByIdDto> Result);