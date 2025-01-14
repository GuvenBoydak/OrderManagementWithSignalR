using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Basket.Queries.GetBasketByMenuTableId;

public class GetBasketByMenuTableIdQueryHandler(IBasketService basketService):IQueryHandler<GetBasketByMenuTableIdQueryRequest,GetBasketByMenuTableIdQueryResponse>
{
    public async Task<GetBasketByMenuTableIdQueryResponse> Handle(GetBasketByMenuTableIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await basketService.GetBasketByMenuTableIdAsync(request.Id));
    }
}