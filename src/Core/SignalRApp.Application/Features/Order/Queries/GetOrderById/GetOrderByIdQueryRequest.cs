namespace SignalRApp.Application.Features.Order.Queries.GetOrderById;

public record GetOrderByIdQueryRequest(int Id):IQuery<GetOrderByIdQueryResponse>;