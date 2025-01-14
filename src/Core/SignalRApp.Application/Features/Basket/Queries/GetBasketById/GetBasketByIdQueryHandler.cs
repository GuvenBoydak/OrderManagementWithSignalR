using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Basket.Queries.GetBasketById;

public class GetBasketByIdQueryHandler(IBasketService basketService):IQueryHandler<GetBasketByIdQueryRequest,GetBasketByIdQueryResponse>
{
    public async Task<GetBasketByIdQueryResponse> Handle(GetBasketByIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await basketService.GetByIdAsync(request.Id));
    }
}