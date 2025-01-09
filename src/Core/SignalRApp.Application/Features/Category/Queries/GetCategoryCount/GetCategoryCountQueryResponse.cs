using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Category.Queries.GetCategoryCount;

public record GetCategoryCountQueryResponse(ServiceResult<int> Result);