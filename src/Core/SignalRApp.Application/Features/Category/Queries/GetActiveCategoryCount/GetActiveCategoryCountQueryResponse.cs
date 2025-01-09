using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Category.Queries.GetActiveCategory;

public record GetActiveCategoryCountQueryResponse(ServiceResult<int> Result);