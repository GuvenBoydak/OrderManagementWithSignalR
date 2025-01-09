using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Category.Queries.GetPassiveCategory;

public record GetPassiveCategoryCountQueryResponse(ServiceResult<int> Result);