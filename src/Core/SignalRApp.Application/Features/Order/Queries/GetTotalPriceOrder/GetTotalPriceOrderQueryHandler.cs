using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Order.Queries.GetTotalPriceOrder;

public class GetTotalPriceOrderQueryHandler(IOrderService orderService):IQueryHandler<GetTotalPriceOrderQueryRequest,GetTotalPriceOrderQueryResponse>
{
    public async Task<GetTotalPriceOrderQueryResponse> Handle(GetTotalPriceOrderQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await orderService.GetTotalPrice());
    }
}