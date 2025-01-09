using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Order.Queries.GetOrderById;

public class GetOrderByIdQueryHandler(IOrderService orderService):IQueryHandler<GetOrderByIdQueryRequest,GetOrderByIdQueryResponse>
{
    public async Task<GetOrderByIdQueryResponse> Handle(GetOrderByIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await orderService.GetByIdAsync(request.Id));
    }
}