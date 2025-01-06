using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.About.Queries.GetAboutById;

public record GetAboutByIdQueryResponse(ServiceResult<GetAboutByIdDto> Result);