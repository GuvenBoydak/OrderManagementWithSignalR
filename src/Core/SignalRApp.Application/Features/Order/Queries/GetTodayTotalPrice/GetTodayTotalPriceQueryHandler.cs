using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Order.Queries.GetTodayTotalPrice;

public class GetTodayTotalPriceQueryHandler(IOrderService orderService):IQueryHandler<GetTodayTotalPriceQueryRequest,GetTodayTotalPriceQueryResponse>
{
    public async Task<GetTodayTotalPriceQueryResponse> Handle(GetTodayTotalPriceQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await orderService.GetTodayTotalPrice());
    }
}