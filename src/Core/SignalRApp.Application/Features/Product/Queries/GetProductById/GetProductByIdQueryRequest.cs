namespace SignalRApp.Application.Features.Product.Queries.GetProductById;

public record GetProductByIdQueryRequest(int Id):IQuery<GetProductByIdQueryResponse>;