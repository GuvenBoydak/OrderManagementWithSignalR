using SignalRApp.Application.Helpers;

namespace SignalRApp.Application.Features.About.Queries.GetAllAbout;

public record GetAllAboutQueryResponse(ServiceResult<List<GetAllAboutDto>> Result);