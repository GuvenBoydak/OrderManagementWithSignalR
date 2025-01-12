using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Order.Queries.GetTotalOrder;

public record GetTotalOrderQueryResponse(ServiceResult<int> Result);