using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Basket.Queries.GetAllBaskets;

public class GetAllBasketQueryHandler(IBasketService basketService):IQueryHandler<GetAllBasketQueryRequest,GetAllBasketQueryResponse>
{
    public async Task<GetAllBasketQueryResponse> Handle(GetAllBasketQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await basketService.GetAllAsync());
    }
}