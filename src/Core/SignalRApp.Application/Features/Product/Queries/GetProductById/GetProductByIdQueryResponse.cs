using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Product.Queries.GetProductById;

public record GetProductByIdQueryResponse(ServiceResult<GetProductByIdDto> Result);