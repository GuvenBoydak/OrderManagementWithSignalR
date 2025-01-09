using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Product.Queries.GetProductCount;

public record GetProductCountQueryResponse(ServiceResult<int> Result);