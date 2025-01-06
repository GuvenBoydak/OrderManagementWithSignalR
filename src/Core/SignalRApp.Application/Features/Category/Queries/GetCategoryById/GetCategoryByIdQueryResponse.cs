using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.Category.Queries.GetCategoryById;

public record GetCategoryByIdQueryResponse(ServiceResult<GetCategoryByIdDto> Result);