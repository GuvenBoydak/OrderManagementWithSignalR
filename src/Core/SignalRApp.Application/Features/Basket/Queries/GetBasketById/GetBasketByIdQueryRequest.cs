namespace SignalRApp.Application.Features.Basket.Queries.GetBasketById;

public record GetBasketByIdQueryRequest(int Id):IQuery<GetBasketByIdQueryResponse>;