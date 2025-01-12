using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Order.Queries.GetTotalPriceOrder;

public record GetTotalPriceOrderQueryResponse(ServiceResult<decimal> Result);