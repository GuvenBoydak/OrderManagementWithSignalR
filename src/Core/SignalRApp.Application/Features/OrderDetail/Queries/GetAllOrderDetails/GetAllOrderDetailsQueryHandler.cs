using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.OrderDetail.Queries.GetAllOrderDetails;

public class GetAllOrderDetailsQueryHandler(IOrderDetailService orderDetailService):IQueryHandler<GetAllOrderDetailsQueryRequest,GetAllOrderDetailsQueryResponse>
{
    public async Task<GetAllOrderDetailsQueryResponse> Handle(GetAllOrderDetailsQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await orderDetailService.GetAllAsync());
    }
}