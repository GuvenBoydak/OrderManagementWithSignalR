using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Basket.Queries.GetAllBaskets;

public record GetAllBasketQueryResponse(ServiceResult<List<GetAllBasketDto>> Result);