
namespace SignalRApp.Application.Features.OrderDetail.Queries.GetOrderDetailById;

public record GetOrderDetailByIdQueryRequest(int Id):IQuery<GetOrderDetailByIdQueryResponse>;