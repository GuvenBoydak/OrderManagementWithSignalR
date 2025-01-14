using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Basket.Queries.GetBasketById;

public record GetBasketByIdQueryResponse(ServiceResult<GetBasketByIdDto> Result);