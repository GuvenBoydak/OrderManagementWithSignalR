using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Product.Queries.GetProductNameByMaxPrice;

public record GetProductNameByMaxPriceQueryResponse(ServiceResult<string> Result);