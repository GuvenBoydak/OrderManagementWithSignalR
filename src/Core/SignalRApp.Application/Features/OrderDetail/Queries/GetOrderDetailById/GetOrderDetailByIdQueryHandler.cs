using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.OrderDetail.Queries.GetOrderDetailById;

public class GetOrderDetailByIdQueryHandler(IOrderDetailService orderDetailService):IQueryHandler<GetOrderDetailByIdQueryRequest,GetOrderDetailByIdQueryResponse>
{
    public async Task<GetOrderDetailByIdQueryResponse> Handle(GetOrderDetailByIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await orderDetailService.GetByIdAsync(request.Id));
    }
}