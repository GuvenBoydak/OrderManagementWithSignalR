using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Order.Queries.GetTodayTotalPrice;

public record GetTodayTotalPriceQueryResponse(ServiceResult<decimal> Result);