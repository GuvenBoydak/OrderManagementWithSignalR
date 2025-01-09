using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Order.Queries.GetAllOrders;

public class GetAllOrdersQueryHandler(IOrderService orderService):IQueryHandler<GetAllOrdersQueryRequest,GetAllOrdersQueryResponse>
{
    public async Task<GetAllOrdersQueryResponse> Handle(GetAllOrdersQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await orderService.GetAllAsync());
    }
}