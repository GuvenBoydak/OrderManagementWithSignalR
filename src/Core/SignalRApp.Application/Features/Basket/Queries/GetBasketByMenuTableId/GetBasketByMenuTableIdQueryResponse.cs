using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Basket.Queries.GetBasketByMenuTableId;

public record GetBasketByMenuTableIdQueryResponse(ServiceResult<GetBasketByMenuTableIdDto> Result);