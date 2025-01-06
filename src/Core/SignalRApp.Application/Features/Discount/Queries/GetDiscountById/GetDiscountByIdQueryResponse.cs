using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Discount.Queries.GetDiscountById;

public record GetDiscountByIdQueryResponse(ServiceResult<GetDiscountByIdDto> Result);