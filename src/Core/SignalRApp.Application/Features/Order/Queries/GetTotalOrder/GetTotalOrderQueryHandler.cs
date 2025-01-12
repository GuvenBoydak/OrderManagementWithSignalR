using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Order.Queries.GetTotalOrder;

public class GetTotalOrderQueryHandler(IOrderService orderService):IQueryHandler<GetTotalOrderQueryRequest,GetTotalOrderQueryResponse>
{
    public async Task<GetTotalOrderQueryResponse> Handle(GetTotalOrderQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await orderService.GetTotalOrder());
    }
}