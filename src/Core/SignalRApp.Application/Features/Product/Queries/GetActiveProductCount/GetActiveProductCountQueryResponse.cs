using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Product.Queries.GetActiveProductCount;

public record GetActiveProductCountQueryResponse(ServiceResult<int> Result);