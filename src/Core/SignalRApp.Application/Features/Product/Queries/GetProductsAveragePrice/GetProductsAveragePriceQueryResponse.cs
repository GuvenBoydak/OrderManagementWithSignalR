using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Product.Queries.GetProductsAveragePrice;

public record GetProductsAveragePriceQueryResponse(ServiceResult<decimal> Result);