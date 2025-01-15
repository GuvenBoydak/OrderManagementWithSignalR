using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Basket.Queries.GetBasketByMenuTableId;

public record GetBasketByMenuTableIdQueryResponse(ServiceResult<List<GetBasketByMenuTableIdDto>> Result);