using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Product.Queries.GetProductsWithCategory;

public record GetProductsWithCategoryQueryResponse(ServiceResult<List<GetProductsWithCategoryDto>> Result);