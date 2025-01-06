namespace SignalRApp.Application.Features.Discount.Queries.GetDiscountById;

public record GetDiscountByIdQueryRequest(int Id):IQuery<GetDiscountByIdQueryResponse>;