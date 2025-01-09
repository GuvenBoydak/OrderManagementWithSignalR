using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Order.Queries.GetOrderById;

public record GetOrderByIdQueryResponse(ServiceResult<GetOrderByIdDto> Result);