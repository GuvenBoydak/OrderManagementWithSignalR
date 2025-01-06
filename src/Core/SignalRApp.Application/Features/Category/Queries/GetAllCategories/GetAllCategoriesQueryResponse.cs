using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Category.Queries.GetAllCategories;

public record GetAllCategoriesQueryResponse(ServiceResult<List<GetAllCategoriesDto>> Result);