using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Discount.Queries.GetAllDiscount;

public record GetAllDiscountQueryResponse(ServiceResult<List<GetAllDiscountDto>> Result);