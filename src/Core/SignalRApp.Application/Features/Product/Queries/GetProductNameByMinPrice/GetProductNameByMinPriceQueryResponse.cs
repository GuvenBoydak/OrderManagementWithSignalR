using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Product.Queries.GetProductNameByMinPrice;

public record GetProductNameByMinPriceQueryResponse(ServiceResult<string> Result);