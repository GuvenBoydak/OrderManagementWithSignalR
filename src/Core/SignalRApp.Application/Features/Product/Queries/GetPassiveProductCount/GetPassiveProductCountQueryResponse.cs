using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Product.Queries.GetPassiveProductCount;

public record GetPassiveProductCountQueryResponse(ServiceResult<int> Result);